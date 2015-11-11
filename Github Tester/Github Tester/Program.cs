using Models;
using System;

namespace Github_Tester
{
    class Program
    {
        public static void Main(string[] args)
        {
            Team team = GetTeam("Jays");

            for (int i = 0; i < 10000; i++)
            {
                Console.WriteLine("Go {0}!", team.Name);
            }
        }

        private static Team GetTeam(string name)
        {
            return new Team { Name = name };
        }
    }
}
