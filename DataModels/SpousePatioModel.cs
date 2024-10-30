using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Creator_NT.DataModels
{
    internal class SpousePatioModel
    {
        public string MapAsset { get; set; } = null;
        public RectangleModel MapSourceRect { get; set; }
        public int[][] SpriteAnimationFrames { get; set; }
        public PointModel SpritePixelOffset { get; set; }
    }
}
