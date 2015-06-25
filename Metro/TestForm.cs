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
            this.ColorSchema = ColorSchema.Schemata[1];
        }
    }
}
