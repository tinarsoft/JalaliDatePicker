namespace FarsiLibrary.Test
{
    partial class frm09
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.faDatePickerConverter = new FarsiLibrary.Win.Controls.FADatePickerConverter();
            this.faMonthView = new FarsiLibrary.Win.Controls.FAMonthView();
            this.faDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(8, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 21);
            this.label6.TabIndex = 27;
            this.label6.Text = "Birth Date : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(321, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "Birth Date : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(100, 81);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(200, 22);
            this.txtFirstname.TabIndex = 22;
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(100, 52);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(200, 22);
            this.txtLastname.TabIndex = 21;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(100, 23);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(53, 22);
            this.txtID.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(8, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 19;
            this.label4.Text = "Hire Date : ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(8, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 18;
            this.label3.Text = "Firstname : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 17;
            this.label2.Text = "Lastname : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID : ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridView
            // 
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Location = new System.Drawing.Point(11, 204);
            this.gridView.MultiSelect = false;
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.Size = new System.Drawing.Size(569, 150);
            this.gridView.TabIndex = 15;
            // 
            // faDatePickerConverter
            // 
            this.faDatePickerConverter.ButtonImage = global::FarsiLibrary.Test.Properties.Resources.Redo;
            this.faDatePickerConverter.CalendarType = FarsiLibrary.Win.Enums.CalendarTypes.English;
            this.faDatePickerConverter.Location = new System.Drawing.Point(100, 136);
            this.faDatePickerConverter.Name = "faDatePickerConverter";
            this.faDatePickerConverter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePickerConverter.Size = new System.Drawing.Size(200, 20);
            this.faDatePickerConverter.TabIndex = 26;
            this.faDatePickerConverter.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.faDatePickerConverter.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // faMonthView
            // 
            this.faMonthView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faMonthView.IsMultiSelect = true;
            this.faMonthView.IsNull = false;
            this.faMonthView.Location = new System.Drawing.Point(398, 23);
            this.faMonthView.Name = "faMonthView";
            this.faMonthView.SelectedDateTime = new System.DateTime(2006, 5, 28, 16, 2, 46, 262);
            this.faMonthView.TabIndex = 24;
            this.faMonthView.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // faDatePicker
            // 
            this.faDatePicker.Location = new System.Drawing.Point(100, 110);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePicker.Size = new System.Drawing.Size(200, 20);
            this.faDatePicker.TabIndex = 23;
            this.faDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // frm09
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 366);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.faDatePickerConverter);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.faMonthView);
            this.Controls.Add(this.faDatePicker);
            this.Controls.Add(this.txtFirstname);
            this.Controls.Add(this.txtLastname);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridView);
            this.Name = "frm09";
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private FarsiLibrary.Win.Controls.FADatePickerConverter faDatePickerConverter;
        private System.Windows.Forms.Label label5;
        private FarsiLibrary.Win.Controls.FAMonthView faMonthView;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridView;
    }
}