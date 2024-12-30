namespace ServerSocket
{
    partial class Server
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Server));
            ShowingInfo = new RichTextBox();
            label1 = new Label();
            button_close = new Button();
            button_start = new Button();
            SuspendLayout();
            // 
            // ShowingInfo
            // 
            ShowingInfo.Location = new Point(1, 37);
            ShowingInfo.Margin = new Padding(1);
            ShowingInfo.Name = "ShowingInfo";
            ShowingInfo.Size = new Size(558, 407);
            ShowingInfo.TabIndex = 0;
            ShowingInfo.Text = "";
            ShowingInfo.TextChanged += richTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans Ultra Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 6);
            label1.Name = "label1";
            label1.Size = new Size(101, 30);
            label1.TabIndex = 1;
            label1.Text = "Server";
            // 
            // button_close
            // 
            button_close.Location = new Point(467, 6);
            button_close.Name = "button_close";
            button_close.Size = new Size(81, 27);
            button_close.TabIndex = 2;
            button_close.Text = "CLOSE";
            button_close.UseVisualStyleBackColor = true;
            button_close.Click += button_close_Click;
            // 
            // button_start
            // 
            button_start.Location = new Point(380, 6);
            button_start.Name = "button_start";
            button_start.Size = new Size(81, 27);
            button_start.TabIndex = 3;
            button_start.Text = "START";
            button_start.UseVisualStyleBackColor = true;
            button_start.Click += button_start_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 443);
            Controls.Add(button_start);
            Controls.Add(button_close);
            Controls.Add(label1);
            Controls.Add(ShowingInfo);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Server";
            Text = "Server";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox ShowingInfo;
        private Label label1;
        private Button button_close;
        private Button button_start;
    }
}
