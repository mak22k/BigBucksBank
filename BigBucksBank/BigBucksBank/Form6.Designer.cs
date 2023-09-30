namespace BigBucksBank
{
    partial class Form6
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
            this.btReturnTransfer = new System.Windows.Forms.Button();
            this.btCalcTransfer = new System.Windows.Forms.Button();
            this.txtAmtTransfer = new System.Windows.Forms.TextBox();
            this.txtSourceBal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDestBal = new System.Windows.Forms.TextBox();
            this.cbFrom = new System.Windows.Forms.ComboBox();
            this.cbTo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Source Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter Transfer Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "From Account";
            // 
            // btReturnTransfer
            // 
            this.btReturnTransfer.Location = new System.Drawing.Point(296, 359);
            this.btReturnTransfer.Name = "btReturnTransfer";
            this.btReturnTransfer.Size = new System.Drawing.Size(120, 39);
            this.btReturnTransfer.TabIndex = 12;
            this.btReturnTransfer.Text = "Return to Menu";
            this.btReturnTransfer.UseVisualStyleBackColor = true;
            this.btReturnTransfer.Click += new System.EventHandler(this.btReturnTransfer_Click);
            // 
            // btCalcTransfer
            // 
            this.btCalcTransfer.Location = new System.Drawing.Point(91, 359);
            this.btCalcTransfer.Name = "btCalcTransfer";
            this.btCalcTransfer.Size = new System.Drawing.Size(120, 39);
            this.btCalcTransfer.TabIndex = 3;
            this.btCalcTransfer.Text = "Calculate";
            this.btCalcTransfer.UseVisualStyleBackColor = true;
            this.btCalcTransfer.Click += new System.EventHandler(this.btCalcTransfer_Click);
            // 
            // txtAmtTransfer
            // 
            this.txtAmtTransfer.Location = new System.Drawing.Point(264, 145);
            this.txtAmtTransfer.Name = "txtAmtTransfer";
            this.txtAmtTransfer.Size = new System.Drawing.Size(152, 22);
            this.txtAmtTransfer.TabIndex = 2;
            this.txtAmtTransfer.Tag = "Transfer Amount";
            // 
            // txtSourceBal
            // 
            this.txtSourceBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtSourceBal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtSourceBal.Location = new System.Drawing.Point(264, 226);
            this.txtSourceBal.Name = "txtSourceBal";
            this.txtSourceBal.ReadOnly = true;
            this.txtSourceBal.Size = new System.Drawing.Size(152, 22);
            this.txtSourceBal.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(108, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "To Account";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Destination Balance";
            // 
            // txtDestBal
            // 
            this.txtDestBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtDestBal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDestBal.Location = new System.Drawing.Point(264, 272);
            this.txtDestBal.Name = "txtDestBal";
            this.txtDestBal.ReadOnly = true;
            this.txtDestBal.Size = new System.Drawing.Size(152, 22);
            this.txtDestBal.TabIndex = 18;
            this.txtDestBal.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cbFrom
            // 
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.Location = new System.Drawing.Point(264, 56);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.Size = new System.Drawing.Size(152, 24);
            this.cbFrom.TabIndex = 0;
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.Location = new System.Drawing.Point(264, 101);
            this.cbTo.Name = "cbTo";
            this.cbTo.Size = new System.Drawing.Size(152, 24);
            this.cbTo.TabIndex = 1;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 450);
            this.ControlBox = false;
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDestBal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturnTransfer);
            this.Controls.Add(this.btCalcTransfer);
            this.Controls.Add(this.txtAmtTransfer);
            this.Controls.Add(this.txtSourceBal);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBB - Transfer Funds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReturnTransfer;
        private System.Windows.Forms.Button btCalcTransfer;
        private System.Windows.Forms.TextBox txtAmtTransfer;
        private System.Windows.Forms.TextBox txtSourceBal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDestBal;
        private System.Windows.Forms.ComboBox cbFrom;
        private System.Windows.Forms.ComboBox cbTo;
    }
}