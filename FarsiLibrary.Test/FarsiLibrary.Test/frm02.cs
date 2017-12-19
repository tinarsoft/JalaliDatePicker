using System;
using FarsiLibrary.Win.Events;

namespace FarsiLibrary.Test
{
    public partial class frm02 : baseForm
    {
        #region Ctor

        public frm02()
        {
            InitializeComponent();
        }

        #endregion

        #region Private Methods
        
        private void AddItem(string senderName, string eventName)
        {
            listEvents.Items.Add(string.Format("{1} fired {0} event.", eventName, senderName));
        }
        
        #endregion

        #region EventHandlers

        private void faMonthView_DayChanged(object sender, EventArgs e)
        {
            AddItem(faMonthView.Name, "DayChanged");
        }

        private void faMonthView_MonthChanged(object sender, EventArgs e)
        {
            AddItem(faMonthView.Name, "MonthChanged");
        }

        private void faMonthView_SelectedDateChanged(object sender, EventArgs e)
        {
            AddItem(faMonthView.Name, "SelectedDateChanged");
        }

        private void faMonthView_SelectedDateRangeChanged(object sender, EventArgs e)
        {
            AddItem(faMonthView.Name, "SelectedDateRangeChanged");
        }

        private void faMonthView_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            AddItem(faMonthView.Name, "SelectedDateTimeChanged");
        }

        private void faMonthView_ThemeChanged(object sender, EventArgs e)
        {
            AddItem(faMonthView.Name, "ThemeChanged");
        }

        private void faMonthView_YearChanged(object sender, EventArgs e)
        {
            AddItem(faMonthView.Name, "YearChanged");
        }

        private void faDatePicker_ValueValidating(object sender, ValueValidatingEventArgs e)
        {
            AddItem(faDatePicker.Name, "ValueValidating");
        }

        private void faDatePicker_ValueChanged(object sender, EventArgs e)
        {
            AddItem(faDatePicker.Name, "ValueChanged");
        }

        private void faDatePicker_SelectedDateTimeChanging(object sender, SelectedDateTimeChangingEventArgs e)
        {
            AddItem(faDatePicker.Name, "SelectedDateTimeChanging");
        }

        private void faDatePicker_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            AddItem(faDatePicker.Name, "SelectedDateTimeChanged");
        }

        private void faDatePickerConverter_ValueValidating(object sender, ValueValidatingEventArgs e)
        {
            AddItem(faDatePickerConverter.Name, "ValueValidating");
        }

        private void faDatePickerConverter_ValueChanged(object sender, EventArgs e)
        {
            AddItem(faDatePickerConverter.Name, "ValueChanged");
        }

        private void faDatePickerConverter_SelectedDateTimeChanging(object sender, SelectedDateTimeChangingEventArgs e)
        {
            AddItem(faDatePickerConverter.Name, "SelectedDateTimeChanging");
        }

        private void faDatePickerConverter_SelectedDateTimeChanged(object sender, EventArgs e)
        {
            AddItem(faDatePickerConverter.Name, "SelectedDateTimeChanged");
        }

        private void faDatePickerConverter_RightToLeftChanged(object sender, EventArgs e)
        {
            AddItem(faDatePickerConverter.Name, "RightToLeftChanged");
        }

        private void faDatePicker_RightToLeftChanged(object sender, EventArgs e)
        {
            AddItem(faDatePicker.Name, "RightToLeftChanged");
        }

        private void faDatePickerConverter_ConvertButtonClicked(object sender, EventArgs e)
        {
            AddItem(faDatePickerConverter.Name, "ConvertButtonClicked");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listEvents.Items.Clear();
        }

        private void btnDatePicker_Click(object sender, EventArgs e)
        {
            listEvents.Items.Clear();
            propertyGrid.SelectedObject = faDatePicker;
        }

        private void btnDatePickerConverter_Click(object sender, EventArgs e)
        {
            listEvents.Items.Clear();
            propertyGrid.SelectedObject = faDatePickerConverter;
        }

        private void btnMonthView_Click(object sender, EventArgs e)
        {
            listEvents.Items.Clear();
            propertyGrid.SelectedObject = faMonthView;
        }

        #endregion
    }
}