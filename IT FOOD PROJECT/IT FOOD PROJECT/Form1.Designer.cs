namespace IT_FOOD_PROJECT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.LeftBarPanel = new System.Windows.Forms.Panel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LogoPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.HomePageButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.ShopsButton = new System.Windows.Forms.Button();
            this.AdressButton = new System.Windows.Forms.Button();
            this.OrderHistoryButton = new System.Windows.Forms.Button();
            this.PaymentWayButton = new System.Windows.Forms.Button();
            this.FavButton = new System.Windows.Forms.Button();
            this.RatingsButton = new System.Windows.Forms.Button();
            this.textLabel1 = new System.Windows.Forms.Label();
            this.textLabel2 = new System.Windows.Forms.Label();
            this.textLabel3 = new System.Windows.Forms.Label();
            this.OrderButton = new System.Windows.Forms.Button();
            this.userLogin1 = new IT_FOOD_PROJECT.UserLogin();
            this.LeftBarPanel.SuspendLayout();
            this.LogoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftBarPanel
            // 
            this.LeftBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.LeftBarPanel.Controls.Add(this.RatingsButton);
            this.LeftBarPanel.Controls.Add(this.FavButton);
            this.LeftBarPanel.Controls.Add(this.PaymentWayButton);
            this.LeftBarPanel.Controls.Add(this.OrderHistoryButton);
            this.LeftBarPanel.Controls.Add(this.AdressButton);
            this.LeftBarPanel.Controls.Add(this.ShopsButton);
            this.LeftBarPanel.Controls.Add(this.SidePanel);
            this.LeftBarPanel.Controls.Add(this.HomePageButton);
            this.LeftBarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftBarPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftBarPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LeftBarPanel.Name = "LeftBarPanel";
            this.LeftBarPanel.Size = new System.Drawing.Size(220, 574);
            this.LeftBarPanel.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(220, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(697, 15);
            this.TopPanel.TabIndex = 2;
            // 
            // LogoPanel
            // 
            this.LogoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.LogoPanel.Controls.Add(this.pictureBox1);
            this.LogoPanel.Location = new System.Drawing.Point(240, 0);
            this.LogoPanel.Name = "LogoPanel";
            this.LogoPanel.Size = new System.Drawing.Size(125, 160);
            this.LogoPanel.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(2, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // HomePageButton
            // 
            this.HomePageButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.HomePageButton.FlatAppearance.BorderSize = 0;
            this.HomePageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomePageButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HomePageButton.Image = ((System.Drawing.Image)(resources.GetObject("HomePageButton.Image")));
            this.HomePageButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomePageButton.Location = new System.Drawing.Point(10, 68);
            this.HomePageButton.Name = "HomePageButton";
            this.HomePageButton.Size = new System.Drawing.Size(210, 40);
            this.HomePageButton.TabIndex = 4;
            this.HomePageButton.Text = "   Αρχική Σελίδα";
            this.HomePageButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.HomePageButton.UseVisualStyleBackColor = true;
            this.HomePageButton.Click += new System.EventHandler(this.HomePageButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 68);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 40);
            this.SidePanel.TabIndex = 4;
            // 
            // ShopsButton
            // 
            this.ShopsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShopsButton.FlatAppearance.BorderSize = 0;
            this.ShopsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShopsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ShopsButton.Image = ((System.Drawing.Image)(resources.GetObject("ShopsButton.Image")));
            this.ShopsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ShopsButton.Location = new System.Drawing.Point(10, 115);
            this.ShopsButton.Name = "ShopsButton";
            this.ShopsButton.Size = new System.Drawing.Size(210, 40);
            this.ShopsButton.TabIndex = 5;
            this.ShopsButton.Text = "   Καταστήματα";
            this.ShopsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ShopsButton.UseVisualStyleBackColor = true;
            this.ShopsButton.Click += new System.EventHandler(this.ShopsButton_Click);
            // 
            // AdressButton
            // 
            this.AdressButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AdressButton.FlatAppearance.BorderSize = 0;
            this.AdressButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdressButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AdressButton.Image = ((System.Drawing.Image)(resources.GetObject("AdressButton.Image")));
            this.AdressButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AdressButton.Location = new System.Drawing.Point(10, 162);
            this.AdressButton.Name = "AdressButton";
            this.AdressButton.Size = new System.Drawing.Size(210, 40);
            this.AdressButton.TabIndex = 6;
            this.AdressButton.Text = "   Οι Διευθύνσεις μου";
            this.AdressButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AdressButton.UseVisualStyleBackColor = true;
            this.AdressButton.Click += new System.EventHandler(this.AdressButton_Click);
            // 
            // OrderHistoryButton
            // 
            this.OrderHistoryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OrderHistoryButton.FlatAppearance.BorderSize = 0;
            this.OrderHistoryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderHistoryButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.OrderHistoryButton.Image = ((System.Drawing.Image)(resources.GetObject("OrderHistoryButton.Image")));
            this.OrderHistoryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OrderHistoryButton.Location = new System.Drawing.Point(10, 209);
            this.OrderHistoryButton.Name = "OrderHistoryButton";
            this.OrderHistoryButton.Size = new System.Drawing.Size(210, 40);
            this.OrderHistoryButton.TabIndex = 7;
            this.OrderHistoryButton.Text = "   Ιστορικό Παραγγελιών";
            this.OrderHistoryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.OrderHistoryButton.UseVisualStyleBackColor = true;
            this.OrderHistoryButton.Click += new System.EventHandler(this.OrderHistoryButton_Click);
            // 
            // PaymentWayButton
            // 
            this.PaymentWayButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PaymentWayButton.FlatAppearance.BorderSize = 0;
            this.PaymentWayButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentWayButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PaymentWayButton.Image = ((System.Drawing.Image)(resources.GetObject("PaymentWayButton.Image")));
            this.PaymentWayButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PaymentWayButton.Location = new System.Drawing.Point(10, 256);
            this.PaymentWayButton.Name = "PaymentWayButton";
            this.PaymentWayButton.Size = new System.Drawing.Size(210, 40);
            this.PaymentWayButton.TabIndex = 8;
            this.PaymentWayButton.Text = "   Τρόπος Πληρωμής";
            this.PaymentWayButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PaymentWayButton.UseVisualStyleBackColor = true;
            this.PaymentWayButton.Click += new System.EventHandler(this.PaymentWayButton_Click);
            // 
            // FavButton
            // 
            this.FavButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.FavButton.FlatAppearance.BorderSize = 0;
            this.FavButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FavButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FavButton.Image = ((System.Drawing.Image)(resources.GetObject("FavButton.Image")));
            this.FavButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.FavButton.Location = new System.Drawing.Point(10, 303);
            this.FavButton.Name = "FavButton";
            this.FavButton.Size = new System.Drawing.Size(210, 40);
            this.FavButton.TabIndex = 9;
            this.FavButton.Text = "   Αγαπημένα Καραστήματα";
            this.FavButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.FavButton.UseVisualStyleBackColor = true;
            this.FavButton.Click += new System.EventHandler(this.FavButton_Click);
            // 
            // RatingsButton
            // 
            this.RatingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RatingsButton.FlatAppearance.BorderSize = 0;
            this.RatingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RatingsButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.RatingsButton.Image = ((System.Drawing.Image)(resources.GetObject("RatingsButton.Image")));
            this.RatingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RatingsButton.Location = new System.Drawing.Point(10, 350);
            this.RatingsButton.Name = "RatingsButton";
            this.RatingsButton.Size = new System.Drawing.Size(210, 40);
            this.RatingsButton.TabIndex = 10;
            this.RatingsButton.Text = "   Οι Αξιολογήσεις μου";
            this.RatingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RatingsButton.UseVisualStyleBackColor = true;
            this.RatingsButton.Click += new System.EventHandler(this.RatingsButton_Click);
            // 
            // textLabel1
            // 
            this.textLabel1.AutoSize = true;
            this.textLabel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textLabel1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel1.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.textLabel1.Location = new System.Drawing.Point(400, 190);
            this.textLabel1.Name = "textLabel1";
            this.textLabel1.Size = new System.Drawing.Size(410, 55);
            this.textLabel1.TabIndex = 4;
            this.textLabel1.Text = "Η no1 εφαρμογή";
            // 
            // textLabel2
            // 
            this.textLabel2.AutoSize = true;
            this.textLabel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textLabel2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel2.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.textLabel2.Location = new System.Drawing.Point(467, 256);
            this.textLabel2.Name = "textLabel2";
            this.textLabel2.Size = new System.Drawing.Size(277, 55);
            this.textLabel2.TabIndex = 5;
            this.textLabel2.Text = "για online";
            // 
            // textLabel3
            // 
            this.textLabel3.AutoSize = true;
            this.textLabel3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textLabel3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.textLabel3.Font = new System.Drawing.Font("Broadway", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.textLabel3.Location = new System.Drawing.Point(483, 322);
            this.textLabel3.Name = "textLabel3";
            this.textLabel3.Size = new System.Drawing.Size(245, 55);
            this.textLabel3.TabIndex = 6;
            this.textLabel3.Text = "delivery";
            // 
            // OrderButton
            // 
            this.OrderButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.OrderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.OrderButton.FlatAppearance.BorderSize = 0;
            this.OrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OrderButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderButton.Location = new System.Drawing.Point(458, 427);
            this.OrderButton.Name = "OrderButton";
            this.OrderButton.Size = new System.Drawing.Size(295, 65);
            this.OrderButton.TabIndex = 7;
            this.OrderButton.Text = "Παρήγγειλε Τώρα";
            this.OrderButton.UseVisualStyleBackColor = false;
            this.OrderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // userLogin1
            // 
            this.userLogin1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLogin1.Location = new System.Drawing.Point(388, 142);
            this.userLogin1.Margin = new System.Windows.Forms.Padding(4);
            this.userLogin1.Name = "userLogin1";
            this.userLogin1.Size = new System.Drawing.Size(495, 390);
            this.userLogin1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(917, 574);
            this.Controls.Add(this.userLogin1);
            this.Controls.Add(this.OrderButton);
            this.Controls.Add(this.textLabel3);
            this.Controls.Add(this.textLabel2);
            this.Controls.Add(this.textLabel1);
            this.Controls.Add(this.LogoPanel);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.LeftBarPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.LeftBarPanel.ResumeLayout(false);
            this.LogoPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LeftBarPanel;
        private System.Windows.Forms.Button RatingsButton;
        private System.Windows.Forms.Button FavButton;
        private System.Windows.Forms.Button PaymentWayButton;
        private System.Windows.Forms.Button OrderHistoryButton;
        private System.Windows.Forms.Button AdressButton;
        private System.Windows.Forms.Button ShopsButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button HomePageButton;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel LogoPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label textLabel1;
        private System.Windows.Forms.Label textLabel2;
        private System.Windows.Forms.Label textLabel3;
        private System.Windows.Forms.Button OrderButton;
        private UserLogin userLogin1;
    }
}

