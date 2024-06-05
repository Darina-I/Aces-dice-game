using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aces_dice_game
{
    public partial class OrderOfTheMove : Form
    {
        private Game game;
        private Timer timer;
        private Random random = new Random();
        Dice randomDice;
        private int currentPlayerIndex = 0;
        private List<(Player, Dice)> playingOrder = new List<(Player, Dice)>();

        public OrderOfTheMove(Game game)
        {
            this.game = game;
            InitializeComponent();
            label1.Text = "Бросает кость " + game.Players[0].Name;
            timer = new Timer();
            timer.Interval = 1500;
            timer.Tick += Timer_Tick;
        }
        //Кнопка БРОСИТЬ КУБИКИ
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"../../dices/rollDice.gif");
            button_roll.Visible = false;
            timer.Start();
            if (currentPlayerIndex != game.Players.Count - 1)
                button_next.Visible = true;
            else
            {
                button_order.Visible = true;
                button_start.Visible = true;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            randomDice = (Dice)random.Next(1, 7);
            playingOrder.Add((game.Players[currentPlayerIndex], randomDice));
            string imageUrl = $@"../../dices/{(int)randomDice}.png";
            pictureBox1.Image = Image.FromFile(imageUrl);
            timer.Stop();
        }
        //Кнопка СЛЕДУЮЩИЙ ИГРОК
        private void button2_Click(object sender, EventArgs e)
        {
            if (currentPlayerIndex != game.Players.Count - 1)
            {
                currentPlayerIndex = (currentPlayerIndex + 1);
                label1.Text = "Бросает кость " + game.Players[currentPlayerIndex].Name;
                button_roll.Visible = true;
                button_next.Visible = false;
            }
            else
            {
                button_roll.Visible = false;               
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.OrderOfTheMove(playingOrder);

            foreach (var player in game.Players)
            {
                ListViewItem item = new ListViewItem(new string[] {
                    (game.Players.IndexOf(player) + 1).ToString(),
                    player.Name });
                listView_players.Items.Add(item);
            }

            listView_players.Visible = true;

        }
        //кнопка НАЧАТЬ ИГРУ
        private void button4_Click(object sender, EventArgs e)
        {
            PlayerMove playerMove = game.StartGame();
            var Form1 = new FormGame(playerMove,game);
            this.Hide();
            Form1.Show();
        }
    }
}
