using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesFiller
{
    public partial class Form1 : Form
    {
        public enum drawingMode
        {
            MeshOnly,
            FillOnly
        }
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

        private void sampleSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            sampleCount = sampleSizeTrackBar.Value;
            sampleCountLabel.Text = sampleCount.ToString();
            RecalculatePoints();
            drawingPanel.Invalidate();
        }

        private void fillRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (fillRadio.Checked)
            {
                dMode = drawingMode.FillOnly;
                drawingPanel.Invalidate();
            }
        }

        private void meshRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (meshRadio.Checked)
            {
                dMode = drawingMode.MeshOnly;
                drawingPanel.Invalidate();
            }
        }
    }
}
