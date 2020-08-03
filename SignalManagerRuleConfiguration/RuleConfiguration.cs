using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using System.Xml.Serialization;

namespace SignalManagerRuleConfiguration
{
    public class RuleSerialize
    {
        [XmlArray(ElementName = "Rules")]
        public RuleConfiguration[] RuleConfigurations { get; set; }
    }
    [Serializable]
    [XmlRoot("Rules", IsNullable = false)]
    public class RuleConfiguration : BindableBase
    {
        public RuleConfiguration()
        {
                
        }
        private string _name;
        private string _description;
        private DateTime _createdDateTime;
        private DateTime _modifiedDateTime;
        private string _createdby;
        private bool _isDefault;
        [XmlAttribute("NAME")]
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }
        [XmlAttribute("Description")]
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }
        [XmlAttribute("CreatedDateTime")]
        public DateTime CreatedDateTime
        {
            get { return _createdDateTime; }
            set { SetProperty(ref _createdDateTime, value); }
        }
        [XmlAttribute("ModifiedDateTime")]
        public DateTime ModifiedDateTime
        {
            get { return _modifiedDateTime; }
            set { SetProperty(ref _modifiedDateTime, value); }
        }
        [XmlAttribute("CreatedBy")]
        public string CreatedBy
        {
            get { return _createdby; }
            set { SetProperty(ref _createdby, value); }
        }
        [XmlAttribute("IsDefault")]
        public bool IsDefault
        {
            get { return _isDefault; }
            set { SetProperty(ref _isDefault, value); }
        }

        //[XmlAttribute("RuleCondition")]
        //public RuleCondition RuleCondition { get; set; }=new RuleCondition()
        //{
        //    AttributeName = "asds"
        //    ,AttributeValue = "asdsad",ConditionOperator = ">",LogicalOperator = "AND"
        //};
        [XmlArray(ElementName = "Conditions"),XmlArrayItem(typeof(RuleCondition),ElementName = "Condition")]
        public ObservableCollection<RuleCondition> Conditions { get; }=new ObservableCollection<RuleCondition>();

        [XmlArray(ElementName = "Setters"),XmlArrayItem(typeof(RuleSetter), ElementName = "Setter")]
        public ObservableCollection<RuleSetter> Setters { get; } = new ObservableCollection<RuleSetter>();

        public RuleConfiguration Clone()
        {
            var clone= new RuleConfiguration
            {
                Name = Name,
                CreatedBy = CreatedBy,
                CreatedDateTime = CreatedDateTime,
                Description = Description,
                IsDefault = IsDefault,
                ModifiedDateTime = ModifiedDateTime,

            };
            foreach (var setter in Setters)
            {
                clone.Setters.Add(setter.Clone());
            }
            foreach (var condition in Conditions)
            {
                clone.Conditions.Add(condition.Clone());
            }
            return clone;
        }
    }
}
