﻿namespace NoteApp
{
    partial class MainMenu
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
            button1 = new Button();
            ListsDropDown = new ComboBox();
            button2 = new Button();
            textBox1 = new TextBox();
            button3 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(348, 173);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "AddList";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ListsDropDown
            // 
            ListsDropDown.DropDownStyle = ComboBoxStyle.DropDownList;
            ListsDropDown.FormattingEnabled = true;
            ListsDropDown.Location = new Point(584, 174);
            ListsDropDown.Name = "ListsDropDown";
            ListsDropDown.Size = new Size(151, 28);
            ListsDropDown.TabIndex = 1;
            // 
            // button2
            // 
            button2.Location = new Point(667, 409);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 2;
            button2.Text = "Create New NoteBook";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CreateButton;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(337, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(567, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "Select";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.Location = new Point(685, 12);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 5;
            button5.Text = "close";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CloseButton;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(ListsDropDown);
            Controls.Add(button1);
            Name = "MainMenu";
            Text = "MainMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private ComboBox ListsDropDown;
        private Button button2;
        private TextBox textBox1;
        private Button button3;
        private Button button4;
        private Button button5;
    }
}