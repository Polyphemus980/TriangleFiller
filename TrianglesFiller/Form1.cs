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
        public float lightingSourceZ = 250;
        public int radius = 300;
        public double radians = 0;
        public float lightingSourceX = 0;
        public float lightingSourceY = 0;
        public bool lightingExpanding = true;
        public drawingMode dMode = drawingMode.FillOnly;
        public Vector3 lightingPosition =>
            new Vector3(lightingSourceX, lightingSourceY, lightingSourceZ);
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
            updateLightingTimer.Interval = 50;
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
            lightingSourceX = (float)(radius * Math.Sin(radians));
            lightingSourceY = (float)(radius * Math.Cos(radians));
            drawingPanel.Invalidate();
        }

        private void drawingPanel_Resize(object sender, EventArgs e)
        {
            drawingPanel.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            updateLightingTimer.Enabled = checkBox1.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog
            {
                Filter = "Image Files|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tiff;*.jfif",
                Title = "Select texture file",
            };
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                string path = openFile.FileName;
                normalBitmap = new Bitmap(path);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (normalBitmap != null)
                normalMap = checkBox2.Checked;
            else
            {
                checkBox2.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (normalBitmap != null)
                usingTexture = checkBox3.Checked;
            else
            {
                checkBox3.Checked = false;
            }
        }
    }
}
