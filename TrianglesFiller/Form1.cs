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
        public float lightingSourceZ = 100;
        public int radius = 400;
        public double radians = 0;
        public float lightingSourceX = 0;
        public float lightingSourceY = 0;

        public Vector3 lightingVector => new Vector3(lightingSourceX, lightingSourceY, lightingSourceZ);
        System.Windows.Forms.Timer updateLightingTimer;
        public Color fillingColor = Color.FromArgb(128, 30, 200);
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
            updateLightingTimer = new System.Windows.Forms.Timer();
            updateLightingTimer.Interval = 100;
            updateLightingTimer.Tick += UpdateLightingTimer_Tick;
            triangles = new List<Triangle>();
            LoadPoints();
            sampleCount = 20;
            points = new Vertex[sampleCount, sampleCount];
            SamplePoints();
            TriangulatePoints();
            this.DoubleBuffered = true;
            updateLightingTimer.Enabled = true;
        }

        private void UpdateLightingTimer_Tick(object? sender, EventArgs e)
        {
            radians += Math.PI / 100;
            lightingSourceX = (float)(radius * Math.Cos(radians));
            lightingSourceY = (float)(radius * Math.Sin(radians));
            drawingPanel.Invalidate();
        }
        
        private void drawingPanel_Resize(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();
        }
    }
}
