using System;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();
            Console.WriteLine("Please enter your team member's name:");
            string memberName = Console.ReadLine();
            Console.WriteLine("Please enter your team member's skill level:");
            int memberSkillLevel = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your team member's courage factor:");
            double memberCourageFactor = double.Parse(Console.ReadLine());

            TeamMember newGuy = new TeamMember(memberName, memberSkillLevel, memberCourageFactor);

            Console.WriteLine($"{newGuy.Name} has a skill level of {newGuy.SkillLevel} and a courage factor of {newGuy.CourageFactor}.");
        }
    }
}
