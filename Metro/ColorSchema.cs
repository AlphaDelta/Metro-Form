using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Metro
{
    public class ColorSchema
    {
        public static ColorSchema[] Schemata =
        {
            new ColorSchema(), //Light blue (Default)
            new ColorSchema()  //Blue
            {
                cPrimaryLightLightLight = Color.FromArgb(0xDC, 0xE7, 0xFF),
                cPrimaryLightLight = Color.FromArgb(0x94, 0xAD, 0xE5),
                cPrimaryLight = Color.FromArgb(0x5A, 0x7E, 0xD0),
                cPrimary = Color.FromArgb(0x31, 0x5D, 0xC1),
                cPrimaryDark = Color.FromArgb(0x0F, 0x3D, 0xA8),
                cPrimaryDarkDark = Color.FromArgb(0x0A, 0x2B, 0x76)
            },
            new ColorSchema() //Red
            {
                cPrimaryLightLightLight = Color.FromArgb(0xFD, 0xEA, 0xEA),
                cPrimaryLightLight = Color.FromArgb(0xFF, 0x84, 0x84),
                cPrimaryLight = Color.FromArgb(0xFE, 0x5B, 0x5B),
                cPrimary = Color.FromArgb(0xEA, 0x33, 0x33),
                cPrimaryDark = Color.FromArgb(0x9E, 0x02, 0x02),
                cPrimaryDarkDark = Color.FromArgb(0x9E, 0x02, 0x02)
            },
            new ColorSchema()  //Purple
            {
                cPrimaryLightLightLight = Color.FromArgb(0xEB, 0xDC, 0xFF),
                cPrimaryLightLight = Color.FromArgb(0xB6, 0x8E, 0xEA),
                cPrimaryLight = Color.FromArgb(0x8D, 0x53, 0xD9),
                cPrimary = Color.FromArgb(0x6F, 0x28, 0xCD),
                cPrimaryDark = Color.FromArgb(0x50, 0x0B, 0xAC),
                cPrimaryDarkDark = Color.FromArgb(0x37, 0x07, 0x75)
            }
        };

        public Color
        cPrimaryLightLightLight = Color.FromArgb(0xEC, 0xF7, 0xFC),
        cPrimaryLightLight = Color.FromArgb(0x80, 0xCB, 0xEB),
        cPrimaryLight = Color.FromArgb(0x4F, 0xC8, 0xFC),
        cPrimary = Color.FromArgb(0x41, 0xB1, 0xE1),
        cPrimaryDark = Color.FromArgb(0x27, 0x6B, 0x87),
        cPrimaryDarkDark = Color.FromArgb(0x08, 0x6F, 0x9E),

        cSecondary = Color.FromArgb(0xFF, 0xFF, 0xFF),
        cSecondaryDark = Color.FromArgb(0xF7, 0xF7, 0xF7),
        cSecondaryDarkMid = Color.FromArgb(0xE0, 0xE0, 0xE0), //Blame MahApps for this, I usually follow the LL L M D DD format
        cSecondaryDarkDark = Color.FromArgb(0xCC, 0xCC, 0xCC),
        cSecondaryTextDark = Color.FromArgb(0x00, 0x00, 0x00);

        public SolidBrush
        bCaption,
        bWindow,
        bCaptionTitle,
        bCaptionControls,
        bCaptionControlsHover,
        bCaptionControlsActive,
        bCaptionControlsShadow,

        bControlBackground,
        bControlBackgroundHover,
        bControlBackgroundActive;

        public Pen
        pBorder,
        pCaptionControls,
        pCaptionControlsActive,
        pCaptionControlsShadow,

        pControlBorder,
        pControlBorderFocused;

        public ColorSchema()
        {
            Update();
        }

        public void Update()
        {
            bCaption = new SolidBrush(cPrimary);
            bWindow = new SolidBrush(cSecondary);
            bCaptionTitle = new SolidBrush(cSecondary);
            bCaptionControls = new SolidBrush(cPrimaryDark);
            bCaptionControlsHover = new SolidBrush(cPrimaryLightLight);
            bCaptionControlsActive = new SolidBrush(cPrimaryDarkDark);
            bCaptionControlsShadow = new SolidBrush(cPrimaryLight);

            bControlBackground = new SolidBrush(cSecondaryDark);
            bControlBackgroundHover = new SolidBrush(cSecondaryDarkMid);
            bControlBackgroundActive = new SolidBrush(cPrimaryLightLightLight);

            pBorder = new Pen(cPrimary);
            pCaptionControls = new Pen(cPrimaryDark, 2f);
            pCaptionControlsActive = new Pen(cSecondary, 2f);
            pCaptionControlsShadow = new Pen(cPrimaryLight, 2f);

            pControlBorder = new Pen(cSecondaryDarkDark);
            pControlBorderFocused = new Pen(cPrimaryLight);
        }
    }
}
