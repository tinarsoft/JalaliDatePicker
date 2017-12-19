using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Win.Events;

namespace FarsiLibrary.Test
{
    public partial class frm20 : baseForm
    {
        #region Ctor

        public frm20()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            faMonthView.SelectedDateRange.CollectionChanged += SelectedDateRange_CollectionChanged;
        }

        #endregion

        #region Methods

        private void btnChangeSelectionMode_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            faMonthView.IsMultiSelect = !faMonthView.IsMultiSelect;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            faMonthView.SelectedDateRange.Clear();
        }

        private void btnSelectDays_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            faMonthView.SelectedDateRange.AddRange(new DateTime[] { DateTime.Now.Date, DateTime.Now.Date.AddDays(1), DateTime.Now.Date.AddDays(-1) });
        }

        private void btnSetNull_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            faMonthView.IsNull = true;
        }

        private void btnSelectMonth_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            List<DateTime> selection = new List<DateTime>();
            DateTime thismonth = new DateTime(DateTime.Now.Date.Year, DateTime.Now.Date.Month, 1, 0, 0, 0, 0, faMonthView.DefaultCalendar);
            int NumberOfDays = faMonthView.DefaultCalendar.GetDaysInMonth(thismonth.Year, thismonth.Month);

            for (int dayNo = 1; dayNo <= NumberOfDays; dayNo++)
            {
                selection.Add(new DateTime(thismonth.Year, thismonth.Month, dayNo, 0, 0, 0, 0, faMonthView.DefaultCalendar));
            }

            faMonthView.SelectedDateRange.Clear();
            faMonthView.SelectedDateRange.AddRange(selection.ToArray());
        }

        private void faMonthView_SelectedDateRangeChanged(object sender, EventArgs e)
        {
            textBox1.Text += "SelectedDateRangeChanged event fired\r\n";
            UpdateCount();
        }

        private void SelectedDateRange_CollectionChanged(object sender, CollectionChangedEventArgs e)
        {
            textBox1.Text += "CollectionChanged [" + e.ChangeType.ToString() + "] event fired\r\n";
            UpdateCount();
        }

        private void faMonthView_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            textBox1.Text += "SelectedDateTimeChanged event fired.\r\n";
            UpdateCount();
        }

        private void UpdateCount()
        {
            lblMessage.Text = "Selected Date Count : " + faMonthView.SelectedDateRange.Count.ToString() + "\r\n";
        }

        #endregion
    }
}