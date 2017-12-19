namespace FarsiLibrary.Test
{
    partial class frm18
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
            this.faMonthView = new FarsiLibrary.Win.Controls.FAMonthView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(317, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "We\'re custom drawing 1384/04/08 date plus each first day of the new year (Nowrooz" +
                ").";
            // 
            // faMonthView
            // 
            this.faMonthView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faMonthView.Location = new System.Drawing.Point(86, 88);
            this.faMonthView.Name = "faMonthView";
            this.faMonthView.SelectedDateTime = new System.DateTime(2006, 6, 6, 13, 49, 30, 658);
            this.faMonthView.TabIndex = 1;
            this.faMonthView.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faMonthView.DrawCurrentDay += new FarsiLibrary.Win.Events.CustomDrawDayEventHandler(this.faMonthView_DrawCurrentDay);
            // 
            // frm18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 286);
            this.Controls.Add(this.faMonthView);
            this.Controls.Add(this.label1);
            this.Name = "frm18";
            this.Text = "frm18";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FarsiLibrary.Win.Controls.FAMonthView faMonthView;
    }
}