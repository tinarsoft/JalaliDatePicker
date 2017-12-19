namespace FarsiLibrary.Test
{
    partial class frm03
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
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faDatePickerConverter1 = new FarsiLibrary.Win.Controls.FADatePickerConverter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.faDatePickerConverter2 = new FarsiLibrary.Win.Controls.FADatePickerConverter();
            this.faDatePicker2 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Right To Left : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(14, 38);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(213, 22);
            this.faDatePicker1.TabIndex = 1;
            this.faDatePicker1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // faDatePickerConverter1
            // 
            this.faDatePickerConverter1.Location = new System.Drawing.Point(14, 67);
            this.faDatePickerConverter1.Name = "faDatePickerConverter1";
            this.faDatePickerConverter1.Size = new System.Drawing.Size(213, 22);
            this.faDatePickerConverter1.TabIndex = 2;
            this.faDatePickerConverter1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.faDatePickerConverter1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(9, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 2);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(14, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Left To Right : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // faDatePickerConverter2
            // 
            this.faDatePickerConverter2.Location = new System.Drawing.Point(17, 200);
            this.faDatePickerConverter2.Name = "faDatePickerConverter2";
            this.faDatePickerConverter2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePickerConverter2.Size = new System.Drawing.Size(213, 22);
            this.faDatePickerConverter2.TabIndex = 6;
            this.faDatePickerConverter2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.faDatePickerConverter2.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // faDatePicker2
            // 
            this.faDatePicker2.Location = new System.Drawing.Point(17, 171);
            this.faDatePicker2.Name = "faDatePicker2";
            this.faDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePicker2.Size = new System.Drawing.Size(213, 22);
            this.faDatePicker2.TabIndex = 5;
            this.faDatePicker2.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // frm03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 238);
            this.Controls.Add(this.faDatePickerConverter2);
            this.Controls.Add(this.faDatePicker2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.faDatePickerConverter1);
            this.Controls.Add(this.faDatePicker1);
            this.Controls.Add(this.label1);
            this.Name = "frm03";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private FarsiLibrary.Win.Controls.FADatePickerConverter faDatePickerConverter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private FarsiLibrary.Win.Controls.FADatePickerConverter faDatePickerConverter2;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker2;
    }
}