using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Win;
using FarsiLibrary.Win.Enums;

namespace FarsiLibrary.Test
{
    public partial class frm14 : baseForm
    {
        #region Ctor

        public frm14()
        {
            InitializeComponent();
        }

        #endregion

        #region EventHandlers

        private void windowsXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripManager.VisualStylesEnabled = true;
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.System;
            FAThemeManager.Theme = ThemeTypes.WindowsXP;
        }

        private void office2003ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripManager.VisualStylesEnabled = true;
            ToolStripManager.RenderMode = ToolStripManagerRenderMode.Professional;
            FAThemeManager.Theme = ThemeTypes.Office2003;
        }

        private void office2000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripManager.VisualStylesEnabled = false;
            FAThemeManager.Theme = ThemeTypes.Office2000;
        }

        #endregion
    }
}