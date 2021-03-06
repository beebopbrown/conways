﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameOfLife.Patterns.Oscillators
{
    /// <summary>
    /// The beacon pattern.
    /// Initial Size: 4x4
    /// Max Size: 4x4
    /// </summary>
    public class Beacon : Oscillator
    {
        /// <summary>
        /// Creates a new beacon patter
        /// </summary>
        public Beacon() : base(4, 4, 4, 4) { }

        /// <summary>
        /// Builds the beacon pattern.
        /// </summary>
        protected override void Build()
        {
            Cells[0, 0] = true;
            Cells[0, 1] = true;
            Cells[1, 0] = true;

            Cells[2, 3] = true;
            Cells[3, 2] = true;
            Cells[3, 3] = true;
        }
    }
}
