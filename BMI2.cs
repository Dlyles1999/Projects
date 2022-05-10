using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApplication26
{
    class Program
    {
        static void Main(string[] args)
        {

            string pName;
            char measurement;
            double height;
            double weight;

            pName = InputName();
            measurement = InputMeasurement();
            height = InputHeight();
            weight = InputWeight();
            BMI bodyMass = new
                BMI(pName, measurement, height, weight);
            Clear();
            WriteLine(bodyMass);
            ReadKey();

                 
    }
      public static string InputName()
        {
            string sName;
            Write("Enter Your Name:");
            sName = ReadLine();
            return sName;
        }

      public static char InputMeasurement()
        {
            string aValue;
            char tMeasurement;
            WriteLine("Enter What Measurement You Want To Use.");
            WriteLine("\nImperial [Type 1]");
            WriteLine("\nMetric [Type 2]");
            WriteLine();
            aValue = ReadLine();
            tMeasurement = Convert.ToChar(aValue);
            return tMeasurement;
        }

        public static double InputHeight()
        {
            string aValue;
            double height;
            Write("Enter The Height:");
            aValue = ReadLine();
            if (double.TryParse(aValue, out height) == false)
                WriteLine("Invaild data entered {0} -" + "0 was recorded", height);
            return height;
        }

        public static double InputWeight()
        {
            string aValue;
            double weight;
            Write("Enter The Weight:");
            aValue = ReadLine();
            if (double.TryParse(aValue, out weight) == false)
                WriteLine("Invaild data entered {0} -" + "0 was recorded", weight);
            return weight;
        }


    }
}
