using System;
using System.Diagnostics;

namespace CinemaDramaticSolutions
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.
            PrintWelcomeClient();
            //2.
            HandleOptions();
            
        }

        //Handles the menu optoions for the program
        private static void HandleOptions()
        {
            //While true, menu will be running
            bool menuActual = true;
            do
            {
                //prints out menu
                PrintMenu();
                //switch recives input from user and handle options chose dependent of users string input
                string x = Console.ReadLine();
                string caseSwitch = x;
                switch (caseSwitch)
                {
                    case "1":
                        StrOut("Menyval 1: Ungdom eller pensionär");
                        TicketPrice(AskPersonAge());
                        StrOut("\n");
                        break;
                    case "2":
                        StrOut("Menyval 2: Upprepa tio gånger" + "\n" + "Skriv det du vill ska upprepas tio gånger:");
                        string tenTimesStr = Console.ReadLine();
                        Repeat10times(tenTimesStr);
                        break;
                    case "3":
                        StrOut("Menyval 3: Det tredje ordet" + "\n" + "Skriv en mening med minst tre ord");
                        var words = Console.ReadLine();
                        ToStrSplit(words);
                        StrOut("\n");
                        break;
                    case "4":
                        StrOut("Menyval 4: Räkna ut priset för ett sällskap");
                        string str = "Ange antal biljetter till sälskapet? (ange endast i siffror)";
                        CompanyAmoutAndCost(str);
                        break;
                    case "0":
                        StrOut("Menyval 0 för att avsluta program");
                        menuActual = false;
                        Environment.Exit(0);
                        break;
                    default:
                        StrOut("Felaktig input, försök igen enligt anvisningarna:");
                        break;
                }
            } while (menuActual);
        }

        //Splitts string content in to var(string) array, gets the thid string from w array and writes out to user
        private static void ToStrSplit(string words)
        {
            var w = words.Split();
            var w3 = w[2];
            StrOut(w3);
        }

        //Outprints typed word 10 times with number of times before
        private static void Repeat10times(string str)
        {
            for (int i = 0; i < 10; i++)
            {
                StrOut((i + 1) + ". " + str + ", ");
            }
            StrOut("\n");
        }

        //calculates all individual tickets cost
        private static int TicketPrice(string str)
        {
            //metod behöver:
            int ticketprice;
            int number = Stringtoint(str);
            if ((number < 20) && (number > 4))
            {
                ticketprice = 80;
                Console.WriteLine("Ungdomspris: " + ticketprice + "kr");
            }
            else if ((number > 64) && (number < 101))
            {
                ticketprice = 90;
                Console.WriteLine("Pensionärspris: " + ticketprice + "kr");
            }
            else if (number > 100)
            {
                ticketprice = 0;
                Console.WriteLine("OLD: " + ticketprice + "kr");
            }
            else if (number < 5)
            {
                ticketprice = 0;
                Console.WriteLine("BABY: " + ticketprice + "kr");
            }
            else
            {
                ticketprice = 120;
                Console.WriteLine("Standardpris: " + ticketprice + "kr");
            }
            return ticketprice;
        }

        //converts strings to ints
        private static int Stringtoint(string text)
        {
            bool success = false;
            int number;
            do
            {
                StrOut(text);
                string x = Console.ReadLine();
                success = false;
                success = int.TryParse(x, out number);
                if (!success)
                    Console.WriteLine("Felaktig input, försök igen med siffror");
            } while (!success);
            return number;
        }

        //calculates how all tickets cost in total
        private static void CompanyAmoutAndCost(string text)
        {
            int antalbiljetter = Stringtoint(text);
            bool success = false;
            int totalprice =0;
            int i = 0;
            //totalprice = antalbiljetter x biljettpris
            if (antalbiljetter > 0)
            {
                while (!success)
                {
                    i++;
                    totalprice += TicketPrice(AskPersonAge());
                    if (i == antalbiljetter)
                    {
                        success = true;
                        i = 0;
                    }
                }
                StrOut("\n" + "Du Skall alltså ha " + antalbiljetter + " biljetter till sälskapet för totalt " + totalprice + "kr" + "\n");
            }
        }

        //Prints out strings
        private static void StrOut(string str)
        {
            Console.WriteLine(str);
        }

        //asks persons age
        private static string AskPersonAge()
        {
            return "Ange ålder i siffror";
        }

        //Prints out how to use the menu system
        private static void PrintWelcomeClient()
        {
            string[] starray = new string[] { "Welcome to the Cinema!",
            "Du har kommit till huvudmenyn och kommer navigera genom att skriva in siffror för att testa olika funktioner.",
            "Tryck sedan Enter för att fortsätta.",
            "\n" };
            string str = String.Join("\n", starray);
            StrOut(str);
        }

        //Prints out the menu
        private static void PrintMenu()
        {
            string[] starray = new string[]{"Huvudmeny: ",
            "Menyval 1: Ungdom eller pensionär",
            "Menyval 2: Upprepa tio gånger",
            "Menyval 3: Det tredje ordet",
            "Menyval 4: Räkna ut priset för ett sällskap",
            "Menyval 0 för att avsluta program",
            "\n" };
            string str = String.Join("\n", starray);
            StrOut(str);
        }
    }
}
