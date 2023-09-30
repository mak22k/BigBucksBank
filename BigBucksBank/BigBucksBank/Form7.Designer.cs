namespace BigBucksBank
{
    partial class Form7
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
            this.label1 = new System.Windows.Forms.Label();
            this.btReturnWith = new System.Windows.Forms.Button();
            this.txtCustNum = new System.Windows.Forms.TextBox();
            this.txtReceiptDetails = new System.Windows.Forms.TextBox();
            this.txtReceiptMoney = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Customer ID";
            // 
            // btReturnWith
            // 
            this.btReturnWith.Location = new System.Drawing.Point(499, 16);
            this.btReturnWith.Name = "btReturnWith";
            this.btReturnWith.Size = new System.Drawing.Size(120, 29);
            this.btReturnWith.TabIndex = 0;
            this.btReturnWith.Text = "Return to Menu";
            this.btReturnWith.UseVisualStyleBackColor = true;
            this.btReturnWith.Click += new System.EventHandler(this.btReturnWith_Click);
            // 
            // txtCustNum
            // 
            this.txtCustNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtCustNum.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCustNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustNum.Location = new System.Drawing.Point(117, 19);
            this.txtCustNum.Name = "txtCustNum";
            this.txtCustNum.Size = new System.Drawing.Size(370, 27);
            this.txtCustNum.TabIndex = 16;
            // 
            // txtReceiptDetails
            // 
            this.txtReceiptDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReceiptDetails.Cursor = System.Windows.Forms.Cursors.No;
            this.txtReceiptDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptDetails.Location = new System.Drawing.Point(29, 80);
            this.txtReceiptDetails.Multiline = true;
            this.txtReceiptDetails.Name = "txtReceiptDetails";
            this.txtReceiptDetails.Size = new System.Drawing.Size(458, 378);
            this.txtReceiptDetails.TabIndex = 28;
            // 
            // txtReceiptMoney
            // 
            this.txtReceiptMoney.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtReceiptMoney.Cursor = System.Windows.Forms.Cursors.No;
            this.txtReceiptMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReceiptMoney.Location = new System.Drawing.Point(493, 80);
            this.txtReceiptMoney.Multiline = true;
            this.txtReceiptMoney.Name = "txtReceiptMoney";
            this.txtReceiptMoney.Size = new System.Drawing.Size(126, 378);
            this.txtReceiptMoney.TabIndex = 29;
            this.txtReceiptMoney.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 483);
            this.ControlBox = false;
            this.Controls.Add(this.txtReceiptMoney);
            this.Controls.Add(this.txtReceiptDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturnWith);
            this.Controls.Add(this.txtCustNum);
            this.Name = "Form7";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBB - Receipt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReturnWith;
        private System.Windows.Forms.TextBox txtCustNum;
        private System.Windows.Forms.TextBox txtReceiptDetails;
        private System.Windows.Forms.TextBox txtReceiptMoney;
    }
}