using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CompanyService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "PersonalService" in both code and config file together.
    public class PersonalService : IPersonalService
    {
        public string DoWork()
        {
            return "Hello epta";
        }
    }
}
