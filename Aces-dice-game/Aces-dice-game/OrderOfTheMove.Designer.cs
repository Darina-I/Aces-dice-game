
namespace Aces_dice_game
{
    partial class OrderOfTheMove
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_roll = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.button_order = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.listView_players = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(327, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(292, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Бросает кубики *имя*";
            // 
            // button_roll
            // 
            this.button_roll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_roll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_roll.Location = new System.Drawing.Point(597, 117);
            this.button_roll.Name = "button_roll";
            this.button_roll.Size = new System.Drawing.Size(163, 46);
            this.button_roll.TabIndex = 2;
            this.button_roll.Text = "Бросить кость";
            this.button_roll.UseVisualStyleBackColor = false;
            this.button_roll.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_next.Location = new System.Drawing.Point(597, 178);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(163, 46);
            this.button_next.TabIndex = 3;
            this.button_next.Text = "Следующий игрок";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Visible = false;
            this.button_next.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_order
            // 
            this.button_order.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_order.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_order.Location = new System.Drawing.Point(597, 240);
            this.button_order.Name = "button_order";
            this.button_order.Size = new System.Drawing.Size(163, 43);
            this.button_order.TabIndex = 4;
            this.button_order.Text = "Порядок хода";
            this.button_order.UseVisualStyleBackColor = false;
            this.button_order.Visible = false;
            this.button_order.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_start
            // 
            this.button_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_start.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_start.Location = new System.Drawing.Point(239, 365);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(350, 62);
            this.button_start.TabIndex = 5;
            this.button_start.Text = "НАЧАТЬ ИГРУ";
            this.button_start.UseVisualStyleBackColor = false;
            this.button_start.Visible = false;
            this.button_start.Click += new System.EventHandler(this.button4_Click);
            // 
            // listView_players
            // 
            this.listView_players.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView_players.HideSelection = false;
            this.listView_players.Location = new System.Drawing.Point(13, 89);
            this.listView_players.Name = "listView_players";
            this.listView_players.Size = new System.Drawing.Size(257, 245);
            this.listView_players.TabIndex = 6;
            this.listView_players.UseCompatibleStateImageBehavior = false;
            this.listView_players.View = System.Windows.Forms.View.Details;
            this.listView_players.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Номер";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Игрок";
            // 
            // OrderOfTheMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView_players);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_order);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_roll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OrderOfTheMove";
            this.Text = "OrderOfTheMove";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_roll;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Button button_order;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.ListView listView_players;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}