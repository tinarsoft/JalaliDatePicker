using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Win.Enums;

namespace FarsiLibrary.Test
{
    public partial class frm16 : baseForm
    {
        #region Ctor

        public frm16()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void rbDays_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDays.Checked)
            {
                faMonthView1.ScrollOption = ScrollOptionTypes.Day;
                faMonthView1.Focus();
            }
        }

        private void rbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (rbMonth.Checked)
            {
                faMonthView1.ScrollOption = ScrollOptionTypes.Month;
                faMonthView1.Focus();
            }
        }

        private void rbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (rbYear.Checked)
            {
                faMonthView1.ScrollOption = ScrollOptionTypes.Year;
                faMonthView1.Focus();
            }
        }

        #endregion
    }
}