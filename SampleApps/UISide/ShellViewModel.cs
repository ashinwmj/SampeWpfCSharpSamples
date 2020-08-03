using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;

namespace UISide
{
   public class ShellViewModel:BindableBase
    {
        private string _loggerValue ="0";
        public string LoggerValue
        {
            get { return _loggerValue; }
            set { SetProperty(ref _loggerValue, value); }
        }

        public static void SetStausValue(string value)
        {
           
        }
    }
}
