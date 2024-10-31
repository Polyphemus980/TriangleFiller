using System.Globalization;
using System.Numerics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms.VisualStyles;

namespace TrianglesFiller
{
    public partial class Form1 : Form
    {
        private int sampleCount;
        public List<Vector3> loadedPoints = new List<Vector3>();
        public Vertex[,] points;
        public List<Triangle> triangles;
        public int alpha = 0;
        public int beta = 0;
        public float ks = 0.5f;
        public float kd = 0.5f;
        public int m = 50;
        public Color fillingColor = Color.FromArgb(128,30 ,200);
        public Form1()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember(
               "DoubleBuffered",
               BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
               null,
               drawingPanel,
               new object[] { true }
           );
            triangles = new List<Triangle>();
            LoadPoints();
            sampleCount = 20;
            points = new Vertex[sampleCount, sampleCount];
            SamplePoints();
            TriangulatePoints();
            InitializeLabels();
            this.DoubleBuffered = true;
        }

        private void InitializeLabels()
        {
            alphaValueLabel.Text = alphaTrackBar.Value.ToString();
            betaValueLabel.Text = betaTrackBar.Value.ToString();
        }
        private void TriangulatePoints()
        {
            triangles.Clear();
            for (int i = 0; i < sampleCount - 1; i++)
            {
                for (int j = 0; j < sampleCount - 1; j++)
                {
                    Vertex p1 = points[i, j];
                    Vertex p2 = points[i + 1, j];
                    Vertex p3 = points[i, j + 1];
                    Vertex p4 = points[i + 1, j + 1];
                    triangles.Add(new Triangle(p1, p2, p3));
                    triangles.Add(new Triangle(p2, p3, p4));
                }
            }
        }
        private void LoadPoints()
        {
            string path = Path.Combine(Application.StartupPath, "Points.txt");
            if (!File.Exists(path))
            {
                MessageBox.Show("Must have a points.txt file");
                Application.Exit();
            }
            using (StreamReader sr = new StreamReader(path))
            {
                string? line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] coordinates = line.Trim().Split();
                    if (coordinates.Length != 3)
                    {
                        MessageBox.Show("Incorrect format of Points.txt file");
                        Application.Exit();
                    }
                    float x = float.Parse(coordinates[0], CultureInfo.InvariantCulture);
                    float y = float.Parse(coordinates[1], CultureInfo.InvariantCulture);
                    float z = float.Parse(coordinates[2], CultureInfo.InvariantCulture);
                    Vector3 v = new Vector3(x, y, z);
                    loadedPoints.Add(v);
                }
                if (loadedPoints.Count != 16)
                {
                    MessageBox.Show("Points.txt file must have 16 points");
                    Application.Exit();
                }
            }
        }

        private void drawingPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.ScaleTransform(1, -1);
            g.TranslateTransform(drawingPanel.Width / 2, -drawingPanel.Height / 2);
            if (triangles != null)
            {
                foreach (Triangle t in triangles)
                {
                    var points2D = new PointF[3];
                    for (int i = 0; i < 3; i++)
                    {
                        points2D[i] = new PointF(t.vertices[i].postRotationPosition.X, t.vertices[i].postRotationPosition.Y);
                    }
                    e.Graphics.DrawPolygon(new Pen(Color.Red), points2D);
                    Random rnd = new Random();
                    FillTriangle(g, t, calculateFillingColor(t));//fillingColor);
                    e.Graphics.DrawPolygon(new Pen(Color.Red), points2D);
                    for (int i = 0; i < 3; i++)
                    {
                        points2D[i] = new PointF(t.vertices[i].postRotationPosition.X, t.vertices[i].postRotationPosition.Y);
                        e.Graphics.FillEllipse(Brushes.Gainsboro, t.vertices[i].postRotationPosition.X, t.vertices[i].postRotationPosition.Y, 5, 5);
                    }
                }
                foreach (Vector3 v in loadedPoints)
                {
                    e.Graphics.FillEllipse(Brushes.Yellow, v.X, v.Y, 5, 5);
                }
            }
        }

        private void SamplePoints()
        {
            for (int i = 0; i < sampleCount; i++)
            {
                float u = (float)i / (sampleCount - 1);
                for (int j = 0; j < sampleCount; j++)
                {
                    float v = (float)j / (sampleCount - 1);
                    points[i, j] = GetPoint(u, v);
                }
            }
        }

        private float calculateBernstein(int top, int bottom, float t)
        {
            return (float)(calculateBinomialCoefficient(top, bottom) * Math.Pow(t, bottom) * Math.Pow(1 - t, top - bottom));
        }

        private int calculateBinomialCoefficient(int n, int k)
        {
            int[,] C = new int[n + 1, k + 1];
            int i, j;
            for (i = 0; i <= n; i++)
            {
                for (j = 0; j <= Math.Min(i, k); j++)
                {
                    if (j == 0 || j == i)
                        C[i, j] = 1;
                    else
                        C[i, j] = C[i - 1, j - 1] + C[i - 1, j];
                }
            }
            return C[n, k];
        }

        private float calculateDerivativeBernstein(int index, float t)
        {
            switch (index)
            {
                case 0: return -3 * (1 - t) * (1 - t);
                case 1: return 3 * (1 - t) * (1 - 2 * t);
                case 2: return 3 * t * (2 - 3 * t);
                case 3: return 3 * t * t;
                default: throw new Exception(message: "shouldnt be here");
            }
        }

        public Color calculateFillingColor(Triangle t)
        {
            double r = fillingColor.R * 1.0f/255;
            double g = fillingColor.G * 1.0f/255;
            double b = fillingColor.B * 1.0f/255;

            Vector3 lightDirection = new Vector3(1, 0, 0);
            Vector3 normalizedL = Vector3.Normalize(lightDirection);
            Vector3 V = new Vector3(0, 0, 1);
            Vector3 R = Vector3.Reflect(-normalizedL, t.CenterNormal);
            double rnew = (kd * r * Math.Max(0, Vector3.Dot(normalizedL, t.CenterNormal)) +
                 ks * r * Math.Pow(Math.Max(0, Vector3.Dot(V, R)), m)) * 255;

            double gnew = (kd * g * Math.Max(0, Vector3.Dot(normalizedL, t.CenterNormal)) +
                             ks * g * Math.Pow(Math.Max(0, Vector3.Dot(V, R)), m)) * 255;

            double bnew = (kd * b * Math.Max(0, Vector3.Dot(normalizedL, t.CenterNormal)) +
                             ks * b * Math.Pow(Math.Max(0, Vector3.Dot(V, R)), m)) * 255;

            int finalR = (int)(rnew);
            int finalG = (int)(gnew);
            int finalB = (int)(bnew);
            
            return Color.FromArgb(finalR, finalG, (int) bnew);
        }
        public Vertex GetPoint(float u, float v)
        {
            Vector3 point = new Vector3(0, 0, 0);
            Vector3 tangentU = new Vector3(0, 0, 0);
            Vector3 tangentV = new Vector3(0, 0, 0);
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    float BernsteinU = calculateBernstein(3, i, u);
                    float BernsteinDerivativeU = calculateDerivativeBernstein(i, u);
                    float BernsteinDerivateV = calculateDerivativeBernstein(j, v);
                    float BernsteinV = calculateBernstein(3, j, v);
                    point += BernsteinU * BernsteinV * loadedPoints[4 * i + j];
                    tangentU += BernsteinDerivativeU * BernsteinV * loadedPoints[4 * i + j];
                    tangentV += BernsteinDerivateV * BernsteinU * loadedPoints[4 * i + j];
                }
            }
            return new Vertex(point,Vector3.Normalize(tangentU),Vector3.Normalize(tangentV));
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
        private void RotateAxis()
        {
            Matrix4x4 rotationXMatrix = Matrix4x4.CreateRotationX(beta * 1.0f / 180 * (float)Math.PI);
            Matrix4x4 rotationZMatrix = Matrix4x4.CreateRotationZ(alpha * 1.0f / 180 * (float)Math.PI);
            Matrix4x4 rotationMatrix = rotationXMatrix * rotationZMatrix;
            for (int i = 0; i < sampleCount; i++)
            {
                for (int j = 0; j < sampleCount; j++)
                {
                    points[i, j].ApplyRotation(rotationMatrix);
                }
            }
            TriangulatePoints();
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
                if (e.yMin != e.yMax)
                {
                    edges.Add(e);
                    yMin = Math.Min(yMin, (int)e.yMin);
                    yMax = Math.Max(yMax, (int)e.yMax);
                }
            }

            List<Edge> activeEdges = new List<Edge>();
            for (int y = yMin; y < yMax; y++)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void mTrackBar_Scroll(object sender, EventArgs e)
        {
            m = mTrackBar.Value;
            mValueLabel.Text = m.ToString();
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

        private void colorButton_Click(object sender, EventArgs e)
        {
            ColorDialog g = new ColorDialog();
            if (g.ShowDialog() == DialogResult.OK)
            {
                fillingColor = g.Color;
            }
            drawingPanel.Invalidate();
        }
    }
}
