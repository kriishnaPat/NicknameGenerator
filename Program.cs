using System;
using System.Collections.Generic;  

namespace NicknameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompting user to input their first and last name
            Console.WriteLine("what is your first name?");
            string first_name = Console.ReadLine();            
            Console.WriteLine("what is your last name?");
            string last_name = Console.ReadLine();
            var nicknames = new List<string>() {"Dog", "Smart", "Alien", "Beard", "Cat", "Wrestler", "Cow", "Dragon", "Magic", "Blah", "Yummy", "Amazing", "Monster", "Dummy", "Grape", "Wow"};
            //Giving the user results based on their choice
            while (true){
                
            
            //Picking a random number that can be used as the index number for the random nickname option
                Random rnd = new Random();
                int num = rnd.Next(0, nicknames.Count);
            
            //prompting user to pick from the menu options
                Console.WriteLine(@"
    1.Change Name
    2.Display a Random Nickname
    3.Display All Nicknames
    4.Add a Nickname
    5.Remove a Nickname
    6.Exit
.");
                //Converting the user input to integer 
                int user_choice = Convert.ToInt32(Console.ReadLine());

                //Providing results based on user input
                if (user_choice == 1)
                {
                    Console.WriteLine("what is your first name?");
                    first_name = Console.ReadLine();            
                    Console.WriteLine("what is your last name?");
                    last_name = Console.ReadLine();
                } 
                else if (user_choice == 2)
                {
                    Console.Write(first_name +" "+ nicknames[num] + " " + last_name);
                }
                else if (user_choice == 3) 
                {
                    for (int i = 0; i < nicknames.Count; i++ ){
                        Console.WriteLine(first_name +" "+ nicknames[i] + " " + last_name);
                    }
                }
                else if (user_choice == 4)
                {
                    Console.Write("Enter the nickname you would like to add: ");
                    string added_name = Console.ReadLine();
                    nicknames.Add(added_name);
                }
                else if (user_choice == 5)
                {
                    Console.Write("What nickname would you like to remove? ");
                    string remove = Console.ReadLine();
                        if (nicknames.Contains(remove)){
                            int index = nicknames.IndexOf(remove);
                            Console.Write(index);
                            nicknames.RemoveAt(index);
                        }else{
                            Console.Write("This is not a nickname in our system:(");
                        }
                }
                else if (user_choice == 6)
                {
                    break;
                }
                else 
                {
                    Console.Write("Invalid choice");
                }

            }


        }
    }
}
