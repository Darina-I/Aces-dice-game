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
    public partial class FormGame : Form
    {
        private PlayerMove playerMove;
        private Game game;
        private Player playerLeft;
        private Player playerRight;
        private List<int> analisysDices;
        List<PictureBox> picturebox = new List<PictureBox>();
        private Timer timer;
        FlowLayoutPanel flowLayoutPanel1;

        public FormGame(PlayerMove playerMove, Game game)
        {
            InitializeComponent();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.FlowDirection = FlowDirection.LeftToRight;
            flowLayoutPanel1.Height = 140; // Set the height to 200 pixels
            this.Controls.Add(flowLayoutPanel1);

            this.playerMove = playerMove;
            this.game = game;

            UpdateLeftRightPlayer();

            UpdateLabel();

            timer = new Timer();
            timer.Interval = 1500;
            timer.Tick += Timer_Tick;
        }

        //кнопка БРОСИТЬ КОСТИ
        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            timer.Start();
            for (var i = 0; i < playerMove.currentPlayer.NumberOfDices; i++)
            {
                var pb = new PictureBox();
                pb.Size = new Size(60, 60);
                pb.Image = Image.FromFile(@"../../dices/rollDice.gif");
                pb.SizeMode = PictureBoxSizeMode.StretchImage;
                flowLayoutPanel1.Controls.Add(pb);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            playerMove.RollTheDices();
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < playerMove.Dices.Count; i++)
            {
                string newImageUrl = $@"../../dices/{(int)playerMove.Dices[i]}.png";
                PictureBox pb = new PictureBox();
                pb.Size = new Size(50, 50);
                pb.Image = Image.FromFile(newImageUrl);
                pb.SizeMode = PictureBoxSizeMode.StretchImage;

                // Добавляем PictureBox в FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(pb);
            }
            timer.Stop();
            analisysDices = game.DoAnalysis(playerMove);
            listView1.Items.Clear();
            ListViewItem item = new ListViewItem(analisysDices[0].ToString());
            item.SubItems.Add(analisysDices[1].ToString());
            item.SubItems.Add(analisysDices[2].ToString());
            listView1.Items.Add(item);
            if (analisysDices.Sum() == 0)
                button3.Visible = true;
            else
                button1.Visible = true;
            button2.Visible = false;
        }

        //кнопка РАЗДАТЬ КОСТИ
        private void button1_Click(object sender, EventArgs e)
        {
            game.UpdateNumberOfDices(analisysDices, playerLeft, playerRight, playerMove.currentPlayer);
            if (game.AllDices == 0)
            {
                game.EndGame(playerMove.currentPlayer);
                var Form1 = new EndGame(game);
                this.Hide();
                Form1.Show();
            }
            else
            {
                playerMove.CanEndMove(analisysDices);
                UpdateLabel();

                if (playerMove.canRoll)
                {
                    playerMove = game.CreatePlayerMove(playerMove.currentPlayer);
                    button1.Visible = false;
                    button2.Visible = true;
                }
                else
                {
                    button1.Visible = false;
                    button3.Visible = true;
                }
            }               
        }

        //кнопка ПЕРЕДАТЬ ХОД
        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            label7.Visible = false;
            if(game.Players.IndexOf(playerMove.currentPlayer) == game.Players.Count - 1)
                playerMove = game.CreatePlayerMove(game.Players[0]);
            else
                playerMove = game.CreatePlayerMove(game.Players[game.Players.IndexOf(playerMove.currentPlayer) + 1]);

            UpdateLeftRightPlayer();
            UpdateLabel();
            if (playerMove.currentPlayer.NumberOfDices == 0)
                label7.Visible = true;
            else
            {
                button3.Visible = false;
                button2.Visible = true;
            }
        }

        private void UpdateLabel()
        {
            label5.Text = playerLeft.Name + ". Костей: " + playerLeft.NumberOfDices.ToString();
            label6.Text = playerRight.Name + ". Костей: " + playerRight.NumberOfDices.ToString();
            label8.Text = "Количество костей в игре: " + game.AllDices.ToString();
            label1.Text = playerMove.currentPlayer.Name + ", ваши кости: " + playerMove.currentPlayer.NumberOfDices.ToString();
        }

        private void UpdateLeftRightPlayer()
        {
            if (game.Players.IndexOf(playerMove.currentPlayer) == 0)
                this.playerLeft = game.Players[game.Players.Count - 1];
            else
                this.playerLeft = game.Players[game.Players.IndexOf(playerMove.currentPlayer) - 1];
            if (game.Players.IndexOf(playerMove.currentPlayer) == game.Players.Count - 1)
                this.playerRight = game.Players[0];
            else
                this.playerRight = game.Players[game.Players.IndexOf(playerMove.currentPlayer) + 1];
        }

        private void FormGame_Load(object sender, EventArgs e)
        {

        }
    }
}
