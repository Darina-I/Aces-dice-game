﻿
namespace Aces_dice_game
{
    partial class FormGame
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView_dices = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_give = new System.Windows.Forms.Button();
            this.button_roll = new System.Windows.Forms.Button();
            this.button_next = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(262, 326);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ваши кости: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(21, 126);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игрок слева";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(611, 116);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label3.Size = new System.Drawing.Size(110, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Игрок справа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(88, 9);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label4.Size = new System.Drawing.Size(576, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "1 - сбрасываем, 2 - отдаем игроку слева, 5 - отдаем игроку справа";
            // 
            // listView_dices
            // 
            this.listView_dices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView_dices.HideSelection = false;
            this.listView_dices.Location = new System.Drawing.Point(234, 126);
            this.listView_dices.Name = "listView_dices";
            this.listView_dices.Size = new System.Drawing.Size(294, 102);
            this.listView_dices.TabIndex = 4;
            this.listView_dices.UseCompatibleStateImageBehavior = false;
            this.listView_dices.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "\"единицы\"";
            this.columnHeader1.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "\"двойки\"";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "\"пятерки\"";
            this.columnHeader3.Width = 70;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(21, 173);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label5.Size = new System.Drawing.Size(160, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "имя *кол-во костей*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(611, 162);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label6.Size = new System.Drawing.Size(160, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "имя *кол-во костей*";
            // 
            // button_give
            // 
            this.button_give.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_give.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_give.Location = new System.Drawing.Point(293, 271);
            this.button_give.Name = "button_give";
            this.button_give.Size = new System.Drawing.Size(175, 37);
            this.button_give.TabIndex = 7;
            this.button_give.Text = "Раздать кости";
            this.button_give.UseVisualStyleBackColor = false;
            this.button_give.Visible = false;
            this.button_give.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_roll
            // 
            this.button_roll.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_roll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_roll.Location = new System.Drawing.Point(293, 271);
            this.button_roll.Name = "button_roll";
            this.button_roll.Size = new System.Drawing.Size(175, 38);
            this.button_roll.TabIndex = 8;
            this.button_roll.Text = "Бросить кости";
            this.button_roll.UseVisualStyleBackColor = false;
            this.button_roll.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_next
            // 
            this.button_next.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_next.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_next.Location = new System.Drawing.Point(596, 227);
            this.button_next.Name = "button_next";
            this.button_next.Size = new System.Drawing.Size(175, 38);
            this.button_next.TabIndex = 9;
            this.button_next.Text = "Передать ход";
            this.button_next.UseVisualStyleBackColor = false;
            this.button_next.Visible = false;
            this.button_next.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(253, 78);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label8.Size = new System.Drawing.Size(235, 30);
            this.label8.TabIndex = 11;
            this.label8.Text = "Количество костей на столе: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 396);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.label7.Size = new System.Drawing.Size(437, 30);
            this.label7.TabIndex = 12;
            this.label7.Text = "В связи с тем, что у вас нет костей, вы пропускаете ход!";
            this.label7.Visible = false;
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 580);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button_next);
            this.Controls.Add(this.button_roll);
            this.Controls.Add(this.button_give);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView_dices);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGame";
            this.Text = "Игра";
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView_dices;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_give;
        private System.Windows.Forms.Button button_roll;
        private System.Windows.Forms.Button button_next;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}