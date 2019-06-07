using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamSerafin
{
    class ProgramSRFN
    {
        static void Main(string[] args)
        {
            int InputNumberP3;
            int IN1P5;
            int IN2P5;
            string MorAP5;
            DateTime DTP6;
            int InputNumberP7;
            //int[] arr = new int[5];
            string[] InputArrayP8 = { "This", "is", "an", "Array" };
            string[] InputArrP8 = new string[100];

            //Problem1
            //Console.WriteLine(GetMyInfo());
            //Problem2
            //Console.WriteLine(Problem2());

            //Problem3
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out InputNumberP3);
            //Console.WriteLine(Problem3(InputNumberP3).ToString());

            //Problem4
            //Console.WriteLine(Problem4());

            //Problem5
            //Console.WriteLine("Enter first number please:");
            //int.TryParse(Console.ReadLine(), out IN1P5);
            //Console.WriteLine("Enter second number please:");
            //int.TryParse(Console.ReadLine(), out IN2P5);
            //Console.WriteLine("Enter character M or A to Multiply or Add those numbers:");
            //MorAP5 = Console.ReadLine();
            //Console.WriteLine(Problem5(IN1P5,IN2P5,MorAP5).ToString());

            //Problem6
            //Console.WriteLine("Please enter a date in format YYYY-MM-DD: ");
            //DateTime.TryParse(Console.ReadLine(), out DTP6);
            //Console.WriteLine(Problem6(DTP6));

            //Problem7
            //Console.WriteLine("Please enter a number: ");
            //int.TryParse(Console.ReadLine(), out InputNumberP7);
            //Console.WriteLine(Problem7(InputNumberP7).ToString());

            //Problem8
            //Console.WriteLine("An array of strings is entered as the input of the method: ");
            ////InputArrP8 = Console.ReadLine();
            //Console.WriteLine("[this], [is], [an], [array]");
            //Console.WriteLine(Problem8(InputArrayP8));







            //To keep the console window open.
            Console.ReadKey();
        }

        //Problem1
        static private string GetMyInfo()
        {
            try
            {
                string OutputString;
                OutputString = "Serafin Garcia " + DateTime.Now.ToString("yyyy-MM-dd hh:mmtt");

                return OutputString;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.ToString());
                return "";
            }
        }

        //Problem2
        static private int Problem2()
        {
            try
            {
                string InputStringP2;

                Console.WriteLine("Please enter a string: ");
                InputStringP2 = Console.ReadLine();
                Console.WriteLine("");
                
                return InputStringP2.Length;
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.ToString());
                return 0;
            }
        }

        //Problem3
        static private string Problem3(int aa1)
        {
            try
            {
                if (aa1 % 2 == 0) return "EVEN";
                else return "ODD";
            }
            catch (Exception ex)
            {
                return "An error ocurred: " + ex.ToString();
            }
        }

        //Problem4
        static private string Problem4()
        {
            try
            {
                string OutputStringP4 = "";

                for (int i = 1; i <= 10; i++)
                {
                    OutputStringP4 += i + " ";
                }

                return OutputStringP4;

            }
            catch (Exception ex)
            {
                return "An error ocurred: " + ex.ToString();
            }
        }

        //Problem5
        static private int Problem5(int a1, int a2, string MorA)
        {
            try
            {
                if (MorA == "M")
                {
                    return a1 * a2;
                }
                else if (MorA == "A")
                {
                    return a1 + a2;
                }
                else return 0;

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.ToString());
                return 0;
            }
        }


        //Problem6
        static private string Problem6(DateTime dt1)
        {
            try
            {
                return dt1.DayOfWeek.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error ocurred: " + ex.ToString());
                return "";
            }
        }

        //Problem7
        static private string Problem7(int aa7)
        {
            try
            {
                if (aa7 > 0) return "POSITIVE";
                else if (aa7 < 0) return "NEGATIVE";
                else return "ZERO";
            }
            catch (Exception ex)
            {
                return "An error ocurred: " + ex.ToString();
            }
        }

        //Problem8
        static private string Problem8(string[] ArrayP8)
        {
            string OutputStringP8 = "";
            string OutputString2P8 = ArrayP8[0];
            try
            {
                for (int j=0; j < ArrayP8.Length; j++)
                {
                    OutputStringP8 += ArrayP8[j] + " ";
                }
                OutputStringP8 = OutputStringP8.ToUpper();

                return OutputStringP8;
            }
            catch (Exception ex)
            {
                return "An error ocurred: " + ex.ToString();
            }
        }







    }
}
