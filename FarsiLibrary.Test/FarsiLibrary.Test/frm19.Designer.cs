namespace FarsiLibrary.Test
{
    partial class frm19
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
            this.btnBasicMSG = new System.Windows.Forms.Button();
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnCustom = new System.Windows.Forms.Button();
            this.btnGetBasic = new System.Windows.Forms.Button();
            this.btnGetAdv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBasicMSG
            // 
            this.btnBasicMSG.Location = new System.Drawing.Point(12, 12);
            this.btnBasicMSG.Name = "btnBasicMSG";
            this.btnBasicMSG.Size = new System.Drawing.Size(317, 23);
            this.btnBasicMSG.TabIndex = 0;
            this.btnBasicMSG.Text = "Show Basic MessageBox";
            this.btnBasicMSG.UseVisualStyleBackColor = true;
            this.btnBasicMSG.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.Location = new System.Drawing.Point(12, 221);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(317, 56);
            this.lblMessage.TabIndex = 1;
            // 
            // btnCustom
            // 
            this.btnCustom.Location = new System.Drawing.Point(12, 41);
            this.btnCustom.Name = "btnCustom";
            this.btnCustom.Size = new System.Drawing.Size(317, 23);
            this.btnCustom.TabIndex = 2;
            this.btnCustom.Text = "Use Advanced Buttons";
            this.btnCustom.UseVisualStyleBackColor = true;
            this.btnCustom.Click += new System.EventHandler(this.btnCustom_Click);
            // 
            // btnGetBasic
            // 
            this.btnGetBasic.Location = new System.Drawing.Point(12, 82);
            this.btnGetBasic.Name = "btnGetBasic";
            this.btnGetBasic.Size = new System.Drawing.Size(317, 23);
            this.btnGetBasic.TabIndex = 3;
            this.btnGetBasic.Text = "Get Selected Value of Basic MessageBox";
            this.btnGetBasic.UseVisualStyleBackColor = true;
            this.btnGetBasic.Click += new System.EventHandler(this.btnGetBasic_Click);
            // 
            // btnGetAdv
            // 
            this.btnGetAdv.Location = new System.Drawing.Point(12, 111);
            this.btnGetAdv.Name = "btnGetAdv";
            this.btnGetAdv.Size = new System.Drawing.Size(317, 23);
            this.btnGetAdv.TabIndex = 4;
            this.btnGetAdv.Text = "Get Selected Value of Advanced MessageBox";
            this.btnGetAdv.UseVisualStyleBackColor = true;
            this.btnGetAdv.Click += new System.EventHandler(this.btnGetAdv_Click);
            // 
            // frm19
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 286);
            this.Controls.Add(this.btnGetAdv);
            this.Controls.Add(this.btnGetBasic);
            this.Controls.Add(this.btnCustom);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.btnBasicMSG);
            this.Name = "frm19";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBasicMSG;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Button btnCustom;
        private System.Windows.Forms.Button btnGetBasic;
        private System.Windows.Forms.Button btnGetAdv;
    }
}