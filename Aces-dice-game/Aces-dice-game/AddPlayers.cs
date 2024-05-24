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
    public partial class AddPlayers : Form
    {
        private Game game;
        private List<string> players = new List<string>();

        public AddPlayers(Game game)
        {
            this.game = game;   
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string playerName = textBox1.Text.Trim();
            if (!string.IsNullOrEmpty(playerName))
            {
                game.AddPlayer(playerName);
                players.Add(playerName);
                if (players.Count > 1)
                    button2.Visible = true;
                textBox1.Clear();
                UpdatePlayerListView();
            }
        }

        private void UpdatePlayerListView()
        {
            listView1.Items.Clear();

            for (int i = 0; i < players.Count; i++)
            {
                ListViewItem item = new ListViewItem(new string[] { (i + 1).ToString(), players[i], "5" });
                listView1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var Form1 = new OrderOfTheMove(game);
            this.Hide();
            Form1.Show();
        }
    }
}
