namespace BigBucksBank
{
    partial class Form2
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
            this.textBoxF2 = new System.Windows.Forms.TextBox();
            this.rdDeposit = new System.Windows.Forms.RadioButton();
            this.rbWithdraw = new System.Windows.Forms.RadioButton();
            this.rbBalance = new System.Windows.Forms.RadioButton();
            this.rbTransfer = new System.Windows.Forms.RadioButton();
            this.rbExit = new System.Windows.Forms.RadioButton();
            this.gbMenu = new System.Windows.Forms.GroupBox();
            this.gbMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxF2
            // 
            this.textBoxF2.BackColor = System.Drawing.Color.Chartreuse;
            this.textBoxF2.Cursor = System.Windows.Forms.Cursors.No;
            this.textBoxF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxF2.Location = new System.Drawing.Point(137, 40);
            this.textBoxF2.Multiline = true;
            this.textBoxF2.Name = "textBoxF2";
            this.textBoxF2.ReadOnly = true;
            this.textBoxF2.Size = new System.Drawing.Size(213, 44);
            this.textBoxF2.TabIndex = 1;
            this.textBoxF2.TabStop = false;
            this.textBoxF2.Text = "Main Menu";
            this.textBoxF2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rdDeposit
            // 
            this.rdDeposit.AutoSize = true;
            this.rdDeposit.Location = new System.Drawing.Point(17, 9);
            this.rdDeposit.Name = "rdDeposit";
            this.rdDeposit.Size = new System.Drawing.Size(127, 21);
            this.rdDeposit.TabIndex = 5;
            this.rdDeposit.Text = "Make a Deposit";
            this.rdDeposit.UseVisualStyleBackColor = true;
            this.rdDeposit.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // rbWithdraw
            // 
            this.rbWithdraw.AutoSize = true;
            this.rbWithdraw.Location = new System.Drawing.Point(17, 50);
            this.rbWithdraw.Name = "rbWithdraw";
            this.rbWithdraw.Size = new System.Drawing.Size(148, 21);
            this.rbWithdraw.TabIndex = 6;
            this.rbWithdraw.Text = "Make a Withdrawal";
            this.rbWithdraw.UseVisualStyleBackColor = true;
            this.rbWithdraw.Click += new System.EventHandler(this.rbWithdraw_Click);
            // 
            // rbBalance
            // 
            this.rbBalance.AutoSize = true;
            this.rbBalance.Location = new System.Drawing.Point(17, 97);
            this.rbBalance.Name = "rbBalance";
            this.rbBalance.Size = new System.Drawing.Size(123, 21);
            this.rbBalance.TabIndex = 7;
            this.rbBalance.Text = "Check Balance";
            this.rbBalance.UseVisualStyleBackColor = true;
            this.rbBalance.Click += new System.EventHandler(this.rbBalance_Click);
            // 
            // rbTransfer
            // 
            this.rbTransfer.AutoSize = true;
            this.rbTransfer.Location = new System.Drawing.Point(17, 141);
            this.rbTransfer.Name = "rbTransfer";
            this.rbTransfer.Size = new System.Drawing.Size(126, 21);
            this.rbTransfer.TabIndex = 8;
            this.rbTransfer.Text = "Transfer Funds";
            this.rbTransfer.UseVisualStyleBackColor = true;
            this.rbTransfer.Click += new System.EventHandler(this.rbTransfer_Click);
            // 
            // rbExit
            // 
            this.rbExit.AutoSize = true;
            this.rbExit.Location = new System.Drawing.Point(17, 206);
            this.rbExit.Name = "rbExit";
            this.rbExit.Size = new System.Drawing.Size(51, 21);
            this.rbExit.TabIndex = 9;
            this.rbExit.Text = "Exit";
            this.rbExit.UseVisualStyleBackColor = true;
            this.rbExit.Click += new System.EventHandler(this.rbExit_Click);
            // 
            // gbMenu
            // 
            this.gbMenu.Controls.Add(this.rbExit);
            this.gbMenu.Controls.Add(this.rbTransfer);
            this.gbMenu.Controls.Add(this.rbBalance);
            this.gbMenu.Controls.Add(this.rbWithdraw);
            this.gbMenu.Controls.Add(this.rdDeposit);
            this.gbMenu.Location = new System.Drawing.Point(159, 157);
            this.gbMenu.Name = "gbMenu";
            this.gbMenu.Size = new System.Drawing.Size(181, 241);
            this.gbMenu.TabIndex = 2;
            this.gbMenu.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.ControlBox = false;
            this.Controls.Add(this.gbMenu);
            this.Controls.Add(this.textBoxF2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBB - Main Menu";
            this.gbMenu.ResumeLayout(false);
            this.gbMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxF2;
        private System.Windows.Forms.RadioButton rdDeposit;
        private System.Windows.Forms.RadioButton rbWithdraw;
        private System.Windows.Forms.RadioButton rbBalance;
        private System.Windows.Forms.RadioButton rbTransfer;
        private System.Windows.Forms.RadioButton rbExit;
        private System.Windows.Forms.GroupBox gbMenu;
    }
}