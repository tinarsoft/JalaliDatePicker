namespace FarsiLibrary.Test
{
    partial class frm04
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
            this.btnFarsi = new System.Windows.Forms.Button();
            this.btnArabic = new System.Windows.Forms.Button();
            this.btnInvariant = new System.Windows.Forms.Button();
            this.faMonthView = new FarsiLibrary.Win.Controls.FAMonthView();
            this.btnDefault = new System.Windows.Forms.Button();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.SuspendLayout();
            // 
            // btnFarsi
            // 
            this.btnFarsi.Location = new System.Drawing.Point(219, 13);
            this.btnFarsi.Name = "btnFarsi";
            this.btnFarsi.Size = new System.Drawing.Size(174, 25);
            this.btnFarsi.TabIndex = 1;
            this.btnFarsi.Text = "Farsi Culture";
            this.btnFarsi.UseVisualStyleBackColor = true;
            this.btnFarsi.Click += new System.EventHandler(this.btnFarsi_Click);
            // 
            // btnArabic
            // 
            this.btnArabic.Location = new System.Drawing.Point(219, 44);
            this.btnArabic.Name = "btnArabic";
            this.btnArabic.Size = new System.Drawing.Size(174, 25);
            this.btnArabic.TabIndex = 2;
            this.btnArabic.Text = "Arabic Culture";
            this.btnArabic.UseVisualStyleBackColor = true;
            this.btnArabic.Click += new System.EventHandler(this.btnArabic_Click);
            // 
            // btnInvariant
            // 
            this.btnInvariant.Location = new System.Drawing.Point(219, 75);
            this.btnInvariant.Name = "btnInvariant";
            this.btnInvariant.Size = new System.Drawing.Size(174, 25);
            this.btnInvariant.TabIndex = 3;
            this.btnInvariant.Text = "Invariant Culture";
            this.btnInvariant.UseVisualStyleBackColor = true;
            this.btnInvariant.Click += new System.EventHandler(this.btnInvariant_Click);
            // 
            // faMonthView
            // 
            this.faMonthView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faMonthView.IsNull = false;
            this.faMonthView.Location = new System.Drawing.Point(12, 31);
            this.faMonthView.Name = "faMonthView";
            this.faMonthView.SelectedDateTime = new System.DateTime(2006, 5, 24, 16, 34, 43, 67);
            this.faMonthView.TabIndex = 0;
            this.faMonthView.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // btnDefault
            // 
            this.btnDefault.Location = new System.Drawing.Point(219, 154);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.Size = new System.Drawing.Size(174, 25);
            this.btnDefault.TabIndex = 4;
            this.btnDefault.Text = "System Default Culture";
            this.btnDefault.UseVisualStyleBackColor = true;
            this.btnDefault.Click += new System.EventHandler(this.btnDefault_Click);
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(12, 5);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(166, 20);
            this.faDatePicker1.TabIndex = 5;
            this.faDatePicker1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // frm04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 209);
            this.Controls.Add(this.faDatePicker1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.btnInvariant);
            this.Controls.Add(this.btnArabic);
            this.Controls.Add(this.btnFarsi);
            this.Controls.Add(this.faMonthView);
            this.Name = "frm04";
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.Controls.FAMonthView faMonthView;
        private System.Windows.Forms.Button btnFarsi;
        private System.Windows.Forms.Button btnArabic;
        private System.Windows.Forms.Button btnInvariant;
        private System.Windows.Forms.Button btnDefault;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
    }
}