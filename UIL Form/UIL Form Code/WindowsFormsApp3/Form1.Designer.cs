namespace WindowsFormsApp3
{
    partial class UIL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UIL));
            this.label1 = new System.Windows.Forms.Label();
            this.Flash_Drive_Box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Recorder_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.School_Box = new System.Windows.Forms.TextBox();
            this.Flash_Drive_Button = new System.Windows.Forms.Button();
            this.Recorder_Button = new System.Windows.Forms.Button();
            this.Enter_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flash Drive Path:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Flash_Drive_Box
            // 
            this.Flash_Drive_Box.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flash_Drive_Box.Location = new System.Drawing.Point(155, 120);
            this.Flash_Drive_Box.Name = "Flash_Drive_Box";
            this.Flash_Drive_Box.Size = new System.Drawing.Size(213, 29);
            this.Flash_Drive_Box.TabIndex = 1;
            this.Flash_Drive_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Flash_Drive_Box_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Recorder Path:";
            // 
            // Recorder_box
            // 
            this.Recorder_box.Location = new System.Drawing.Point(155, 170);
            this.Recorder_box.Name = "Recorder_box";
            this.Recorder_box.Size = new System.Drawing.Size(213, 29);
            this.Recorder_box.TabIndex = 3;
            this.Recorder_box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Recorder_box_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "School Name:";
            // 
            // School_Box
            // 
            this.School_Box.Location = new System.Drawing.Point(155, 70);
            this.School_Box.Name = "School_Box";
            this.School_Box.Size = new System.Drawing.Size(213, 29);
            this.School_Box.TabIndex = 5;
            this.School_Box.TextChanged += new System.EventHandler(this.School_Box_TextChanged);
            this.School_Box.KeyDown += new System.Windows.Forms.KeyEventHandler(this.School_Box_KeyDown);
            // 
            // Flash_Drive_Button
            // 
            this.Flash_Drive_Button.Location = new System.Drawing.Point(374, 120);
            this.Flash_Drive_Button.Name = "Flash_Drive_Button";
            this.Flash_Drive_Button.Size = new System.Drawing.Size(75, 29);
            this.Flash_Drive_Button.TabIndex = 6;
            this.Flash_Drive_Button.Text = "Browse";
            this.Flash_Drive_Button.UseVisualStyleBackColor = true;
            this.Flash_Drive_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Recorder_Button
            // 
            this.Recorder_Button.Location = new System.Drawing.Point(374, 170);
            this.Recorder_Button.Name = "Recorder_Button";
            this.Recorder_Button.Size = new System.Drawing.Size(75, 29);
            this.Recorder_Button.TabIndex = 7;
            this.Recorder_Button.Text = "Browse";
            this.Recorder_Button.UseVisualStyleBackColor = true;
            this.Recorder_Button.Click += new System.EventHandler(this.Recorder_Button_Click);
            // 
            // Enter_button
            // 
            this.Enter_button.Location = new System.Drawing.Point(199, 230);
            this.Enter_button.Name = "Enter_button";
            this.Enter_button.Size = new System.Drawing.Size(110, 40);
            this.Enter_button.TabIndex = 8;
            this.Enter_button.Text = "Run";
            this.Enter_button.UseVisualStyleBackColor = true;
            this.Enter_button.Click += new System.EventHandler(this.Enter_button_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(397, 420);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Help";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 420);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 10;
            this.button2.Text = "About";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(374, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 29);
            this.button3.TabIndex = 11;
            this.button3.Text = "Enter";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp3.Properties.Resources.uillogo;
            this.pictureBox1.Location = new System.Drawing.Point(110, 297);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(264, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // UIL
            // 
            this.AcceptButton = this.Enter_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Enter_button);
            this.Controls.Add(this.Recorder_Button);
            this.Controls.Add(this.Flash_Drive_Button);
            this.Controls.Add(this.School_Box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Recorder_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Flash_Drive_Box);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "UIL";
            this.Text = "UIL File Transfer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Flash_Drive_Box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Recorder_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox School_Box;
        private System.Windows.Forms.Button Flash_Drive_Button;
        private System.Windows.Forms.Button Recorder_Button;
        private System.Windows.Forms.Button Enter_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

