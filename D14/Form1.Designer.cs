namespace D14
{
    partial class main
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
            minimize = new Button();
            close = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // minimize
            // 
            minimize.Location = new Point(787, 9);
            minimize.Name = "minimize";
            minimize.Size = new Size(50, 50);
            minimize.TabIndex = 0;
            minimize.Text = "_";
            minimize.UseVisualStyleBackColor = true;
            minimize.Click += minimize_Click;
            // 
            // close
            // 
            close.Location = new Point(882, 9);
            close.Name = "close";
            close.Size = new Size(50, 50);
            close.TabIndex = 1;
            close.Text = "x";
            close.UseVisualStyleBackColor = true;
            close.Click += close_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(210, 299);
            label1.Name = "label1";
            label1.Size = new Size(141, 48);
            label1.TabIndex = 2;
            label1.Text = "Discord";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ActiveCaptionText;
            textBox1.ForeColor = Color.Cyan;
            textBox1.Location = new Point(94, 350);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Type Here";
            textBox1.Size = new Size(375, 55);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(23, 32);
            button1.Name = "button1";
            button1.Size = new Size(225, 69);
            button1.TabIndex = 4;
            button1.Text = "Help";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Flat;
            label2.ForeColor = Color.Cyan;
            label2.Location = new Point(668, 304);
            label2.Name = "label2";
            label2.Size = new Size(141, 48);
            label2.TabIndex = 5;
            label2.Text = "Discord";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaptionText;
            textBox2.ForeColor = Color.Cyan;
            textBox2.Location = new Point(542, 355);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Type Here";
            textBox2.Size = new Size(375, 55);
            textBox2.TabIndex = 6;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // main
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1002, 848);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(close);
            Controls.Add(minimize);
            Name = "main";
            Theme = MetroFramework.MetroThemeStyle.Dark;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button minimize;
        private Button close;
        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private TextBox textBox2;
    }
}
