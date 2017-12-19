namespace FarsiLibrary.Test
{
    partial class frm13
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
            this.faDatePickerConverter1 = new FarsiLibrary.Win.Controls.FADatePickerConverter();
            this.faDatePicker1 = new FarsiLibrary.Win.Controls.FADatePicker();
            this.faMonthView1 = new FarsiLibrary.Win.Controls.FAMonthView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // faDatePickerConverter1
            // 
            this.faDatePickerConverter1.Location = new System.Drawing.Point(43, 143);
            this.faDatePickerConverter1.Name = "faDatePickerConverter1";
            this.faDatePickerConverter1.Size = new System.Drawing.Size(182, 20);
            this.faDatePickerConverter1.TabIndex = 10;
            this.faDatePickerConverter1.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.faDatePickerConverter1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
            // 
            // faDatePicker1
            // 
            this.faDatePicker1.Location = new System.Drawing.Point(43, 169);
            this.faDatePicker1.Name = "faDatePicker1";
            this.faDatePicker1.Size = new System.Drawing.Size(182, 20);
            this.faDatePicker1.TabIndex = 11;
            // 
            // faMonthView1
            // 
            this.faMonthView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.faMonthView1.IsNull = false;
            this.faMonthView1.Location = new System.Drawing.Point(306, 124);
            this.faMonthView1.Name = "faMonthView1";
            this.faMonthView1.SelectedDateTime = new System.DateTime(2005, 5, 31, 23, 14, 57, 364);
            this.faMonthView1.TabIndex = 12;
            this.faMonthView1.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "To Office 2000...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.faButton1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 37);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "To Windows XP...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.faButton2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(295, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(189, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "To Office 2003...";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.faButton3_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 77);
            this.label1.TabIndex = 16;
            this.label1.Text = "Notice that on changing the theme on this form, all other controls will paint the" +
                "meselved using the specified theme, even if they\'re on another form.";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(295, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "To Design-Time value...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // frm13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 296);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.faMonthView1);
            this.Controls.Add(this.faDatePicker1);
            this.Controls.Add(this.faDatePickerConverter1);
            this.Name = "frm13";
            this.ResumeLayout(false);

        }

        #endregion

        private FarsiLibrary.Win.Controls.FADatePickerConverter faDatePickerConverter1;
        private FarsiLibrary.Win.Controls.FADatePicker faDatePicker1;
        private FarsiLibrary.Win.Controls.FAMonthView faMonthView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;



    }
}