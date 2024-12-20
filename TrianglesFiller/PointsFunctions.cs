﻿using System.Globalization;
using System.Numerics;

namespace TrianglesFiller
{
    public partial class Form1 : Form
    {
        const int pointsLength = 4;

        public void RecalculatePoints()
        {
            points = new Vertex[sampleCount, sampleCount];
            SamplePoints();
            RotateAxis();
            TriangulatePoints();
        }

        public Vertex GetPoint(float u, float v)
        {
            Vector3 point = new Vector3(0, 0, 0);
            Vector3 tangentU = new Vector3(0, 0, 0);
            Vector3 tangentV = new Vector3(0, 0, 0);

            float[] bernsteinU = new float[pointsLength];
            float[] bernsteinDerivativeU = new float[pointsLength];
            float[] bernsteinV = new float[pointsLength];
            float[] bernsteinDerivativeV = new float[pointsLength];

            for (int i = 0; i < pointsLength; i++)
            {
                bernsteinU[i] = calculateBernstein(pointsLength - 1, i, u);
                bernsteinDerivativeU[i] = calculateDerivativeBernstein(i, u);
                bernsteinV[i] = calculateBernstein(pointsLength - 1, i, v);
                bernsteinDerivativeV[i] = calculateDerivativeBernstein(i, v);
            }

            for (int i = 0; i < pointsLength; i++)
            {
                for (int j = 0; j < pointsLength; j++)
                {
                    Vector3 loadedPoint = loadedPoints[pointsLength * i + j];

                    point += bernsteinU[i] * bernsteinV[j] * loadedPoint;
                    tangentU += bernsteinDerivativeU[i] * bernsteinV[j] * loadedPoint;
                    tangentV += bernsteinDerivativeV[j] * bernsteinU[i] * loadedPoint;
                }
            }
            return new Vertex(
                point,
                Vector3.Normalize(4 * tangentU),
                Vector3.Normalize(4 * tangentV),
                u,
                v
            );
        }

        private void RotateAxis()
        {
            Matrix4x4 rotationXMatrix = Matrix4x4.CreateRotationX(
                beta * 1.0f / 180 * (float)Math.PI
            );
            Matrix4x4 rotationZMatrix = Matrix4x4.CreateRotationZ(
                alpha * 1.0f / 180 * (float)Math.PI
            );
            Matrix4x4 rotationMatrix = rotationXMatrix * rotationZMatrix;
            for (int i = 0; i < sampleCount; i++)
            {
                for (int j = 0; j < sampleCount; j++)
                {
                    points[i, j].ApplyRotation(rotationMatrix);
                }
            }
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
            return (float)(
                calculateBinomialCoefficient(top, bottom)
                * Math.Pow(t, bottom)
                * Math.Pow(1 - t, top - bottom)
            );
        }

        private int calculateBinomialCoefficient(int n, int k)
        {
            int[][] binomialCoefficients = { [1], [1, 1], [1, 2, 1], [1, 3, 3, 1] };
            return binomialCoefficients[n][k];
        }

        private float calculateDerivativeBernstein(int index, float t)
        {
            switch (index)
            {
                case 0:
                    return -3 * (1 - t) * (1 - t);
                case 1:
                    return 3 * (1 - t) * (1 - 2 * t);
                case 2:
                    return 3 * t * (2 - 3 * t);
                case 3:
                    return 3 * t * t;
                default:
                    throw new Exception(message: "shouldnt be here");
            }
        }

        private void LoadPoints()
        {
            string path = Path.Combine(Application.StartupPath, "Points.txt");
            if (!File.Exists(path))
            {
                MessageBox.Show("Must have a Points.txt file");
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
    }
}
