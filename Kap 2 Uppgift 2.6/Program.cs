using System;
namespace Uppgift2_6
{
    class Program
    {
        static void Main(string[] args)
        {

            //Skriv en mening
            Console.WriteLine("Skriv en mening med tre ord och en punkt på slutet.");
            string sentance = Console.ReadLine();

            //Indexen för mellanslagen samt punkt
            int space1Index = sentance.IndexOf(" ");
            int space2Index = sentance.IndexOf(" ", (space1Index+1));
            int periodIndex = sentance.IndexOf(".");

            //string för varje ord
            string word1 = sentance[..space1Index];
            string word2 = sentance[(space1Index+1)..space2Index];
            string word3 = sentance[(space2Index+1)..periodIndex];

            //Skriver ut meningen baklänges
            Console.WriteLine($"Din mening baklänges: {word3} {word2} {word1}.");
            Console.ReadKey();
        }
    }
}
