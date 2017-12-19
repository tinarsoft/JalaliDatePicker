namespace FarsiLibrary.Test
{
    partial class frm20
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
            this.faMonthView = new FarsiLibrary.Win.Controls.FAMonthView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnChangeSelectionMode = new System.Windows.Forms.Button();
            this.btnSelectDays = new System.Windows.Forms.Button();
            this.btnSelectMonth = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnSetNull = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // faMonthView
            // 
            this.faMonthView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faMonthView.IsMultiSelect = true;
            this.faMonthView.IsNull = false;
            this.faMonthView.Location = new System.Drawing.Point(12, 12);
            this.faMonthView.Name = "faMonthView";
            this.faMonthView.SelectedDateTime = new System.DateTime(2006, 5, 25, 10, 20, 34, 380);
            this.faMonthView.TabIndex = 6;
            this.faMonthView.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            this.faMonthView.SelectedDateRangeChanged += new System.EventHandler(this.faMonthView_SelectedDateRangeChanged);
            this.faMonthView.SelectedDateTimeChanged += new System.EventHandler(this.faMonthView_SelectedDateTimeChanged);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(184, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(253, 25);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear Selection";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnChangeSelectionMode
            // 
            this.btnChangeSelectionMode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChangeSelectionMode.Location = new System.Drawing.Point(184, 17);
            this.btnChangeSelectionMode.Name = "btnChangeSelectionMode";
            this.btnChangeSelectionMode.Size = new System.Drawing.Size(253, 25);
            this.btnChangeSelectionMode.TabIndex = 9;
            this.btnChangeSelectionMode.Text = "Change Selection Mode";
            this.btnChangeSelectionMode.UseVisualStyleBackColor = true;
            this.btnChangeSelectionMode.Click += new System.EventHandler(this.btnChangeSelectionMode_Click);
            // 
            // btnSelectDays
            // 
            this.btnSelectDays.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectDays.Location = new System.Drawing.Point(184, 110);
            this.btnSelectDays.Name = "btnSelectDays";
            this.btnSelectDays.Size = new System.Drawing.Size(253, 25);
            this.btnSelectDays.TabIndex = 10;
            this.btnSelectDays.Text = "Select Some Days";
            this.btnSelectDays.UseVisualStyleBackColor = true;
            this.btnSelectDays.Click += new System.EventHandler(this.btnSelectDays_Click);
            // 
            // btnSelectMonth
            // 
            this.btnSelectMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectMonth.Location = new System.Drawing.Point(184, 141);
            this.btnSelectMonth.Name = "btnSelectMonth";
            this.btnSelectMonth.Size = new System.Drawing.Size(253, 25);
            this.btnSelectMonth.TabIndex = 11;
            this.btnSelectMonth.Text = "Select The Whole Month";
            this.btnSelectMonth.UseVisualStyleBackColor = true;
            this.btnSelectMonth.Click += new System.EventHandler(this.btnSelectMonth_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 214);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(425, 109);
            this.textBox1.TabIndex = 12;
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 183);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(425, 25);
            this.lblMessage.TabIndex = 13;
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSetNull
            // 
            this.btnSetNull.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetNull.Location = new System.Drawing.Point(184, 79);
            this.btnSetNull.Name = "btnSetNull";
            this.btnSetNull.Size = new System.Drawing.Size(253, 25);
            this.btnSetNull.TabIndex = 14;
            this.btnSetNull.Text = "Set Null";
            this.btnSetNull.UseVisualStyleBackColor = true;
            this.btnSetNull.Click += new System.EventHandler(this.btnSetNull_Click);
            // 
            // frm20
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 335);
            this.Controls.Add(this.btnSetNull);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnSelectMonth);
            this.Controls.Add(this.btnSelectDays);
            this.Controls.Add(this.btnChangeSelectionMode);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.faMonthView);
            this.Name = "frm20";
            this.Text = "frm20";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FarsiLibrary.Win.Controls.FAMonthView faMonthView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnChangeSelectionMode;
        private System.Windows.Forms.Button btnSelectDays;
        private System.Windows.Forms.Button btnSelectMonth;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnSetNull;
    }
}