namespace FarsiLibrary.Test
{
    partial class frm01
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
            this.btnChangeTheme = new System.Windows.Forms.Button();
            this.btnVisualStyles = new System.Windows.Forms.Button();
            this.btnToggleBorder = new System.Windows.Forms.Button();
            this.btnToggleFocusRect = new System.Windows.Forms.Button();
            this.faMonthView = new FarsiLibrary.Win.Controls.FAMonthView();
            this.SuspendLayout();
            // 
            // btnChangeTheme
            // 
            this.btnChangeTheme.Location = new System.Drawing.Point(184, 13);
            this.btnChangeTheme.Name = "btnChangeTheme";
            this.btnChangeTheme.Size = new System.Drawing.Size(134, 25);
            this.btnChangeTheme.TabIndex = 1;
            this.btnChangeTheme.Text = "Change Theme";
            this.btnChangeTheme.UseVisualStyleBackColor = true;
            this.btnChangeTheme.Click += new System.EventHandler(this.btnChangeTheme_Click);
            // 
            // btnVisualStyles
            // 
            this.btnVisualStyles.Location = new System.Drawing.Point(184, 44);
            this.btnVisualStyles.Name = "btnVisualStyles";
            this.btnVisualStyles.Size = new System.Drawing.Size(134, 25);
            this.btnVisualStyles.TabIndex = 2;
            this.btnVisualStyles.Text = "Toggle VisualStyles";
            this.btnVisualStyles.UseVisualStyleBackColor = true;
            this.btnVisualStyles.Click += new System.EventHandler(this.btnVisualStyles_Click);
            // 
            // btnToggleBorder
            // 
            this.btnToggleBorder.Location = new System.Drawing.Point(184, 75);
            this.btnToggleBorder.Name = "btnToggleBorder";
            this.btnToggleBorder.Size = new System.Drawing.Size(134, 25);
            this.btnToggleBorder.TabIndex = 3;
            this.btnToggleBorder.Text = "Toggle Border";
            this.btnToggleBorder.UseVisualStyleBackColor = true;
            this.btnToggleBorder.Click += new System.EventHandler(this.btnToggleBorder_Click);
            // 
            // btnToggleFocusRect
            // 
            this.btnToggleFocusRect.Location = new System.Drawing.Point(184, 107);
            this.btnToggleFocusRect.Name = "btnToggleFocusRect";
            this.btnToggleFocusRect.Size = new System.Drawing.Size(134, 25);
            this.btnToggleFocusRect.TabIndex = 4;
            this.btnToggleFocusRect.Text = "Toggle Focus Rect";
            this.btnToggleFocusRect.UseVisualStyleBackColor = true;
            this.btnToggleFocusRect.Click += new System.EventHandler(this.btnToggleFocusRect_Click);
            // 
            // faMonthView
            // 
            this.faMonthView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faMonthView.IsNull = false;
            this.faMonthView.Location = new System.Drawing.Point(12, 13);
            this.faMonthView.Name = "faMonthView";
            this.faMonthView.SelectedDateTime = new System.DateTime(2006, 5, 25, 10, 20, 34, 380);
            this.faMonthView.TabIndex = 5;
            this.faMonthView.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // frm01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 190);
            this.Controls.Add(this.faMonthView);
            this.Controls.Add(this.btnToggleFocusRect);
            this.Controls.Add(this.btnToggleBorder);
            this.Controls.Add(this.btnVisualStyles);
            this.Controls.Add(this.btnChangeTheme);
            this.Name = "frm01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeTheme;
        private System.Windows.Forms.Button btnVisualStyles;
        private System.Windows.Forms.Button btnToggleBorder;
        private System.Windows.Forms.Button btnToggleFocusRect;
        private FarsiLibrary.Win.Controls.FAMonthView faMonthView;
    }
}