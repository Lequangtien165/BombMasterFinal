namespace SuperTank
{
    partial class Lobby
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lobby));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Total = new System.Windows.Forms.Label();
            this.lb_roomID = new System.Windows.Forms.Label();
            this.namePlayer1 = new System.Windows.Forms.Label();
            this.lbReady1 = new System.Windows.Forms.Label();
            this.namePlayer2 = new System.Windows.Forms.Label();
            this.namePlayer3 = new System.Windows.Forms.Label();
            this.namePlayer4 = new System.Windows.Forms.Label();
            this.lbReady4 = new System.Windows.Forms.Label();
            this.lbReady2 = new System.Windows.Forms.Label();
            this.lbReady3 = new System.Windows.Forms.Label();
            this.ptb_player1 = new System.Windows.Forms.PictureBox();
            this.ptb_player2 = new System.Windows.Forms.PictureBox();
            this.ptb_player3 = new System.Windows.Forms.PictureBox();
            this.ptb_player4 = new System.Windows.Forms.PictureBox();
            this.btn_Ready = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_chat = new System.Windows.Forms.Button();
            this.button_instruc = new System.Windows.Forms.Button();
            this.panel_instruc = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player4)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lobby";
            // 
            // lb_Total
            // 
            this.lb_Total.AutoSize = true;
            this.lb_Total.BackColor = System.Drawing.Color.Transparent;
            this.lb_Total.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_Total.Location = new System.Drawing.Point(480, 122);
            this.lb_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Total.Name = "lb_Total";
            this.lb_Total.Size = new System.Drawing.Size(78, 25);
            this.lb_Total.TabIndex = 1;
            this.lb_Total.Text = "Total:";
            // 
            // lb_roomID
            // 
            this.lb_roomID.AutoSize = true;
            this.lb_roomID.BackColor = System.Drawing.Color.Transparent;
            this.lb_roomID.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lb_roomID.Location = new System.Drawing.Point(133, 122);
            this.lb_roomID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_roomID.Name = "lb_roomID";
            this.lb_roomID.Size = new System.Drawing.Size(100, 25);
            this.lb_roomID.TabIndex = 2;
            this.lb_roomID.Text = "Room ID:";
            // 
            // namePlayer1
            // 
            this.namePlayer1.AutoSize = true;
            this.namePlayer1.BackColor = System.Drawing.Color.Transparent;
            this.namePlayer1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.namePlayer1.Location = new System.Drawing.Point(143, 267);
            this.namePlayer1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePlayer1.Name = "namePlayer1";
            this.namePlayer1.Size = new System.Drawing.Size(100, 25);
            this.namePlayer1.TabIndex = 4;
            this.namePlayer1.Text = "Player 1";
            // 
            // lbReady1
            // 
            this.lbReady1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbReady1.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbReady1.Location = new System.Drawing.Point(142, 306);
            this.lbReady1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReady1.Name = "lbReady1";
            this.lbReady1.Size = new System.Drawing.Size(99, 50);
            this.lbReady1.TabIndex = 8;
            this.lbReady1.Text = "Not ready";
            this.lbReady1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // namePlayer2
            // 
            this.namePlayer2.AutoSize = true;
            this.namePlayer2.BackColor = System.Drawing.Color.Transparent;
            this.namePlayer2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.namePlayer2.Location = new System.Drawing.Point(264, 267);
            this.namePlayer2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePlayer2.Name = "namePlayer2";
            this.namePlayer2.Size = new System.Drawing.Size(100, 25);
            this.namePlayer2.TabIndex = 10;
            this.namePlayer2.Text = "Player 2";
            // 
            // namePlayer3
            // 
            this.namePlayer3.AutoSize = true;
            this.namePlayer3.BackColor = System.Drawing.Color.Transparent;
            this.namePlayer3.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.namePlayer3.Location = new System.Drawing.Point(382, 267);
            this.namePlayer3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePlayer3.Name = "namePlayer3";
            this.namePlayer3.Size = new System.Drawing.Size(100, 25);
            this.namePlayer3.TabIndex = 11;
            this.namePlayer3.Text = "Player 3";
            // 
            // namePlayer4
            // 
            this.namePlayer4.AutoSize = true;
            this.namePlayer4.BackColor = System.Drawing.Color.Transparent;
            this.namePlayer4.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.namePlayer4.Location = new System.Drawing.Point(501, 267);
            this.namePlayer4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namePlayer4.Name = "namePlayer4";
            this.namePlayer4.Size = new System.Drawing.Size(100, 25);
            this.namePlayer4.TabIndex = 12;
            this.namePlayer4.Text = "Player 4";
            // 
            // lbReady4
            // 
            this.lbReady4.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbReady4.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbReady4.Location = new System.Drawing.Point(502, 306);
            this.lbReady4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReady4.Name = "lbReady4";
            this.lbReady4.Size = new System.Drawing.Size(99, 50);
            this.lbReady4.TabIndex = 13;
            this.lbReady4.Text = "Not ready";
            this.lbReady4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReady2
            // 
            this.lbReady2.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbReady2.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbReady2.Location = new System.Drawing.Point(267, 306);
            this.lbReady2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReady2.Name = "lbReady2";
            this.lbReady2.Size = new System.Drawing.Size(99, 50);
            this.lbReady2.TabIndex = 14;
            this.lbReady2.Text = "Not ready";
            this.lbReady2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbReady3
            // 
            this.lbReady3.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbReady3.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbReady3.Location = new System.Drawing.Point(383, 306);
            this.lbReady3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbReady3.Name = "lbReady3";
            this.lbReady3.Size = new System.Drawing.Size(99, 50);
            this.lbReady3.TabIndex = 15;
            this.lbReady3.Text = "Not ready";
            this.lbReady3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ptb_player1
            // 
            this.ptb_player1.Image = global::SuperTank.Properties.Resources.player;
            this.ptb_player1.Location = new System.Drawing.Point(138, 159);
            this.ptb_player1.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_player1.Name = "ptb_player1";
            this.ptb_player1.Size = new System.Drawing.Size(105, 104);
            this.ptb_player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_player1.TabIndex = 16;
            this.ptb_player1.TabStop = false;
            this.ptb_player1.Click += new System.EventHandler(this.ptb_player1_Click);
            // 
            // ptb_player2
            // 
            this.ptb_player2.Image = global::SuperTank.Properties.Resources.player1;
            this.ptb_player2.Location = new System.Drawing.Point(260, 159);
            this.ptb_player2.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_player2.Name = "ptb_player2";
            this.ptb_player2.Size = new System.Drawing.Size(105, 104);
            this.ptb_player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_player2.TabIndex = 17;
            this.ptb_player2.TabStop = false;
            // 
            // ptb_player3
            // 
            this.ptb_player3.Image = global::SuperTank.Properties.Resources.player;
            this.ptb_player3.Location = new System.Drawing.Point(377, 159);
            this.ptb_player3.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_player3.Name = "ptb_player3";
            this.ptb_player3.Size = new System.Drawing.Size(105, 104);
            this.ptb_player3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_player3.TabIndex = 18;
            this.ptb_player3.TabStop = false;
            // 
            // ptb_player4
            // 
            this.ptb_player4.Image = global::SuperTank.Properties.Resources.player;
            this.ptb_player4.Location = new System.Drawing.Point(495, 159);
            this.ptb_player4.Margin = new System.Windows.Forms.Padding(2);
            this.ptb_player4.Name = "ptb_player4";
            this.ptb_player4.Size = new System.Drawing.Size(105, 104);
            this.ptb_player4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptb_player4.TabIndex = 19;
            this.ptb_player4.TabStop = false;
            // 
            // btn_Ready
            // 
            this.btn_Ready.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ready.Location = new System.Drawing.Point(138, 391);
            this.btn_Ready.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(116, 50);
            this.btn_Ready.TabIndex = 20;
            this.btn_Ready.Text = "Ready";
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.ForeColor = System.Drawing.Color.White;
            this.btn_Start.Location = new System.Drawing.Point(314, 391);
            this.btn_Start.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(116, 50);
            this.btn_Start.TabIndex = 21;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Visible = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_chat
            // 
            this.btn_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chat.Location = new System.Drawing.Point(485, 391);
            this.btn_chat.Margin = new System.Windows.Forms.Padding(2);
            this.btn_chat.Name = "btn_chat";
            this.btn_chat.Size = new System.Drawing.Size(116, 50);
            this.btn_chat.TabIndex = 23;
            this.btn_chat.Text = "Chat";
            this.btn_chat.UseVisualStyleBackColor = true;
            this.btn_chat.Click += new System.EventHandler(this.btn_Chat_Click);
            // 
            // button_instruc
            // 
            this.button_instruc.BackColor = System.Drawing.Color.Navy;
            this.button_instruc.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_instruc.ForeColor = System.Drawing.Color.White;
            this.button_instruc.Location = new System.Drawing.Point(544, 77);
            this.button_instruc.Name = "button_instruc";
            this.button_instruc.Size = new System.Drawing.Size(110, 34);
            this.button_instruc.TabIndex = 24;
            this.button_instruc.Text = "Instruction";
            this.button_instruc.UseVisualStyleBackColor = false;
            this.button_instruc.Click += new System.EventHandler(this.button_instruc_Click);
            // 
            // panel_instruc
            // 
            this.panel_instruc.BackgroundImage = global::SuperTank.Properties.Resources.instruction_multi;
            this.panel_instruc.Location = new System.Drawing.Point(110, 159);
            this.panel_instruc.Name = "panel_instruc";
            this.panel_instruc.Size = new System.Drawing.Size(516, 215);
            this.panel_instruc.TabIndex = 25;
            this.panel_instruc.Visible = false;
            // 
            // Lobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperTank.Properties.Resources.looby;
            this.ClientSize = new System.Drawing.Size(748, 501);
            this.Controls.Add(this.panel_instruc);
            this.Controls.Add(this.button_instruc);
            this.Controls.Add(this.btn_chat);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.btn_Ready);
            this.Controls.Add(this.ptb_player4);
            this.Controls.Add(this.ptb_player3);
            this.Controls.Add(this.ptb_player2);
            this.Controls.Add(this.ptb_player1);
            this.Controls.Add(this.lbReady3);
            this.Controls.Add(this.lbReady2);
            this.Controls.Add(this.lbReady4);
            this.Controls.Add(this.namePlayer4);
            this.Controls.Add(this.namePlayer3);
            this.Controls.Add(this.namePlayer2);
            this.Controls.Add(this.lbReady1);
            this.Controls.Add(this.namePlayer1);
            this.Controls.Add(this.lb_roomID);
            this.Controls.Add(this.lb_Total);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Lobby";
            this.Text = "Lobby";
            this.Load += new System.EventHandler(this.Lobby_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptb_player4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Total;
        private System.Windows.Forms.Label lb_roomID;
        private System.Windows.Forms.Label namePlayer1;
        private System.Windows.Forms.Label lbReady1;
        private System.Windows.Forms.Label namePlayer2;
        private System.Windows.Forms.Label namePlayer3;
        private System.Windows.Forms.Label namePlayer4;
        private System.Windows.Forms.Label lbReady4;
        private System.Windows.Forms.Label lbReady2;
        private System.Windows.Forms.Label lbReady3;
        private System.Windows.Forms.PictureBox ptb_player1;
        private System.Windows.Forms.PictureBox ptb_player2;
        private System.Windows.Forms.PictureBox ptb_player3;
        private System.Windows.Forms.PictureBox ptb_player4;
        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_chat;
        private System.Windows.Forms.Button button_instruc;
        private System.Windows.Forms.Panel panel_instruc;
    }
}