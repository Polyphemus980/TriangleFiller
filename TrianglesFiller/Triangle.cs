using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesFiller
{
    public class Triangle
    {
        public Vertex[] vertices;

        public Triangle(Vertex v1, Vertex v2,Vertex v3) 
        {
            vertices = new Vertex[] {v1,v2,v3};
        }
        
        public Vector3 CenterPosition => 1.0f/3 * (vertices[0].postRotationPosition + vertices[1].postRotationPosition + vertices[2].postRotationPosition);
        public Vector3 CenterNormal => Vector3.Normalize(1.0f / 3 * (vertices[0].postRotationNormal + vertices[1].postRotationNormal + vertices[2].postRotationNormal));
        public Vector3 CenterTangentU => Vector3.Normalize(1.0f / 3 * (vertices[0].postRotationTangentU + vertices[1].postRotationTangentU + vertices[2].postRotationTangentU));
        public Vector3 CenterTangentV => Vector3.Normalize(1.0f / 3 * (vertices[0].postRotationTangentV + vertices[1].postRotationTangentV + vertices[2].postRotationTangentV));

        public float uCenter => (vertices[0].u + vertices[1].u + vertices[2].u)/3;
        public float vCenter => (vertices[0].v + vertices[1].v + vertices[2].v)/3;
    }
}
