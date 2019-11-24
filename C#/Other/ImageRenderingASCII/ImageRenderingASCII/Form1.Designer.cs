namespace ImageRenderingASCII
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
            this.Picture_Box = new System.Windows.Forms.PictureBox();
            this.Show_Reg_Image = new System.Windows.Forms.Button();
            this.Show_ASCII_Image = new System.Windows.Forms.Button();
            this.Show_Full_Inv_Image = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Show_Half_Inv_Image = new System.Windows.Forms.Button();
            this.ASCII = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture_Box
            // 
            this.Picture_Box.Location = new System.Drawing.Point(174, 55);
            this.Picture_Box.Name = "Picture_Box";
            this.Picture_Box.Size = new System.Drawing.Size(400, 400);
            this.Picture_Box.TabIndex = 1;
            this.Picture_Box.TabStop = false;
            // 
            // Show_Reg_Image
            // 
            this.Show_Reg_Image.Location = new System.Drawing.Point(12, 54);
            this.Show_Reg_Image.Name = "Show_Reg_Image";
            this.Show_Reg_Image.Size = new System.Drawing.Size(155, 45);
            this.Show_Reg_Image.TabIndex = 2;
            this.Show_Reg_Image.Text = "Show Regular Image";
            this.Show_Reg_Image.UseVisualStyleBackColor = true;
            this.Show_Reg_Image.Click += new System.EventHandler(this.Show_Reg_Image_Click);
            // 
            // Show_ASCII_Image
            // 
            this.Show_ASCII_Image.Location = new System.Drawing.Point(12, 207);
            this.Show_ASCII_Image.Name = "Show_ASCII_Image";
            this.Show_ASCII_Image.Size = new System.Drawing.Size(155, 45);
            this.Show_ASCII_Image.TabIndex = 3;
            this.Show_ASCII_Image.Text = "Show ASCII Image";
            this.Show_ASCII_Image.UseVisualStyleBackColor = true;
            this.Show_ASCII_Image.Click += new System.EventHandler(this.Show_ASCII_Image_Click);
            // 
            // Show_Full_Inv_Image
            // 
            this.Show_Full_Inv_Image.Location = new System.Drawing.Point(12, 156);
            this.Show_Full_Inv_Image.Name = "Show_Full_Inv_Image";
            this.Show_Full_Inv_Image.Size = new System.Drawing.Size(155, 45);
            this.Show_Full_Inv_Image.TabIndex = 4;
            this.Show_Full_Inv_Image.Text = "Show Full Inverted Colors Image";
            this.Show_Full_Inv_Image.UseVisualStyleBackColor = true;
            this.Show_Full_Inv_Image.Click += new System.EventHandler(this.Show_Full_Inv_Image_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(560, 20);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Enter a file path for your image here:";
            // 
            // Show_Half_Inv_Image
            // 
            this.Show_Half_Inv_Image.Location = new System.Drawing.Point(12, 105);
            this.Show_Half_Inv_Image.Name = "Show_Half_Inv_Image";
            this.Show_Half_Inv_Image.Size = new System.Drawing.Size(155, 45);
            this.Show_Half_Inv_Image.TabIndex = 7;
            this.Show_Half_Inv_Image.Text = "Show Half Inverted Colors Image";
            this.Show_Half_Inv_Image.UseVisualStyleBackColor = true;
            this.Show_Half_Inv_Image.Click += new System.EventHandler(this.Show_Half_Inv_Image_Click);
            // 
            // ASCII
            // 
            this.ASCII.Location = new System.Drawing.Point(174, 55);
            this.ASCII.Name = "ASCII";
            this.ASCII.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.ASCII.Size = new System.Drawing.Size(400, 400);
            this.ASCII.TabIndex = 8;
            this.ASCII.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 466);
            this.Controls.Add(this.Show_Half_Inv_Image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Show_Full_Inv_Image);
            this.Controls.Add(this.Show_ASCII_Image);
            this.Controls.Add(this.Show_Reg_Image);
            this.Controls.Add(this.Picture_Box);
            this.Controls.Add(this.ASCII);
            this.Name = "Form1";
            this.Text = "ASCII Image Renderer";
            ((System.ComponentModel.ISupportInitialize)(this.Picture_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Picture_Box;
        private System.Windows.Forms.Button Show_Reg_Image;
        private System.Windows.Forms.Button Show_ASCII_Image;
        private System.Windows.Forms.Button Show_Full_Inv_Image;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Show_Half_Inv_Image;
        private System.Windows.Forms.RichTextBox ASCII;
    }
}

