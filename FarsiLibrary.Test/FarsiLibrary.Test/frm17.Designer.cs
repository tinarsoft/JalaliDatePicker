namespace FarsiLibrary.Test
{
    partial class frm17
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm17));
            this.btnCalc = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCastTo = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCastFrom = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDTMinValue = new System.Windows.Forms.Label();
            this.lblPDMinValue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(15, 202);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 0;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Casting DateTime.Now to PersianDate instance :  ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCastTo
            // 
            this.lblCastTo.Location = new System.Drawing.Point(321, 81);
            this.lblCastTo.Name = "lblCastTo";
            this.lblCastTo.Size = new System.Drawing.Size(198, 23);
            this.lblCastTo.TabIndex = 3;
            this.lblCastTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(300, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Casting PersianDate.Now to DateTime instance : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCastFrom
            // 
            this.lblCastFrom.Location = new System.Drawing.Point(321, 104);
            this.lblCastFrom.Name = "lblCastFrom";
            this.lblCastFrom.Size = new System.Drawing.Size(198, 23);
            this.lblCastFrom.TabIndex = 5;
            this.lblCastFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(15, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Casting DateTime.MinValue to PersianDate instance : ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(300, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Casting PersianDate.MinValue to DateTime instance : ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblDTMinValue
            // 
            this.lblDTMinValue.Location = new System.Drawing.Point(321, 127);
            this.lblDTMinValue.Name = "lblDTMinValue";
            this.lblDTMinValue.Size = new System.Drawing.Size(198, 23);
            this.lblDTMinValue.TabIndex = 8;
            this.lblDTMinValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPDMinValue
            // 
            this.lblPDMinValue.Location = new System.Drawing.Point(321, 150);
            this.lblPDMinValue.Name = "lblPDMinValue";
            this.lblPDMinValue.Size = new System.Drawing.Size(198, 23);
            this.lblPDMinValue.TabIndex = 9;
            this.lblPDMinValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm17
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 237);
            this.Controls.Add(this.lblPDMinValue);
            this.Controls.Add(this.lblDTMinValue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCastFrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblCastTo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalc);
            this.Name = "frm17";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCastTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCastFrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDTMinValue;
        private System.Windows.Forms.Label lblPDMinValue;
    }
}