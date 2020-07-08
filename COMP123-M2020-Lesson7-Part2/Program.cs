using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace COMP123_M2020_Lesson7_Part2
{
    class Program
    {
        static void waitForAnyKey()
        {
            Console.ReadKey();
        }



        static void Main(string[] args)
        {
            Vector2D position = new Vector2D();
            float Xinput, Yinput;
            bool XInputCorrect = false;
            bool YInputCorrect = false;

            while (!XInputCorrect)
            {
                Console.Write("Enter the X coordinate: ");
                if (float.TryParse(Console.ReadLine(), out Xinput))
                {
                    position.x = Xinput;
                    XInputCorrect = true;
                }
                else
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("ERROR");
                    Console.WriteLine("Please enter a number value for X");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine();
                }
            }

            while (!YInputCorrect)
            {
                Console.Write("Enter the Y coordinate: ");
                if (float.TryParse(Console.ReadLine(), out Yinput))
                {
                    position.y = Yinput;
                    YInputCorrect = true;
                }
                else
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("ERROR");
                    Console.WriteLine("Please enter a number value for Y");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine();
                }
            }

            // encoding for file output
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("Writing to File");
            Console.WriteLine("========================================");
            Console.WriteLine();
            // Steps for Writing Files
            // Step 1 - setup our streams
            FileStream outPutFile = new FileStream("positions.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outPutFile);

            // Step 2 - Write to the stream
            writer.WriteLine(position.StringEncode());

            // Step 3 - clean up
            writer.Close();
            outPutFile.Close();

            // decoding for file input
            Console.WriteLine();
            Console.WriteLine("========================================");
            Console.WriteLine("Reading from File");
            Console.WriteLine("========================================");
            Console.WriteLine();
            // Steps for Reading Files
            // Step 1 - setup our streams
            FileStream inputFile = new FileStream("positions.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(inputFile);

            // Step 2 - Read from the stream
            string inputString = reader.ReadLine();

            Console.WriteLine("String read from file: " + inputString);

            // Step 3 - clean up
            reader.Close();
            inputFile.Close();


            Console.WriteLine("Decoding Coordinates");
            position.StringDecode(inputString);

            Console.WriteLine("New Coordinates are: " + position.ToString());


            waitForAnyKey();
        }
    }
}
