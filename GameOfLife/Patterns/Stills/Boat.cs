﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Stills
{
    /// <summary>
    /// The boat pattern:
    /// Size: 3x3
    /// </summary>
    public class Boat : Pattern
    {
        /// <summary>
        /// Create the boat pattern.
        /// </summary>
        public Boat() : base(3, 3) { }


        /// <summary>
        /// Build the boat pattern
        /// </summary>
        protected override void Build()
        {
            Cells[0, 0] = true;
            Cells[0, 1] = true;
            Cells[1, 0] = true;
            Cells[1, 2] = true;
            Cells[2, 1] = true;
        }
    }
}
