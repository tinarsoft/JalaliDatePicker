using System;
using System.Drawing;
using System.Windows.Forms;

namespace FarsiLibrary.Test
{
    public partial class baseForm : Form
    {
        #region Ctor

        public baseForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.Manual;
            BringToFront();
        }

        #endregion

        #region Overrides

        protected override void OnClosed(EventArgs e)
        {
            if(MainForm.Instance != null && !MainForm.Instance.Visible)
            {
                MainForm.Instance.Visible = false;
                MainForm.Instance.Show();
            }
            
            base.OnClosed(e);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (Owner != null)
                Owner.Hide();

            if(!DesignMode)
                CenterForm();

            Activate();
            BringToFront();
            Focus();
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
    }
}