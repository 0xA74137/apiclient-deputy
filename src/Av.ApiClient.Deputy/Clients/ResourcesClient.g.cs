// <auto-generated/>
#nullable enable
using Av.ApiClients.Deputy.Models.Resources;
using Task = Av.ApiClients.Deputy.Models.Resources.Task;

namespace Av.ApiClients.Deputy.Clients;

public partial interface IResourcesClient
{
    IResourceClient<Address> Addresss { get; }
    IResourceClient<Category> Categorys { get; }
    IResourceClient<Comment> Comments { get; }
    IResourceClient<Company> Companys { get; }
    IResourceClient<CompanyPeriod> CompanyPeriods { get; }
    IResourceClient<Contact> Contacts { get; }
    IResourceClient<Country> Countrys { get; }
    IResourceClient<CustomAppData> CustomAppDatas { get; }
    IResourceClient<CustomField> CustomFields { get; }
    IResourceClient<CustomFieldData> CustomFieldDatas { get; }
    IResourceClient<Employee> Employees { get; }
    IResourceClient<EmployeeAgreement> EmployeeAgreements { get; }
    IResourceClient<EmployeeAgreementHistory> EmployeeAgreementHistorys { get; }
    IResourceClient<EmployeeAppraisal> EmployeeAppraisals { get; }
    IResourceClient<EmployeeAvailability> EmployeeAvailabilitys { get; }
    IResourceClient<EmployeeHistory> EmployeeHistorys { get; }
    IResourceClient<EmployeePaycycle> EmployeePaycycles { get; }
    IResourceClient<EmployeePaycycleReturn> EmployeePaycycleReturns { get; }
    IResourceClient<EmployeeRole> EmployeeRoles { get; }
    IResourceClient<EmployeeWorkplace> EmployeeWorkplaces { get; }
    IResourceClient<EmploymentCondition> EmploymentConditions { get; }
    IResourceClient<EmploymentContract> EmploymentContracts { get; }
    IResourceClient<EmploymentContractLeaveRules> EmploymentContractLeaveRuless { get; }
    IResourceClient<Event> Events { get; }
    IResourceClient<Geo> Geos { get; }
    IResourceClient<Journal> Journals { get; }
    IResourceClient<Kiosk> Kiosks { get; }
    IResourceClient<Leave> Leaves { get; }
    IResourceClient<LeaveAccrual> LeaveAccruals { get; }
    IResourceClient<LeavePayLine> LeavePayLines { get; }
    IResourceClient<LeaveRules> LeaveRuless { get; }
    IResourceClient<Memo> Memos { get; }
    IResourceClient<OperationalUnit> OperationalUnits { get; }
    IResourceClient<PayPeriod> PayPeriods { get; }
    IResourceClient<PayRules> PayRuless { get; }
    IResourceClient<PublicHoliday> PublicHolidays { get; }
    IResourceClient<Roster> Rosters { get; }
    IResourceClient<RosterOpen> RosterOpens { get; }
    IResourceClient<RosterSwap> RosterSwaps { get; }
    IResourceClient<SalesData> SalesDatas { get; }
    IResourceClient<Schedule> Schedules { get; }
    IResourceClient<ShiftTemplate> ShiftTemplates { get; }
    IResourceClient<SmsLog> SmsLogs { get; }
    IResourceClient<State> States { get; }
    IResourceClient<StressProfile> StressProfiles { get; }
    IResourceClient<SystemUsageBalance> SystemUsageBalances { get; }
    IResourceClient<SystemUsageTracking> SystemUsageTrackings { get; }
    IResourceClient<Task> Tasks { get; }
    IResourceClient<TaskGroup> TaskGroups { get; }
    IResourceClient<TaskGroupSetup> TaskGroupSetups { get; }
    IResourceClient<TaskOpunitConfig> TaskOpunitConfigs { get; }
    IResourceClient<TaskSetup> TaskSetups { get; }
    IResourceClient<Team> Teams { get; }
    IResourceClient<Timesheet> Timesheets { get; }
    IResourceClient<TimesheetPayReturn> TimesheetPayReturns { get; }
    IResourceClient<TrainingModule> TrainingModules { get; }
    IResourceClient<TrainingRecord> TrainingRecords { get; }
    IResourceClient<Webhook> Webhooks { get; }
}

internal partial class ResourcesClient
{
    private ResourceClient<Address>? __Address;
    private ResourceClient<Category>? __Category;
    private ResourceClient<Comment>? __Comment;
    private ResourceClient<Company>? __Company;
    private ResourceClient<CompanyPeriod>? __CompanyPeriod;
    private ResourceClient<Contact>? __Contact;
    private ResourceClient<Country>? __Country;
    private ResourceClient<CustomAppData>? __CustomAppData;
    private ResourceClient<CustomField>? __CustomField;
    private ResourceClient<CustomFieldData>? __CustomFieldData;
    private ResourceClient<Employee>? __Employee;
    private ResourceClient<EmployeeAgreement>? __EmployeeAgreement;
    private ResourceClient<EmployeeAgreementHistory>? __EmployeeAgreementHistory;
    private ResourceClient<EmployeeAppraisal>? __EmployeeAppraisal;
    private ResourceClient<EmployeeAvailability>? __EmployeeAvailability;
    private ResourceClient<EmployeeHistory>? __EmployeeHistory;
    private ResourceClient<EmployeePaycycle>? __EmployeePaycycle;
    private ResourceClient<EmployeePaycycleReturn>? __EmployeePaycycleReturn;
    private ResourceClient<EmployeeRole>? __EmployeeRole;
    private ResourceClient<EmployeeWorkplace>? __EmployeeWorkplace;
    private ResourceClient<EmploymentCondition>? __EmploymentCondition;
    private ResourceClient<EmploymentContract>? __EmploymentContract;
    private ResourceClient<EmploymentContractLeaveRules>? __EmploymentContractLeaveRules;
    private ResourceClient<Event>? __Event;
    private ResourceClient<Geo>? __Geo;
    private ResourceClient<Journal>? __Journal;
    private ResourceClient<Kiosk>? __Kiosk;
    private ResourceClient<Leave>? __Leave;
    private ResourceClient<LeaveAccrual>? __LeaveAccrual;
    private ResourceClient<LeavePayLine>? __LeavePayLine;
    private ResourceClient<LeaveRules>? __LeaveRules;
    private ResourceClient<Memo>? __Memo;
    private ResourceClient<OperationalUnit>? __OperationalUnit;
    private ResourceClient<PayPeriod>? __PayPeriod;
    private ResourceClient<PayRules>? __PayRules;
    private ResourceClient<PublicHoliday>? __PublicHoliday;
    private ResourceClient<Roster>? __Roster;
    private ResourceClient<RosterOpen>? __RosterOpen;
    private ResourceClient<RosterSwap>? __RosterSwap;
    private ResourceClient<SalesData>? __SalesData;
    private ResourceClient<Schedule>? __Schedule;
    private ResourceClient<ShiftTemplate>? __ShiftTemplate;
    private ResourceClient<SmsLog>? __SmsLog;
    private ResourceClient<State>? __State;
    private ResourceClient<StressProfile>? __StressProfile;
    private ResourceClient<SystemUsageBalance>? __SystemUsageBalance;
    private ResourceClient<SystemUsageTracking>? __SystemUsageTracking;
    private ResourceClient<Task>? __Task;
    private ResourceClient<TaskGroup>? __TaskGroup;
    private ResourceClient<TaskGroupSetup>? __TaskGroupSetup;
    private ResourceClient<TaskOpunitConfig>? __TaskOpunitConfig;
    private ResourceClient<TaskSetup>? __TaskSetup;
    private ResourceClient<Team>? __Team;
    private ResourceClient<Timesheet>? __Timesheet;
    private ResourceClient<TimesheetPayReturn>? __TimesheetPayReturn;
    private ResourceClient<TrainingModule>? __TrainingModule;
    private ResourceClient<TrainingRecord>? __TrainingRecord;
    private ResourceClient<Webhook>? __Webhook;

    public IResourceClient<Address> Addresss => __Address ??= new ResourceClient<Address>(_httpClient);
    public IResourceClient<Category> Categorys => __Category ??= new ResourceClient<Category>(_httpClient);
    public IResourceClient<Comment> Comments => __Comment ??= new ResourceClient<Comment>(_httpClient);
    public IResourceClient<Company> Companys => __Company ??= new ResourceClient<Company>(_httpClient);
    public IResourceClient<CompanyPeriod> CompanyPeriods => __CompanyPeriod ??= new ResourceClient<CompanyPeriod>(_httpClient);
    public IResourceClient<Contact> Contacts => __Contact ??= new ResourceClient<Contact>(_httpClient);
    public IResourceClient<Country> Countrys => __Country ??= new ResourceClient<Country>(_httpClient);
    public IResourceClient<CustomAppData> CustomAppDatas => __CustomAppData ??= new ResourceClient<CustomAppData>(_httpClient);
    public IResourceClient<CustomField> CustomFields => __CustomField ??= new ResourceClient<CustomField>(_httpClient);
    public IResourceClient<CustomFieldData> CustomFieldDatas => __CustomFieldData ??= new ResourceClient<CustomFieldData>(_httpClient);
    public IResourceClient<Employee> Employees => __Employee ??= new ResourceClient<Employee>(_httpClient);
    public IResourceClient<EmployeeAgreement> EmployeeAgreements => __EmployeeAgreement ??= new ResourceClient<EmployeeAgreement>(_httpClient);
    public IResourceClient<EmployeeAgreementHistory> EmployeeAgreementHistorys => __EmployeeAgreementHistory ??= new ResourceClient<EmployeeAgreementHistory>(_httpClient);
    public IResourceClient<EmployeeAppraisal> EmployeeAppraisals => __EmployeeAppraisal ??= new ResourceClient<EmployeeAppraisal>(_httpClient);
    public IResourceClient<EmployeeAvailability> EmployeeAvailabilitys => __EmployeeAvailability ??= new ResourceClient<EmployeeAvailability>(_httpClient);
    public IResourceClient<EmployeeHistory> EmployeeHistorys => __EmployeeHistory ??= new ResourceClient<EmployeeHistory>(_httpClient);
    public IResourceClient<EmployeePaycycle> EmployeePaycycles => __EmployeePaycycle ??= new ResourceClient<EmployeePaycycle>(_httpClient);
    public IResourceClient<EmployeePaycycleReturn> EmployeePaycycleReturns => __EmployeePaycycleReturn ??= new ResourceClient<EmployeePaycycleReturn>(_httpClient);
    public IResourceClient<EmployeeRole> EmployeeRoles => __EmployeeRole ??= new ResourceClient<EmployeeRole>(_httpClient);
    public IResourceClient<EmployeeWorkplace> EmployeeWorkplaces => __EmployeeWorkplace ??= new ResourceClient<EmployeeWorkplace>(_httpClient);
    public IResourceClient<EmploymentCondition> EmploymentConditions => __EmploymentCondition ??= new ResourceClient<EmploymentCondition>(_httpClient);
    public IResourceClient<EmploymentContract> EmploymentContracts => __EmploymentContract ??= new ResourceClient<EmploymentContract>(_httpClient);
    public IResourceClient<EmploymentContractLeaveRules> EmploymentContractLeaveRuless => __EmploymentContractLeaveRules ??= new ResourceClient<EmploymentContractLeaveRules>(_httpClient);
    public IResourceClient<Event> Events => __Event ??= new ResourceClient<Event>(_httpClient);
    public IResourceClient<Geo> Geos => __Geo ??= new ResourceClient<Geo>(_httpClient);
    public IResourceClient<Journal> Journals => __Journal ??= new ResourceClient<Journal>(_httpClient);
    public IResourceClient<Kiosk> Kiosks => __Kiosk ??= new ResourceClient<Kiosk>(_httpClient);
    public IResourceClient<Leave> Leaves => __Leave ??= new ResourceClient<Leave>(_httpClient);
    public IResourceClient<LeaveAccrual> LeaveAccruals => __LeaveAccrual ??= new ResourceClient<LeaveAccrual>(_httpClient);
    public IResourceClient<LeavePayLine> LeavePayLines => __LeavePayLine ??= new ResourceClient<LeavePayLine>(_httpClient);
    public IResourceClient<LeaveRules> LeaveRuless => __LeaveRules ??= new ResourceClient<LeaveRules>(_httpClient);
    public IResourceClient<Memo> Memos => __Memo ??= new ResourceClient<Memo>(_httpClient);
    public IResourceClient<OperationalUnit> OperationalUnits => __OperationalUnit ??= new ResourceClient<OperationalUnit>(_httpClient);
    public IResourceClient<PayPeriod> PayPeriods => __PayPeriod ??= new ResourceClient<PayPeriod>(_httpClient);
    public IResourceClient<PayRules> PayRuless => __PayRules ??= new ResourceClient<PayRules>(_httpClient);
    public IResourceClient<PublicHoliday> PublicHolidays => __PublicHoliday ??= new ResourceClient<PublicHoliday>(_httpClient);
    public IResourceClient<Roster> Rosters => __Roster ??= new ResourceClient<Roster>(_httpClient);
    public IResourceClient<RosterOpen> RosterOpens => __RosterOpen ??= new ResourceClient<RosterOpen>(_httpClient);
    public IResourceClient<RosterSwap> RosterSwaps => __RosterSwap ??= new ResourceClient<RosterSwap>(_httpClient);
    public IResourceClient<SalesData> SalesDatas => __SalesData ??= new ResourceClient<SalesData>(_httpClient);
    public IResourceClient<Schedule> Schedules => __Schedule ??= new ResourceClient<Schedule>(_httpClient);
    public IResourceClient<ShiftTemplate> ShiftTemplates => __ShiftTemplate ??= new ResourceClient<ShiftTemplate>(_httpClient);
    public IResourceClient<SmsLog> SmsLogs => __SmsLog ??= new ResourceClient<SmsLog>(_httpClient);
    public IResourceClient<State> States => __State ??= new ResourceClient<State>(_httpClient);
    public IResourceClient<StressProfile> StressProfiles => __StressProfile ??= new ResourceClient<StressProfile>(_httpClient);
    public IResourceClient<SystemUsageBalance> SystemUsageBalances => __SystemUsageBalance ??= new ResourceClient<SystemUsageBalance>(_httpClient);
    public IResourceClient<SystemUsageTracking> SystemUsageTrackings => __SystemUsageTracking ??= new ResourceClient<SystemUsageTracking>(_httpClient);
    public IResourceClient<Task> Tasks => __Task ??= new ResourceClient<Task>(_httpClient);
    public IResourceClient<TaskGroup> TaskGroups => __TaskGroup ??= new ResourceClient<TaskGroup>(_httpClient);
    public IResourceClient<TaskGroupSetup> TaskGroupSetups => __TaskGroupSetup ??= new ResourceClient<TaskGroupSetup>(_httpClient);
    public IResourceClient<TaskOpunitConfig> TaskOpunitConfigs => __TaskOpunitConfig ??= new ResourceClient<TaskOpunitConfig>(_httpClient);
    public IResourceClient<TaskSetup> TaskSetups => __TaskSetup ??= new ResourceClient<TaskSetup>(_httpClient);
    public IResourceClient<Team> Teams => __Team ??= new ResourceClient<Team>(_httpClient);
    public IResourceClient<Timesheet> Timesheets => __Timesheet ??= new ResourceClient<Timesheet>(_httpClient);
    public IResourceClient<TimesheetPayReturn> TimesheetPayReturns => __TimesheetPayReturn ??= new ResourceClient<TimesheetPayReturn>(_httpClient);
    public IResourceClient<TrainingModule> TrainingModules => __TrainingModule ??= new ResourceClient<TrainingModule>(_httpClient);
    public IResourceClient<TrainingRecord> TrainingRecords => __TrainingRecord ??= new ResourceClient<TrainingRecord>(_httpClient);
    public IResourceClient<Webhook> Webhooks => __Webhook ??= new ResourceClient<Webhook>(_httpClient);
}
