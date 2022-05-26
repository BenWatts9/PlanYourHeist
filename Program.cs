using System;
using System.Collections.Generic;

namespace PlanYourHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();
            List<TeamMember> memberList = new List<TeamMember>();
            bool memberCheck = true;
            
            while(memberCheck){

                Console.WriteLine("Please enter your team member's name");
                string memberName = Console.ReadLine();
                if (memberName != ""){

                Console.WriteLine("Please enter your team member's skill level");
                int memberSkillLevel = int.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your team member's courage factor (0.0 - 2.0");
                double memberCourageFactor = double.Parse(Console.ReadLine());

                TeamMember newGuy = new TeamMember(memberName, memberSkillLevel, memberCourageFactor);

                Console.WriteLine($"{newGuy.Name} has a skill level of {newGuy.SkillLevel} and a courage factor of {newGuy.CourageFactor}.");

                memberList.Add(newGuy);
                }
                else{
                    memberCheck = false;
                    Console.WriteLine($"There are {memberList.Count} members on the team.");
                }
            }
            foreach (TeamMember member in memberList)
            {
                Console.WriteLine($"{member.Name} has a skill level of {member.SkillLevel} and a courage factor of {member.CourageFactor}");
            }
        }
    }
}
