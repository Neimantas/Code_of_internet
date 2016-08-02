using System;
using System.Collections.Generic;
using System.Threading;

namespace Requirement_2_0
{
    public class Requirement
    {
        public string Term;
    }

    /// <summary>
    /// Here is a better place for comments.
    /// Also, you can add more.
    /// Also, it hides.
    /// Did you knew it that it makes up an info for class/method?
    /// </summary>
    public class DotNetBackendDevelopersWanted 
    {
        private static readonly List<Requirement> MainRequirements = FillMainRequirements();
        private static int _counter;

        private static void Main()
        {
            Console.WriteLine(CheckIfDevMeetsReqs()
                ? "You are what we are looking for, please write us john.doe@programmer.com"
                : "We need more experienced person, but good luck next time!");

            Thread.Sleep(4000);
        }

        /// <summary>
        /// This method contains all of the requirements for the .Net position.
        /// </summary>
        private static List<Requirement> FillMainRequirements()
        {
            return new List<Requirement>
        {
            new Requirement() {Term = "Sql Server"},
            new Requirement() {Term = "Net, C#"},
            new Requirement() {Term = "ORM, Entity, Linq"},
            new Requirement() {Term = "Code conversion"},
            new Requirement() {Term = "Winforms"},
            new Requirement() {Term = "Web frameworks such as MVC, Asp.net Html, CSS, javascript"}
        };
        }

        /// <summary>
        /// We check if candidate has mininum skills needed.
        /// </summary>
        public static bool CheckIfDevMeetsReqs()
        {
            Console.WriteLine("Please tell us if you are experienced with:");
            foreach (var req in MainRequirements)
            {
                Console.WriteLine(req.Term);
                Console.WriteLine("YES/NO");
                CheckTyposAndIncrementCounter();
            }

            if (_counter >= 4)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// This methods checks for typos. Also some people think that recursion is some kind of magic. It is not.
        /// </summary>
        private static void CheckTyposAndIncrementCounter()
        {
            var readLine = Console.ReadLine();

                var answerCheck = (readLine.ToUpper() == "YES" || readLine.ToUpper() == "NO") ? "Good" : "Bad";
                if (answerCheck == "Bad")
                {
                    Console.WriteLine("You made a typo, try again");
                    CheckTyposAndIncrementCounter();
                }

                var answer = readLine.ToUpper();

                if (answer == "YES")
                {
                    _counter += 1;
                }

        }
    }
}