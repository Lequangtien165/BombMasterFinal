
namespace SuperTank.WindowsForms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.pnTitle = new System.Windows.Forms.Panel();
            this.picMinus = new System.Windows.Forms.PictureBox();
            this.picMultiply = new System.Windows.Forms.PictureBox();
            this.pnInstructions = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanelInstructions = new System.Windows.Forms.FlowLayoutPanel();
            this.picInstructions = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.pnAboutUs = new System.Windows.Forms.Panel();
            this.btnAboutUsMenu = new System.Windows.Forms.Button();
            this.pnLevel = new System.Windows.Forms.Panel();
            this.btnLevelMenu = new System.Windows.Forms.Button();
            this.btnLevel8 = new System.Windows.Forms.Button();
            this.btnLevel7 = new System.Windows.Forms.Button();
            this.btnLevel6 = new System.Windows.Forms.Button();
            this.btnLevel5 = new System.Windows.Forms.Button();
            this.btnLevel4 = new System.Windows.Forms.Button();
            this.btnLevel3 = new System.Windows.Forms.Button();
            this.btnLevel10 = new System.Windows.Forms.Button();
            this.btnLevel9 = new System.Windows.Forms.Button();
            this.btnLevel2 = new System.Windows.Forms.Button();
            this.btnLevel1 = new System.Windows.Forms.Button();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btn_PlayerMulti = new System.Windows.Forms.Button();
            this.btnInstructions = new System.Windows.Forms.Button();
            this.btnPlaySingle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAboutUs = new System.Windows.Forms.Button();
            this.pnTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultiply)).BeginInit();
            this.pnInstructions.SuspendLayout();
            this.flowLayoutPanelInstructions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picInstructions)).BeginInit();
            this.pnAboutUs.SuspendLayout();
            this.pnLevel.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTitle
            // 
            this.pnTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnTitle.Controls.Add(this.picMinus);
            this.pnTitle.Controls.Add(this.picMultiply);
            this.pnTitle.Location = new System.Drawing.Point(0, 0);
            this.pnTitle.Name = "pnTitle";
            this.pnTitle.Size = new System.Drawing.Size(500, 40);
            this.pnTitle.TabIndex = 26;
            this.pnTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.pnTitle_Paint);
            this.pnTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseDown);
            this.pnTitle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnTitle_MouseMove);
            // 
            // picMinus
            // 
            this.picMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinus.Image = ((System.Drawing.Image)(resources.GetObject("picMinus.Image")));
            this.picMinus.Location = new System.Drawing.Point(430, 5);
            this.picMinus.Name = "picMinus";
            this.picMinus.Size = new System.Drawing.Size(30, 30);
            this.picMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMinus.TabIndex = 2;
            this.picMinus.TabStop = false;
            this.picMinus.Click += new System.EventHandler(this.picMinus_Click);
            this.picMinus.MouseEnter += new System.EventHandler(this.picMinus_MouseEnter);
            this.picMinus.MouseLeave += new System.EventHandler(this.picMinus_MouseLeave);
            // 
            // picMultiply
            // 
            this.picMultiply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMultiply.Image = ((System.Drawing.Image)(resources.GetObject("picMultiply.Image")));
            this.picMultiply.Location = new System.Drawing.Point(467, 5);
            this.picMultiply.Name = "picMultiply";
            this.picMultiply.Size = new System.Drawing.Size(30, 30);
            this.picMultiply.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMultiply.TabIndex = 0;
            this.picMultiply.TabStop = false;
            this.picMultiply.Click += new System.EventHandler(this.picMultiply_Click);
            this.picMultiply.MouseEnter += new System.EventHandler(this.picMultiply_MouseEnter);
            this.picMultiply.MouseLeave += new System.EventHandler(this.picMultiply_MouseLeave);
            // 
            // pnInstructions
            // 
            this.pnInstructions.BackgroundImage = global::SuperTank.Properties.Resources.instruc;
            this.pnInstructions.Controls.Add(this.button1);
            this.pnInstructions.Controls.Add(this.flowLayoutPanelInstructions);
            this.pnInstructions.Location = new System.Drawing.Point(1000, 40);
            this.pnInstructions.Name = "pnInstructions";
            this.pnInstructions.Size = new System.Drawing.Size(500, 500);
            this.pnInstructions.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.button1.Location = new System.Drawing.Point(197, 421);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 37);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.Text = "Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // flowLayoutPanelInstructions
            // 
            this.flowLayoutPanelInstructions.AllowDrop = true;
            this.flowLayoutPanelInstructions.AutoScroll = true;
            this.flowLayoutPanelInstructions.Controls.Add(this.picInstructions);
            this.flowLayoutPanelInstructions.Controls.Add(this.lblInstructions);
            this.flowLayoutPanelInstructions.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.flowLayoutPanelInstructions.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelInstructions.Location = new System.Drawing.Point(69, 139);
            this.flowLayoutPanelInstructions.Name = "flowLayoutPanelInstructions";
            this.flowLayoutPanelInstructions.Size = new System.Drawing.Size(363, 273);
            this.flowLayoutPanelInstructions.TabIndex = 29;
            // 
            // picInstructions
            // 
            this.picInstructions.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.picInstructions.Image = ((System.Drawing.Image)(resources.GetObject("picInstructions.Image")));
            this.picInstructions.Location = new System.Drawing.Point(3, 3);
            this.picInstructions.Name = "picInstructions";
            this.picInstructions.Size = new System.Drawing.Size(349, 776);
            this.picInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picInstructions.TabIndex = 0;
            this.picInstructions.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.Color.Transparent;
            this.lblInstructions.Font = new System.Drawing.Font("Bahnschrift Condensed", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.White;
            this.lblInstructions.Location = new System.Drawing.Point(358, 0);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(395, 300);
            this.lblInstructions.TabIndex = 27;
            this.lblInstructions.Text = resources.GetString("lblInstructions.Text");
            // 
            // pnAboutUs
            // 
            this.pnAboutUs.BackgroundImage = global::SuperTank.Properties.Resources._2;
            this.pnAboutUs.Controls.Add(this.btnAboutUsMenu);
            this.pnAboutUs.Location = new System.Drawing.Point(1500, 40);
            this.pnAboutUs.Name = "pnAboutUs";
            this.pnAboutUs.Size = new System.Drawing.Size(500, 500);
            this.pnAboutUs.TabIndex = 24;
            // 
            // btnAboutUsMenu
            // 
            this.btnAboutUsMenu.BackColor = System.Drawing.Color.White;
            this.btnAboutUsMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUsMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAboutUsMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAboutUsMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAboutUsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUsMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnAboutUsMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnAboutUsMenu.Location = new System.Drawing.Point(202, 416);
            this.btnAboutUsMenu.Name = "btnAboutUsMenu";
            this.btnAboutUsMenu.Size = new System.Drawing.Size(116, 37);
            this.btnAboutUsMenu.TabIndex = 24;
            this.btnAboutUsMenu.TabStop = false;
            this.btnAboutUsMenu.Text = "Menu";
            this.btnAboutUsMenu.UseVisualStyleBackColor = false;
            this.btnAboutUsMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // pnLevel
            // 
            this.pnLevel.BackgroundImage = global::SuperTank.Properties.Resources._6;
            this.pnLevel.Controls.Add(this.btnLevelMenu);
            this.pnLevel.Controls.Add(this.btnLevel8);
            this.pnLevel.Controls.Add(this.btnLevel7);
            this.pnLevel.Controls.Add(this.btnLevel6);
            this.pnLevel.Controls.Add(this.btnLevel5);
            this.pnLevel.Controls.Add(this.btnLevel4);
            this.pnLevel.Controls.Add(this.btnLevel3);
            this.pnLevel.Controls.Add(this.btnLevel10);
            this.pnLevel.Controls.Add(this.btnLevel9);
            this.pnLevel.Controls.Add(this.btnLevel2);
            this.pnLevel.Controls.Add(this.btnLevel1);
            this.pnLevel.Location = new System.Drawing.Point(500, 40);
            this.pnLevel.Name = "pnLevel";
            this.pnLevel.Size = new System.Drawing.Size(500, 500);
            this.pnLevel.TabIndex = 14;
            // 
            // btnLevelMenu
            // 
            this.btnLevelMenu.BackColor = System.Drawing.Color.White;
            this.btnLevelMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevelMenu.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevelMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevelMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevelMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevelMenu.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevelMenu.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnLevelMenu.Location = new System.Drawing.Point(191, 417);
            this.btnLevelMenu.Name = "btnLevelMenu";
            this.btnLevelMenu.Size = new System.Drawing.Size(116, 37);
            this.btnLevelMenu.TabIndex = 22;
            this.btnLevelMenu.TabStop = false;
            this.btnLevelMenu.Text = "Menu";
            this.btnLevelMenu.UseVisualStyleBackColor = false;
            this.btnLevelMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnLevel8
            // 
            this.btnLevel8.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel8.Enabled = false;
            this.btnLevel8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel8.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel8.Location = new System.Drawing.Point(261, 313);
            this.btnLevel8.Name = "btnLevel8";
            this.btnLevel8.Size = new System.Drawing.Size(116, 37);
            this.btnLevel8.TabIndex = 21;
            this.btnLevel8.TabStop = false;
            this.btnLevel8.Tag = "8";
            this.btnLevel8.Text = "Level 8";
            this.btnLevel8.UseVisualStyleBackColor = false;
            this.btnLevel8.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel7
            // 
            this.btnLevel7.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel7.Enabled = false;
            this.btnLevel7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel7.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel7.Location = new System.Drawing.Point(113, 313);
            this.btnLevel7.Name = "btnLevel7";
            this.btnLevel7.Size = new System.Drawing.Size(116, 37);
            this.btnLevel7.TabIndex = 20;
            this.btnLevel7.TabStop = false;
            this.btnLevel7.Tag = "7";
            this.btnLevel7.Text = "Level 7";
            this.btnLevel7.UseVisualStyleBackColor = false;
            this.btnLevel7.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel6
            // 
            this.btnLevel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel6.Enabled = false;
            this.btnLevel6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel6.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel6.Location = new System.Drawing.Point(261, 257);
            this.btnLevel6.Name = "btnLevel6";
            this.btnLevel6.Size = new System.Drawing.Size(116, 37);
            this.btnLevel6.TabIndex = 19;
            this.btnLevel6.TabStop = false;
            this.btnLevel6.Tag = "6";
            this.btnLevel6.Text = "Level 6";
            this.btnLevel6.UseVisualStyleBackColor = false;
            this.btnLevel6.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel5
            // 
            this.btnLevel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel5.Enabled = false;
            this.btnLevel5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel5.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel5.Location = new System.Drawing.Point(113, 257);
            this.btnLevel5.Name = "btnLevel5";
            this.btnLevel5.Size = new System.Drawing.Size(116, 37);
            this.btnLevel5.TabIndex = 18;
            this.btnLevel5.TabStop = false;
            this.btnLevel5.Tag = "5";
            this.btnLevel5.Text = "Level 5";
            this.btnLevel5.UseVisualStyleBackColor = false;
            this.btnLevel5.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel4
            // 
            this.btnLevel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel4.Enabled = false;
            this.btnLevel4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel4.Location = new System.Drawing.Point(261, 203);
            this.btnLevel4.Name = "btnLevel4";
            this.btnLevel4.Size = new System.Drawing.Size(116, 37);
            this.btnLevel4.TabIndex = 17;
            this.btnLevel4.TabStop = false;
            this.btnLevel4.Tag = "4";
            this.btnLevel4.Text = "Level 4";
            this.btnLevel4.UseVisualStyleBackColor = false;
            this.btnLevel4.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel3
            // 
            this.btnLevel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel3.Enabled = false;
            this.btnLevel3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel3.Location = new System.Drawing.Point(113, 203);
            this.btnLevel3.Name = "btnLevel3";
            this.btnLevel3.Size = new System.Drawing.Size(116, 37);
            this.btnLevel3.TabIndex = 16;
            this.btnLevel3.TabStop = false;
            this.btnLevel3.Tag = "3";
            this.btnLevel3.Text = "Level 3";
            this.btnLevel3.UseVisualStyleBackColor = false;
            this.btnLevel3.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel10
            // 
            this.btnLevel10.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel10.Enabled = false;
            this.btnLevel10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel10.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel10.Location = new System.Drawing.Point(261, 367);
            this.btnLevel10.Name = "btnLevel10";
            this.btnLevel10.Size = new System.Drawing.Size(116, 37);
            this.btnLevel10.TabIndex = 15;
            this.btnLevel10.TabStop = false;
            this.btnLevel10.Tag = "10";
            this.btnLevel10.Text = "Level 10";
            this.btnLevel10.UseVisualStyleBackColor = false;
            this.btnLevel10.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel9
            // 
            this.btnLevel9.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel9.Enabled = false;
            this.btnLevel9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel9.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel9.Location = new System.Drawing.Point(113, 367);
            this.btnLevel9.Name = "btnLevel9";
            this.btnLevel9.Size = new System.Drawing.Size(116, 37);
            this.btnLevel9.TabIndex = 14;
            this.btnLevel9.TabStop = false;
            this.btnLevel9.Tag = "9";
            this.btnLevel9.Text = "Level 9";
            this.btnLevel9.UseVisualStyleBackColor = false;
            this.btnLevel9.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel2
            // 
            this.btnLevel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel2.Enabled = false;
            this.btnLevel2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel2.Location = new System.Drawing.Point(261, 147);
            this.btnLevel2.Name = "btnLevel2";
            this.btnLevel2.Size = new System.Drawing.Size(116, 37);
            this.btnLevel2.TabIndex = 13;
            this.btnLevel2.TabStop = false;
            this.btnLevel2.Tag = "2";
            this.btnLevel2.Text = "Level 2";
            this.btnLevel2.UseVisualStyleBackColor = false;
            this.btnLevel2.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnLevel1
            // 
            this.btnLevel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnLevel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLevel1.Enabled = false;
            this.btnLevel1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnLevel1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLevel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLevel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnLevel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLevel1.Location = new System.Drawing.Point(113, 147);
            this.btnLevel1.Name = "btnLevel1";
            this.btnLevel1.Size = new System.Drawing.Size(116, 37);
            this.btnLevel1.TabIndex = 12;
            this.btnLevel1.TabStop = false;
            this.btnLevel1.Tag = "1";
            this.btnLevel1.Text = "Level 1";
            this.btnLevel1.UseVisualStyleBackColor = false;
            this.btnLevel1.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // pnMenu
            // 
            this.pnMenu.BackgroundImage = global::SuperTank.Properties.Resources._1;
            this.pnMenu.Controls.Add(this.btn_PlayerMulti);
            this.pnMenu.Controls.Add(this.btnInstructions);
            this.pnMenu.Controls.Add(this.btnPlaySingle);
            this.pnMenu.Controls.Add(this.btnExit);
            this.pnMenu.Controls.Add(this.btnAboutUs);
            this.pnMenu.Location = new System.Drawing.Point(-1, 39);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(500, 500);
            this.pnMenu.TabIndex = 13;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMenu_Paint);
            // 
            // btn_PlayerMulti
            // 
            this.btn_PlayerMulti.BackColor = System.Drawing.Color.MidnightBlue;
            this.btn_PlayerMulti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PlayerMulti.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_PlayerMulti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_PlayerMulti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_PlayerMulti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PlayerMulti.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btn_PlayerMulti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_PlayerMulti.Location = new System.Drawing.Point(259, 143);
            this.btn_PlayerMulti.Name = "btn_PlayerMulti";
            this.btn_PlayerMulti.Size = new System.Drawing.Size(134, 61);
            this.btn_PlayerMulti.TabIndex = 27;
            this.btn_PlayerMulti.TabStop = false;
            this.btn_PlayerMulti.Text = "MULTI PLAYER";
            this.btn_PlayerMulti.UseVisualStyleBackColor = false;
            this.btn_PlayerMulti.Click += new System.EventHandler(this.btn_PlayerMulti_Click);
            // 
            // btnInstructions
            // 
            this.btnInstructions.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnInstructions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInstructions.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInstructions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnInstructions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstructions.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnInstructions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnInstructions.Location = new System.Drawing.Point(104, 226);
            this.btnInstructions.Name = "btnInstructions";
            this.btnInstructions.Size = new System.Drawing.Size(289, 52);
            this.btnInstructions.TabIndex = 2;
            this.btnInstructions.TabStop = false;
            this.btnInstructions.Text = "INSTRUCTIONS";
            this.btnInstructions.UseVisualStyleBackColor = false;
            this.btnInstructions.Click += new System.EventHandler(this.btnInstructions_Click);
            // 
            // btnPlaySingle
            // 
            this.btnPlaySingle.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnPlaySingle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlaySingle.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlaySingle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnPlaySingle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlaySingle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaySingle.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaySingle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPlaySingle.Location = new System.Drawing.Point(104, 143);
            this.btnPlaySingle.Name = "btnPlaySingle";
            this.btnPlaySingle.Size = new System.Drawing.Size(134, 61);
            this.btnPlaySingle.TabIndex = 0;
            this.btnPlaySingle.TabStop = false;
            this.btnPlaySingle.Text = "SINGLE PLAYER";
            this.btnPlaySingle.UseVisualStyleBackColor = false;
            this.btnPlaySingle.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnExit.Location = new System.Drawing.Point(104, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(289, 52);
            this.btnExit.TabIndex = 4;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAboutUs
            // 
            this.btnAboutUs.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAboutUs.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAboutUs.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAboutUs.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAboutUs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAboutUs.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.btnAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAboutUs.Location = new System.Drawing.Point(104, 307);
            this.btnAboutUs.Name = "btnAboutUs";
            this.btnAboutUs.Size = new System.Drawing.Size(289, 52);
            this.btnAboutUs.TabIndex = 3;
            this.btnAboutUs.TabStop = false;
            this.btnAboutUs.Text = "ABOUT US";
            this.btnAboutUs.UseVisualStyleBackColor = false;
            this.btnAboutUs.Click += new System.EventHandler(this.btnAboutUs_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1860, 540);
            this.Controls.Add(this.pnTitle);
            this.Controls.Add(this.pnInstructions);
            this.Controls.Add(this.pnAboutUs);
            this.Controls.Add(this.pnLevel);
            this.Controls.Add(this.pnMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.pnTitle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMultiply)).EndInit();
            this.pnInstructions.ResumeLayout(false);
            this.flowLayoutPanelInstructions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picInstructions)).EndInit();
            this.pnAboutUs.ResumeLayout(false);
            this.pnLevel.ResumeLayout(false);
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAboutUs;
        private System.Windows.Forms.Button btnPlaySingle;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Panel pnLevel;
        private System.Windows.Forms.Button btnLevelMenu;
        private System.Windows.Forms.Button btnLevel8;
        private System.Windows.Forms.Button btnLevel7;
        private System.Windows.Forms.Button btnLevel6;
        private System.Windows.Forms.Button btnLevel5;
        private System.Windows.Forms.Button btnLevel4;
        private System.Windows.Forms.Button btnLevel3;
        private System.Windows.Forms.Button btnLevel10;
        private System.Windows.Forms.Button btnLevel9;
        private System.Windows.Forms.Button btnLevel2;
        private System.Windows.Forms.Button btnLevel1;
        private System.Windows.Forms.Panel pnAboutUs;
        private System.Windows.Forms.Button btnAboutUsMenu;
        private System.Windows.Forms.Panel pnTitle;
        private System.Windows.Forms.PictureBox picMinus;
        private System.Windows.Forms.PictureBox picMultiply;
        private System.Windows.Forms.Button btnInstructions;
        private System.Windows.Forms.Panel pnInstructions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInstructions;
        private System.Windows.Forms.PictureBox picInstructions;
        private System.Windows.Forms.Label lblInstructions;
        private System.Windows.Forms.Button btn_PlayerMulti;
    }
}