using System.Windows.Forms;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;

public class RoundButton : Button
{
    protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
    {
        GraphicsPath grPath = new GraphicsPath();
        grPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
        this.Region = new System.Drawing.Region(grPath);
        base.OnPaint(e);
        // --   Zorgen dat d ebutton transparent is.
        FlatStyle = FlatStyle.Flat;
        FlatAppearance.BorderSize = 0;
        base.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
    }
}