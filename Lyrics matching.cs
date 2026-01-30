using NetCoreAudio;
using System;
using System.IO;
using System.Runtime.Intrinsics.X86;
using System.Threading;

namespace Lyrics_matching
{
    //This is a simple program that plays songs and displays lyrics in the console. This projec isn't fully done yet, made on 25/01/2026, Today (27/01/2026) i decide tp leave this shit. I am done with typing and timing lyrics
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
                Console.WriteLine("3. True Love");
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
                        Thread.Sleep(1100); 

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
                        Thread.Sleep(1440);

                        Console.WriteLine("Don't nobody try to go on me");
                        Thread.Sleep(1333);

                        Console.WriteLine("They'll get more than cursed out");
                        Thread.Sleep(1311);

                        Console.WriteLine("Love having you around");
                        Thread.Sleep(1551);

                        Console.WriteLine("Love the way you hold me down");
                        Thread.Sleep(1661);

                        Console.WriteLine("In that kitty, I'ma drown");
                        Thread.Sleep(1400);

                        Console.WriteLine("It got that macaroni sound");
                        Thread.Sleep(1500);

                        Console.WriteLine("Have troble breathing");
                        Thread.Sleep(2580);

                        Console.WriteLine("It's because i need her");
                        Thread.Sleep(2800);

                        Console.WriteLine("For reasons beyond our comprehension");
                        Thread.Sleep(4000);

                        Console.WriteLine("I forgot to mention");
                        Thread.Sleep(1500);

                        Console.WriteLine("Your love is an addiction");
                        Thread.Sleep(2700);

                        Console.WriteLine("And I've been tryna get my fix on");
                        Thread.Sleep(2300);

                     









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

                    case "3": // I might said i am finished but i couldn't pass out a master piece like this, 30/01/26. (NOT FINISHED YET)
                        string path3 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Songs", "True Love.mp3");
                        audioPlayer.Play(path3);
                        Console.Clear();
                        
                       
                        Console.Write("True love ");
                        Thread.Sleep(2500);

                        Console.Write("Shouldn't be this complicated,");
                        Thread.Sleep(3500);

                        Console.WriteLine("I thought I'd die in your arms" );
                        Thread.Sleep(2900);

                        Console.WriteLine("I thought I′d die in your-");
                        Thread.Sleep(2500);

                        Console.Clear();

                        Console.Write("True love ");
                        Thread.Sleep(2500);

                        Console.Write("Shouldn't be this complicated,");
                        Thread.Sleep(3500);

                        Console.WriteLine("I thought I'd die in your arms");
                        Thread.Sleep(2900);

                        Console.WriteLine("I thought I′d die in your-");
                        Thread.Sleep(2200);

                        Console.Clear();
                        Console.Write("No hard feelings, but these feelings harder ");
                        Thread.Sleep(2300);

                        Console.Clear();
                        Console.Write("No-no hard feelings, but these feelings harder");
                        Thread.Sleep(2600);

                        Console.Clear();
                        Console.Write("No-no hard feelings, but these feelings harder X2 ");
                        Thread.Sleep(2600);

                        Console.Clear();
                        Console.Write("Wait, when you see the kids ? I′ll see y'all tomorrow ");
                        Thread.Sleep(3200);

                        Console.WriteLine("Wait, when the sun set? I see y′all tomorrow");
                        Thread.Sleep(2600);

                        Console.Write("Wait, when I pick 'em up, I feel like they borrowed ");
                        Thread.Sleep(3000);

                        Console.Clear();
                        Console.Write("When I gotta return them, scan ′em like a barcode ");
                        Thread.Sleep(2900);

                        Console.Write("Wait, no hard feelings, but these feelings hard though ");
                        Thread.Sleep(3000);

                        Console.Write("Wait, who got the kids in those 'What are those?' ");
                        Thread.Sleep(2900);

                        Console.Clear();

                        Console.Write("Wait, why they can't wear Yeezys with the cargos? ");
                        Thread.Sleep(2700);

                        Console.Write("Y′all know Nike don't like me, y'all take it too far, though");
                        Thread.Sleep(3000);

                        Console.Write("At least have ′em in some Mike′s, he played for Chicago");
                        Thread.Sleep(2800);

                        Console.Clear();

                        Console.WriteLine("I only see three kids, who watchin' Chicago?");
                        Thread.Sleep(2700);





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
    
