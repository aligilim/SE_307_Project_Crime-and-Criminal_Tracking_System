
namespace CrimeAndCriminalTrackingSystem
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addNewCriminalButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.searchCriminalButton = new System.Windows.Forms.Button();
            this.searchPoliceButton = new System.Windows.Forms.Button();
            this.addNewPoliceButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(113, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(38, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(192, 56);
            this.button1.TabIndex = 1;
            this.button1.Text = "Create Crime Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 209);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 54);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search Crime Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNewCriminalButton
            // 
            this.addNewCriminalButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewCriminalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewCriminalButton.Location = new System.Drawing.Point(38, 302);
            this.addNewCriminalButton.Name = "addNewCriminalButton";
            this.addNewCriminalButton.Size = new System.Drawing.Size(192, 52);
            this.addNewCriminalButton.TabIndex = 3;
            this.addNewCriminalButton.Text = "Add New Criminal";
            this.addNewCriminalButton.UseVisualStyleBackColor = false;
            this.addNewCriminalButton.Click += new System.EventHandler(this.addNewCriminalButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(6, 544);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Current User:";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(110, 544);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(0, 16);
            this.username.TabIndex = 5;
            // 
            // searchCriminalButton
            // 
            this.searchCriminalButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchCriminalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCriminalButton.Location = new System.Drawing.Point(259, 302);
            this.searchCriminalButton.Name = "searchCriminalButton";
            this.searchCriminalButton.Size = new System.Drawing.Size(188, 52);
            this.searchCriminalButton.TabIndex = 6;
            this.searchCriminalButton.Text = "Search Criminal";
            this.searchCriminalButton.UseVisualStyleBackColor = false;
            this.searchCriminalButton.Click += new System.EventHandler(this.searchCriminalButton_Click);
            // 
            // searchPoliceButton
            // 
            this.searchPoliceButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchPoliceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPoliceButton.Location = new System.Drawing.Point(259, 394);
            this.searchPoliceButton.Name = "searchPoliceButton";
            this.searchPoliceButton.Size = new System.Drawing.Size(188, 52);
            this.searchPoliceButton.TabIndex = 8;
            this.searchPoliceButton.Text = "Search Police";
            this.searchPoliceButton.UseVisualStyleBackColor = false;
            this.searchPoliceButton.Click += new System.EventHandler(this.searchPoliceButton_Click);
            // 
            // addNewPoliceButton
            // 
            this.addNewPoliceButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addNewPoliceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewPoliceButton.Location = new System.Drawing.Point(38, 394);
            this.addNewPoliceButton.Name = "addNewPoliceButton";
            this.addNewPoliceButton.Size = new System.Drawing.Size(192, 52);
            this.addNewPoliceButton.TabIndex = 7;
            this.addNewPoliceButton.Text = "Add New Police";
            this.addNewPoliceButton.UseVisualStyleBackColor = false;
            this.addNewPoliceButton.Click += new System.EventHandler(this.addNewPoliceButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logoutButton.Location = new System.Drawing.Point(167, 480);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(150, 52);
            this.logoutButton.TabIndex = 9;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 570);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.searchPoliceButton);
            this.Controls.Add(this.addNewPoliceButton);
            this.Controls.Add(this.searchCriminalButton);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addNewCriminalButton);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crime and Criminal Tracking System";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addNewCriminalButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Button searchCriminalButton;
        private System.Windows.Forms.Button searchPoliceButton;
        private System.Windows.Forms.Button addNewPoliceButton;
        private System.Windows.Forms.Button logoutButton;
    }
}