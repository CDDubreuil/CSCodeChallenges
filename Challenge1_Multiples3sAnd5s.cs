using System.Xml.Schema;

namespace Multiples3sAnd5s
{
    internal class Challenge1_Multiples3sAnd5s
    {
        static void Main(string[] args)
        {

         int sum = 0;



          for (int x = 0; x < 1000; x++)
            {

                
                if ( x % 3 == 0 || x % 5 == 0)
                {
                    sum += x;

                    Console.WriteLine(sum);
                }
                

            }



        }
        }
    }
