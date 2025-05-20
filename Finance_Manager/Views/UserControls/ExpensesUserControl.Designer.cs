namespace Finance_Manager
{
    partial class ExpensesUserControl
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
            this.btnNewExpense = new System.Windows.Forms.Button();
            this.lblExpense = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewExpense
            // 
            this.btnNewExpense.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNewExpense.FlatAppearance.BorderSize = 0;
            this.btnNewExpense.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNewExpense.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewExpense.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNewExpense.Location = new System.Drawing.Point(591, 15);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(259, 35);
            this.btnNewExpense.TabIndex = 4;
            this.btnNewExpense.Text = "+  New Expense Category";
            this.btnNewExpense.UseVisualStyleBackColor = false;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(22, 19);
            this.lblExpense.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(141, 24);
            this.lblExpense.TabIndex = 3;
            this.lblExpense.Text = "New Expense";
            // 
            // ExpensesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewExpense);
            this.Controls.Add(this.lblExpense);
            this.Name = "ExpensesUserControl";
            this.Size = new System.Drawing.Size(870, 520);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Label lblExpense;
    }
}
