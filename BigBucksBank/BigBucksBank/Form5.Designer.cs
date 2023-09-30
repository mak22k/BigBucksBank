namespace BigBucksBank
{
    partial class Form5
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
            this.label1 = new System.Windows.Forms.Label();
            this.btReturnBal = new System.Windows.Forms.Button();
            this.btGetBal = new System.Windows.Forms.Button();
            this.txtBalBal = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Account";
            // 
            // btReturnBal
            // 
            this.btReturnBal.Location = new System.Drawing.Point(254, 280);
            this.btReturnBal.Name = "btReturnBal";
            this.btReturnBal.Size = new System.Drawing.Size(120, 39);
            this.btReturnBal.TabIndex = 12;
            this.btReturnBal.Text = "Return to Menu";
            this.btReturnBal.UseVisualStyleBackColor = true;
            this.btReturnBal.Click += new System.EventHandler(this.btReturnBal_Click);
            // 
            // btGetBal
            // 
            this.btGetBal.Location = new System.Drawing.Point(49, 280);
            this.btGetBal.Name = "btGetBal";
            this.btGetBal.Size = new System.Drawing.Size(120, 39);
            this.btGetBal.TabIndex = 1;
            this.btGetBal.Text = "Show Balance";
            this.btGetBal.UseVisualStyleBackColor = true;
            this.btGetBal.Click += new System.EventHandler(this.btGetBal_Click);
            // 
            // txtBalBal
            // 
            this.txtBalBal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalBal.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBalBal.Location = new System.Drawing.Point(222, 165);
            this.txtBalBal.Name = "txtBalBal";
            this.txtBalBal.ReadOnly = true;
            this.txtBalBal.Size = new System.Drawing.Size(152, 22);
            this.txtBalBal.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(222, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 388);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturnBal);
            this.Controls.Add(this.btGetBal);
            this.Controls.Add(this.txtBalBal);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBB - Check Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btReturnBal;
        private System.Windows.Forms.Button btGetBal;
        private System.Windows.Forms.TextBox txtBalBal;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}