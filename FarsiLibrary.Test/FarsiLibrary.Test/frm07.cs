using System;
using FarsiLibrary.Utils;

namespace FarsiLibrary.Test
{
    public partial class frm07 : baseForm
    {
        #region Ctor

        public frm07()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void btnConvert_Click(object sender, EventArgs e)
        {
            try
            {
                long num = long.Parse(txtNumber.Text);
                lblResult.Text = ToWords.ToString(num);
            }
            catch(ArgumentOutOfRangeException)
            {
                lblResult.Text = "لطفا عدد کوچکتری را وارد کنید";
            }
            catch(FormatException)
            {
                lblResult.Text = string.Empty;
            }
        }

        #endregion
    }
}