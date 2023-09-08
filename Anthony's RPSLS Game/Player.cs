using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public abstract class Player
    {
        //Member Variabes (HAS A)
        public string name;
        public List<string> gestures;
        public string chosenGesture;
        public int score;

        //Constructor
        public Player(string name)
        {
            this.name = name;
            gestures = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            chosenGesture = "";
            score = 0;
        }

        //Member Methods (CAN DO)
        //This abstract method must be overridden by the child Player classes
        public abstract void ChooseGesture();



    }
}
   
    // internal class HumanPlayer : Player
    //{
        
    //    public HumanPlayer(string name) :base(name)
    //    {
           
    //    }

       
    //    public override void ChooseGesture()
    //    {
    //        Console.WriteLine(gestures);
    //        Console.WriteLine("Choose one from the list above");
    //        chosenGesture = Console.ReadLine();
    //    }


    //}
    //    internal class ComputerPlayer : Player
    //{
    //    public ComputerPlayer(string name) : base(name)
    //    {
            
    //    }

    //    public override void ChooseGesture()
    //    {
    //         var random = new Random();
    //        random.Next(gestures.Count);
    //        Console.WriteLine(gestures);
    //        chosenGesture = Console.ReadLine();

            //var rand = new List<string> { "rock", "paper", "scissors", "lizard", "Spock" };
            //int index = random.Next(rand.Count);
           

            //Console.WriteLine(rand[index]); 
        
            
        
    





