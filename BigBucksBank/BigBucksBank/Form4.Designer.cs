namespace BigBucksBank
{
    partial class Form4
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btReturnWith = new System.Windows.Forms.Button();
            this.btCalculateWith = new System.Windows.Forms.Button();
            this.txtAmtWith = new System.Windows.Forms.TextBox();
            this.txtBalWith = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(145, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Withdrawal Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Account";
            // 
            // btReturnWith
            // 
            this.btReturnWith.Location = new System.Drawing.Point(312, 309);
            this.btReturnWith.Name = "btReturnWith";
            this.btReturnWith.Size = new System.Drawing.Size(120, 39);
            this.btReturnWith.TabIndex = 12;
            this.btReturnWith.Text = "Return to Menu";
            this.btReturnWith.UseVisualStyleBackColor = true;
            this.btReturnWith.Click += new System.EventHandler(this.btReturnWith_Click);
            // 
            // btCalculateWith
            // 
            this.btCalculateWith.Location = new System.Drawing.Point(107, 309);
            this.btCalculateWith.Name = "btCalculateWith";
            this.btCalculateWith.Size = new System.Drawing.Size(120, 39);
            this.btCalculateWith.TabIndex = 2;
            this.btCalculateWith.Text = "Calculate";
            this.btCalculateWith.UseVisualStyleBackColor = true;
            this.btCalculateWith.Click += new System.EventHandler(this.btCalcWithdraw_Click);
            // 
            // txtAmtWith
            // 
            this.txtAmtWith.Location = new System.Drawing.Point(280, 116);
            this.txtAmtWith.Name = "txtAmtWith";
            this.txtAmtWith.Size = new System.Drawing.Size(152, 22);
            this.txtAmtWith.TabIndex = 1;
            this.txtAmtWith.Tag = "Withdrawl Amount";
            // 
            // txtBalWith
            // 
            this.txtBalWith.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalWith.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBalWith.Location = new System.Drawing.Point(280, 183);
            this.txtBalWith.Name = "txtBalWith";
            this.txtBalWith.ReadOnly = true;
            this.txtBalWith.Size = new System.Drawing.Size(152, 22);
            this.txtBalWith.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 409);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturnWith);
            this.Controls.Add(this.btCalculateWith);
            this.Controls.Add(this.txtAmtWith);
            this.Controls.Add(this.txtBalWith);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBB - Withdrawal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReturnWith;
        private System.Windows.Forms.Button btCalculateWith;
        private System.Windows.Forms.TextBox txtAmtWith;
        private System.Windows.Forms.TextBox txtBalWith;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}