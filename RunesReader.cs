using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RunesCaster
{
    class Program
    {
        /// <summary>
        /// Generates three random runes, also randomly decides if rune is face up and inverted and to which degree. This was a rough go through. I plan to use one method to call & cast runes and add another dictionary of interpretations - also images of runes cast on a field and wrap it up in xamarin to create a workable app for android phone. I'll keep you posted as I continue work on this project. https://github.com/bdemaloney
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Runes Dictionary
            var runesDict = new Dictionary<int, string>();

            runesDict.Add(1, "Fehu");
            runesDict.Add(2, "Uruz");
            runesDict.Add(3, "Thurisaz");
            runesDict.Add(4, "Ansuz");
            runesDict.Add(5, "Raidho");
            runesDict.Add(6, "Kenaz");
            runesDict.Add(7, "Gebo");
            runesDict.Add(8, "Wunjo");
            runesDict.Add(9, "Hagalaz");
            runesDict.Add(10, "Nauthiz");
            runesDict.Add(11, "Isa");
            runesDict.Add(12, "Jera");
            runesDict.Add(13, "Eihwaz");
            runesDict.Add(14, "Perthro");
            runesDict.Add(15, "Algiz");
            runesDict.Add(16, "Sowilo");
            runesDict.Add(17, "Tiwaz");
            runesDict.Add(18, "Berkano");
            runesDict.Add(19, "Ehwaz");
            runesDict.Add(20, "Mannaz");
            runesDict.Add(21, "Laguz");
            runesDict.Add(22, "Ingwaz");
            runesDict.Add(23, "Dagaz");
            runesDict.Add(24, "Othala");
            runesDict.Add(25, "Woden \'Blank\'");

            // Random number generator
            Random random = new Random();
            int randomNumber1 = random.Next(0, 26);
            int randomNumber2 = random.Next(0, 26);
            int randomNumber3 = random.Next(0, 26);
            int faceUp1 = random.Next(0, 2);
            int faceUp2 = random.Next(0, 2);
            int faceUp3 = random.Next(0, 2);
            int degRotated1 = random.Next(0, 361);
            int degRotated2 = random.Next(0, 361);
            int degRotated3 = random.Next(0, 361);


            foreach (KeyValuePair<int, String> kv in runesDict)
            {
                if (randomNumber1 == kv.Key)
                {
                    Console.Write(kv.Value);

                    if (faceUp1 == 1)
                    {
                        Console.WriteLine("Face up - External influence");
                    }
                    else
                    {
                        Console.WriteLine("Face Down - Obscured influence");
                    }

                    
                    if (degRotated1 <= 90)
                    {
                        Console.WriteLine("Upright Position - North-West Orientation");
                    }
                    else if (degRotated1 <= 180)
                    {
                        Console.WriteLine("Upright Position - North-East Orientation");
                    }
                    else if (degRotated1 <= 270)
                    {
                        Console.WriteLine("Inverted Position - South-East Orientation");
                    }
                    else
                    {
                        Console.WriteLine("Inverted Position - South-West Orientation");
                    }
        
                }


                else if (randomNumber2 == kv.Key)
                {
                    Console.WriteLine(kv.Value);

                    if (faceUp2 == 1)
                    {
                        Console.WriteLine("Face up - External influence");
                    }
                    else
                    {
                        Console.WriteLine("Face Down - Obscured influence");
                    }


                    if (degRotated2 <= 90)
                    {
                        Console.WriteLine("Upright Position - North-West Orientation");
                    }
                    else if (degRotated2 <= 180)
                    {
                        Console.WriteLine("Upright Position - North-East Orientation");
                    }
                    else if (degRotated2 <= 270)
                    {
                        Console.WriteLine("Inverted Position - South-East Orientation");
                    }
                    else
                    {
                        Console.WriteLine("Inverted Position - South-West Orientation");
                    }
                }
                else if (randomNumber3 == kv.Key)
                {
                    Console.WriteLine(kv.Value);

                    if (faceUp3 == 1)
                    {
                        Console.WriteLine("Face up - External influence");
                    }
                    else
                    {
                        Console.WriteLine("Face Down - Obscured influence");
                    }


                    if (degRotated3 <= 90)
                    {
                        Console.WriteLine("Upright Position - North-West Orientation");
                    }
                    else if (degRotated3 <= 180)
                    {
                        Console.WriteLine("Upright Position - North-East Orientation");
                    }
                    else if (degRotated3 <= 270)
                    {
                        Console.WriteLine("Inverted Position - South-East Orientation");
                    }
                    else
                    {
                        Console.WriteLine("Inverted Position - South-West Orientation");
                    }
                }
            }

            Console.WriteLine("{0} {1} {2}", randomNumber1, randomNumber2, randomNumber3);
            Console.Read();

        }
    }
}
