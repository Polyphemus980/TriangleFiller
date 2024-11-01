﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace TrianglesFiller
{
    public class Vertex
    {
        private Vector3 position { get; set; }
        private Vector3 normal { get; set; }
        private Vector3 tangentU { get; set; }

        private Vector3 tangentV { get; set; }
        public Vector3 postRotationNormal { get; set; }
        public Vector3 postRotationTangentU { get; set; }

        public Vector3 postRotationTangentV { get; set; }

        public Vector3 postRotationPosition { get; set; }

        public Vertex(Vector3 position,Vector3 tangentU,Vector3 tangentV)
        {
            this.position = position;
            this.normal = Vector3.Cross(tangentU,tangentV);
            this.tangentU = tangentU;
            this.tangentV = tangentV;
            postRotationPosition = position;
            postRotationNormal = normal;
            postRotationTangentU = tangentU;
            postRotationTangentV = tangentV;
        }
        
        public void ApplyRotation(Matrix4x4 rotationMatrix)
        {
            postRotationPosition = Vector3.Transform(position, rotationMatrix);
            postRotationTangentU = Vector3.Transform(tangentU, rotationMatrix);
            postRotationTangentV = Vector3.Transform(tangentV, rotationMatrix);
            postRotationNormal = Vector3.Transform(normal, rotationMatrix);
        }
    }
}
