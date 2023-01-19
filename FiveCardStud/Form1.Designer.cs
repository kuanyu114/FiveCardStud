namespace FiveCardStud
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
            this.Suit1 = new System.Windows.Forms.ComboBox();
            this.Suit2 = new System.Windows.Forms.ComboBox();
            this.Suit3 = new System.Windows.Forms.ComboBox();
            this.Suit4 = new System.Windows.Forms.ComboBox();
            this.Suit5 = new System.Windows.Forms.ComboBox();
            this.Rank1 = new System.Windows.Forms.ComboBox();
            this.Rank2 = new System.Windows.Forms.ComboBox();
            this.Rank3 = new System.Windows.Forms.ComboBox();
            this.Rank4 = new System.Windows.Forms.ComboBox();
            this.Rank5 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Suit1
            // 
            this.Suit1.FormattingEnabled = true;
            this.Suit1.Location = new System.Drawing.Point(94, 83);
            this.Suit1.Name = "Suit1";
            this.Suit1.Size = new System.Drawing.Size(121, 23);
            this.Suit1.TabIndex = 0;
            // 
            // Suit2
            // 
            this.Suit2.FormattingEnabled = true;
            this.Suit2.Location = new System.Drawing.Point(94, 125);
            this.Suit2.Name = "Suit2";
            this.Suit2.Size = new System.Drawing.Size(121, 23);
            this.Suit2.TabIndex = 1;
            // 
            // Suit3
            // 
            this.Suit3.FormattingEnabled = true;
            this.Suit3.Location = new System.Drawing.Point(94, 166);
            this.Suit3.Name = "Suit3";
            this.Suit3.Size = new System.Drawing.Size(121, 23);
            this.Suit3.TabIndex = 2;
            // 
            // Suit4
            // 
            this.Suit4.FormattingEnabled = true;
            this.Suit4.Location = new System.Drawing.Point(94, 211);
            this.Suit4.Name = "Suit4";
            this.Suit4.Size = new System.Drawing.Size(121, 23);
            this.Suit4.TabIndex = 3;
            // 
            // Suit5
            // 
            this.Suit5.FormattingEnabled = true;
            this.Suit5.Location = new System.Drawing.Point(94, 258);
            this.Suit5.Name = "Suit5";
            this.Suit5.Size = new System.Drawing.Size(121, 23);
            this.Suit5.TabIndex = 4;
            // 
            // Rank1
            // 
            this.Rank1.FormattingEnabled = true;
            this.Rank1.Location = new System.Drawing.Point(249, 83);
            this.Rank1.Name = "Rank1";
            this.Rank1.Size = new System.Drawing.Size(121, 23);
            this.Rank1.TabIndex = 5;
            // 
            // Rank2
            // 
            this.Rank2.FormattingEnabled = true;
            this.Rank2.Location = new System.Drawing.Point(249, 125);
            this.Rank2.Name = "Rank2";
            this.Rank2.Size = new System.Drawing.Size(121, 23);
            this.Rank2.TabIndex = 6;
            // 
            // Rank3
            // 
            this.Rank3.FormattingEnabled = true;
            this.Rank3.Location = new System.Drawing.Point(249, 166);
            this.Rank3.Name = "Rank3";
            this.Rank3.Size = new System.Drawing.Size(121, 23);
            this.Rank3.TabIndex = 7;
            // 
            // Rank4
            // 
            this.Rank4.FormattingEnabled = true;
            this.Rank4.Location = new System.Drawing.Point(249, 211);
            this.Rank4.Name = "Rank4";
            this.Rank4.Size = new System.Drawing.Size(121, 23);
            this.Rank4.TabIndex = 8;
            // 
            // Rank5
            // 
            this.Rank5.FormattingEnabled = true;
            this.Rank5.Location = new System.Drawing.Point(249, 258);
            this.Rank5.Name = "Rank5";
            this.Rank5.Size = new System.Drawing.Size(121, 23);
            this.Rank5.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "隨機發牌";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "顯示牌面結果";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Card1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Card2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Card3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Card4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 266);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Card5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 413);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Rank5);
            this.Controls.Add(this.Rank4);
            this.Controls.Add(this.Rank3);
            this.Controls.Add(this.Rank2);
            this.Controls.Add(this.Rank1);
            this.Controls.Add(this.Suit5);
            this.Controls.Add(this.Suit4);
            this.Controls.Add(this.Suit3);
            this.Controls.Add(this.Suit2);
            this.Controls.Add(this.Suit1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox Suit1;
        private ComboBox Suit2;
        private ComboBox Suit3;
        private ComboBox Suit4;
        private ComboBox Suit5;
        private ComboBox Rank1;
        private ComboBox Rank2;
        private ComboBox Rank3;
        private ComboBox Rank4;
        private ComboBox Rank5;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}