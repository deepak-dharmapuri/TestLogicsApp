using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bank of Testing welcomes you...");
            Console.WriteLine("Enter the Amount you want to withdraw");
            int withDrawAmt = 0;
            int.TryParse(Console.ReadLine(), out withDrawAmt);
            if (withDrawAmt.Equals(0))
            {
                Console.WriteLine("Invalid Amount");
                Console.ReadLine();
            }
            else
            {
                if (withDrawAmt % 100 != 0)
                {
                    Console.WriteLine("Amount can't be dispenced.");
                    Console.ReadLine();
                }
                else
                {
                    int[] notes = new int[] { 1000, 500, 100 };
                    int[] noteCounter = new int[3];

                    for (int i = 0; i < 3; i++)
                    {
                        if (withDrawAmt >= notes[i])
                        {
                            noteCounter[i] = withDrawAmt / notes[i];
                            withDrawAmt = withDrawAmt - noteCounter[i] * notes[i];
                        }
                    }
                    Console.WriteLine("Fetched denomination...");
                    for (int i = 0; i < 3; i++)
                    {
                        if (noteCounter[i] != 0)
                        {
                            Console.WriteLine(notes[i] + ":" + noteCounter[i]);
                        }
                    }
                    Console.ReadLine();
                }
            }

        }
    }
}
