using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aces_dice_game
{
    public class Game
    {
        public List<Player> Players;
        public int AllDices;
        public Player Winner;

        public Game()
        {
            Players = new List<Player>();
            AllDices = 0;
            Winner = null;
        }

        public void AddPlayer(string name)
        {
            Player player = new Player(name);
            AllDices += 5;
            Players.Add(player);
        }

        public List<Player> OrderOfTheMove(List<(Player, Dice)> playingOrder)
        {
            List<Player> orderList = playingOrder.OrderByDescending(pair => pair.Item2)
                                  .Select(pair => pair.Item1)
                                  .ToList();
            Players = orderList;
            return orderList;
        }

        public PlayerMove StartGame()
        {
            PlayerMove playerMove = new PlayerMove(Players[0]);
            return playerMove;
        }

        public PlayerMove CreatePlayerMove(Player player)
        {
            PlayerMove nextPlayerMove = new PlayerMove(player);
            return nextPlayerMove;
        }

        public List<int> DoAnalysis(PlayerMove playerMove)
        {
            List<int> analysisDices = playerMove.AnalisysDices();
            return analysisDices;
        }

        public void UpdateNumberOfDices(List<int> analysisDices, Player playerLeft, Player playerRight, Player currentPlayer)
        {
            AllDices -= analysisDices[0];
            currentPlayer.MinusDices(analysisDices.Sum());
            playerLeft.PlusDices(analysisDices[1]);
            playerRight.PlusDices(analysisDices[2]);
        }

        public void EndGame(Player winner)
        {
            this.Winner = winner;
        }
    }
}
