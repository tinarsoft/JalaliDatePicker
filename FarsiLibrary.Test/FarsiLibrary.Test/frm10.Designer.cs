namespace FarsiLibrary.Test
{
    partial class frm10
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
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnDefault = new System.Windows.Forms.Button();
            this.faDatePickerConverter = new FarsiLibrary.Win.Controls.FADatePickerConverter();
            this.faDatePicker = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faMonthView = new FarsiLibrary.Win.Controls.FAMonthView();
            this.SuspendLayout();
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(12, 9);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(148, 53);
            this.btnCustom.TabIndex = 4;
            this.btnCustom.Text = "Custom Localizer  (ES-ES Culture)";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(12, 64);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(148, 53);
            this.btnDefault.TabIndex = 5;
            this.btnDefault.Text = "Default Localizer (Thread\'s Culture)";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // faDatePickerConverter
            // 
            this.faDatePickerConverter.Location = new System.Drawing.Point(180, 12);
            this.faDatePickerConverter.Name = "faDatePickerConverter";
            this.faDatePickerConverter.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePickerConverter.Size = new System.Drawing.Size(231, 20);
            this.faDatePickerConverter.TabIndex = 3;
            this.faDatePickerConverter.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.faDatePickerConverter.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // faDatePicker
            // 
            this.faDatePicker.Location = new System.Drawing.Point(180, 38);
            this.faDatePicker.Name = "faDatePicker";
            this.faDatePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.faDatePicker.Size = new System.Drawing.Size(231, 20);
            this.faDatePicker.TabIndex = 2;
            this.faDatePicker.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // faMonthView
            // 
            this.faMonthView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faMonthView.IsNull = false;
            this.faMonthView.Location = new System.Drawing.Point(213, 64);
            this.faMonthView.Name = "faMonthView";
            this.faMonthView.SelectedDateTime = new System.DateTime(2006, 6, 6, 12, 38, 28, 728);
            this.faMonthView.TabIndex = 0;
            this.faMonthView.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // frm10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 243);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.faDatePickerConverter);
            this.Controls.Add(this.faDatePicker);
            this.Controls.Add(this.faMonthView);
            this.Name = "frm10";
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.Controls.FAMonthView faMonthView;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker;
        private FarsiLibrary.Win.Controls.FADatePickerConverter faDatePickerConverter;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnDefault;
    }
}