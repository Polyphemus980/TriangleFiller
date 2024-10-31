using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesFiller
{
    public partial class Form1 : Form
    {
        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            m = mTrackBar.Value;
            mValueLabel.Text = m.ToString();
            drawingPanel.Invalidate();
        }
        private void betaTrackBar_Scroll(object sender, EventArgs e)
        {
            betaValueLabel.Text = betaTrackBar.Value.ToString();
            beta = betaTrackBar.Value;
            RotateAxis();
            drawingPanel.Invalidate();
        }

        private void alphaTrackBar_Scroll(object sender, EventArgs e)
        {
            alphaValueLabel.Text = alphaTrackBar.Value.ToString();
            alpha = alphaTrackBar.Value;
            RotateAxis();
            drawingPanel.Invalidate();
        }
        private void ksTrackBar_Scroll(object sender, EventArgs e)
        {
            ks = ksTrackBar.Value * 1.0f / 100;
            ksValueLabel.Text = ks.ToString();
            drawingPanel.Invalidate();
        }

        private void kdTrackBar_Scroll(object sender, EventArgs e)
        {
            kd = kdTrackBar.Value * 1.0f / 100;
            kdValueLabel.Text = kd.ToString();
            drawingPanel.Invalidate();
        }

        private void ZTrackBar_Scroll(object sender, EventArgs e)
        {
            lightingSourceZ = ZTrackBar.Value;
            ZValueLabel.Text = ZTrackBar.Value.ToString();
            drawingPanel.Invalidate();
        }
    }
}
