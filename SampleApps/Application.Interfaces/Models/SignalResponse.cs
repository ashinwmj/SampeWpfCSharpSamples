using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.Models
{
    public class SignalResponse
    {
        public string Name { get; set; }
        public string TagSource { get; set; }

        public Dictionary<string,string> Attributes { get; set; }

    }
}
