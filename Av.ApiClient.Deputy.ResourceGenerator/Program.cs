// See https://aka.ms/new-console-template for more information
using System.Text;
using Av.ApiClients.Deputy;
using Av.ApiClients.Deputy.ResourceGenerator;
using Av.ApiClients.Deputy.Models;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using Av.ApiClients.Deputy.ResourceGenerator.Generators;

var config = new ConfigurationBuilder()
    .AddUserSecrets<Program>()
    .Build();

var client = new DeputyClient(new HttpClient(), new DeputyClientSettings
{
    IncludeMetadata = false,
    InstanceUrl = config["InstanceUrl"] ?? throw new Exception("Missing InstanceUrl in secrets"),
    Token = config["Token"] ?? throw new Exception("Missing Token in secrets"),
});


// .../sln/src/Av.ApiClient.Deputy.ResourceGenerator/bin/Debug/net8.0/... => .../sln/src/...
var resourceListPath = Directory.GetFiles("../../../../", "resourceList.txt", SearchOption.AllDirectories)
    .FirstOrDefault() ?? throw new FileNotFoundException("Can't find resourceList.txt");

var resourcesOutputPath = Path.Join(Path.GetDirectoryName(resourceListPath), "Generated");
Directory.CreateDirectory(resourcesOutputPath);
var resourcesClientOutputPath = Path.Join(resourcesOutputPath, "../../../Clients", "ResourcesClient.g.cs");

var resourceList = File.ReadLines(resourceListPath);
foreach (var resourceName in resourceList)
{
    try
    {
        Console.Write($"{resourceName}...");
        ResourceInfo info;
        var cachePath = Path.Join(Path.GetTempPath(), $"_deputycache_{resourceName}.json");
        if (File.Exists(cachePath))
        {
            var cache = File.ReadAllText(cachePath);
            info = JsonSerializer.Deserialize<ResourceInfo>(cache)!;
        }
        else
        {
            info = await client.Resources.Resource(resourceName).Info();
            var cache = JsonSerializer.Serialize(info);
            File.WriteAllText(cachePath, cache, Encoding.UTF8);
        }

        var generator = new ResourceGenerator(resourceName, info);

        File.WriteAllText(Path.Join(resourcesOutputPath, $"{resourceName}.cs"), generator.Generate(), Encoding.UTF8);
        Console.WriteLine("Ok");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error");
        Console.WriteLine(ex.ToString());
    }
}

var resourcesClientGenerator = new ResourcesClientGenerator(resourceList);
File.WriteAllText(resourcesClientOutputPath, resourcesClientGenerator.Generate());
