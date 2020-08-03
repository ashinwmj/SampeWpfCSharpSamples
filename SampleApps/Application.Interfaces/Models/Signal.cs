using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Application.Interfaces.Models
{
    public class Signal : EntityBase
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Signal_Source { get; set; }
        public virtual string Xml_data { get; set; }

        public Dictionary<string, string> Attributes
        {
            get
            {
                var dict=new Dictionary<string,string>();
                if (!string.IsNullOrEmpty(Xml_data))
                {
                    foreach (XElement element in XDocument.Parse(Xml_data).Elements("Attributes").Elements("item"))
                    {
                        dict[element.Element("key").Value] = element.Element("value").Value;
                    }
                }
                return  dict;
            }
        }
    }
}
