using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace HomeSalesPt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Char Nameint = '\0';

            Char Highsale = '\0';

            Char[] InitalArray = { 'D', 'E', 'F', 'Z' };

            String[] NameArray = { "Danelle", "Edward", "Francis" };

            bool isValid=false;

            int HighAmt = 0;           
                     
            int CurrentSale = 0;

            int[] TotArray = { 0, 0, 0, 0 };

            do
            {

                do
                {
                    Console.WriteLine("Enter a initial D, E, or F. Press Z to see a grand toatal of all sales.");

                    Nameint = Console.ReadKey().KeyChar;

                    Nameint = Char.ToUpper(Nameint);

                    isValid = false;

                    for (int i = 0; i < 4; i++) 
                    {
                        if (Nameint == InitalArray[i]) 
                        {
                         isValid = true;
                            break;                     
                        }

                        
                    }
                    Console.WriteLine("\n");
                } while (!isValid);

                Console.WriteLine("\n");

                if (Nameint != 'Z')
                {
                    Console.WriteLine("Enter Sale amount");

                    CurrentSale = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\n");

                    switch (Nameint)
                    {
                        case 'D':
                            TotArray[0] = TotArray[0] + CurrentSale;
                            break;

                        case 'E':
                            TotArray[1] = TotArray[1] = CurrentSale;
                            break;

                        case 'F':
                            TotArray[2] = TotArray[2] + CurrentSale;
                            break;

                    }

                    TotArray[3] = TotArray[3] = CurrentSale;


                    if (CurrentSale > HighAmt)
                    {
                        HighAmt = CurrentSale;
                        Highsale = Nameint;

                    }
                }
            } while (Nameint != 'Z');

            for (int i = 0; i < 3; i++) 
            {
                Console.WriteLine("The total for " + NameArray[i] + " is " + TotArray[i]);
            }
            Console.WriteLine("The Grand Total is " + TotArray[3]);
            Console.WriteLine("Person with highest sale is " + Highsale);


            Console.ReadKey();


        }
    }
}
