using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Metro.Controls
{
    public class MetroCheckBox : CheckBox
    {
        public MetroCheckBox()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        MetroForm ParentForm;
        protected override void OnCreateControl()
        {
            Form f = this.FindForm();
            if (!(f is MetroForm)) throw new Exception("A metro control must be created in a MetroWindow");
            ParentForm = (MetroForm)f;

            base.OnCreateControl();
        }

        bool IsHovering = false;
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);

            IsHovering = true;
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);

            IsHovering = false;
        }

        const int pading = 2;
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle((this.BackColor == Color.Transparent ? ParentForm.ColorSchema.bWindow : new SolidBrush(this.BackColor)), e.ClipRectangle);
            e.Graphics.FillRectangle((IsHovering ? ParentForm.ColorSchema.bControlBackgroundHover : ParentForm.ColorSchema.bControlBackground), 1, 1, this.Height - 2, this.Height - 2);
            e.Graphics.DrawRectangle((this.Focused ? ParentForm.ColorSchema.pControlBorderFocused : ParentForm.ColorSchema.pControlBorder), 0, 0, this.Height - 1, this.Height - 1);

            if (this.Checked)
            {
                int half = (int)Math.Round(this.Height / 2f);
                Pen check = new Pen((this.Enabled ? ParentForm.ColorSchema.cPrimary : ParentForm.ColorSchema.cSecondaryDarkDark), (this.Height / 6f));

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                //e.Graphics.DrawLine(check, pading, half, half, this.Height - pading - 1);
                //e.Graphics.DrawLine(check, half - 1, this.Height - pading - 2, this.Height - pading, pading);
                e.Graphics.DrawLines(check, new Point[] {
                    new Point(pading + 1, half),
                    new Point(half, this.Height - pading - 3),
                    new Point(this.Height - pading - 2, pading + 1)
                });
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
            }

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(this.Height + 2, 0, this.Width - 1, this.Height - 1), (this.Enabled ? ParentForm.ColorSchema.cSecondaryTextDark : ParentForm.ColorSchema.cSecondaryDarkDark), TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            //base.OnPaint(e);
        }
    }
}
