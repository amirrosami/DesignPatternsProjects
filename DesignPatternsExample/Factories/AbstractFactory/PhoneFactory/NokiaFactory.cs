using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.AbstractFactory.PhoneFactory
{
    public class NokiaFactory : AbstractFactoryPhone
    {
        public override ISimple GetSimple()
        {
            return new asha();
        }

        public override ISmart GetSmart()
        {
            return new Lumia();
        }
    }
}
