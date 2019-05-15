using System;
using System.Diagnostics;
using System.Threading;
using ObserverAtPlay.Library;
using static System.Console;

namespace ObserverAtPlay.WeLikeNumbers
{
    class Program
    {
        private static RandomIntsForDays randoNumber = new RandomIntsForDays();
        private static NumberFan fanBoy = SetFanBoy();

        private static NumberFan SetFanBoy()
        {
            var emailTemplate = new FanMail("HEY GUYS GUESS WHAT!", "DON'T FORGET TO SUBSCRIBE TO MY RSS FEED!");
            var fanBoy = new NumberFan(emailTemplate);
            fanBoy.SubscribeTo(randoNumber);
            return fanBoy;
        }

        static void Main(string[] args)
        {   
            WriteLine("*********************************************");
            WriteLine("*      Welcome to \"We Like Numbers!\"      *");
            WriteLine("*          Where John Updates YOU!          *");
            WriteLine("*          On HIS Favorite Number!          *");
            WriteLine("*********************************************");

            var userInput = string.Empty;
            var goodNumber = false;
            var secondsToRun = 0;
            var stopTrigger = "77";

            WriteLine("I have subscribed to a new service that shows me new numbers all the time. When I see one that's my favorite, I can let you know about it!");
            
            while (goodNumber == false)
            {
                Write("How Many Seconds Do You Want To Know My Favorite Number? ");
                userInput = ReadLine();
                goodNumber = int.TryParse(userInput, out secondsToRun);
            }

            WriteLine();
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            var lastTime = stopwatch.Elapsed;
            
            while (stopwatch.Elapsed < TimeSpan.FromSeconds(secondsToRun))
            {
                WriteLine($"It's Been {(stopwatch.Elapsed - lastTime).Milliseconds} Milliseconds Since I Last Got a Number!");
                lastTime = stopwatch.Elapsed;
                randoNumber.GenerateNumber();
                var emailBlast = fanBoy.WriteBlast();
                WriteLine(emailBlast);
                WriteLine();
                Thread.Sleep(500);

                if (emailBlast.Contains(stopTrigger))
                {
                    stopwatch.Stop();
                    Write("Do You Think I Should Stay With This Number? Then Type \"Unsubscribe\" to make me unsubscribe from the subject: ");
                    userInput = ReadLine();

                    if (userInput == "Unsubscribe")
                    {
                        fanBoy.Unsubscribe(randoNumber);
                        stopTrigger = "Keep Going";
                        WriteLine("The things are decoupled now!");
                    }
                    stopwatch.Start();
                }
            }
            stopwatch.Stop();

            ClosingMessage();
            ReadLine();

        }

        private static void ClosingMessage()
        {
            Clear();
            WriteLine();
            WriteLine("What a trip, eh?");
            WriteLine();

            WriteLine("*********************************************");
            WriteLine("*        Bye From \"We Like Numbers!\"       *");
            WriteLine("*          Where John Updated YOU!          *");
            WriteLine("*          On HIS Favorite Number!          *");
            WriteLine("*********************************************");
        }
    }
}