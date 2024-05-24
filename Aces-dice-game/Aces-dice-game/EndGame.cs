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
    public partial class EndGame : Form
    {
        private Game game;
        private string imageUrl = $@"../../dices/win.gif";
        

        public EndGame(Game game)
        {
            InitializeComponent();
            this.game = game;
            pictureBox1.Image = Image.FromFile(imageUrl);
        }

        private void EndGame_Load(object sender, EventArgs e)
        {
            label1.Text = "Победитель: " + game.Winner.Name;
        }
    }
}
