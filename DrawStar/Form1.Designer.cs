namespace DrawStar
{
    partial class mainDisplay
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
            this.starButton = new System.Windows.Forms.Button();
            this.xvalueInput = new System.Windows.Forms.MaskedTextBox();
            this.yvalueInput = new System.Windows.Forms.MaskedTextBox();
            this.scaleInput = new System.Windows.Forms.MaskedTextBox();
            this.displayLabelO = new System.Windows.Forms.Label();
            this.displayTwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // starButton
            // 
            this.starButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.starButton.Location = new System.Drawing.Point(534, 112);
            this.starButton.Name = "starButton";
            this.starButton.Size = new System.Drawing.Size(75, 23);
            this.starButton.TabIndex = 0;
            this.starButton.Text = "Draw Star";
            this.starButton.UseVisualStyleBackColor = false;
            this.starButton.Click += new System.EventHandler(this.starButton_Click);
            // 
            // xvalueInput
            // 
            this.xvalueInput.Location = new System.Drawing.Point(568, 12);
            this.xvalueInput.Name = "xvalueInput";
            this.xvalueInput.Size = new System.Drawing.Size(41, 20);
            this.xvalueInput.TabIndex = 1;
            // 
            // yvalueInput
            // 
            this.yvalueInput.Location = new System.Drawing.Point(568, 38);
            this.yvalueInput.Name = "yvalueInput";
            this.yvalueInput.Size = new System.Drawing.Size(41, 20);
            this.yvalueInput.TabIndex = 2;
            // 
            // scaleInput
            // 
            this.scaleInput.Location = new System.Drawing.Point(568, 64);
            this.scaleInput.Name = "scaleInput";
            this.scaleInput.Size = new System.Drawing.Size(41, 20);
            this.scaleInput.TabIndex = 3;
            // 
            // displayLabelO
            // 
            this.displayLabelO.AutoSize = true;
            this.displayLabelO.Location = new System.Drawing.Point(521, 15);
            this.displayLabelO.Name = "displayLabelO";
            this.displayLabelO.Size = new System.Drawing.Size(41, 13);
            this.displayLabelO.TabIndex = 4;
            this.displayLabelO.Text = "x value";
            // 
            // displayTwo
            // 
            this.displayTwo.AutoSize = true;
            this.displayTwo.Location = new System.Drawing.Point(521, 41);
            this.displayTwo.Name = "displayTwo";
            this.displayTwo.Size = new System.Drawing.Size(41, 13);
            this.displayTwo.TabIndex = 5;
            this.displayTwo.Text = "y value";
            // 
            // mainDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(621, 391);
            this.Controls.Add(this.displayTwo);
            this.Controls.Add(this.displayLabelO);
            this.Controls.Add(this.scaleInput);
            this.Controls.Add(this.yvalueInput);
            this.Controls.Add(this.xvalueInput);
            this.Controls.Add(this.starButton);
            this.Name = "mainDisplay";
            this.Text = "Draw Star";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button starButton;
        private System.Windows.Forms.MaskedTextBox xvalueInput;
        private System.Windows.Forms.MaskedTextBox yvalueInput;
        private System.Windows.Forms.MaskedTextBox scaleInput;
        private System.Windows.Forms.Label displayLabelO;
        private System.Windows.Forms.Label displayTwo;
    }
}

