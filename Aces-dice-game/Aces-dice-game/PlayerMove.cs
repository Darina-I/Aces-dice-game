using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aces_dice_game
{
    public class PlayerMove
    {
        public List<Dice> Dices;
        public bool canRoll;
        public Player currentPlayer;

        public PlayerMove(Player player)
        {
            Dices = new List<Dice>();
            currentPlayer = player;
        }

        public void RollTheDices()
        {
            Random random = new Random();
            int numberOfDices = currentPlayer.NumberOfDices;
            for (var i = 0; i < numberOfDices; i++)
            {
                Dices.Add((Dice)random.Next(1, 7));
            }
        }

        public List<int> AnalisysDices()
        {
            List<int> analisysDices = new List<int>();
            analisysDices.Add(Dices.Count(d => d == Dice.One));
            analisysDices.Add(Dices.Count(d => d == Dice.Two));
            analisysDices.Add(Dices.Count(d => d == Dice.Five));
            return analisysDices;
        }

        public void CanEndMove(List<int> analisysDices)
        {
            if (currentPlayer.NumberOfDices == 0)
                canRoll = false;
            else
                canRoll = !analisysDices.All(count => count == 0);
        }

    }
}
