﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Shapes
{
    /// <summary>
    /// The vertical line pattern.
    /// Size: nx1
    /// </summary>
    public class VerticalLine : Pattern
    {

        /// <summary>
        /// Create a new vertical line pattern.
        /// </summary>
        /// <param name="height">Height of the vertical line.</param>
        public VerticalLine(int height) : base(height, 1) { }

        /// <summary>
        /// Build the vertical line pattern.
        /// </summary>
        protected override void Build()
        {
            for (int i = 0; i < Height; i++)
                Cells[i, 0] = true;
        }
    }
}
