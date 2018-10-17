using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Speech.Synthesis;
using System.Threading;
using System.Threading.Tasks;

namespace ConCoolThings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

            //do
            //{
            //    Console.Beep();
            //}while (Console.ReadKey(true).Key != ConsoleKey.Enter);

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();

                Console.WriteLine("Hello and welcome to the future, my name is B40");
                synth.Speak("Hello and welcome to the future, my name is B40");

                Console.WriteLine("How may i help you?");
                synth.Speak("How may i help you?");

            }

            Console.WriteLine("Input text : ");
            string user = Console.ReadLine();

            using (SpeechSynthesizer synth = new SpeechSynthesizer())
            {
                synth.SetOutputToDefaultAudioDevice();

                Console.WriteLine("Your wish is my command");
                synth.Speak("your wish is my command");

                Console.WriteLine("Should i play your favorite song : ");
                synth.Speak("Should i play your favorite anthem?");
                Console.WriteLine("Y/N");
                user = Console.ReadLine();

                string y="y";
                string n="n";

                if(user=="y"||user=="Y")
                {
                    //Console.Beep(300, 500);
                    //Thread.Sleep(50);
                    //Console.Beep(300, 500);
                    //Thread.Sleep(50);
                    //Console.Beep(300, 500);
                    //Thread.Sleep(50);
                    //Console.Beep(250, 500);
                    //Thread.Sleep(50);
                    //Console.Beep(350, 250);
                    //Console.Beep(300, 500);
                    //Thread.Sleep(50);
                    //Console.Beep(250, 500);
                    //Thread.Sleep(50);
                    //Console.Beep(350, 250);
                    //Console.Beep(300, 500);
                    //Thread.Sleep(50);

                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(932, 150);
                    Thread.Sleep(150);
                    Console.Beep(1047, 150);
                    Thread.Sleep(150);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(699, 150);
                    Thread.Sleep(150);
                    Console.Beep(740, 150);
                    Thread.Sleep(150);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(932, 150);
                    Thread.Sleep(150);
                    Console.Beep(1047, 150);
                    Thread.Sleep(150);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(784, 150);
                    Thread.Sleep(300);
                    Console.Beep(699, 150);
                    Thread.Sleep(150);
                    Console.Beep(740, 150);
                    Thread.Sleep(150);
                    Console.Beep(932, 150);
                    Console.Beep(784, 150);
                    Console.Beep(587, 1200);
                    Thread.Sleep(75);
                    Console.Beep(932, 150);
                    Console.Beep(784, 150);
                    Console.Beep(554, 1200);
                    Thread.Sleep(75);
                    Console.Beep(932, 150);
                    Console.Beep(784, 150);
                    Console.Beep(523, 1200);
                    Thread.Sleep(150);
                    Console.Beep(466, 150);
                    Console.Beep(523, 1200);


                }
                else if(user=="n"||user=="N")
                {
                    Console.WriteLine("See you later");
                    synth.Speak("See you later");
                }

              
            }



                //Random rnd = new Random();
                //int i;
                //while (true)//Makes screen beep at random
                //{
                //    i = rnd.Next(1, 10);
                //    Console.Beep();
                //    System.Threading.Thread.Sleep(i);
                //}

                Console.ReadKey();
        }
    }
}
