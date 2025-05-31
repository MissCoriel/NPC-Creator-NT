using Microsoft.VisualBasic;
using StardewModdingAPI.Toolkit.Framework.ModScanning;
using StardewModdingAPI.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StardewModdingAPI;
using Newtonsoft.Json;
using NPC_Creator_NT.Data;
using NPC_Creator_NT.DataModels;
namespace NPC_Creator_NT.Forms
{
    public partial class _00Loading : Form
    {
        public static string SDVFilePath;
        public static string UnpackedPath;
        public static string ContentPatcher;
        public static string ToolKit;
        public _00Loading()
        {
            InitializeComponent();
        }
        private void GetCP()
        {

            if (!string.IsNullOrEmpty(SDVFilePath))
            {
                //MessageBox.Show($"Game Folder is {SDVFilePath}", "Test", MessageBoxButtons.OK);

                string getSMAPI = Path.Combine(SDVFilePath, "smapi-internal", "SMAPI.Toolkit.dll");
                //MessageBox.Show(getSMAPI, "Test", MessageBoxButtons.OK);
                string getSMAPICORE = Path.Combine(SDVFilePath, "smapi-internal", "SMAPI.Toolkit.CoreInterfaces.dll");
                Assembly.LoadFrom(getSMAPI);
                Assembly.LoadFrom(getSMAPICORE);
                ModFolder? contentPatcher = new ModToolkit()
                .GetModFolders(SDVFilePath, true)
                .FirstOrDefault(p => p.Manifest?.UniqueID == "Pathoschild.ContentPatcher");

                ISemanticVersion? version = contentPatcher?.Manifest?.Version;
                ContentPatcher = version.ToString();
                MessageBox.Show($"Content Patcher {version.ToString()} Located.  This will be your format!");
            }

        }
        public void PropogateLists()
        {
            if (!Directory.Exists(Path.Combine(SDVFilePath, "ExtractedData")))
            {
                MessageBox.Show("NPC Tool Kit not found.  Using prepacked data.", "NPC Utility Intergration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string rawItem = File.ReadAllText(Path.Combine(StaticData.CreatorDirectory, "Data", "Default", "ItemList.json"));
                var itempopulate = JsonConvert.DeserializeObject<Dictionary<string, string>>(rawItem);
                foreach (KeyValuePair<string, string> item in itempopulate)
                {
                    StaticData.ItemList.TryAdd(item.Key, item.Value);
                }
                string NPCDataA = File.ReadAllText(Path.Combine(StaticData.CreatorDirectory, "Data", "Default", "NPCMarriagable.json"));
                var NPCDataAA = JsonConvert.DeserializeObject<Dictionary<string, string>>(NPCDataA);
                string NPCDataB = File.ReadAllText(Path.Combine(StaticData.CreatorDirectory, "Data", "Default", "NPCNonMarriageable.json"));
                var NPCDataBB = JsonConvert.DeserializeObject<Dictionary<string, string>>(NPCDataB);
                foreach (KeyValuePair<string, string> npc in NPCDataAA)
                {
                    StaticData.Marriagables.TryAdd(npc.Key, npc.Value);
                }
                foreach (KeyValuePair<string, string> npc in NPCDataBB)
                {
                    StaticData.NormalNPCs.TryAdd(npc.Key, npc.Value);
                }
                string[] maplocale = File.ReadAllLines(Path.Combine(StaticData.CreatorDirectory, "Data", "Default", "MapList.txt"));
                foreach (string locale in maplocale)
                {
                    StaticData.MapLocations.Add(locale);
                }
            }
            else
            {
                string rawItem = File.ReadAllText(Path.Combine(SDVFilePath, "ExtractedData", "ItemList.json"));
                var itempopulate = JsonConvert.DeserializeObject<Dictionary<string, string>>(rawItem);
                foreach (KeyValuePair<string, string> item in itempopulate)
                {
                    StaticData.ItemList.TryAdd(item.Key, item.Value);
                }
                string NPCDataA = File.ReadAllText(Path.Combine(SDVFilePath, "ExtractedData", "NPCMarriagable.json"));
                var NPCDataAA = JsonConvert.DeserializeObject<Dictionary<string, string>>(NPCDataA);
                string NPCDataB = File.ReadAllText(Path.Combine(SDVFilePath, "ExtractedData", "NPCNonMarriageable.json"));
                var NPCDataBB = JsonConvert.DeserializeObject<Dictionary<string, string>>(NPCDataB);
                foreach (KeyValuePair<string, string> npc in NPCDataAA)
                {
                    StaticData.Marriagables.TryAdd(npc.Key, npc.Value);
                }
                foreach (KeyValuePair<string, string> npc in NPCDataBB)
                {
                    StaticData.NormalNPCs.TryAdd(npc.Key, npc.Value);
                }
                string[] maplocale = File.ReadAllLines(Path.Combine(SDVFilePath, "ExtractedData", "MapList.txt"));
                foreach (string locale in maplocale)
                {
                    StaticData.MapLocations.Add(locale);
                }

            }

        }
        public void Setup()
        {
            //First Check for Settings
            if (!File.Exists(Path.Combine(Environment.CurrentDirectory, "Data", "Settings.json")))
            {
                //No Settings, get SDV directory to work
                MessageBox.Show("No settings were found.  Please locate Stardew Valley's executable.", "Setup", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                OpenFileDialog SDVsearch = new OpenFileDialog();
                SDVsearch.Title = "Select your Stardew Valley Executable";
                SDVsearch.Filter = "Executables (*.exe)|*.exe";
                SDVsearch.FilterIndex = 1;
                if (SDVsearch.ShowDialog() == DialogResult.OK)
                {
                    SDVFilePath = Path.GetDirectoryName(SDVsearch.FileName);
                    //Test Path
                    if (File.Exists(Path.Combine(SDVFilePath, "Stardew Valley.exe")))
                    {
                        MessageBox.Show($"{SDVFilePath} has been successfully found!\nPress OK to begin search for Unpacked Content Folder.", "Stardew Valley Game Folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        if (Directory.Exists(Path.Combine(SDVFilePath, "Content (unpacked)")))
                        {
                            UnpackedPath = Path.Combine(SDVFilePath, "Content (unpacked)");
                            MessageBox.Show("Stardew Xnb Hack output folder was found!\nUnpacked Content Folder set!", "Unpacked Content Folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            MessageBox.Show("No Xnb Hack output folder found.\nPlease designate unpacked folder!", "Set Content Folder Manually", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            SaveFileDialog ManualContent = new SaveFileDialog();
                            ManualContent.Title = "Save This in your content folder.";
                            ManualContent.FileName = "content.txt";
                            if (ManualContent.ShowDialog() == DialogResult.OK)
                            {
                                string dummy = "This text file is for tracking purposes! <3";
                                File.WriteAllText(ManualContent.FileName, dummy);
                                UnpackedPath = Path.GetDirectoryName(ManualContent.FileName);
                            }
                        }

                    }

                }
                //string getSMAPI = Path.Combine(SDVFilePath, "smapi-internal", "SMAPI.Toolkit.dll");
                //Assembly.Load(getSMAPI);
                GetCP();
                PropogateLists();
                SaveSettings();
            }
            if(!File.Exists(Path.Combine(Environment.CurrentDirectory, "Data", "Settings.json")))
            {

                string getSMAPI = Path.Combine(SDVFilePath, "smapi-internal", "SMAPI.Toolkit.dll");
                Assembly.LoadFrom(getSMAPI);
                GetCP();
                PropogateLists();
                SaveSettings();
            }
            DataModels.SettingsModel settingsModel = new DataModels.SettingsModel
            {
                SDVFilePath = SDVFilePath,
                UnpackedFolder = UnpackedPath,
                CPFormat = ContentPatcher,
            };
            if(File.Exists(Path.Combine(Environment.CurrentDirectory, "Data", "Settings.json")))
            {
                string settings = File.ReadAllText((Path.Combine(Environment.CurrentDirectory, "Data", "Settings.json")));
                var parseSettings = JsonConvert.DeserializeObject<Dictionary<string, string>>(settings);
                foreach (KeyValuePair<string, string> listsettings in parseSettings)
                {
                    if (listsettings.Key == "SDVFilePath")
                    {
                        SDVFilePath = listsettings.Value;
                    }
                }
                string getSMAPI = Path.Combine(SDVFilePath, "smapi-internal", "SMAPI.Toolkit.dll");
                Assembly.LoadFrom(getSMAPI);
                GetCP();
                PropogateLists();
                SaveSettings();
            }
            this.Close();

        }
        public void SaveSettings()
        {
            DataModels.SettingsModel settings = new DataModels.SettingsModel
            {
                SDVFilePath = SDVFilePath,
                UnpackedFolder = UnpackedPath,
                CPFormat = ContentPatcher,
            };
            Directory.CreateDirectory(Path.Combine(Environment.CurrentDirectory, "Data"));
            File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "Data", "Settings.json"), JsonConvert.SerializeObject(settings, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));

        }

        private void _00Loading_Load(object sender, EventArgs e)
        {
            Setup();
            if (Directory.Exists(Path.Combine(Environment.CurrentDirectory, "Projects")))
            {
                StaticData.ProjectList = Directory.EnumerateDirectories(Path.Combine(Environment.CurrentDirectory, "Projects")).Select(d => new DirectoryInfo(d).Name).ToList();
                MessageBox.Show($"NPC Creator has found {StaticData.ProjectList.Count} Projects.", "Project Count", MessageBoxButtons.OK);
            }
        }
    }
}
