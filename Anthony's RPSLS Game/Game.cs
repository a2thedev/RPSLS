using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace RPSLS
{
    internal class Game
    {
        //Member Variabes (HAS A)
        public Player playerOne;
        public Player playerTwo;

        //Constructor
        public Game()
        {
             
            
        }

        //Member Methods (CAN DO)
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to RPSLS! Here are the rules:\n");
            Console.WriteLine("Rock destroys Scissors\nScissors slashes Paper \nPaper wraps Rock\nRock smashes Lizard\nLizard poisons Spock\nSpock rips Scissors\nScissors chop Lizard\nLizard tears Paper\nPaper smacks Spock\nSpock throws Rock\n");

            Console.WriteLine("Max number of players is 2.\nFirst player to win 2 rounds wins the game!\n");
        }

        public  int ChooseNumberOfHumanPlayers()
        {
            //List<int> numberOfPlayers = new List<int>(2);

            Console.WriteLine("How many players will be playing this game?");
            string choosePlayers = Console.ReadLine();
            int numberOfPlayers = int.Parse(choosePlayers);

            

            return numberOfPlayers;

            
        }

        public void CreatePlayerObjects(int numberOfHumanPlayers)
            
        {
            if (numberOfHumanPlayers == 1)
            {
                Console.WriteLine("Please enter your name.");
                string playerOne = Console.ReadLine();
                HumanPlayer name = new HumanPlayer(playerOne);
                this.playerOne = name;

                string playerTwo = playerOne;
                ComputerPlayer computer = new ComputerPlayer(playerTwo);
                this.playerTwo = computer;
            }
            else if (numberOfHumanPlayers == 2)
            {
                Console.WriteLine("Player One please enter your name.");
                string playerOne = Console.ReadLine();
                HumanPlayer playerOneName = new HumanPlayer(playerOne);
                this.playerOne = playerOneName;

                Console.WriteLine("Player Two please enter your name");
                string playerTwo = Console.ReadLine();
                HumanPlayer playerTwoName = new HumanPlayer(playerTwo);
                this.playerTwo = playerTwoName;
            }
            else
            {
                Console.WriteLine("You can't have less than one player and more than two players! Sorry try again!");
            }






        }

        public void CompareGestures()
        {
            while (playerOne.score < 3 && playerTwo.score <3)
            {
                playerOne.ChooseGesture();
                playerTwo.ChooseGesture();



                if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Rock destroys scissors!");
                    playerOne.score++;
                }

                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Scissors slashes paper!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Paper wraps rock!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "rock" && playerTwo.chosenGesture == "Lizard")
                {
                    Console.WriteLine("Rock Smashes Lizard!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "Spock")
                {
                    Console.WriteLine("Lizard poisons spock!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Spock" && playerTwo.chosenGesture == "scissors")
                {
                    Console.WriteLine("Spock rips Scissors!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "scissors" && playerTwo.chosenGesture == "lizard")
                {
                    Console.WriteLine("Scissors chop Lizard!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "Lizard" && playerTwo.chosenGesture == "paper")
                {
                    Console.WriteLine("Lizard tears paper!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "paper" && playerTwo.chosenGesture == "spock")
                {
                    Console.WriteLine("Paper smacks Spock!");
                    playerOne.score++;
                }
                else if (playerOne.chosenGesture == "spock" && playerTwo.chosenGesture == "rock")
                {
                    Console.WriteLine("Spock throws rock!");
                    playerOne.score++;
                }
                else
                {
                    Console.WriteLine("Nice try! Try again!");
                    playerTwo.score++;
                }
            }
        }

        public void DisplayGameWinner()
        {
            

            if (playerOne.score >= 2)
            {
                Console.WriteLine($"{playerOne} is the winner!");
            }
            else if (playerTwo.score >= 2)
            {
                Console.WriteLine($"{playerTwo} is the winner!");
            }        
        
         }


        public void RunGame()
        {
            WelcomeMessage();

            int numberOfPlayers = ChooseNumberOfHumanPlayers();

            CreatePlayerObjects(numberOfPlayers);

            CompareGestures();

            DisplayGameWinner();
        }
    }
}
