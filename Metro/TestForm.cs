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

        int schema = 0;
        private void metroButton1_Click(object sender, EventArgs e)
        {
            schema++;
            this.ColorSchema = ColorSchema.Schemata[schema % ColorSchema.Schemata.Length];
        }

        private void metroCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            metroCheckBox2.Checked = metroCheckBox1.Checked;
        }
    }
}
