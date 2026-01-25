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
                Console.WriteLine("2. Mistletoe");
                Console.WriteLine("0. to exit the program");
                Console.WriteLine("------------------------");
                string? songChoice = Console.ReadLine();

                switch (songChoice)
                {

                    case "1":
                        string path1 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Songs", "extra.mp3");   
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Playing Extra...");
                        Thread.Sleep(1500);
                        Console.ResetColor();
                        Console.Clear();

                        audioPlayer.Play(path1);
                        Console.WriteLine(" I was broken.");
                        Thread.Sleep(2000);

                        Console.WriteLine("i was shut down.");
                        Thread.Sleep(1100); 

                        Console.WriteLine("'Till i found a new home");
                        Thread.Sleep(1235);

                        Console.WriteLine("Live in you now");
                        Thread.Sleep(1267);

                        Console.WriteLine("I know it'll work out");
                        Thread.Sleep(1750);

                        audioPlayer.Stop();
                        break;

                    case "2":
                        string path2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Songs", "mistletoe.mp3");
                        audioPlayer.Play(path2);
                        string[] gameLyrics = {"Mistletoe"};
                        foreach (string lyric in gameLyrics)
                        {
                            Console.WriteLine(lyric);
                            Thread.Sleep(2000);
                        }
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
    