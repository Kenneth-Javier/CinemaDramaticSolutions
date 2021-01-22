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
            welcomeClient();
            //2.
            inputFromClient();
            
        }

        //0,2.Skapa skalet till en Switch-sats som till en början har Två Cases.
        //Ett för ”0” somstänger ner programmet och ett default som berättar att det är felaktig input.
        private static void inputFromClient()
        {
            bool m = true;
            printMenu();
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
                        Console.WriteLine("Menyval 1: Ungdom eller pensionär");
                        ticketPrice(askpersonage());
                        break;
                    //klar
                    case "2":
                        Console.WriteLine("Menyval 2: Upprepa tio gånger");
                        Console.WriteLine("Skriv det du vill ska upprepas tio gånger:");
                        String tenT = Console.ReadLine();
                        repeat10times(tenT);
                        break;
                    //på gång
                    case "3":
                        Console.WriteLine("Menyval 3: Det tredje ordet");
                        Console.WriteLine("Skriv en mening med minst tre ord");
                        var words = "glökjdslkgj sdgdsga agddgag agag";
                            //Console.ReadLine();
                        toStringSpl(words);
                        break;
                    //klar
                    case "4":
                        Console.WriteLine("Menyval 4: Räkna ut priset för ett sällskap");
                        String text = "Ange antal biljetter till sälskapet? (ange endast i siffror)";
                        menyval4(text);
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

        private static String toStringSpl(string words)
        {
            //Fix
            //Again
            var wordString = words.ToString();
            while (int i = 0; i < wordString.Split(' ').Length; int++){
                var newString[i] = wordString.Split(' ');
            }

            Console.WriteLine(newString);
        }

        private static void repeat10times(String text)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.Write((i + 1) + ". " + text + ", ");
            }
            
        }

        private static string askpersonage()
        {
            return "Ange ålder i siffror";
        }

        //Menyval 1: Ungdom eller pensionär
        //
        private static int ticketPrice(String text)
        {
            //metod behöver:
            int ticketprice;
            int number = stringtoint(text);
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

        private static int stringtoint(string text)
        {
            bool success = false;
            int number;
            do
            {
                strOut(text);
                string x = Console.ReadLine();
                success = false;
                success = int.TryParse(x, out number);
                if (!success)
                    Console.WriteLine("Felaktig input, försök igen med siffror");
            } while (!success);
            return number;
        }

        private static void strOut(String text)
        {
            Console.WriteLine(text);
        }

        //bör använda sig av menyval1() samt priceCounter() för att skriva ut totala priset
        private static void menyval4(String text)
        {
            int antalbiljetter = stringtoint(text);
            bool success = false;
            int totalprice =0;
            int i = 0;
            //totalprice = antalbiljetter x biljettpris
            if (antalbiljetter > 0)
            {
                while (!success)
                {
                    i++;
                    totalprice += ticketPrice(askpersonage());
                    if (i == antalbiljetter)
                    {
                        success = true;
                        i = 0;
                    }
                }

                Console.WriteLine("Du Skall alltså ha " + antalbiljetter + " biljetter till sälskapet för " + totalprice + "kr");
            }
        }

        private static void printMenu()
        {
            Console.WriteLine("Huvudmeny: ");
            Console.WriteLine("Menyval 1: Ungdom eller pensionär");
            Console.WriteLine("Menyval 2: Upprepa tio gånger");
            Console.WriteLine("Menyval 3: Det tredje ordet");
            Console.WriteLine("Menyval 4: Räkna ut priset för ett sällskap");
            Console.WriteLine("Menyval 0 för att avsluta program");
        }

        //0,1.Berätta för användaren att de har kommit till huvudmenyn och de kommernavigera genom att skriva in siffror för att testa olika funktioner.
        private static void welcomeClient()
        {
            Console.WriteLine("Welcome to the Cinema!");
            Console.WriteLine("Du har kommit till huvudmenyn och kommer navigera genom att skriva in siffror för att testa olika funktioner.");
            Console.WriteLine("Tryck Enter för att fortsätta.");
            var x = Console.ReadLine();
        }

    }
}
