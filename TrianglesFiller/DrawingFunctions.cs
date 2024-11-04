
using System.Numerics;
namespace TrianglesFiller
{
    public partial class Form1: Form
    {
        public bool normalMap = false;
        public (float r,float g, float b) lightColor = (1,1,1);
        public Bitmap normalBitmap;
        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.ScaleTransform(1, -1);
            g.TranslateTransform(drawingPanel.Width / 2, -drawingPanel.Height / 2);
            SolidBrush brush = new SolidBrush(fillingColor);
            g.FillEllipse(brush, lightingSourceX, lightingSourceY, 10, 10);
            if (triangles != null)
            {
                foreach (Triangle t in triangles)
                {
                    if (dMode == drawingMode.FillOnly)
                    {
                        FillTriangle(g, t, calculateFillingColor(t));
                    }
                    else
                    {
                        SolidBrush b = new SolidBrush(calculateFillingColor(t));
                        var points2D = new PointF[3];
                        for (int i = 0; i < 3; i++)
                        {
                            points2D[i] = new PointF(t.vertices[i].postRotationPosition.X, t.vertices[i].postRotationPosition.Y);
                        }
                        g.DrawPolygon(new Pen(Color.Red), points2D);
                        foreach (Vector3 v in loadedPoints)
                        {
                            g.FillEllipse(Brushes.Yellow, v.X, v.Y, 5, 5);
                        }
                        
                    }
                }
            }
        }

        public Vector3 calculateModifiedNormal(Triangle t)
        {
            Vector3 tangentU = t.CenterTangentU;
            Vector3 tangentV = t.CenterTangentV;
            Vector3 normal = t.CenterNormal;
            Matrix4x4 M = new Matrix4x4(
            tangentU.X, tangentV.X, normal.X, 0,
            tangentU.Y, tangentV.Y, normal.Y, 0,
            tangentU.Z, tangentV.Z, normal.Z, 0,
            0,          0,          0,        1
            );
            int x = (int)(t.uCenter * (normalBitmap.Width - 1));
            int y = (int)(t.vCenter * normalBitmap.Height - 1);
            Color c = normalBitmap.GetPixel(x, y);
            Vector3 textureNormal = new Vector3(
            (c.R / 255.0f) * 2.0f - 1.0f, 
            (c.G / 255.0f) * 2.0f - 1.0f,  
            (c.B / 255.0f) * 2.0f - 1.0f   
            );
            Vector3 finalNormal = Vector3.Transform(textureNormal, M);
            Vector3 normalized = Vector3.Normalize(finalNormal);
            return normalized;
        }
        public Color calculateFillingColor(Triangle t)
        {
            Vector3 normal = normalMap ? calculateModifiedNormal(t) : t.CenterNormal;

            double r, g, b;
            if (normalMap)
            {
                int x = (int)(t.uCenter * (normalBitmap.Width - 1));
                int y = (int)(t.vCenter * normalBitmap.Height - 1);
                Color c = normalBitmap.GetPixel(x, y);
                r = c.R / 255.0f;
                g = c.G / 255.0f;
                b = c.B / 255.0f;
            }
            else
            {
                r = fillingColor.R * 1.0f / 255;
                g = fillingColor.G * 1.0f / 255;
                b = fillingColor.B * 1.0f / 255;
            }

            Vector3 lightVector = Vector3.Normalize(lightingPosition - t.CenterPosition);
            Vector3 V = new Vector3(0, 0, 1);

            Vector3 R = Vector3.Dot(normal, lightVector) * 2 * normal - lightVector;
            float NLCosine = Math.Max(0,Vector3.Dot(lightVector, normal));
            float VRCosine = (float) Math.Pow(Math.Max(0, Vector3.Dot(V, R)), m);
            double rnew = (kd * r * lightColor.r * NLCosine + lightColor.r * ks * r * VRCosine) * 255;
            double gnew = (kd * g * lightColor.g * NLCosine + lightColor.g * ks * g * VRCosine) * 255;
            double bnew = (kd * b * lightColor.b * NLCosine + lightColor.b * ks * b * VRCosine) * 255;

            int finalR = (int)Math.Min(255, Math.Round(rnew));
            int finalG = (int)Math.Min(255, Math.Round(gnew));
            int finalB = (int)Math.Min(255, Math.Round(bnew));

            return Color.FromArgb(finalR, finalG, finalB);
        }

        private class Edge
        {
            public float yMin, yMax, slopeInverse;
            public float currentX;

            public Edge(Vector3 p1, Vector3 p2)
            {
                if (p1.Y < p2.Y)
                {
                    yMin = p1.Y;
                    yMax = p2.Y;
                    currentX = p1.X;
                }
                else
                {
                    yMin = p2.Y;
                    yMax = p1.Y;
                    currentX = p2.X;
                }

                slopeInverse = (p2.X - p1.X) / (p2.Y - p1.Y);
            }

            public void UpdateCurrentX()
            {
                currentX += slopeInverse;
            }
        }
        private void FillTriangle(Graphics g, Triangle t, Color c)
        {
            int yMin = int.MaxValue;
            int yMax = int.MinValue;

            List<Edge> edges = new List<Edge>();

            for (int i = 0; i < t.vertices.Length; i++)
            {
                Edge e = new Edge(t.vertices[i].postRotationPosition, t.vertices[(i + 1) % t.vertices.Length].postRotationPosition);
                edges.Add(e);
                yMin = Math.Min(yMin, (int)(e.yMin));
                yMax = Math.Max(yMax, (int)e.yMax);
            }

            List<Edge> activeEdges = new List<Edge>();
            for (int y = yMin; y <= yMax; y++)
            {
                activeEdges.Clear();
                foreach (var edge in edges)
                {
                    if (y >= edge.yMin && y < edge.yMax)
                        activeEdges.Add(edge);
                }

                activeEdges.Sort((e1, e2) => e1.currentX.CompareTo(e2.currentX));


                for (int i = 0; i < activeEdges.Count; i += 2)
                {
                    if (i + 1 >= activeEdges.Count)
                        break;

                    Edge e1 = activeEdges[i];
                    Edge e2 = activeEdges[i + 1];

                    int xStart = (int)Math.Ceiling(e1.currentX);
                    int xEnd = (int)Math.Ceiling(e2.currentX);

                    for (int x = xStart; x < xEnd; x++)
                    {
                        g.FillRectangle(new SolidBrush(c), x, y, 1, 1);
                    }
                }
                foreach (var edge in activeEdges)
                {
                    edge.UpdateCurrentX();
                }
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog g = new ColorDialog();
            if (g.ShowDialog() == DialogResult.OK)
            {
                fillingColor = g.Color;
                colorButton.BackColor = g.Color;
                drawingPanel.Invalidate();
            }
        }
    }
}
