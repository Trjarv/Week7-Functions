using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime;
            //programm küsib kasutajal sisestada numbrit 1-3;
            //kui kasutaja sisestab '1', siis kuvatakse kasutaja eesnimi tagurpidi;
            //kui kasutaja valib 2, siis kuvatase kasutaaj eesnime esimest tähte;
            //kui kasutaja valib 3, siis kuvatakse kasutaja eesnime pikkust.

            Console.WriteLine("Palun sisesta oma eesnimi.");
            string userName = Console.ReadLine();
            Console.WriteLine("Palun sisesta number 1-3.");
            int userChoice = Convert.ToInt32(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    UserNameDataBackwards(userName);
                    break;
                case 2:
                    UserNameDataFirst(userName);
                    break;
                case 3:
                    UserNameDataLenght(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }
        public static void UserNameDataBackwards(string userInput) 
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }
        public static void UserNameDataFirst(string userInput) 
        {
            Console.WriteLine($"Teie eesnime esimene täht on {userInput[0]}.");
        }
        public static void UserNameDataLenght(string userInput)
        {
            Console.WriteLine($"Teie eesnimes on {userInput.Length} tähte.");
        }
    }
}
