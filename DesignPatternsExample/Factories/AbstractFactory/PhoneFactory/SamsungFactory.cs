using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.AbstractFactory.PhoneFactory
{
    public class SamsungFactory : AbstractFactoryPhone
    {
        public override ISimple GetSimple()
        {
            return new primo();
        }

        public override ISmart GetSmart()
        {
            return new galaxy();
        }
    }
}
