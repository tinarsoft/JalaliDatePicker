using System;
using System.Data;
using System.IO;

namespace FarsiLibrary.Test
{
    public partial class frm08 : baseForm
    {
        #region Ctor

        public frm08()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            LoadDataSet();
        }

        private void LoadDataSet()
        {
            StringReader sr = new StringReader(Test.Properties.Resources.Employee);
            ds.ReadXml(sr, XmlReadMode.Auto);
        }
        
        #endregion
    }
}