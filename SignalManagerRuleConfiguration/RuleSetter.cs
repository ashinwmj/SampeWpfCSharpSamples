using System;
using System.Xml.Serialization;
namespace SignalManagerRuleConfiguration

{
    [Serializable]

    public class RuleSetter
    {
        public RuleSetter()
        {
                
        }
        [XmlAttribute("AttributeName")]
        public string AttributeName { get; set; }
        [XmlAttribute("AttributeValue")]
        public string AttributeValue { get; set; }

        public RuleSetter Clone()
        {
            return new RuleSetter
            {
                AttributeName = AttributeName,
                AttributeValue = AttributeValue
            };
        }
    }
}
