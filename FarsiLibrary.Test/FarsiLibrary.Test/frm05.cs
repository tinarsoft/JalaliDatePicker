using System;
using FarsiLibrary.Utils;

namespace FarsiLibrary.Test
{
    public partial class frm05 : baseForm
    {
        #region Ctor

        public frm05()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnToday_Click(object sender, EventArgs e)
        {
            lblTodayGregorian.Text = DateTime.Now.ToString("d");
            lblTodayPersian.Text = PersianDateConverter.ToPersianDate(DateTime.Now).ToString();
            lblTodayPersianDate.Text = PersianDate.Now.ToWritten();
            lblPersianDateCtor.Text = new PersianDate(DateTime.Now).ToString("G");
            lblDirectCast.Text = ((PersianDate) DateTime.Now).ToWritten();
        }

        #endregion
    }
}