namespace SuperTank
{
    partial class newRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newRoom));
            this.label4 = new System.Windows.Forms.Label();
            this.tb_ingameName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_findRoom = new System.Windows.Forms.Button();
            this.btn_joinRoom = new System.Windows.Forms.Button();
            this.btn_createRoom = new System.Windows.Forms.Button();
            this.roomID = new System.Windows.Forms.TextBox();
            this.cbb_listRoom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(85, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Nickname:";
            // 
            // tb_ingameName
            // 
            this.tb_ingameName.Font = new System.Drawing.Font("Cascadia Code", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ingameName.Location = new System.Drawing.Point(189, 179);
            this.tb_ingameName.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ingameName.Name = "tb_ingameName";
            this.tb_ingameName.Size = new System.Drawing.Size(225, 27);
            this.tb_ingameName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 19;
            // 
            // btn_findRoom
            // 
            this.btn_findRoom.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_findRoom.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_findRoom.ForeColor = System.Drawing.Color.White;
            this.btn_findRoom.Location = new System.Drawing.Point(323, 266);
            this.btn_findRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btn_findRoom.Name = "btn_findRoom";
            this.btn_findRoom.Size = new System.Drawing.Size(81, 38);
            this.btn_findRoom.TabIndex = 18;
            this.btn_findRoom.Text = "Find";
            this.btn_findRoom.UseVisualStyleBackColor = false;
            this.btn_findRoom.Click += new System.EventHandler(this.btn_findRoom_Click);
            // 
            // btn_joinRoom
            // 
            this.btn_joinRoom.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_joinRoom.Location = new System.Drawing.Point(278, 375);
            this.btn_joinRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btn_joinRoom.Name = "btn_joinRoom";
            this.btn_joinRoom.Size = new System.Drawing.Size(94, 52);
            this.btn_joinRoom.TabIndex = 17;
            this.btn_joinRoom.Text = "Join";
            this.btn_joinRoom.UseVisualStyleBackColor = true;
            this.btn_joinRoom.Click += new System.EventHandler(this.btn_joinRoom_Click);
            // 
            // btn_createRoom
            // 
            this.btn_createRoom.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Bold);
            this.btn_createRoom.Location = new System.Drawing.Point(146, 375);
            this.btn_createRoom.Margin = new System.Windows.Forms.Padding(2);
            this.btn_createRoom.Name = "btn_createRoom";
            this.btn_createRoom.Size = new System.Drawing.Size(94, 52);
            this.btn_createRoom.TabIndex = 16;
            this.btn_createRoom.Text = "Create";
            this.btn_createRoom.UseVisualStyleBackColor = true;
            this.btn_createRoom.Click += new System.EventHandler(this.btn_createRoom_Click);
            // 
            // roomID
            // 
            this.roomID.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12.75F);
            this.roomID.Location = new System.Drawing.Point(189, 312);
            this.roomID.Margin = new System.Windows.Forms.Padding(2);
            this.roomID.Name = "roomID";
            this.roomID.Size = new System.Drawing.Size(225, 27);
            this.roomID.TabIndex = 15;
            // 
            // cbb_listRoom
            // 
            this.cbb_listRoom.Font = new System.Drawing.Font("Cascadia Code", 12.75F);
            this.cbb_listRoom.FormattingEnabled = true;
            this.cbb_listRoom.Location = new System.Drawing.Point(189, 230);
            this.cbb_listRoom.Margin = new System.Windows.Forms.Padding(2);
            this.cbb_listRoom.Name = "cbb_listRoom";
            this.cbb_listRoom.Size = new System.Drawing.Size(225, 30);
            this.cbb_listRoom.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(85, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Room ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(85, 230);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 44);
            this.label1.TabIndex = 12;
            this.label1.Text = "Available \r\nroom:";
            // 
            // newRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SuperTank.Properties.Resources.newroom;
            this.ClientSize = new System.Drawing.Size(499, 504);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_ingameName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_findRoom);
            this.Controls.Add(this.btn_joinRoom);
            this.Controls.Add(this.btn_createRoom);
            this.Controls.Add(this.roomID);
            this.Controls.Add(this.cbb_listRoom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "newRoom";
            this.Text = "newRoom";
            this.Load += new System.EventHandler(this.newRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_ingameName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_findRoom;
        private System.Windows.Forms.Button btn_joinRoom;
        private System.Windows.Forms.Button btn_createRoom;
        private System.Windows.Forms.TextBox roomID;
        private System.Windows.Forms.ComboBox cbb_listRoom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}