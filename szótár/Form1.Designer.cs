﻿namespace szótár
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
            label1 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            listBox2 = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 13);
            label1.Name = "label1";
            label1.Size = new Size(236, 20);
            label1.TabIndex = 0;
            label1.Text = "Keresett szó (angol, vagy magyar):";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(185, 27);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(211, 36);
            button1.Name = "button1";
            button1.Size = new Size(37, 29);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 3;
            label2.Text = "Fordítás:";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(308, 36);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(333, 164);
            listBox1.TabIndex = 4;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(308, 13);
            label3.Name = "label3";
            label3.Size = new Size(142, 20);
            label3.TabIndex = 5;
            label3.Text = "Angol szavak listája:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(308, 231);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 7;
            label4.Text = "Magyar szavak listája:";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(308, 254);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(333, 164);
            listBox2.TabIndex = 6;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 454);
            Controls.Add(label4);
            Controls.Add(listBox2);
            Controls.Add(label3);
            Controls.Add(listBox1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button button1;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private ListBox listBox2;
    }
}
