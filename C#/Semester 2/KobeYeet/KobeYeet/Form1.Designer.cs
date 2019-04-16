namespace KobeYeet
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
            this.Button_Kobe_Yeet = new System.Windows.Forms.Button();
            this.CheckBox_FailSafe = new System.Windows.Forms.CheckBox();
            this.KobeDate = new System.Windows.Forms.DateTimePicker();
            this.Label_Yeet = new System.Windows.Forms.Label();
            this.Picture_Box = new System.Windows.Forms.PictureBox();
            this.Its_Free_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Kobe_Yeet
            // 
            this.Button_Kobe_Yeet.Location = new System.Drawing.Point(81, 66);
            this.Button_Kobe_Yeet.Name = "Button_Kobe_Yeet";
            this.Button_Kobe_Yeet.Size = new System.Drawing.Size(349, 300);
            this.Button_Kobe_Yeet.TabIndex = 0;
            this.Button_Kobe_Yeet.Text = "KOBEYEET";
            this.Button_Kobe_Yeet.UseVisualStyleBackColor = true;
            this.Button_Kobe_Yeet.Click += new System.EventHandler(this.Button_Kobe_Yeet_Click);
            // 
            // CheckBox_FailSafe
            // 
            this.CheckBox_FailSafe.AutoSize = true;
            this.CheckBox_FailSafe.Location = new System.Drawing.Point(81, 369);
            this.CheckBox_FailSafe.Name = "CheckBox_FailSafe";
            this.CheckBox_FailSafe.Size = new System.Drawing.Size(75, 17);
            this.CheckBox_FailSafe.TabIndex = 1;
            this.CheckBox_FailSafe.Text = "FAiL SaFe";
            this.CheckBox_FailSafe.UseVisualStyleBackColor = true;
            this.CheckBox_FailSafe.CheckedChanged += new System.EventHandler(this.CheckBox_FailSafe_CheckedChanged);
            // 
            // KobeDate
            // 
            this.KobeDate.Location = new System.Drawing.Point(89, 40);
            this.KobeDate.Name = "KobeDate";
            this.KobeDate.Size = new System.Drawing.Size(195, 20);
            this.KobeDate.TabIndex = 2;
            this.KobeDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // Label_Yeet
            // 
            this.Label_Yeet.AutoSize = true;
            this.Label_Yeet.Location = new System.Drawing.Point(229, 369);
            this.Label_Yeet.Name = "Label_Yeet";
            this.Label_Yeet.Size = new System.Drawing.Size(55, 13);
            this.Label_Yeet.TabIndex = 3;
            this.Label_Yeet.Text = "LabelYeet";
            // 
            // Picture_Box
            // 
            this.Picture_Box.Location = new System.Drawing.Point(436, 66);
            this.Picture_Box.Name = "Picture_Box";
            this.Picture_Box.Size = new System.Drawing.Size(265, 300);
            this.Picture_Box.TabIndex = 4;
            this.Picture_Box.TabStop = false;
            // 
            // Its_Free_Text
            // 
            this.Its_Free_Text.Location = new System.Drawing.Point(290, 40);
            this.Its_Free_Text.Name = "Its_Free_Text";
            this.Its_Free_Text.Size = new System.Drawing.Size(411, 20);
            this.Its_Free_Text.TabIndex = 5;
            this.Its_Free_Text.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Its_Free_Text);
            this.Controls.Add(this.Picture_Box);
            this.Controls.Add(this.Label_Yeet);
            this.Controls.Add(this.KobeDate);
            this.Controls.Add(this.CheckBox_FailSafe);
            this.Controls.Add(this.Button_Kobe_Yeet);
            this.Name = "Form1";
            this.Text = "KobeYeet";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_Kobe_Yeet;
        private System.Windows.Forms.CheckBox CheckBox_FailSafe;
        private System.Windows.Forms.DateTimePicker KobeDate;
        private System.Windows.Forms.Label Label_Yeet;
        private System.Windows.Forms.PictureBox Picture_Box;
        private System.Windows.Forms.TextBox Its_Free_Text;
    }
}

