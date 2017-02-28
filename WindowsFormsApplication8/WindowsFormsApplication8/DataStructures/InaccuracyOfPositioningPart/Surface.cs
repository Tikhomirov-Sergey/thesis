using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication8.DataStuctures.InaccuracyOfPositioningPart
{
   public class Surface
    {
        public int[] id { get; set; }
        public IntervalOfInaccuracy[] intervalsOfInaccuracy { get; set; }
    }
}
