using System;
using System.Globalization;
using FarsiLibrary.Resources;

namespace FarsiLibrary.Test
{
    public partial class frm10 : baseForm
    {
        #region Ctor

        public frm10()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnCustom_Click(object sender, EventArgs e)
        {
            FALocalizeManager.CustomCulture = new CultureInfo("es-ES");
            FALocalizeManager.CustomLocalizer = new ESLocalizer();
            faDatePicker.SelectedDateTime = DateTime.Now;
            faDatePickerConverter.SelectedDateTime = DateTime.Now;
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            FALocalizeManager.CustomLocalizer = null;
            FALocalizeManager.CustomCulture = null;
            faDatePicker.SelectedDateTime = DateTime.Now;
            faDatePickerConverter.SelectedDateTime = DateTime.Now;
        }

        #endregion
    }
}