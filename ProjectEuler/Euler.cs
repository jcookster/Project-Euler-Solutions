using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Interfaces;
using ProjectEuler.Problems;
using System.Reflection;

namespace ProjectEuler
{

    /// <summary>
    /// This is the starting point for our problem execution class. There is no need to manually add classes in.
    /// All items in the problem namespace are items we potentially want to execute. There is no need to manually 
    /// maintain a list of these items. This is a variation of the GOF Command Pattern. http://en.wikipedia.org/wiki/Command_pattern
    /// 
    /// For this version we have the 
    ///   ----------------------------          ---------------------------------------------------
    ///   | Reciever - contains code |         | Invoker - The Euler Class,                       |
    ///   |     to solve the problem |  ------ |    uses reflection to determine what to execute  |
    ///   ----------------------------          ---------------------------------------------------
    ///   
    /// I didn't want the added complexity of having concreteCommands. It doesn't add flexibility / extensibiltiy for
    /// this specific problem domain. 
    /// </summary>
    class Euler
    {
        // Where we're going to look for the problems.
        // Put this in a config file for greater flexibility.
        private const string PROBLEM_NAMESPACE = "ProjectEuler.Problems";

        // Use reflection to find all classes in the problem namespace.
        private static List<IProblem> GenerateListOfProblems()
        {
            List<IProblem> problems = new List<IProblem>();
           
            // Let linq help me find all of the classes in our namespace.
            var q = from t in Assembly.GetExecutingAssembly().GetTypes()
                    where t.IsClass && t.Namespace == PROBLEM_NAMESPACE
                    select t;

            // Add all of the problems in.
            q.ToList().ForEach(t => problems.Add(Activator.CreateInstance(t) as IProblem));
           
            return problems;
        }

        // Run all the problems.
        public static void Run() 
        {
            List<IProblem> problems = GenerateListOfProblems();

            foreach (IProblem problem in problems) 
            {
                // We may be passed null problems. This is caused by having items in the namespace that don't conform to the 
                // IProblem interface.
                if (problem != null)
                {
                    PrintAnswers(problem.ProblemNumber(), problem.Answer());
                }
            }
        }

        // Print the answers we get.
        private static void PrintAnswers(int problemNumber, decimal answer) 
        {
            Console.WriteLine("Problem # {0} Answer: {1}", problemNumber, answer);
        }
    }
}
