namespace WindowsCusipTestor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tbFirstSix = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblCusip = new System.Windows.Forms.Label();
            this.tbNextTwo = new System.Windows.Forms.TextBox();
            this.tbSum = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblCharNums = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbFirstSix
            // 
            this.tbFirstSix.Location = new System.Drawing.Point(26, 21);
            this.tbFirstSix.MaxLength = 6;
            this.tbFirstSix.Name = "tbFirstSix";
            this.tbFirstSix.Size = new System.Drawing.Size(63, 23);
            this.tbFirstSix.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(169, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Validate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblCusip
            // 
            this.lblCusip.AutoSize = true;
            this.lblCusip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCusip.Location = new System.Drawing.Point(26, 54);
            this.lblCusip.Name = "lblCusip";
            this.lblCusip.Size = new System.Drawing.Size(40, 15);
            this.lblCusip.TabIndex = 2;
            this.lblCusip.Text = "label1";
            // 
            // tbNextTwo
            // 
            this.tbNextTwo.Location = new System.Drawing.Point(91, 21);
            this.tbNextTwo.MaxLength = 2;
            this.tbNextTwo.Name = "tbNextTwo";
            this.tbNextTwo.Size = new System.Drawing.Size(28, 23);
            this.tbNextTwo.TabIndex = 1;
            // 
            // tbSum
            // 
            this.tbSum.Location = new System.Drawing.Point(122, 21);
            this.tbSum.MaxLength = 1;
            this.tbSum.Name = "tbSum";
            this.tbSum.Size = new System.Drawing.Size(28, 23);
            this.tbSum.TabIndex = 2;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(32, 84);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(38, 15);
            this.lblText.TabIndex = 4;
            this.lblText.Text = "label2";
            this.lblText.Visible = false;
            // 
            // lblCharNums
            // 
            this.lblCharNums.AutoSize = true;
            this.lblCharNums.BackColor = System.Drawing.Color.Blue;
            this.lblCharNums.ForeColor = System.Drawing.Color.Yellow;
            this.lblCharNums.Location = new System.Drawing.Point(31, 118);
            this.lblCharNums.Name = "lblCharNums";
            this.lblCharNums.Size = new System.Drawing.Size(38, 15);
            this.lblCharNums.TabIndex = 5;
            this.lblCharNums.Text = "label1";
            this.lblCharNums.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 178);
            this.Controls.Add(this.lblCharNums);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.tbSum);
            this.Controls.Add(this.tbNextTwo);
            this.Controls.Add(this.lblCusip);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFirstSix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Windows Cusip Tester *chaswick*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstSix;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblCusip;
        private System.Windows.Forms.TextBox tbNextTwo;
        private System.Windows.Forms.TextBox tbSum;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Label lblCharNums;
    }
}

