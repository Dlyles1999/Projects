using System;
using System.Collections.Generic;
using static System.Console;
namespace HeartBeatMonitor
{
    class HeartBeat
    {
        private string[] heartName;
        private int[,] heartRate;



       public  HeartBeat()
        {

        }

    public HeartBeat(string [] hName, int [,] hRate)
        {
            heartName = hName;
            heartRate = hRate;
        }

        public HeartBeat( int[,] hRate)
        {
            heartRate = hRate;
        }

        public HeartBeat(string[] hName)
        {
            heartName = hName;
        }

        public string [] HeartName
        {
            get
            {
                return heartName;
            }
            set
            {
                heartName = value;
            }

        }

        public int[,] HeartRate
        {
            get
            {
                return heartRate;
            }
            set
            {
                heartRate = value;
            }

        }




        public override string ToString()
        {
            string hData = "";
            int sum = 0;
            
            WriteLine("\t\t\tTime Slots");
            WriteLine("Users\t\t7 Am\t\tNoon\t\t5 Pm\t\t9 Pm\n");

            for (int i = 0; i < heartName.Length; i++)
            {
                hData += $"{heartName[i]}"; 
                for (int j = 0; j < heartRate.GetLength(1); j++)
                {
                    hData += $"\t\t  {heartRate[i, j]}";
                    sum += (int)heartRate[i, j];
                }
                hData += "\n";

            }


            return hData;

        }

       
        

     





    }
}
