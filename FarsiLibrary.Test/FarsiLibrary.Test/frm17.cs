using System;
using FarsiLibrary.Utils;

namespace FarsiLibrary.Test
{
    public partial class frm17 : baseForm
    {
        #region Ctor

        public frm17()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblCastTo.Text = ((PersianDate) DateTime.Now).ToString("G");
            lblCastFrom.Text = ((DateTime) PersianDate.Now).ToString("G");

            lblDTMinValue.Text = ((PersianDate) DateTime.MaxValue).ToString("G");
            lblPDMinValue.Text = ((DateTime) PersianDate.MinValue).ToString("G");
        }

        #endregion
    }
}