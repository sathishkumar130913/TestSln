using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Jenkins.CoreApp;

namespace webapps
{
    public class Weblogic
    {
        RuleLogic objrule = new RuleLogic();

        void sum()
        {
            int sum = objrule.Sumlogic(1, 2);
        }
    }
}
