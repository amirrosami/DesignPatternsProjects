using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.AbstractFactory.PhoneFactory
{
    public enum PhoneType
    {
        samsung,nokia
    }
    public class AbstractFactory
    {
        public static AbstractFactoryPhone Create(PhoneType phoneType)
        {
           switch (phoneType)
            {
                case PhoneType.samsung: return new SamsungFactory();
                    case PhoneType.nokia: return new NokiaFactory();
                    default: return null;
            }
        }
    }

    public class program
    {
        public static void Main()
        {
            var phone1=AbstractFactory.Create(PhoneType.samsung);
            phone1.GetSimple().GetName(); //returns  'Primo'


            var phone2 = AbstractFactory.Create(PhoneType.nokia);
            phone2.GetSmart().GetName(); //returns  'Lumia'
        }
    }
}

