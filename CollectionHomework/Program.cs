using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Topic topic = new Topic();
            Console.WriteLine(topic.topic("Today`s voting topic is" + " "));
            
            Voting voting = new Voting();
            voting.voting();
        }
    }

    class Topic
    {
        public string? topic(string message)
        {
            Console.WriteLine("Please, write vote topic");
            string voteTopic = Console.ReadLine();
            return message + voteTopic;
        }
    }

    class Voting
    {
        public void voting()
        {
            Console.WriteLine("\nPlease, make a choise, write Yes or No");
            List<string> votingList = new List<string> { };//actually, the votinglist is not necessary for the program work
            votingList.Add(Console.ReadLine());
            if (votingList.Contains("Yes"))
            {
                Console.WriteLine("Voting is ended. The decision is made.");
            }
            else
            {
                Console.WriteLine("Voting is ended. The decision is not made.");
            }
        }
    }
}

//checked
