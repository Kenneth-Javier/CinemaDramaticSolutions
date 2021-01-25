using System;
using System.Diagnostics;

namespace CinemaDramaticSolutions
{
    class Program
    {
        //From git
        static void Main(string[] args)
        {
            //1.
            PrintWelcomeClient();
            //2.
            InputFromClient();
            
        }

        //0,2.Skapa skalet till en Switch-sats som till en början har Två Cases.
        //Ett för ”0” somstänger ner programmet och ett default som berättar att det är felaktig input.
        private static void InputFromClient()
        {
            bool m = true;
            PrintMenu();
            //0,3.Skapa en ​oändlig iteration, ​alltså något som inte tar slut innan vi säger till att den ska ta slut. 
            //Detta löser ni med att skapa en egen bool med tillhörande while-loop.
            do
            {
                string x = Console.ReadLine();
                string caseSwitch = x;
                //0,4.Bygg ut menyn med val att exekvera de övriga övningarna.
                switch (caseSwitch)
                {
                    //klar bugg string catch faliure
                    case "1":
                        StrOut("Menyval 1: Ungdom eller pensionär");
                        TicketPrice(AskPersonAge());
                        StrOut("\n");
                        PrintMenu();
                        break;
                    //klar
                    case "2":
                        StrOut("Menyval 2: Upprepa tio gånger");
                        StrOut("Skriv det du vill ska upprepas tio gånger:");
                        String tenTimesStr = Console.ReadLine();
                        Repeat10times(tenTimesStr);
                        PrintMenu();
                        break;
                    //klar
                    case "3":
                        StrOut("Menyval 3: Det tredje ordet");
                        StrOut("Skriv en mening med minst tre ord");
                        var words = Console.ReadLine();
                        ToStrSplit(words);
                        StrOut("\n");
                        PrintMenu(); 
                        break;
                    //klar
                    case "4":
                        Console.WriteLine("Menyval 4: Räkna ut priset för ett sällskap");
                        string str = "Ange antal biljetter till sälskapet? (ange endast i siffror)";
                        Menyval4(str);
                        PrintMenu();
                        break;
                        //klar
                    case "0":
                        Console.WriteLine("Menyval 0 för att avsluta program");
                        m = false;
                        Environment.Exit(0);
                        break;
                        //klar
                    default:
                        Console.WriteLine("Felaktig input, försök igen enligt anvisningarna:");
                        break;
                }
            } while (m);
        }

        private static void ToStrSplit(string words)
        {
            var w = words.Split();
            var first = w[1];
            var w3 = w[2];
            Console.WriteLine(w3);
        }

        private static void Repeat10times(string str)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". " + str + ", ");
            }
            StrOut("\n");
        }

        //Menyval 1: Ungdom eller pensionär
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


        //bör använda sig av menyval1() samt priceCounter() för att skriva ut totala priset
        private static void Menyval4(string text)
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

        private static void StrOut(string str)
        {
            Console.WriteLine(str);
        }

        private static string AskPersonAge()
        {
            return "Ange ålder i siffror";
        }


        //0,1.Berätta för användaren att de har kommit till huvudmenyn och de kommernavigera genom att skriva in siffror för att testa olika funktioner.
        private static void PrintWelcomeClient()
        {
            StrOut("Welcome to the Cinema!");
            StrOut("Du har kommit till huvudmenyn och kommer navigera genom att skriva in siffror för att testa olika funktioner.");
            StrOut("Tryck sedan Enter för att fortsätta.");
            StrOut("\n");
        }

        private static void PrintMenu()
        {

            StrOut("Huvudmeny: ");
            StrOut("Menyval 1: Ungdom eller pensionär");
            StrOut("Menyval 2: Upprepa tio gånger");
            StrOut("Menyval 3: Det tredje ordet");
            StrOut("Menyval 4: Räkna ut priset för ett sällskap");
            StrOut("Menyval 0 för att avsluta program");
            StrOut("\n");
        }

    }
    namespace StringApplication
    {

        class StringProg
        {

            static void SMain(string[] args)
            {
                string[] starray = new string[]{"Down the way nights are dark",
            "And the sun shines daily on the mountain top",
            "I took a trip on a sailing ship",
            "And when I reached Jamaica",
            "I made a stop"};

                string str = String.Join("\n", starray);
                Console.WriteLine(str);
            }
        }
    }
}
