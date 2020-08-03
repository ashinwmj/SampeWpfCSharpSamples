using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalManagerRuleConfiguration
{
    public class SignalFilterConstants
    {
        public const string DEFAULT_FILTER_NAME = "New Filter";

        public const string StartsWith = "Starts With";
        public const string EndsWith = "Ends With";
        public const string Contains = "Contains";
        public const string NotContains = "Doesn't Contains";
        public const string DoesnotStartsWith = "Doesn't Starts With";
        public const string DoesnotEndsWith = "Doesn't Ends With";
        public const string IsEmpty = "Is empty";
        public const string IsNotEmpty = "Is Not Empty";
        public const string EqualTo = "=";
        public const string NotEqualTo = "<>";
        public const string GreaterThan = ">";
        public const string LessThan = "<";
        public const string GreaterThanEqualTo = ">=";
        public const string LessThanEqualTo = "<=";

        public const string AndOperator = " AND ";
        public const string OrOperator = " OR ";

        public const string TagSourceFilterCondition = "TAGSOURCE<>'MODBUS' AND TAGSOURCE<>'IEC104' AND TAGSOURCE<>'OPC' OR (TAGSOURCE IS NULL OR TAGSOURCE='')";
        public const string TagSourceNotEmptyFilterCondition = "TAGSOURCE<>''";
        public const string TagSourceWithFormat = "TAGSOURCE='{0}'";

        public static string DefaultFilterValue = string.Empty;

        public static readonly IList<string> Operators = new List<string>
        {
            EqualTo,
            NotEqualTo,
            GreaterThan,
            LessThan,
            GreaterThanEqualTo,
            LessThanEqualTo,
            StartsWith, EndsWith,
            Contains, NotContains,
            DoesnotStartsWith,
            DoesnotEndsWith,
            IsEmpty,
            IsNotEmpty
        };
    }

    public class DataColumnConstants
    {
        public const string SignalAliasName = "SIGNAL_ALIAS_NAME";
        public const string SigDesc = "SIG_DESC";
        public const string SigName = "SIG_NAME";
        public const string SigType = "SIG_TYPE";
        public const string OldSigName = "OLD_SIGNAL_NAME";
        public const string Action = "ACTION";
        public const string CRUDOperation = "Operation";
        public const string UpdatedTime = "Updated Time";
        public const string OldTagName = "OLD_TAG_NAME";
        public const string SignalSource = "TAGSOURCE";
        public const string SystemObjectId = "DeviceId";
        public const string SignalId = "signal_id";
        public const string TagSource = "TAGSOURCE";
        public const string PlantArea = "PLANT_AREA";
    }

    public class SnapshotConstants
    {
        public const string SNAPSHOT_NAME = "Snapshot Name";
        public const string CREATED_TIME = "Created Time";
        public const string CREATED_BY = "Created By";
        public const string COMPARISION_RESULT = "Comparison Result";
        public const string REMARKS = "Remarks";
        public const string DUPLICATE = "Duplicate";
        public const string MODIFIED = "Modified";
        public const string ADDED = "Added";
    }

    public class ProtocolConstants
    {
        public const string VersionHistoryExistingNode = "Existing";
        public const string VersionHistoryAddedNode = "Added";
        public const string VersionHistoryDeletedNode = "Deleted";
        public const string Version = "Version";
        public const string UCFileReplaced = "FileReplaced";
        public const string SignalDetails = "SignalDetails";
        public const string SignalListNode = "SignalList";
        public const string VersionTable = "VersionTable";
        public const string UCWorkflow = "Workflow";
        public const string T2SWorkflow = "T2S";
        public const string T2SUCFileSuffix = "_T2S";
        public const string IsValidRowForImport = "IsValidRowForImport";

        public const string UCSignalName = "NAME";
        public const string UCSignalType = "TAGTYPE";
        public const string UCSignalDescription = "DESC";
        public const string UCPlantArea = "PLANTAREA";

        public const string TagsToSignalPipeName = "WB_UC_T2S_PIPE";

        public const string YesValue = "Y";
        public const string NoValue = "N";
    }

    public class HorizontalFieldConstants
    {
        public static readonly IList<FilterAttribute> HarmonyAttributes = new List<FilterAttribute>()
        {
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false, Name = "SIG_NAME",DisplayName = "Tag Name",Description = "Tag Name",IsUnique = true
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "SIG_DESC",DisplayName = "Tag Description",Description = "Tag Description",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=true,Name = "SIG_ID",DisplayName = "Tag GUID",Description = "Globally unique identifier of tag associated with this entity",IsUnique = true
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=true,Name = "SIG_TYPE",DisplayName = "Tag Type",Description = "Type of tag (index into [Domain TagType])",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=true,Name = "LOOP_ADDRESS",DisplayName = "Loop Address",Description = "Loop Address",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=true,Name = "CONTROL_UNIT_ADDRESS",DisplayName = "Node Address",Description = "Node Address",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=true,Name = "CONTROLLER_ADDRESS",DisplayName = "Controller Address",Description = "Controller Address",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=true,Name = "ControlLogicDrawingGUID",DisplayName = "CLD GUID",Description = "GUID of CLD where associated XR block is defined",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=true,Name = "ControlLogicDrawingName",DisplayName = "CLD",Description = "The user given name of the control logic object, Also is the name of the compound file that contains all the CAD sheets.",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=true,Name = "ControlLogicDrawingObjectID",DisplayName = "CLD Obj ID",Description = "If I/O connector: CLD Object ID of I/O Connector.  If local Iref: NULL.",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "Block",DisplayName = "Block",Description = "Block Number",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "EU_DESC",DisplayName = "EU Descriptor",Description = "Engineering units description",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "EngineeringUnitID",DisplayName = "EU Index",Description = "Engineering units index",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "ValueZero",DisplayName = "Value Zero",Description = "Value of zero point",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(float),IsReadOnly=false,Name = "Span",DisplayName = "Span",Description = "Span of possible values",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmGroup",DisplayName = "Alarm Group",Description = "Alarm Group",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityAlarm",DisplayName = "Alarm Priority Alarm",Description = "Alarm Priority for Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityHighAlarm",DisplayName = "Alarm Priority High Alarm",Description = "Alarm Priority for High Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityHighDeviationAlarm",DisplayName = "Alarm Priority High Deviation",Description = "Alarm Priority for High Deviation Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityHighRateChgAlarm",DisplayName = "Alarm Priority High Rate of Change",Description = "Alarm Priority for High Rate of Change Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityHigh2Alarm",DisplayName = "Alarm Priority High2 Alarm",Description = "Alarm Priority for High 2 Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityHigh3Alarm",DisplayName = "Alarm Priority High3 Alarm",Description = "Alarm Priority for High 3 Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityLowAlarm",DisplayName = "AlarmPriorityLowAlarm",Description = "AlarmPriorityLowAlarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityLowDeviationAlarm",DisplayName = "Alarm Priority Low Deviation",Description = "Alarm Priority for Low Deviation Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityLowRateChgAlarm",DisplayName = "Alarm Priority Low Rate of Change",Description = "Alarm Priority for Low Rate of Change Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityLow2Alarm",DisplayName = "Alarm Priority Low2 Alarm",Description = "Alarm Priority for Low 2 Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityLow3Alarm",DisplayName = "Alarm Priority Low3 Alarm",Description = "Alarm Priority for Low 3 Alarm",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityReturnToNormal",DisplayName = "Alarm Priority Return to Normal",Description = "Alarm Priority for Return to Normal",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmPriorityBadQuality",DisplayName = "Alarm Priority Bad Quality",Description = "Alarm Priority for Bad Quality",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "NumberOfDecimalPlaces",DisplayName = "Num Decimal Places",Description = "Number of decimal places",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "SecurityGroup",DisplayName = "Security group",Description = "Security group",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "SecurityLevel",DisplayName = "Security level",Description = "Security level",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "CustomerTagID",DisplayName = "Customer Tag ID",Description = "Customer Tag ID",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "ZeroState",DisplayName = "Zero State",Description = "ZERO state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "OneState",DisplayName = "One State",Description = "ONE state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "TwoState",DisplayName = "Two State",Description = "TWO state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "ThreeState",DisplayName = "Three State",Description = "THREE state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback10State",DisplayName = "FB1 Zero State",Description = "Feedback One ZERO state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback11State",DisplayName = "FB1 One State",Description = "Feedback One ONE state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback20State",DisplayName = "FB2 Zero State",Description = "Feedback Two ZERO state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback21State",DisplayName = "FB2 One State",Description = "Feedback Two ONE state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback30State",DisplayName = "FB3 Zero State",Description = "Feedback Three ZERO state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback31State",DisplayName = "FB3 One State",Description = "Feedback Three ONE state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback40State",DisplayName = "FB4 Zero State",Description = "Feedback Four ZERO state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "Feedback41State",DisplayName = "FB4 One State",Description = "Feedback Four ONE state",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "PrimaryDisplay",DisplayName = "Primary Display",Description = "Primary display",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentReturnToNormalID",DisplayName = "Alarm Comment Return to Norm Ndx",Description = "Alarm Comment Return to Norm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentHighAlarmID",DisplayName = "Alarm Comment High Alarm Ndx",Description = "Alarm Comment High Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentLowAlarmID",DisplayName = "Alarm Comment Low Alarm Ndx",Description = "Alarm Comment Low Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentHigh2AlarmID",DisplayName = "Alarm Comment High2 Alarm Ndx",Description = "Alarm Comment High2 Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentLow2AlarmID",DisplayName = "Alarm Comment Low2 Alarm Ndx",Description = "Alarm Comment Low2 Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentHigh3AlarmID",DisplayName = "Alarm Comment High3 Alarm Ndx",Description = "Alarm Comment High3 Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentLow3AlarmID",DisplayName = "Alarm Comment Low3 Alarm Ndx",Description = "Alarm Comment Low3 Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentHighDeviationAlarmID",DisplayName = "Alarm Comment HighDevi Alarm Ndx",Description = "Alarm Comment HighDevi Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentLowDeviationAlarmID",DisplayName = "Alarm Comment LowDevi Alarm Ndx",Description = "Alarm Comment LowDevi Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentHighRateChghAlarmID",DisplayName = "AlarmCommentHighRateChghAlarmID",Description = "AlarmCommentHighRateChghAlarmID",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentLowRateChghAlarmID",DisplayName = "Alarm Comment High RateChg Ndx",Description = "Alarm Comment High RateChg Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentHdwrFailAlarmID",DisplayName = "Alarm Comment HdwrFail Alarm Ndx",Description = "Alarm Comment HdwrFail Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmCommentAlarmID",DisplayName = "Alarm Comment Alarm Ndx",Description = "Alarm Comment Alarm Ndx",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=false,Name = "AlarmInhibitTag",DisplayName = "Alarm Inhibit Tag",Description = "Alarm Inhibit Tag",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "AlarmInhibitState",DisplayName = "Alarm Inhibit State",Description = "Alarm Inhibit State",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(string),IsReadOnly=true,Name = "FunctionCodeSymbolName",DisplayName = "FC Name",Description = "Function Code symbol name",IsUnique = false
            },
            new FilterAttribute()
            {
                DataType = typeof(int),IsReadOnly=false,Name = "PIDBlock",DisplayName = "PID Block",Description = "PID block address",IsUnique = false
            },
        };

        public static readonly IList<HorizontalMappingInfo> MappingInfos = new List<HorizontalMappingInfo>()
        {
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "SIG_ID",
                DisplayName = "Tag GUID",
                IsReadOnly =true,
                Description = "Globally unique identifier of tag associated with this entity",
                IsUnique = true,
                SMAttributeName="SIG_ID",CHAttributeName="TagGUID"
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "tagname",
                DisplayName = "Tag Name",
                Description = "Tag Name",
                IsUnique = true,
                SMAttributeName ="SIG_NAME",
                CHAttributeName ="tagname"
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "SIG_DESC",
                DisplayName = "Tag Description",
                IsReadOnly =false,
                Description = "Tag Description",
                IsUnique = false,
                SMAttributeName="SIG_DESC",
                CHAttributeName ="TagDescriptor"
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "TagType",
                CHAttributeName ="TagType",
                SMAttributeName ="SIG_TYPE",
                IsReadOnly =true,
                DisplayName = "Tag Type",
                Description = "Type of tag (index into [Domain TagType])",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "LOOP_ADDRESS",
                IsReadOnly =true,
                DisplayName = "Loop Address",
                Description = "Loop Address",
                IsUnique = false,
                SMAttributeName="LOOP_ADDRESS",
                CHAttributeName ="Loop"
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                CHAttributeName = "Node",
                IsReadOnly =true,
                SMAttributeName ="CONTROL_UNIT_ADDRESS",
                Name ="CONTROL_UNIT_ADDRESS",
                DisplayName = "Node Address",
                Description = "Node Address",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "CONTROLLER_ADDRESS",
                IsReadOnly =true,
                CHAttributeName ="Module",
                SMAttributeName ="CONTROLLER_ADDRESS",
                DisplayName = "Controller Address",
                Description = "Controller Address",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "ControlLogicDrawingGUID",
                IsReadOnly =true,
                CHAttributeName ="ControlLogicDrawingGUID",
                SMAttributeName ="ControlLogicDrawingGUID",
                DisplayName = "CLD GUID",
                Description = "GUID of CLD where associated XR block is defined",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "ControlLogicDrawingName",
                IsReadOnly =true,
                CHAttributeName ="ControlLogicDrawingName",
                SMAttributeName ="ControlLogicDrawingName",
                DisplayName = "CLD",
                Description = "User assigned CLD name",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "ControlLogicDrawingObjectID",
                IsReadOnly =true,
                CHAttributeName ="ControlLogicDrawingObjectID",
                SMAttributeName ="ControlLogicDrawingObjectID",
                DisplayName = "CLD Obj ID",
                Description = "CLD Object ID of associated XR block",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "Block",
                IsReadOnly =false,
                CHAttributeName ="Block",
                SMAttributeName ="Block",
                DisplayName = "Block",
                Description = "Block Number",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "EU_DESC",
                IsReadOnly =false,
                CHAttributeName ="EngineeringUnitDescriptor",
                SMAttributeName ="EU_DESC",
                DisplayName = "EU Descriptor",
                Description = "Engineering units description",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "EngineeringUnitID",
                IsReadOnly =false,
                CHAttributeName ="EngineeringUnitID",
                SMAttributeName ="EngineeringUnitID",
                DisplayName = "EU Index",
                Description = "Engineering units index",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "ValueZero",
                IsReadOnly =false,
                CHAttributeName ="ValueZero",
                SMAttributeName ="ValueZero",
                DisplayName = "Value Zero",
                Description = "Value of zero point",
                IsUnique = false
            },
            new HorizontalMappingInfo() {
                DataType = typeof(float),
                Name = "Span",
                IsReadOnly =false,
                CHAttributeName ="Span",
                SMAttributeName ="Span",
                DisplayName = "Span",
                Description = "Span of possible values",
                IsUnique = false },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmGroup",
                IsReadOnly =false,
                CHAttributeName ="AlarmGroup",
                SMAttributeName ="AlarmGroup",
                DisplayName = "Alarm Group",
                Description = "Alarm Group",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityAlarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityAlarm",
                SMAttributeName ="AlarmPriorityAlarm",
                DisplayName = "Alarm Priority Alarm",
                Description = "Alarm Priority for Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityHighAlarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityHighAlarm",
                SMAttributeName ="AlarmPriorityHighAlarm",
                DisplayName = "Alarm Priority High Alarm",
                Description = "Alarm Priority for High Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityHighDeviationAlarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityHighDeviationAlarm",
                SMAttributeName ="AlarmPriorityHighDeviationAlarm",
                DisplayName = "Alarm Priority High Deviation",
                Description = "Alarm Priority for High Deviation Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityHighRateChgAlarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityHighRateChgAlarm",
                SMAttributeName ="AlarmPriorityHighRateChgAlarm",
                DisplayName = "Alarm Priority High Rate of Change",
                Description = "Alarm Priority for High Rate of Change Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityHigh2Alarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityHigh2Alarm",
                SMAttributeName ="AlarmPriorityHigh2Alarm",
                DisplayName = "Alarm Priority High2 Alarm",
                Description = "Alarm Priority for High 2 Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityHigh3Alarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityHigh3Alarm",
                SMAttributeName ="AlarmPriorityHigh3Alarm",
                DisplayName = "Alarm Priority High3 Alarm",
                Description = "Alarm Priority for High 3 Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityLowAlarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityLowAlarm",
                SMAttributeName ="AlarmPriorityLowAlarm",
                DisplayName = "AlarmPriorityLowAlarm",
                Description = "AlarmPriorityLowAlarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityLowDeviationAlarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityLowDeviationAlarm",
                SMAttributeName ="AlarmPriorityLowDeviationAlarm",
                DisplayName = "Alarm Priority Low Deviation",
                Description = "Alarm Priority for Low Deviation Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityLowRateChgAlarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityLowRateChgAlarm",
                SMAttributeName ="AlarmPriorityLowRateChgAlarm",
                DisplayName = "Alarm Priority Low Rate of Change",
                Description = "Alarm Priority for Low Rate of Change Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityLow2Alarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityLow2Alarm",
                SMAttributeName ="AlarmPriorityLow2Alarm",
                DisplayName = "Alarm Priority Low2 Alarm",
                Description = "Alarm Priority for Low 2 Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityLow3Alarm",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityLow3Alarm",
                SMAttributeName ="AlarmPriorityLow3Alarm",
                DisplayName = "Alarm Priority Low3 Alarm",
                Description = "Alarm Priority for Low 3 Alarm",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityReturnToNormal",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityReturnToNormal",
                SMAttributeName ="AlarmPriorityReturnToNormal",
                DisplayName = "Alarm Priority Return to Normal",
                Description = "Alarm Priority for Return to Normal",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmPriorityBadQuality",
                IsReadOnly =false,
                CHAttributeName ="AlarmPriorityBadQuality",
                SMAttributeName ="AlarmPriorityBadQuality",
                DisplayName = "Alarm Priority Bad Quality",
                Description = "Alarm Priority for Bad Quality",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "NumberOfDecimalPlaces",
                IsReadOnly =false,
                CHAttributeName ="NumberOfDecimalPlaces",
                SMAttributeName ="NumberOfDecimalPlaces",
                DisplayName = "Num Decimal Places",
                Description = "Number of decimal places",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "SecurityGroup",
                IsReadOnly =false,
                CHAttributeName ="SecurityGroup",
                SMAttributeName ="SecurityGroup",
                DisplayName = "Security group",
                Description = "Security group",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "SecurityLevel",
                IsReadOnly =false,
                CHAttributeName ="SecurityLevel",
                SMAttributeName ="SecurityLevel",
                DisplayName = "Security level",
                Description = "Security level",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "CustomerTagID",
                IsReadOnly =false,
                CHAttributeName ="CustomerTagID",
                SMAttributeName ="CustomerTagID",
                DisplayName = "Customer Tag ID",
                Description = "Customer Tag ID",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "ZeroState",
                IsReadOnly =false,
                CHAttributeName ="ZeroState",
                SMAttributeName ="ZeroState",
                DisplayName = "Zero State",
                Description = "ZERO state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "OneState",
                IsReadOnly =false,
                CHAttributeName ="OneState",
                SMAttributeName ="OneState",
                DisplayName = "One State",
                Description = "ONE state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "TwoState",
                IsReadOnly =false,
                CHAttributeName ="TwoState",
                SMAttributeName ="TwoState",
                DisplayName = "Two State",
                Description = "TWO state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "ThreeState",
                IsReadOnly =false,
                CHAttributeName ="ThreeState",
                SMAttributeName ="ThreeState",
                DisplayName = "Three State",
                Description = "THREE state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback10State",
                IsReadOnly =false,
                CHAttributeName ="Feedback10State",
                SMAttributeName ="Feedback10State",
                DisplayName = "FB1 Zero State",
                Description = "Feedback One ZERO state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback11State",
                IsReadOnly =false,
                CHAttributeName ="Feedback11State",
                SMAttributeName ="Feedback11State",
                DisplayName = "FB1 One State",
                Description = "Feedback One ONE state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback20State",
                IsReadOnly =false,
                CHAttributeName ="Feedback20State",
                SMAttributeName ="Feedback20State",
                DisplayName = "FB2 Zero State",
                Description = "Feedback Two ZERO state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback21State",
                IsReadOnly =false,
                CHAttributeName ="Feedback21State",
                SMAttributeName ="Feedback21State",
                DisplayName = "FB2 One State",
                Description = "Feedback Two ONE state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback30State",
                IsReadOnly =false,
                CHAttributeName ="Feedback30State",
                SMAttributeName ="Feedback30State",
                DisplayName = "FB3 Zero State",
                Description = "Feedback Three ZERO state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback31State",
                IsReadOnly =false,
                CHAttributeName ="Feedback31State",
                SMAttributeName ="Feedback31State",
                DisplayName = "FB3 One State",
                Description = "Feedback Three ONE state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback40State",
                IsReadOnly =false,
                CHAttributeName ="Feedback40State",
                SMAttributeName ="Feedback40State",
                DisplayName = "FB4 Zero State",
                Description = "Feedback Four ZERO state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "Feedback41State",
                IsReadOnly =false,
                CHAttributeName ="Feedback41State",
                SMAttributeName ="Feedback41State",
                DisplayName = "FB4 One State",
                Description = "Feedback Four ONE state",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                Name = "PrimaryDisplay",
                IsReadOnly =false,
                CHAttributeName ="PrimaryDisplay",
                SMAttributeName ="PrimaryDisplay",
                DisplayName = "Primary Display",
                Description = "Primary display",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmCommentReturnToNormalID",
                IsReadOnly =false,
                CHAttributeName ="AlarmCommentReturnToNormalID",
                SMAttributeName ="AlarmCommentReturnToNormalID",
                DisplayName = "Alarm Comment Return to Norm Ndx",
                Description = "Alarm Comment Return to Norm Ndx",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmCommentHighAlarmID",
                IsReadOnly =false,
                CHAttributeName ="AlarmCommentHighAlarmID",
                SMAttributeName ="AlarmCommentHighAlarmID",
                DisplayName = "Alarm Comment High Alarm Ndx",
                Description = "Alarm Comment High Alarm Ndx",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                Name = "AlarmCommentLowAlarmID",
                IsReadOnly =false,
                CHAttributeName ="AlarmCommentLowAlarmID",
                SMAttributeName ="AlarmCommentLowAlarmID",
                DisplayName = "Alarm Comment Low Alarm Ndx",
                Description = "Alarm Comment Low Alarm Ndx",
                IsUnique = false
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(string),
                IsReadOnly =true,
                Name = "FunctionCodeSymbolName",
                DisplayName = "FC Name",
                Description = "Function Code symbol name",
                IsUnique = false,
                CHAttributeName ="FunctionCodeSymbolName",
                SMAttributeName ="FunctionCodeSymbolName"
            },
            new HorizontalMappingInfo()
            {
                DataType = typeof(int),
                IsReadOnly =false,
                Name = "PIDBlock",
                DisplayName = "PID Block",
                Description = "PID block address",
                IsUnique = false,
                CHAttributeName ="PIDBlock",
                SMAttributeName ="PIDBlock"
            },
        };

        public static IDictionary<string, string> OperatorMapping = new Dictionary<string, string>()
        {
            ["="] = " IN ({0})",
            ["<>"] = " NOT IN ({0})",
            [">"] = ">{0}",
            ["<"] = "<{0}",
            [">="] = ">={0}",
            ["<="] = "<={0}",
            ["IN"] = " IN ({0})",
            ["NOT IN"] = "NOT IN ({0})",
            ["Contains"] = " LIKE '%{0}'",
            ["Does Not Contain"] = " NOT LIKE '%{0}'",
            ["Begin With"] = " LIKE '{0}*'",
            ["Does Not Begin With"] = " NOT LIKE '{0}*'",
            ["Ends With"] = " LIKE '*{0}'",
            ["Does Not End With"] = " NOT LIKE '*{0}'",
            ["IsNULLorEmpty"] = "IS NULL OR {0}=''",
            ["IsNotNULLorEmpty"] = " <>''"
        };

        public static IList<OperatorMappingInfo> OperatorMappingInfos = new List<OperatorMappingInfo>()
        {
            new OperatorMappingInfo()
            {
                Operator=Operator.Equal,EquivalentOperator="=",FilterFormat=" IN ({0})",SupportedTypes=new List<Type>()
                {
                   typeof(string),typeof(char),typeof(int),typeof(float),typeof(double)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.NotEqual,EquivalentOperator="<>",FilterFormat=" NOT IN ({0})",SupportedTypes=new List<Type>()
                {
                    typeof(string),typeof(char),typeof(int),typeof(float),typeof(double)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.GreaterThan,EquivalentOperator=">",FilterFormat=" >{0}",SupportedTypes=new List<Type>()
                {
                    typeof(int)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.GreaterThanOrEqual,EquivalentOperator=">=",FilterFormat=" >={0}",SupportedTypes=new List<Type>()
                {
                    typeof(int)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.LessThan,EquivalentOperator="<",FilterFormat=" <{0}",SupportedTypes=new List<Type>()
                {
                    typeof(int)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.LessThanOrEqual,EquivalentOperator="<=",FilterFormat=" <={0}",SupportedTypes=new List<Type>()
                {
                    typeof(int)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.In,EquivalentOperator="IN",FilterFormat=" IN ({0})",SupportedTypes=new List<Type>()
                {
                    typeof(string),typeof(char),typeof(int),typeof(float),typeof(double)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.NotIn,EquivalentOperator="NOT IN",FilterFormat=" NOT IN ({0})",SupportedTypes=new List<Type>()
                {
                    typeof(string),typeof(char),typeof(int),typeof(float),typeof(double)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.Contains,EquivalentOperator="Contains",FilterFormat=" LIKE '%{0}'",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.DoesNotContain,EquivalentOperator="Does Not Contain",FilterFormat=" NOT LIKE '%{0}'",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.EndsWith,EquivalentOperator="Ends With",FilterFormat=" LIKE '*{0}'",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.DoesNotEndWith,EquivalentOperator="Ends With",FilterFormat=" NOT LIKE '*{0}'",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.BeginsWith,EquivalentOperator="Begin With",FilterFormat=" LIKE '{0}*'",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.DoesNotBeginWith,EquivalentOperator="Does Not Begin With",FilterFormat=" NOT LIKE '{0}*'",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.IsNULL,EquivalentOperator="IsNULLorEmpty",FilterFormat=" IS NULL OR {0}=''",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            },
            new OperatorMappingInfo()
            {
                Operator=Operator.IsNotNULL,EquivalentOperator="IsNotNULLorEmpty",FilterFormat=" <>''",SupportedTypes=new List<Type>()
                {
                    typeof(string)
                }
            }
        };
    }

    public class HorizontalMappingInfo : FilterAttribute
    {
        public string SMAttributeName { get; set; }

        public string CHAttributeName { get; set; }

        public string CO_AttributeName { get; set; }
    }

    public class OperatorMappingInfo
    {
        public Operator Operator { get; set; }

        public string EquivalentOperator { get; set; }

        public string FilterFormat { get; set; }

        public IList<Type> SupportedTypes { get; set; }
    }
}
