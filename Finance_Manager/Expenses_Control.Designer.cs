namespace Finance_Manager
{
    partial class Expenses_Control
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
            this.tabExpenseList = new System.Windows.Forms.TabPage();
            this.tabExpense = new System.Windows.Forms.TabControl();
            this.tabRecordExpense = new System.Windows.Forms.TabPage();
            this.tabExpense.SuspendLayout();
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
            this.btnNewExpense.Location = new System.Drawing.Point(697, 15);
            this.btnNewExpense.Name = "btnNewExpense";
            this.btnNewExpense.Size = new System.Drawing.Size(169, 35);
            this.btnNewExpense.TabIndex = 4;
            this.btnNewExpense.Text = "+  New Expense";
            this.btnNewExpense.UseVisualStyleBackColor = false;
            // 
            // lblExpense
            // 
            this.lblExpense.AutoSize = true;
            this.lblExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpense.Location = new System.Drawing.Point(6, 19);
            this.lblExpense.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblExpense.Name = "lblExpense";
            this.lblExpense.Size = new System.Drawing.Size(103, 24);
            this.lblExpense.TabIndex = 3;
            this.lblExpense.Text = "Expenses";
            // 
            // tabExpenseList
            // 
            this.tabExpenseList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExpenseList.Location = new System.Drawing.Point(4, 27);
            this.tabExpenseList.Name = "tabExpenseList";
            this.tabExpenseList.Padding = new System.Windows.Forms.Padding(3);
            this.tabExpenseList.Size = new System.Drawing.Size(852, 362);
            this.tabExpenseList.TabIndex = 0;
            this.tabExpenseList.Text = "Expense List";
            this.tabExpenseList.UseVisualStyleBackColor = true;
            // 
            // tabExpense
            // 
            this.tabExpense.Controls.Add(this.tabExpenseList);
            this.tabExpense.Controls.Add(this.tabRecordExpense);
            this.tabExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabExpense.Location = new System.Drawing.Point(10, 91);
            this.tabExpense.Name = "tabExpense";
            this.tabExpense.SelectedIndex = 0;
            this.tabExpense.Size = new System.Drawing.Size(860, 393);
            this.tabExpense.TabIndex = 5;
            // 
            // tabRecordExpense
            // 
            this.tabRecordExpense.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRecordExpense.Location = new System.Drawing.Point(4, 27);
            this.tabRecordExpense.Name = "tabRecordExpense";
            this.tabRecordExpense.Padding = new System.Windows.Forms.Padding(3);
            this.tabRecordExpense.Size = new System.Drawing.Size(766, 362);
            this.tabRecordExpense.TabIndex = 1;
            this.tabRecordExpense.Text = "Record Expense";
            this.tabRecordExpense.UseVisualStyleBackColor = true;
            // 
            // Expenses_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNewExpense);
            this.Controls.Add(this.lblExpense);
            this.Controls.Add(this.tabExpense);
            this.Name = "Expenses_Control";
            this.Size = new System.Drawing.Size(873, 503);
            this.tabExpense.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewExpense;
        private System.Windows.Forms.Label lblExpense;
        private System.Windows.Forms.TabPage tabExpenseList;
        private System.Windows.Forms.TabControl tabExpense;
        private System.Windows.Forms.TabPage tabRecordExpense;
    }
}
