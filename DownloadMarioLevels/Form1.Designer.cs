namespace DownloadMarioLevels
{
    partial class Form1
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
            this.button_downloadLevel = new System.Windows.Forms.Button();
            this.textBox_forLevel_ID = new System.Windows.Forms.TextBox();
            this.textBox_levelPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_levelReplace_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_downloadLevel
            // 
            this.button_downloadLevel.Location = new System.Drawing.Point(146, 81);
            this.button_downloadLevel.Name = "button_downloadLevel";
            this.button_downloadLevel.Size = new System.Drawing.Size(75, 54);
            this.button_downloadLevel.TabIndex = 1;
            this.button_downloadLevel.Text = "Download level";
            this.button_downloadLevel.UseVisualStyleBackColor = true;
            this.button_downloadLevel.Click += new System.EventHandler(this.button_downloadLevel_Click);
            // 
            // textBox_forLevel_ID
            // 
            this.textBox_forLevel_ID.Location = new System.Drawing.Point(92, 52);
            this.textBox_forLevel_ID.Name = "textBox_forLevel_ID";
            this.textBox_forLevel_ID.Size = new System.Drawing.Size(131, 23);
            this.textBox_forLevel_ID.TabIndex = 2;
            // 
            // textBox_levelPath
            // 
            this.textBox_levelPath.Location = new System.Drawing.Point(92, 9);
            this.textBox_levelPath.Name = "textBox_levelPath";
            this.textBox_levelPath.Size = new System.Drawing.Size(241, 23);
            this.textBox_levelPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "SMM2 level ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.MaximumSize = new System.Drawing.Size(90, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "where to set the level";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 12);
            this.label1.MaximumSize = new System.Drawing.Size(0, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Example: D:\\Games\\levelsForMario\\";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 40);
            this.button1.TabIndex = 7;
            this.button1.Text = "Open folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 8;
            // 
            // textBox_levelReplace_ID
            // 
            this.textBox_levelReplace_ID.Location = new System.Drawing.Point(227, 104);
            this.textBox_levelReplace_ID.Name = "textBox_levelReplace_ID";
            this.textBox_levelReplace_ID.Size = new System.Drawing.Size(31, 23);
            this.textBox_levelReplace_ID.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Replace. Start with 000, EXAMPLE: 015 = level 16";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(377, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "you need REPLACE level instead of creating or the level will not appear";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(562, 165);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_levelReplace_ID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_levelPath);
            this.Controls.Add(this.textBox_forLevel_ID);
            this.Controls.Add(this.button_downloadLevel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button button_downloadLevel;
        private TextBox textBox_forLevel_ID;
        private TextBox textBox_levelPath;
        private Label label2;
        private Label label3;
        private Label label1;
        private Button button1;
        private Label label4;
        private TextBox textBox_levelReplace_ID;
        private Label label5;
        private Label label6;
    }
}