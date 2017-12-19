using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Win;

namespace FarsiLibrary.Test
{
    public partial class frm13 : baseForm
    {
        public frm13()
        {
            InitializeComponent();
        }

        private void faButton2_Click(object sender, EventArgs e)
        {
            FAThemeManager.Theme = FarsiLibrary.Win.Enums.ThemeTypes.WindowsXP;
        }

        private void faButton1_Click(object sender, EventArgs e)
        {
            FAThemeManager.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2000;
        }

        private void faButton3_Click(object sender, EventArgs e)
        {
            FAThemeManager.Theme = FarsiLibrary.Win.Enums.ThemeTypes.Office2003;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}