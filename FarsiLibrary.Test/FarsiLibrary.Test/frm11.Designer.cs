namespace FarsiLibrary.Test
{
    partial class frm11
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
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faDatePicker2 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.faDatePickerConverter1 = new FarsiLibrary.Win.Controls.FADatePickerConverter();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(302, 9);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePicker1.Size = new System.Drawing.Size(227, 20);
            this.faDatePicker1.TabIndex = 0;
            this.faDatePicker1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faDatePicker1.SelectedDateTimeChanging += new FarsiLibrary.Win.Events.SelectedDateTimeChangingEventHandler(this.faDatePicker1_SelectedDateTimeChanging);
            // 
            // faDatePicker2
            // 
            this.faDatePicker2.Location = new System.Drawing.Point(302, 35);
            this.faDatePicker2.Name = "faDatePicker2";
            this.faDatePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePicker2.Size = new System.Drawing.Size(227, 20);
            this.faDatePicker2.TabIndex = 1;
            this.faDatePicker2.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faDatePicker2.SelectedDateTimeChanging += new FarsiLibrary.Win.Events.SelectedDateTimeChangingEventHandler(this.faDatePicker2_SelectedDateTimeChanging);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select a date prior to year 2000 : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select 20th Of a Month (Otherwise apply default)  : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // faDatePickerConverter1
            // 
            this.faDatePickerConverter1.Location = new System.Drawing.Point(302, 61);
            this.faDatePickerConverter1.Name = "faDatePickerConverter1";
            this.faDatePickerConverter1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePickerConverter1.Size = new System.Drawing.Size(227, 20);
            this.faDatePickerConverter1.TabIndex = 6;
            this.faDatePickerConverter1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.faDatePickerConverter1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faDatePickerConverter1.SelectedDateTimeChanging += new FarsiLibrary.Win.Events.SelectedDateTimeChangingEventHandler(this.faDatePickerConverter1_SelectedDateTimeChanging);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(9, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select 1385/04/08 : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frm11
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 98);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.faDatePickerConverter1);
            this.Controls.Add(this.faDatePicker2);
            this.Controls.Add(this.faDatePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm11";
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FarsiLibrary.Win.Controls.FADatePickerConverter faDatePickerConverter1;
        private System.Windows.Forms.Label label3;





    }
}