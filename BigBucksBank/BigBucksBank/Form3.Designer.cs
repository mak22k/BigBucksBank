namespace BigBucksBank
{
    partial class Form3
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
            this.txtBalDep = new System.Windows.Forms.TextBox();
            this.txtAmtDep = new System.Windows.Forms.TextBox();
            this.btCalcDep = new System.Windows.Forms.Button();
            this.btReturnDep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtBalDep
            // 
            this.txtBalDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalDep.Cursor = System.Windows.Forms.Cursors.No;
            this.txtBalDep.Location = new System.Drawing.Point(257, 175);
            this.txtBalDep.Name = "txtBalDep";
            this.txtBalDep.ReadOnly = true;
            this.txtBalDep.Size = new System.Drawing.Size(152, 22);
            this.txtBalDep.TabIndex = 1;
            // 
            // txtAmtDep
            // 
            this.txtAmtDep.Location = new System.Drawing.Point(257, 108);
            this.txtAmtDep.Name = "txtAmtDep";
            this.txtAmtDep.Size = new System.Drawing.Size(152, 22);
            this.txtAmtDep.TabIndex = 1;
            // 
            // btCalcDep
            // 
            this.btCalcDep.Location = new System.Drawing.Point(84, 301);
            this.btCalcDep.Name = "btCalcDep";
            this.btCalcDep.Size = new System.Drawing.Size(120, 39);
            this.btCalcDep.TabIndex = 2;
            this.btCalcDep.Text = "Calculate";
            this.btCalcDep.UseVisualStyleBackColor = true;
            this.btCalcDep.Click += new System.EventHandler(this.btCalcDep_Click);
            // 
            // btReturnDep
            // 
            this.btReturnDep.Location = new System.Drawing.Point(289, 301);
            this.btReturnDep.Name = "btReturnDep";
            this.btReturnDep.Size = new System.Drawing.Size(120, 39);
            this.btReturnDep.TabIndex = 4;
            this.btReturnDep.Text = "Return to Menu";
            this.btReturnDep.UseVisualStyleBackColor = true;
            this.btReturnDep.Click += new System.EventHandler(this.btReturnDep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Account";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Deposit Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Balance";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(257, 54);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 394);
            this.ControlBox = false;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btReturnDep);
            this.Controls.Add(this.btCalcDep);
            this.Controls.Add(this.txtAmtDep);
            this.Controls.Add(this.txtBalDep);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BBB - Deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBalDep;
        private System.Windows.Forms.TextBox txtAmtDep;
        private System.Windows.Forms.Button btCalcDep;
        private System.Windows.Forms.Button btReturnDep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}