using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Av.ApiClients.Deputy.ResourceGenerator.Generators
{
    internal class FileBuilder
    {
        private readonly HashSet<string> _usings = new();
        private readonly List<Action<IndentableStringBuilder>> _preamble = new();
        private readonly List<ObjectBuilder> _objects = new();

        public void AddUsing(string @using)
            => _usings.Add(@using);
        public void AddPreamble(Action<IndentableStringBuilder> action)
            => _preamble.Add(action);
        public void AddPreamble(string value)
            => _preamble.Add(sb => sb.AppendLine(value));
        public void AddObject(ObjectBuilder builder)
            => _objects.Add(builder);

        public string Build()
        {
            var sb = new IndentableStringBuilder(new string(' ', 4));

            var @objects = _objects.Select(x => x.Build(this)).ToList();

            foreach (var preamble in _preamble)
                preamble.Invoke(sb);

            foreach (var @using in _usings)
                sb.AppendLine(@using);

            foreach (var @object in @objects)
                sb.AppendLine(@object);

            return sb.ToString();
        }
    }

    internal abstract class ObjectBuilder
    {
        private readonly string _accessModifiers;
        private readonly string _type;
        private readonly string _name;

        private List<Action<IndentableStringBuilder>> _preamble = new();
        private string? _parentClass;
        private List<string> _implementedInterfaces = new();
        private List<(string param, string constraint)> _genericConstraints = new();
        private List<Action<IndentableStringBuilder>> _fields = new();
        private List<Action<IndentableStringBuilder>> _constructors = new();
        private List<Action<IndentableStringBuilder>> _properties = new();
        private List<Action<IndentableStringBuilder>> _methods = new();

        public ObjectBuilder(string accessModifiers, string type, string name)
        {
            _accessModifiers = accessModifiers;
            _type = type;
            _name = name;
        }

        public void SetParentClass(string parentClass)
            => _parentClass = parentClass;

        public void AddInterface(string @interface)
            => _implementedInterfaces.Add(@interface);

        public void AddGenericConstraint(string param, string constraint)
            => _genericConstraints.Add((param, constraint));

        public void AddPreamble(Action<IndentableStringBuilder> action)
            => _preamble.Add(action);
        public void AddConstructor(Action<IndentableStringBuilder> action)
            => _constructors.Add(action);
        public void AddField(Action<IndentableStringBuilder> action)
            => _fields.Add(action);
        public void AddProperty(Action<IndentableStringBuilder> action)
            => _properties.Add(action);
        public void AddMethod(Action<IndentableStringBuilder> action)
            => _methods.Add(action);

        public void AddPreamble(string value)
            => _preamble.Add(sb => sb.AppendLine(value));
        public void AddField(string value)
            => _fields.Add(sb => sb.AppendLine(value));
        public void AddProperty(string value)
            => _properties.Add(sb => sb.AppendLine(value));
        public void AddMethod(string value)
            => _methods.Add(sb => sb.AppendLine(value));

        public virtual string Build(FileBuilder fileBuilder)
        {
            var sb = new IndentableStringBuilder(new string(' ', 4));

            foreach (var preamble in _preamble)
                preamble.Invoke(sb);

            sb.Append($"{_accessModifiers} {_type} {_name}");
            if (_parentClass != null || _implementedInterfaces.Count > 0)
                sb.Append(" : ");

            if (_parentClass != null)
            {
                sb.Append(_parentClass);
                if (_implementedInterfaces.Count > 0)
                    sb.Append(",");
            }

            sb.AppendLine(string.Join(", ", _implementedInterfaces));

            sb.Indent();
            foreach (var (param, constraint) in _genericConstraints)
                sb.AppendLine($"where {param} : {constraint}");
            sb.Dedent();

            using (sb.Block())
            {
                if(_fields.Count > 0)
                {
                    foreach (var field in _fields)
                        field.Invoke(sb);

                    sb.AppendLine();
                }

                if(_constructors.Count > 0)
                {
                    foreach (var constructor in _constructors)
                        constructor.Invoke(sb);

                    sb.AppendLine();
                }

                if(_properties.Count > 0)
                {
                    foreach (var property in _properties)
                        property.Invoke(sb);

                    sb.AppendLine();
                }

                if(_methods.Count > 0)
                {
                    foreach (var method in _methods)
                        method.Invoke(sb);

                    sb.AppendLine();
                }
            }

            return sb.ToString();
        }
    }
}
