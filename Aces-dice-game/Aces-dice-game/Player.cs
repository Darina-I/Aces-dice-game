using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aces_dice_game
{
    public class Player
    {
        public string Name;
        public int NumberOfDices;
        public int Order;

        public Player(string name)
        {
            Name = name;
            NumberOfDices = 5;
            Order = 0;
        }

        public void PlusDices(int number)
        {
            NumberOfDices += number;
        }

        public void MinusDices(int number)
        {
            NumberOfDices -= number;
        }
    }
}
