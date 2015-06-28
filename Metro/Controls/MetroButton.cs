using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Metro.Controls
{
    public class MetroButton : Button
    {
        public MetroButton()
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

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle((IsHovering ? ParentForm.ColorSchema.bControlBackgroundHover : ParentForm.ColorSchema.bControlBackground), 1, 1, this.Width - 2, this.Height - 2);
            e.Graphics.DrawRectangle((this.Focused ? ParentForm.ColorSchema.pControlBorderFocused : ParentForm.ColorSchema.pControlBorder), 0, 0, this.Width - 1, this.Height - 1);

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(0, 0, this.Width - 1, this.Height - 1), (this.Enabled ? ParentForm.ColorSchema.cSecondaryTextDark : ParentForm.ColorSchema.cSecondaryDarkDark), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            //base.OnPaint(e);
        }
    }
}
