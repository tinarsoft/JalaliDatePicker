using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;
using FarsiLibrary.Resources;
using FarsiLibrary.Win.Design;

namespace FarsiLibrary.Test
{
    public partial class MainForm : Form
    {
        #region Fields

        private static MainForm self;

        #endregion
        
        #region Ctor

        public MainForm()
        {
            InitializeComponent();
            self = this;
            StartPosition = FormStartPosition.Manual;
            CenterForm();
        }

        #endregion

        #region Props

        public static MainForm Instance
        {
            get { return self; }
        }

        #endregion

        #region Private Methods

        private void CenterForm()
        {
            Point center = new Point();
            center.X = (Screen.PrimaryScreen.WorkingArea.Width - Width) / 2;
            center.Y = (Screen.PrimaryScreen.WorkingArea.Height - Height) / 2;

            Location = center;
        }

        #endregion

        #region EventHandlers

        private void btnThemes_Click(object sender, EventArgs e)
        {
            frm01 form = new frm01();
            form.ShowDialog(this);
        }

        private void btnEvents_Click(object sender, EventArgs e)
        {
            frm02 form = new frm02();
            form.ShowDialog(this);
        }

        private void btnRightToLeft_Click(object sender, EventArgs e)
        {
            frm03 form = new frm03();
            form.ShowDialog(this);
        }

        private void btnCulture_Click(object sender, EventArgs e)
        {
            frm04 form = new frm04();
            form.ShowDialog(this);
        }

        private void btnConvertion_Click(object sender, EventArgs e)
        {
            frm05 form = new frm05();
            form.ShowDialog(this);
        }

        private void btnPersianCalendar_Click(object sender, EventArgs e)
        {
            frm06 form = new frm06();
            form.ShowDialog(this);
        }

        private void btnOther_Click(object sender, EventArgs e)
        {
            frm07 form = new frm07();
            form.ShowDialog(this);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About form = new About(false);
            form.ShowDialog(this);
        }

        private void btnBinding_Click(object sender, EventArgs e)
        {
            frm08 form = new frm08();
            form.ShowDialog(this);
        }

        private void btnBindingBusinessObj_Click(object sender, EventArgs e)
        {
            CultureInfo oldValue = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;
            
            frm09 form = new frm09();
            form.ShowDialog(this);

            Thread.CurrentThread.CurrentCulture = oldValue;
            Thread.CurrentThread.CurrentUICulture = oldValue;
        }

        private void btnCustomLocalization_Click(object sender, EventArgs e)
        {
            frm10 form = new frm10();
            form.ShowDialog(this);
        }

        private void btnValidation_Click(object sender, EventArgs e)
        {
            CultureInfo oldValue = Thread.CurrentThread.CurrentUICulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fa-IR");
            Thread.CurrentThread.CurrentUICulture = Thread.CurrentThread.CurrentCulture;

            frm11 form = new frm11();
            form.ShowDialog(this);

            Thread.CurrentThread.CurrentCulture = oldValue;
            Thread.CurrentThread.CurrentUICulture = oldValue;
        }

        private void btnGridView_Click(object sender, EventArgs e)
        {
            FALocalizeManager.CustomCulture = FALocalizeManager.FarsiCulture;
            
            frm12 form = new frm12();
            form.ShowDialog(this);

            FALocalizeManager.CustomCulture = null;
        }

        private void btnThemeManager_Click(object sender, EventArgs e)
        {
            frm13 form = new frm13();
            form.ShowDialog(this);
        }

        private void btnToolStrip_Click(object sender, EventArgs e)
        {
            frm14 form = new frm14();
            form.ShowDialog(this);
        }

        private void btnCustomFormatting_Click(object sender, EventArgs e)
        {
            frm15 form = new frm15();
            form.ShowDialog(this);
        }

        private void btnScrolling_Click(object sender, EventArgs e)
        {
            frm16 form = new frm16();
            form.ShowDialog(this);
        }

        private void btnDirectCast_Click(object sender, EventArgs e)
        {
            frm17 form = new frm17();
            form.ShowDialog(this);
        }

        private void btnCustomDraw_Click(object sender, EventArgs e)
        {
            frm18 form = new frm18();
            form.ShowDialog(this);
        }

        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            frm19 form = new frm19();
            form.ShowDialog(this);
        }

        private void btnMultiSelection_Click(object sender, EventArgs e)
        {
            frm20 form = new frm20();
            form.ShowDialog(this);
        }

        #endregion
    }
}