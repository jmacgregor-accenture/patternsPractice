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
        private static string stopTrigger = "77";

        static void Main(string[] args)
        {   
            DisplayWelcome();

            var secondsToRun = StartRun();
            
            var stopwatch = StartStopwatch();

            var lastTime = stopwatch.Elapsed;
            
            ExecuteLoop(stopwatch, secondsToRun, lastTime);

            ClosingMessage();
            ReadLine();

        }

        private static void DisplayWelcome()
        {
            WriteLine("*********************************************");
            WriteLine("*      Welcome to \"We Like Numbers!\"      *");
            WriteLine("*          Where John Updates YOU!          *");
            WriteLine("*          On HIS Favorite Number!          *");
            WriteLine("*********************************************");
        }

        private static void ExecuteLoop(Stopwatch stopwatch, int secondsToRun, TimeSpan lastTime)
        {
            while (stopwatch.Elapsed < TimeSpan.FromSeconds(secondsToRun))
            {
                lastTime = TriggerNewNumber(stopwatch, lastTime);

                var emailBlast = WriteTheEmail();

                if (emailBlast.Contains(stopTrigger))
                {
                    stopTrigger = UnsubscribeDecision(stopwatch, stopTrigger);
                }

                Thread.Sleep(500);
            }

            stopwatch.Stop();
        }

        private static Stopwatch StartStopwatch()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            return stopwatch;
        }

        private static string WriteTheEmail()
        {
            var emailBlast = fanBoy.WriteBlast();
            WriteLine(emailBlast);
            WriteLine();
            return emailBlast;
        }

        private static int StartRun()
        {
            var secondsToRun = 0;
            bool goodNumber = false;
            string userInput;
            WriteLine(
                "I have subscribed to a new service that shows me new numbers all the time. When I see one that's my favorite, I can let you know about it!");

            while (goodNumber == false)
            {
                Write("How Many Seconds Do You Want To Know My Favorite Number? ");
                userInput = ReadLine();
                goodNumber = int.TryParse(userInput, out secondsToRun);
            }

            WriteLine();
            return secondsToRun;
        }

        private static TimeSpan TriggerNewNumber(Stopwatch stopwatch, TimeSpan lastTime)
        {
            WriteLine($"It's Been {(stopwatch.Elapsed - lastTime).Milliseconds} Milliseconds Since I Last Got a Number!");
            lastTime = stopwatch.Elapsed;
            randoNumber.GenerateNumber();
            return lastTime;
        }

        private static string UnsubscribeDecision(Stopwatch stopwatch, string stopTrigger)
        {
            stopwatch.Stop();
            Write(
                "Do You Think I Should Stay With This Number? Then Type \"Unsubscribe\" to make me unsubscribe from the subject: ");
            var userInput = ReadLine();

            if (userInput == "Unsubscribe")
            {
                fanBoy.Unsubscribe(randoNumber);
                stopTrigger = "Keep Going";
                WriteLine("The things are decoupled now!");
            }

            stopwatch.Start();
            return stopTrigger;
        }

        private static NumberFan SetFanBoy()
        {
            var emailTemplate = new FanMail("HEY GUYS GUESS WHAT!", "DON'T FORGET TO SUBSCRIBE TO MY RSS FEED!");
            var fanBoy = new NumberFan(emailTemplate);
            fanBoy.SubscribeTo(randoNumber);
            return fanBoy;
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