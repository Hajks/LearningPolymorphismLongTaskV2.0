namespace LearningPolymorphismLongTaskV2._0
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.goThere = new System.Windows.Forms.Button();
            this.goThrough = new System.Windows.Forms.Button();
            this.exitsBox = new System.Windows.Forms.ComboBox();
            this.checkButton = new System.Windows.Forms.Button();
            this.hideButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(357, 201);
            this.textBox1.TabIndex = 0;
            // 
            // goThere
            // 
            this.goThere.Location = new System.Drawing.Point(13, 230);
            this.goThere.Name = "goThere";
            this.goThere.Size = new System.Drawing.Size(75, 21);
            this.goThere.TabIndex = 1;
            this.goThere.Text = "Idź tutaj:";
            this.goThere.UseVisualStyleBackColor = true;
            this.goThere.Click += new System.EventHandler(this.goThere_Click);
            // 
            // goThrough
            // 
            this.goThrough.Location = new System.Drawing.Point(12, 259);
            this.goThrough.Name = "goThrough";
            this.goThrough.Size = new System.Drawing.Size(357, 21);
            this.goThrough.TabIndex = 2;
            this.goThrough.Text = "Przejdź przez drzwi";
            this.goThrough.UseVisualStyleBackColor = true;
            this.goThrough.Click += new System.EventHandler(this.goThrough_Click);
            // 
            // exitsBox
            // 
            this.exitsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exitsBox.FormattingEnabled = true;
            this.exitsBox.Location = new System.Drawing.Point(109, 230);
            this.exitsBox.Name = "exitsBox";
            this.exitsBox.Size = new System.Drawing.Size(260, 21);
            this.exitsBox.TabIndex = 3;
            // 
            // checkButton
            // 
            this.checkButton.Location = new System.Drawing.Point(12, 286);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(357, 21);
            this.checkButton.TabIndex = 5;
            this.checkButton.Text = "----";
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // hideButton
            // 
            this.hideButton.Location = new System.Drawing.Point(13, 312);
            this.hideButton.Name = "hideButton";
            this.hideButton.Size = new System.Drawing.Size(357, 21);
            this.hideButton.TabIndex = 6;
            this.hideButton.Text = "Kryj się!";
            this.hideButton.UseVisualStyleBackColor = true;
            this.hideButton.Click += new System.EventHandler(this.hideButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 345);
            this.Controls.Add(this.hideButton);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.exitsBox);
            this.Controls.Add(this.goThrough);
            this.Controls.Add(this.goThere);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Dom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button goThere;
        private System.Windows.Forms.Button goThrough;
        private System.Windows.Forms.ComboBox exitsBox;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Button hideButton;
    }
}

