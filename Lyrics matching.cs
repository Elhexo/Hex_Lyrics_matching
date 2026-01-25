using System;
using System.Threading;
using NetCoreAudio;
using System.IO;
namespace Lyrics_matching
{
    //This is a simple program that plays songs and displays lyrics in the console. This projec isn't fully done yet, made on 25/01/2026
    internal class Program
    {
        static Player audioPlayer = new Player();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("---WELCOME TO HEX LYRICS MATCHING--");
            Console.ResetColor();
            Console.WriteLine("Here you can choose from the following options we have");
            Console.WriteLine("------------------------");

            bool KeepPlaying = true;

            while (KeepPlaying)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Extra");
                Console.WriteLine("2. Sleep Paralysi");
                Console.WriteLine("0. to exit the program");
                Console.WriteLine("------------------------");
                string? songChoice = Console.ReadLine();

                switch (songChoice)
                {

                    case "1":
                        string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Songs", "extra.mp3");   
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                       // Console.WriteLine("Playing Extra...");
                       // Thread.Sleep(1500);
                        Console.ResetColor();
                        Console.Clear();

                        audioPlayer.Play(path1);
                        Console.WriteLine("I was broken.");
                        Thread.Sleep(2000);

                        Console.WriteLine("I was shut down.");
                        Thread.Sleep(1200); 

                        Console.WriteLine("'Till i found a new home");
                        Thread.Sleep(1235);

                        Console.WriteLine("Live in you now");
                        Thread.Sleep(1267);

                        Console.WriteLine("I know it'll work out");
                        Thread.Sleep(1700);

                        Console.WriteLine("Girl, you got me turnt out");
                        Thread.Sleep(1500);

                        Console.WriteLine("Fuck until we burnt out");
                        Thread.Sleep(1400);

                        Console.WriteLine("Do it like you know how");
                        Thread.Sleep(1300);

                        Console.WriteLine("Thought it was a hex on me");
                        Thread.Sleep(1640);

                        Console.WriteLine("Until you fucked the curse out");
                        Thread.Sleep(1500);
                        audioPlayer.Stop();
                        break;

                    case "2":
                        string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Songs", "Sleep Paralysi.mp3");
                        audioPlayer.Play(path2);
                        Console.Clear();

                        Thread.Sleep(4750);
                        Console.Write("Sleep Paralysi again");

                        audioPlayer.Stop();
                        break;


                    case "0":
                        KeepPlaying = false;
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Exiting the program.");
                        Console.ResetColor();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ResetColor();
                        Console.WriteLine("------------------------");
                        break;
                }
            }
        }
    }
}
    