using System;
using System.Runtime.CompilerServices;

namespace RockPaperScissors
{
    class Program
    {
        private static string choice1;
        private static string choice2;
        private static int counter;
        private static bool StarterLoop = false;
        

        static void Main(string[] args)
        {

            string player1;
            string player2;

            Console.WriteLine("Welcome To Rock Papers Scissors");
            Console.WriteLine("Enter Player Ones Name");
            player1 = Console.ReadLine();

            Console.WriteLine("Enter Player Twos Name");
            player2 = Console.ReadLine();
            Play_Game(player1,player2);

        }


        private static void Play_Game(string player1, string player2)
        {
            Console.WriteLine("Press 1 For Rock \nPress 2 For Paper  \nPress 3 for Scissors ");
            counter = 1;             
            do
            {
                game_Player(player1, player2);              
            } 
            while (counter == 1);


        }


        private static void game_Player(string player1, string player2)
        {
                do
                {
                    
                    Player1_Option(player1);
                    if (choice1 != "1" && choice1 != "2" && choice1 != "3")
                    {
                        Console.WriteLine("Please enter valid number");
                        StarterLoop = false;
                    }
                    else
                {
                    StarterLoop = true;
                    game_Player2(player1, player2);
                }
                    
                }
                while (StarterLoop == false);          
        }

        private static void game_Player2(string player1, string player2)
        {
            do
            {
                Player2_Option(player2);
                if (choice2 != "1" && choice2 != "2" && choice2 != "3")
                {
                    Console.WriteLine("Please enter valid number");
                    
                }
                else
                {
                    WinningLogic(choice1, choice2, player1, player2);
                    StarterLoop = false;
                }
            } while (StarterLoop == true);
        }

    

        private static void Player1_Option(string player1)
        {
            Console.Clear();
            Console.WriteLine("Press 1 For Rock \nPress 2 For Paper  \nPress 3 for Scissors ");
            Console.WriteLine("{0} Enter your Choice", player1);
            choice1 = Console.ReadLine();          
        }
        private static void Player2_Option(string player2)
        {
            Console.Clear();
            Console.WriteLine("Press 1 For Rock \nPress 2 For Paper  \nPress 3 for Scissors ");
            Console.WriteLine("{0} Enter your Choice",player2);
            choice2 = Console.ReadLine();
        }


        private static void WinningLogic(string option1, string option2, string player1, string player2)
        {                  
            string draw = "draw";
            GameEnd_Cal(option1, option2, player2, "1", "2");
            GameEnd_Cal(option1, option2, draw, "1", "1");
            GameEnd_Cal(option1, option2, player1, "1", "3");

            GameEnd_Cal(option1, option2, player1, "2", "1");
            GameEnd_Cal(option1, option2, draw, "2", "2");
            GameEnd_Cal(option1, option2, player2, "2", "3");

            GameEnd_Cal(option1, option2, player1, "3", "1");
            GameEnd_Cal(option1, option2, draw, "3", "3");
            GameEnd_Cal(option1, option2, player2, "3", "2");
        }



        private static void GameEnd_Cal (string option1, string option2, string player, string score1, string score2 )
        {
            if (option1 == score1 && option2 == score2)
            {
                Console.Clear();
                Console.WriteLine("{0} wins the Game", player);
                Console.WriteLine("Press 1 To Exit Press 2 to Start Again");
                string answer1 = Console.ReadLine();
                if (answer1 == "1")
                {
                    Environment.Exit(0);
                }
                else
                {
                    counter = 1;
                }            
            }
        }
    }
}
