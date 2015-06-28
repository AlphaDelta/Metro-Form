using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Metro.Controls
{
    public class MetroButtonToggle : Button
    {
        public MetroButtonToggle()
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

        [Category("Behavior")]
        public bool Value
        {
            get { return _Value; }
            set { _Value = value; }
        }
        bool _Value = false;
        protected override void OnClick(EventArgs e)
        {
            Value = !Value;
            this.Invalidate();

            base.OnClick(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillRectangle((Value && this.Enabled ? ParentForm.ColorSchema.bControlBackgroundActive : (IsHovering ? ParentForm.ColorSchema.bControlBackgroundHover : ParentForm.ColorSchema.bControlBackground)), 1, 1, this.Width - 2, this.Height - 2);
            e.Graphics.DrawRectangle(((this.Focused || Value) && this.Enabled ? ParentForm.ColorSchema.pControlBorderFocused : ParentForm.ColorSchema.pControlBorder), 0, 0, this.Width - 1, this.Height - 1);

            TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Rectangle(0, 0, this.Width - 1, this.Height - 1), (!this.Enabled ? ParentForm.ColorSchema.cSecondaryDarkDark : (Value ? ParentForm.ColorSchema.cPrimary : ParentForm.ColorSchema.cSecondaryTextDark)), TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            //base.OnPaint(e);
        }
    }
}
