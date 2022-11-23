using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsExample.Factories.FactoryMethod.Point
{

    public class pointfactory
    {
        public  point CreateCartesianPoint(int r, int theta)
        {
            return new point(r * Math.Cos(theta), r * Math.Sin(theta));
        }


        public  point CreatePolarPoint(double x, double y)
        {
            return new point(x, y);
        }
    }

    public class point
    {
        public double x, y;
        internal point(double x_point,double y_point)
        {
            x=x_point;
            y=y_point;
        }

        public static pointfactory factory=>new pointfactory();


       


    }


    public class program
    {
        public static void main()
        {
         point cartesianpoint=  point.factory.CreateCartesianPoint(10,220);
          point polarpoint=  point.factory.CreatePolarPoint(20,30);
        }
    }
}


