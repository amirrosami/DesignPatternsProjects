using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.AbstractFactory.PhoneFactory
{
    public class asha : ISimple
    {
        public string GetName()
        {
            return "asha";
        }
    }
}
