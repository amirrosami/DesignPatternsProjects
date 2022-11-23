using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.CreateShapes
{
    public class FactoryShape
    {
        public IShape? CreateShape(string shapename)
        {
            switch (shapename)
            {
                case "circle":return new Circle();
                case "rectangle":return new Rectangle();
                default:return null;
            }
        }
    }
}
