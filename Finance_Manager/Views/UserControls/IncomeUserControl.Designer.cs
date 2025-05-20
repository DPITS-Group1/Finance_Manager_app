namespace Finance_Manager
{
    partial class IncomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblIncome = new System.Windows.Forms.Label();
            this.btnNewIncome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIncome
            // 
            this.lblIncome.AutoSize = true;
            this.lblIncome.Location = new System.Drawing.Point(22, 19);
            this.lblIncome.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblIncome.Name = "lblIncome";
            this.lblIncome.Size = new System.Drawing.Size(139, 25);
            this.lblIncome.TabIndex = 0;
            this.lblIncome.Text = "New Income";
            // 
            // btnNewIncome
            // 
            this.btnNewIncome.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewIncome.FlatAppearance.BorderSize = 0;
            this.btnNewIncome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewIncome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewIncome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewIncome.Location = new System.Drawing.Point(634, 16);
            this.btnNewIncome.Name = "btnNewIncome";
            this.btnNewIncome.Size = new System.Drawing.Size(216, 35);
            this.btnNewIncome.TabIndex = 1;
            this.btnNewIncome.Text = "+  New Income Category";
            this.btnNewIncome.UseVisualStyleBackColor = false;
            // 
            // IncomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewIncome);
            this.Controls.Add(this.lblIncome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "IncomeUserControl";
            this.Size = new System.Drawing.Size(870, 520);
            this.Load += new System.EventHandler(this.Income_Control_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncome;
        private System.Windows.Forms.Button btnNewIncome;
    }
}
