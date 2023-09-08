using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class HumanPlayer : Player
    {

        public HumanPlayer(string name) : base(name)
        {

        }


        public override void ChooseGesture()
        {
            foreach (string item in gestures)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("Choose one from the list above");
            chosenGesture = Console.ReadLine();
        }

    }
}