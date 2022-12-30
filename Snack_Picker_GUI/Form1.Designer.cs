namespace Snack_Picker_GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Form_Title = new System.Windows.Forms.Label();
            this.Minimize_Button = new System.Windows.Forms.Button();
            this.Close_Button = new System.Windows.Forms.Button();
            this.Add_Snack_BTN = new System.Windows.Forms.Button();
            this.Add_Snack_Text_Box = new System.Windows.Forms.TextBox();
            this.View_Snacks_Text_Box = new System.Windows.Forms.TextBox();
            this.View_Snacks_BTN = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Pick_A_Random_Snack = new System.Windows.Forms.Button();
            this.Pick_A_Random_Snack_Text_Box = new System.Windows.Forms.TextBox();
            this.Status_label = new System.Windows.Forms.Label();
            this.Clear_BTN = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Close_Button);
            this.panel1.Controls.Add(this.Minimize_Button);
            this.panel1.Controls.Add(this.Form_Title);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 53);
            this.panel1.TabIndex = 0;
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // Form_Title
            // 
            this.Form_Title.AutoSize = true;
            this.Form_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Form_Title.ForeColor = System.Drawing.Color.White;
            this.Form_Title.Location = new System.Drawing.Point(88, 7);
            this.Form_Title.Name = "Form_Title";
            this.Form_Title.Size = new System.Drawing.Size(216, 39);
            this.Form_Title.TabIndex = 1;
            this.Form_Title.Text = "Snack Picker";
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Location = new System.Drawing.Point(708, 10);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.Size = new System.Drawing.Size(37, 34);
            this.Minimize_Button.TabIndex = 2;
            this.Minimize_Button.Text = "-";
            this.Minimize_Button.UseVisualStyleBackColor = true;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Close_Button
            // 
            this.Close_Button.Location = new System.Drawing.Point(751, 10);
            this.Close_Button.Name = "Close_Button";
            this.Close_Button.Size = new System.Drawing.Size(37, 34);
            this.Close_Button.TabIndex = 3;
            this.Close_Button.Text = "X";
            this.Close_Button.UseVisualStyleBackColor = true;
            this.Close_Button.Click += new System.EventHandler(this.Close_Button_Click);
            // 
            // Add_Snack_BTN
            // 
            this.Add_Snack_BTN.Location = new System.Drawing.Point(657, 73);
            this.Add_Snack_BTN.Name = "Add_Snack_BTN";
            this.Add_Snack_BTN.Size = new System.Drawing.Size(131, 40);
            this.Add_Snack_BTN.TabIndex = 1;
            this.Add_Snack_BTN.Text = "Add Snack";
            this.Add_Snack_BTN.UseVisualStyleBackColor = true;
            this.Add_Snack_BTN.Click += new System.EventHandler(this.Add_Snack_BTN_Click);
            // 
            // Add_Snack_Text_Box
            // 
            this.Add_Snack_Text_Box.Location = new System.Drawing.Point(12, 82);
            this.Add_Snack_Text_Box.Name = "Add_Snack_Text_Box";
            this.Add_Snack_Text_Box.Size = new System.Drawing.Size(632, 22);
            this.Add_Snack_Text_Box.TabIndex = 2;
            this.Add_Snack_Text_Box.TextChanged += new System.EventHandler(this.Add_Snack_Text_Box_TextChanged);
            // 
            // View_Snacks_Text_Box
            // 
            this.View_Snacks_Text_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.View_Snacks_Text_Box.Location = new System.Drawing.Point(12, 293);
            this.View_Snacks_Text_Box.Multiline = true;
            this.View_Snacks_Text_Box.Name = "View_Snacks_Text_Box";
            this.View_Snacks_Text_Box.ReadOnly = true;
            this.View_Snacks_Text_Box.Size = new System.Drawing.Size(776, 160);
            this.View_Snacks_Text_Box.TabIndex = 3;
            this.View_Snacks_Text_Box.TextChanged += new System.EventHandler(this.View_Snacks_Text_Box_TextChanged);
            // 
            // View_Snacks_BTN
            // 
            this.View_Snacks_BTN.Location = new System.Drawing.Point(12, 239);
            this.View_Snacks_BTN.Name = "View_Snacks_BTN";
            this.View_Snacks_BTN.Size = new System.Drawing.Size(776, 50);
            this.View_Snacks_BTN.TabIndex = 4;
            this.View_Snacks_BTN.Text = "View Your Added Snacks";
            this.View_Snacks_BTN.UseVisualStyleBackColor = true;
            this.View_Snacks_BTN.Click += new System.EventHandler(this.View_Snacks_BTN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Controls.Add(this.linkLabel1);
            this.panel2.Location = new System.Drawing.Point(-1, 507);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(801, 49);
            this.panel2.TabIndex = 5;
            // 
            // Pick_A_Random_Snack
            // 
            this.Pick_A_Random_Snack.Location = new System.Drawing.Point(12, 158);
            this.Pick_A_Random_Snack.Name = "Pick_A_Random_Snack";
            this.Pick_A_Random_Snack.Size = new System.Drawing.Size(240, 40);
            this.Pick_A_Random_Snack.TabIndex = 6;
            this.Pick_A_Random_Snack.Text = "Pick A Random Snack";
            this.Pick_A_Random_Snack.UseVisualStyleBackColor = true;
            this.Pick_A_Random_Snack.Click += new System.EventHandler(this.Pick_A_Random_Snack_Click);
            // 
            // Pick_A_Random_Snack_Text_Box
            // 
            this.Pick_A_Random_Snack_Text_Box.Location = new System.Drawing.Point(258, 167);
            this.Pick_A_Random_Snack_Text_Box.Name = "Pick_A_Random_Snack_Text_Box";
            this.Pick_A_Random_Snack_Text_Box.ReadOnly = true;
            this.Pick_A_Random_Snack_Text_Box.Size = new System.Drawing.Size(530, 22);
            this.Pick_A_Random_Snack_Text_Box.TabIndex = 7;
            this.Pick_A_Random_Snack_Text_Box.TextChanged += new System.EventHandler(this.Pick_A_Random_Snack_Text_Box_TextChanged);
            // 
            // Status_label
            // 
            this.Status_label.AutoSize = true;
            this.Status_label.Location = new System.Drawing.Point(336, 111);
            this.Status_label.Name = "Status_label";
            this.Status_label.Size = new System.Drawing.Size(50, 16);
            this.Status_label.TabIndex = 8;
            this.Status_label.Text = "Status: ";
            this.Status_label.Click += new System.EventHandler(this.Status_label_Click);
            // 
            // Clear_BTN
            // 
            this.Clear_BTN.Location = new System.Drawing.Point(320, 459);
            this.Clear_BTN.Name = "Clear_BTN";
            this.Clear_BTN.Size = new System.Drawing.Size(131, 40);
            this.Clear_BTN.TabIndex = 9;
            this.Clear_BTN.Text = "Clear List";
            this.Clear_BTN.UseVisualStyleBackColor = true;
            this.Clear_BTN.Click += new System.EventHandler(this.Clear_BTN_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Snack_Picker_GUI.Properties.Resources.snack_2_40x40;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 43);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.BackColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(14, 20);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(169, 16);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "© Codeplanet Code School";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.Clear_BTN);
            this.Controls.Add(this.Status_label);
            this.Controls.Add(this.Pick_A_Random_Snack_Text_Box);
            this.Controls.Add(this.Pick_A_Random_Snack);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.View_Snacks_BTN);
            this.Controls.Add(this.View_Snacks_Text_Box);
            this.Controls.Add(this.Add_Snack_Text_Box);
            this.Controls.Add(this.Add_Snack_BTN);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Snack Picker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Close_Button;
        private System.Windows.Forms.Button Minimize_Button;
        private System.Windows.Forms.Label Form_Title;
        private System.Windows.Forms.Button Add_Snack_BTN;
        private System.Windows.Forms.TextBox Add_Snack_Text_Box;
        private System.Windows.Forms.TextBox View_Snacks_Text_Box;
        private System.Windows.Forms.Button View_Snacks_BTN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Pick_A_Random_Snack;
        private System.Windows.Forms.TextBox Pick_A_Random_Snack_Text_Box;
        private System.Windows.Forms.Label Status_label;
        private System.Windows.Forms.Button Clear_BTN;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

