using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Utils;

namespace FarsiLibrary.Test
{
    public partial class frm11 : baseForm
    {
        #region Ctor

        public frm11()
        {
            InitializeComponent();
        }

        #endregion

        private void faDatePicker1_SelectedDateTimeChanging(object sender, FarsiLibrary.Win.Events.SelectedDateTimeChangingEventArgs e)
        {
            if (e.NewValue.Year > 2000 && !faDatePicker1.IsNull)
            {
                e.Message = "This is a custom error message.";
            }
        }

        private void faDatePicker2_SelectedDateTimeChanging(object sender, FarsiLibrary.Win.Events.SelectedDateTimeChangingEventArgs e)
        {
            if (e.NewValue.Day != 20 && !faDatePicker2.IsNull)
            {
                e.Message = "Invalid date. Default Date is applied.";
                e.NewValue = new DateTime(2010, 1, 20, 0, 0, 0);
            }
        }

        private void faDatePickerConverter1_SelectedDateTimeChanging(object sender, FarsiLibrary.Win.Events.SelectedDateTimeChangingEventArgs e)
        {
            PersianDate pd = e.NewValue;
            
            if(pd.Day != 8 || pd.Month != 4 || pd.Year != 1385)
            {
                e.Cancel = true;
            }
        }

    }
}