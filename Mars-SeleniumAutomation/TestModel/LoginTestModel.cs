using Mars_SeleniumAutomation.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_SeleniumAutomation.TestModel
{
    public class LoginTestModel : Base
    {
#pragma warning disable     
        public string email {  get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
    }
}
