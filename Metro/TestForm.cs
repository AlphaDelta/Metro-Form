using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Metro
{
    public partial class TestForm : MetroForm
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.ColorSchema.cPrimaryLightLight = Color.FromArgb(0xFF, 0x84, 0x84);
            this.ColorSchema.cPrimaryLight = Color.FromArgb(0xFE, 0x5B, 0x5B);
            this.ColorSchema.cPrimary = Color.FromArgb(0xEA, 0x33, 0x33);
            this.ColorSchema.cPrimaryDark = Color.FromArgb(0x9E, 0x02, 0x02);
            this.ColorSchema.cPrimaryDarkDark = Color.FromArgb(0x9E, 0x02, 0x02);
            this.ColorSchema.Update();
            this.Invalidate();
            this.glow.Render();
        }
    }
}
