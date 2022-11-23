using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.AbstractFactory.PhoneFactory
{
   public abstract class AbstractFactoryPhone
    {
        public abstract  ISimple GetSimple();
        public abstract  ISmart GetSmart();
    }
}
