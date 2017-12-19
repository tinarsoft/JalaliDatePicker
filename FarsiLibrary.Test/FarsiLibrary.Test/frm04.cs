using System;

namespace FarsiLibrary.Test
{
    public partial class frm04 : baseForm
    {
        #region Ctor

        public frm04()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnFarsi_Click(object sender, EventArgs e)
        {
            faMonthView.DefaultCalendar = faMonthView.PersianCalendar;
            faMonthView.DefaultCulture = faMonthView.PersianCulture;
        }

        private void btnArabic_Click(object sender, EventArgs e)
        {
            faMonthView.DefaultCalendar = faMonthView.HijriCalendar;
            faMonthView.DefaultCulture = faMonthView.ArabicCulture;
        }

        private void btnInvariant_Click(object sender, EventArgs e)
        {
            faMonthView.DefaultCalendar = faMonthView.InvariantCalendar;
            faMonthView.DefaultCulture = faMonthView.InvariantCulture;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            faMonthView.DefaultCalendar = null;
            faMonthView.DefaultCulture = null;
        }

        #endregion
    }
}