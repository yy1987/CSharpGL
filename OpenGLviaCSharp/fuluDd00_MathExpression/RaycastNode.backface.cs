﻿using CSharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fuluDd00_MathExpression
{
    public partial class RaycastNode
    {
        private const string backfaceVert = @"#version 150

in vec3 inPosition;
in vec3 inBoundingBox;

out vec3 passExitPoint;

uniform mat4 mvpMat;


void main()
{
    passExitPoint = inBoundingBox;
    gl_Position = mvpMat * vec4(inPosition, 1.0);
}
";
        private const string backfaceFrag = @"#version 150

in vec3 passExitPoint;
out vec4 outColor;


void main()
{
    outColor = vec4(passExitPoint, 1.0);
}
";
    }
}
