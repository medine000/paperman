namespace WinFormsApp8
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
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(505, 186);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(492, 351);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
            panel1.Enabled = false;
            panel1.ForeColor = Color.CornflowerBlue;
            panel1.Location = new Point(5, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(992, 157);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Segoe UI", 15F);
            button1.Location = new Point(12, 177);
            button1.Name = "button1";
            button1.Size = new Size(409, 71);
            button1.TabIndex = 2;
            button1.Text = "Read File";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.Font = new Font("Segoe UI", 15F);
            button2.Location = new Point(12, 271);
            button2.Name = "button2";
            button2.Size = new Size(409, 68);
            button2.TabIndex = 3;
            button2.Text = "Add File";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveBorder;
            button3.Font = new Font("Segoe UI", 15F);
            button3.Location = new Point(12, 359);
            button3.Name = "button3";
            button3.Size = new Size(409, 64);
            button3.TabIndex = 4;
            button3.Text = "Remove File";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveBorder;
            button4.Font = new Font("Segoe UI", 15F);
            button4.Location = new Point(12, 447);
            button4.Name = "button4";
            button4.Size = new Size(409, 65);
            button4.TabIndex = 5;
            button4.Text = "Word File";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 549);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}
