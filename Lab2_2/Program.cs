using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Part2();  
        }

        static void Patr1()
        {
            StreamWriter sw = new StreamWriter(@"C:\Users\bsnbk2\Desktop\new.txt", true);


            sw.WriteLine("hello world!");

            sw.Close();

        }

        static void Part2()
        {
            try
            {
                StreamReader sr = File.OpenText(@"C:\Users\bsnbk2\Desktop\new.txt");

                try
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    sr.Close();
                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
