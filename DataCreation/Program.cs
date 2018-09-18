using System;
using System.IO;

namespace DataCreation
{
    class Program
    {
        static void Main(string[] args)
        {

            WriteData();

            Console.ReadLine();
        }

        public static void WriteData()
        {
            using (StreamWriter file = new StreamWriter(@"C:\workspace\DataCreation.txt", true))
            {


            Random random = new Random();


            for (int i = 0; i < 1000000; i++)
            {
                //GUID
                Guid g = Guid.NewGuid();

                //Double
                double d = random.NextDouble();
                
                file.WriteLine(String.Format("{0}, {1}, {2}", i, g, d));

            }
            }

        }
    }
}
