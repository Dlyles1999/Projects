/* Programmger : Daniel Lyles
 * Date: 4/15/19
 * Purpose: 
 * 
 * 
 */
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace HeartBeatMonitor
{
    class HeartBeatMonitorApp
    {
        static void Main()
        {
            IntroHeart();
            ProvideGuidelines();           
            ArrayList name = new ArrayList();
            CollectUserNames(out name);
            int num = name.Count;
            int[,] heartBeat = new int[num, 4];
            string[] time = new string[] { "7", "9", "5", "12" };
            ReadValue(num, name, time, heartBeat);
            var nameArray =(string[]) name.ToArray(typeof(string));
            HeartBeat test = new HeartBeat(nameArray,heartBeat);
            Clear();
            WriteLine(test.ToString());
            WriteLine("\n\n");
            GetTest(GetAverage(heartBeat, name));
            ReadKey();

        }

        public static void IntroHeart()
        {
            Title = "Heart Beat Monitor";
            WriteLine("\t\t\t\tWelcome To The Heart Monitor App");
            WriteLine("\n\nThis Program Will Help Store Your Heart Beat Daily");
            WriteLine("\n");
            WriteLine("Press Enter To Continue");
            ReadKey();
            

        }
        public static void ProvideGuidelines()
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("################################");
            WriteLine("Heart beat is measured like this");
            WriteLine("################################");
            WriteLine("\n\n1. Find a watch or an electronic device with a second hand and place it on your right wrist or on the table next to your left hand.");
            WriteLine("2. After finding your pulse, count the number of beats for 20 seconds.");
            WriteLine("3. Multiply by 3 to get your heart rate, or beats per minute (or just count for 60 seconds for a math-free option)");
            ForegroundColor = ConsoleColor.Black; 

            WriteLine("\n");            
        }
        public static void CollectUserNames(out ArrayList name)
        {
            bool pepsi = true;
            name = new ArrayList();

            do // gathering the user names
            {
                WriteLine();
                Write("Who is going to be measuring heart beats? ");
                name.Add(ReadLine());

                Write("more users? (yes) ");
                if (ReadLine() == "yes")
                    pepsi = true;
                else pepsi = false;

            } while (pepsi);

        }



        public static void ReadValue(int num, ArrayList name, string[] time, int[,] htbt)
        {
            WriteLine("Enter your name and time and value in the following NAME, TIME, VALUE \nFor Example enter (Daniel, 7, 88)");
            WriteLine("Enter 00 To End\n");
            string input = "";
            while (input != "00")
                {
                 input = ReadLine();
                if (input != "00")
                {
                    string[] inputArray = input.Split(',');
                    int row = name.IndexOf(inputArray[0]);
                    int col = Array.IndexOf(time, inputArray[1]);
                    htbt[row, col] = int.Parse(inputArray[2]);
                    if (htbt[row, col] == 0)
                    {
                        htbt[row, col] = int.Parse(inputArray[2]);
                    }
                    else
                        if (int.Parse(inputArray[2]) < htbt[row, col])

                    {
                        htbt[row, col] = int.Parse(inputArray[2]);

                    }
                }

            }




        }
                public static string GetTest(double val)
        {
            if (val < 60)
            {
                return "bradycardia";
            }
            else
                if (val > 60)
            {
                return "normal";
            }

            else
                if (val > 100)
            {
                return "tachycardia";
            }

            
                return "";
            
        }

        public static double GetAverage(int [,] hBeat, ArrayList name )
        {
            int sum = 0;
            double average = 0;
            for (int i = 0; i < hBeat.GetLength(0); i++)
            {
                for(int j = 0; j < hBeat.GetLength(1); j++)
                {
                    sum += hBeat[i, j];
                }
                average = sum / 4;
                Write(name[i] + "");
                Write("\t" + average);
                Write("\t" + GetTest(average));
                Write("\n");
                sum = 0;

            }
            return average;
        }

       

    }
                 
    }

