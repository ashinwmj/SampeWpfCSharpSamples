using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace SignalManagerRuleConfiguration
{
    [Serializable]

    public class RuleCondition
    {
        public RuleCondition()
        {
                
        }
        [XmlAttribute("LogicalOperator")]
        public  string LogicalOperator { get; set; }

        [XmlAttribute("AttributeName")]

        public  string AttributeName { get; set; }

        [XmlAttribute("ConditionOperator")]

        public  string ConditionOperator { get; set; }

        [XmlAttribute("AttributeValue")]

        public  string AttributeValue { get; set; }

        public RuleCondition Clone()
        {
            return new RuleCondition
            {
                LogicalOperator = LogicalOperator,
                AttributeName = AttributeName,
                ConditionOperator = ConditionOperator,
                AttributeValue = AttributeValue
            };
        }
      
    }
}
