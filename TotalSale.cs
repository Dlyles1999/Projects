/* Programmer : Daniel Lyles 
 * Date: 2/5/2019
 * Purpose: A Program that shows how each monthly sales contributes to their overall total sales. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Total_Sales2
{
    class BigSale
    {
        static void Main(string[] args)
        {

            WriteLine("To Start Enter Your Name And The Number Of Sales You Made That Month.");
            InputName();
            double[] sales = new double[12];
            double sum = InputValues(sales);
            Clear();
            WriteLine("The Final Report");
            double[] percentage = new double[12];
            for (int i = 0; i < percentage.Length; i++)
            {
                percentage[i] = sales[i] / sum;
                       
            }
            for (int i = 0; i < percentage.Length; i++)
            {
                WriteLine("{0:C} {1:P}", sales[i], percentage[i]);
                 }
            WriteLine("\tThe Sum of Sales: {0:C}", sum);

            ReadKey();
        }

        public static void  InputName()
        {
            string aValue;
            WriteLine("Summary Data(Insert Your Name Down Below)");
            aValue = ReadLine();
           
        }

        public static double InputValues(double [] sale)
        {
            
            double sum = 0;
            string aValue;
            for(int i = 0; i < sale.Length; i++)
            {
                WriteLine("Enter The Number of Sale Month{0}:", i+1);
                aValue = ReadLine();
                sale[i] = double.Parse(aValue);
                sum += sale[i];
                
               
            }
            return sum;


           }
       
        


    }
}
