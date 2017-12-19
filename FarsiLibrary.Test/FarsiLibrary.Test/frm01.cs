using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using FarsiLibrary.Win.Enums;

namespace FarsiLibrary.Test
{
    public partial class frm01 : baseForm
    {
        #region Fields

        private int currentTheme = (int)ThemeTypes.Office2000;

        #endregion

        #region Ctor

        public frm01()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnChangeTheme_Click(object sender, EventArgs e)
        {
            if (currentTheme > 1)
            {
                currentTheme = 0;
                faMonthView.Theme = ThemeTypes.Office2000;
            }
            else
            {
                currentTheme++;
                faMonthView.Theme = (ThemeTypes)currentTheme;
            }
        }

        private void btnVisualStyles_Click(object sender, EventArgs e)
        {
            if (Application.VisualStyleState == VisualStyleState.ClientAndNonClientAreasEnabled)
            {
                Application.VisualStyleState = VisualStyleState.NoneEnabled;
            }
            else
            {
                Application.VisualStyleState = VisualStyleState.ClientAndNonClientAreasEnabled;
            }
        }

        private void btnToggleBorder_Click(object sender, EventArgs e)
        {
            faMonthView.ShowBorder = !faMonthView.ShowBorder;
        }

        private void btnToggleFocusRect_Click(object sender, EventArgs e)
        {
            faMonthView.ShowFocusRect = !faMonthView.ShowFocusRect;
        }

        #endregion
    }
}