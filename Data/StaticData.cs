using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Creator_NT.Data
{
    internal static class StaticData
    {
        public static List<string> MapLocations = new List<string>();
        public static Dictionary<string, string> ItemList = new Dictionary<string, string>();
        public static Dictionary<string, string> NormalNPCs = new Dictionary<string, string>();
        public static Dictionary<string, string> Marriagables = new Dictionary<string, string>();
        public static string CreatorDirectory = Environment.CurrentDirectory;
        public static List<string> ProjectList = new List<string>();
        public static string CurrentProject;
    }
}
