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

        private void button1_Click(object sender, EventArgs e)
        {
            this.ColorSchema.cPrimaryDarkDark = Color.FromArgb(0xBB, 0x65, 0x00);
            this.ColorSchema.cPrimaryDark = Color.FromArgb(0xBB, 0x65, 0x00);
            this.ColorSchema.cPrimary = Color.FromArgb(0xEB, 0x8C, 0x1D);
            this.ColorSchema.cPrimaryLight = Color.FromArgb(0xFF, 0xA5, 0x3C);
            this.ColorSchema.cPrimaryLightLight = Color.FromArgb(0xFF, 0xBD, 0x6F);
            this.ColorSchema.Update();
            this.glow.Render();
        }
    }
}
