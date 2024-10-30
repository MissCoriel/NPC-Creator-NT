using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Creator_NT.DataModels
{
    internal class HomeSpawnModel
    {
        public string Id { get; set; } //Unique ID of Spawn
        public string Condition { get; set; } = null; //gamestate can effect this if not null
        public string Location { get; set; } = null; //Spawn Map
        public PointModel Tile { get; set; } //Use only X and Y
        public string Direction { get; set; } = "up";
    }
}
