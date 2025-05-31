using Newtonsoft.Json;
using NPC_Creator_NT.Data;
using NPC_Creator_NT.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NPC_Creator_NT.Forms
{
    public partial class CharacterData : Form
    {
        Dictionary<string, string> NPCRelationLibrary = new Dictionary<string, string>();

        public CharacterData()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CD_DISPLAYNAME_TextChanged(object sender, EventArgs e)
        {

        }

        private void CharacterData_Load(object sender, EventArgs e)
        {
            //populate lists
            foreach (string locations in StaticData.MapLocations)
            {
                HomeMapList.Items.Add(locations);
            }
            foreach (KeyValuePair<string, string> item in StaticData.ItemList)
            {
                ItemList.Items.Add(item.Key);
            }
            foreach (KeyValuePair<string, string> npc in StaticData.NormalNPCs)
            {
                CD_NPCRELATION.Items.Add(npc.Value);
                CD_NPCLISTLOVE.Items.Add(npc.Value);
            }
            foreach (KeyValuePair<string, string> npc in StaticData.Marriagables)
            {
                CD_NPCRELATION.Items.Add(npc.Value);
                CD_NPCLISTLOVE.Items.Add(npc.Value);
            }

        }
        public Rectangle GetTileArea(int tileIndex, int tileWidth, int tileHeight, int sheetWidthInTiles)
        {
            int x = tileIndex % sheetWidthInTiles;
            int y = tileIndex / sheetWidthInTiles;
            return new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
        }
        public void LoadImageData()
        {

        }
        public void AssembleData()
        {
            if (CD_ENABLERELATIONS.Checked)
            {

            }
        }

        private void CD_ENABLERELATIONS_CheckedChanged(object sender, EventArgs e)
        {
            if (CD_ENABLERELATIONS.Checked == false)
            {
                CD_NPCLISTLOVE.Enabled = false;
                CD_NPCRELATION.Enabled = false;
                CD_RELATIONLIST.Enabled = false;
                CD_RELLABEL.Enabled = false;
                CD_RELATIONDEL.Enabled = false;
                CD_ADDRELATIONBUTTON.Enabled = false;
                CD_RELATIONDEL.Enabled = false;
                CD_CLEARRELATION.Enabled = false;
            }
            if (CD_ENABLERELATIONS.Checked == true)
            {
                CD_NPCLISTLOVE.Enabled = true;
                CD_NPCRELATION.Enabled = true;
                CD_RELATIONLIST.Enabled = true;
                CD_RELLABEL.Enabled = true;
                CD_RELATIONDEL.Enabled = true;
                CD_ADDRELATIONBUTTON.Enabled = true;
                CD_RELATIONDEL.Enabled = true;
                CD_CLEARRELATION.Enabled = true;

            }

        }

        private void CDCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CD_ADDRELATIONBUTTON_Click(object sender, EventArgs e)
        {
            NPCRelationLibrary.Add(CD_NPCRELATION.Text, CD_RELLABEL.Text);
            CD_RELATIONLIST.Items.Add($"{CD_NPCRELATION.Text}: {CD_RELLABEL.Text}");
            CD_RELLABEL.Text = null;
        }

        private void CD_RELATIONDEL_Click(object sender, EventArgs e)
        {
            try
            {
                string keyextract = CD_RELATIONLIST.Text.Substring(0, CD_RELATIONLIST.Text.IndexOf(':'));
                NPCRelationLibrary.Remove(keyextract);
                CD_RELATIONLIST.Items.Remove(CD_RELATIONLIST.SelectedItem);

            }
            catch (Exception ex)
            {
                //Leave Blank.. Should only give errors if you try to delete nothing.
            }
        }

        private void CD_CLEARRELATION_Click(object sender, EventArgs e)
        {
            NPCRelationLibrary.Clear();
            CD_RELATIONLIST.Items.Clear();
        }

        private void WSGiftAdd_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<string, string> item in StaticData.ItemList)
            {
                if (item.Key == ItemList.Text)
                {
                    GiftList.Items.Add(item.Value);
                }
            }
        }

        private void WSGiftDelete_Click(object sender, EventArgs e)
        {
            GiftList.Items.Remove(GiftList.SelectedItems);
        }

        private void WSGiftClear_Click(object sender, EventArgs e)
        {
            GiftList.Items.Clear();
        }

        private void SHAKELIST_SelectedIndexChanged(object sender, EventArgs e)
        {
            //no implementation
        }

        private void CDCreate_Click(object sender, EventArgs e)
        {
            //Begin adding in Data
            string CharacterId = "{{ModId}}_" + CD_NPCNAME.Text;
            DataModels.HomeSpawnModel DefaultHome = new DataModels.HomeSpawnModel
            {
                Id = HOMEUniqueID.Text,
                Condition = null, //conditions not implemented
                Location = HomeMapList.Text,
                Tile = new PointModel
                {
                    X = (int)XTilePos.Value,
                    Y = (int)YTilePos.Value
                },
                Direction = FacingPosition.Text,
            };
            DataModels.NPCCharacterDataModel NPCDatum = new DataModels.NPCCharacterDataModel
            {
                DisplayName = CD_DISPLAYNAME.Text,
                BirthSeason = CD_BDAYSEASON.Text,
                BirthDay = (int)CS_BIRTHDAYDAY.Value,
                HomeRegion = CD_HOMEREGION.Text,
                Language = CD_LANGUAGE.Text,
                Gender = CD_GENDER.Text,
                Age = CD_AGE.Text,
                Manner = CD_MANNERS.Text,
                SocialAnxiety = CD_ANXIETY.Text,
                Optimisim = CD_OPTIMISM.Text,
                IsDarkSkinned = CD_DARKSKIN.Checked,
                CanBeRomanced = CD_ROMANCE.Checked,
                LoveInterest = CD_NPCLISTLOVE.Text,
                Calendar = CD_CALENDAR.Text,
                SocialTab = CD_SocialTab.Text,
                CanSocialize = CD_CANSOCIALIZE.Checked,
                CanRecieveGifts = CD_ALLOWGIFTS.Checked,
                CanGreetNearbyCharacters = CD_GREETOTHER.Checked,
                CanCommentOnPurchasedShopItems = CD_COMMENTITEMS.Checked,
                CanVisitIsland = CD_VISITISLAND.Checked,
                IntroductionQuest = CD_INTRO.Checked,
                ItemDeliveryQuests = CD_ITEMDELIVERY.Checked,
                PerfectionScore = CD_Perfection.Checked,
                EndSlideShow = CD_ENDING.Text,
                SpouseAdopts = CD_ADOPT.Checked,
                SpouseWantsChildren = CD_WANTSKIDS.Checked,
                SpouseGiftJealousy = CD_GIFTJEALOUS.Checked,
                SpouseGiftJealousyFriendshipChange = (int)CD_FPLOSS.Value,
                SpouseRoom = null,//Not Implemented
                SpousePatio = null,//Not Implemented
                SpouseFloors = null,//Not Implemented
                DumpsterDiveFriendshipEffect = (int)CD_FPADJUSTDD.Value, //Not Implemented
                DumpsterDiveEmote = 8,
                FriendsAndFamily = null,//Not Implemented
                FlowerDanceCanDance = CDCanDance.Checked,
                WinterStarGifts = null, //not implemented
                WinterStarParticipant = CDWinterStar.Checked,
                UnlockConditions = null,//Not Implemented
                SpawnIfMissing = true,//Not implemented
                Home = DefaultHome, //single home implemented
                TextureName = null,//No implementation
                Appearance = null,//Not Implemented
                MugShotSourceRect = null, //No implementation
                Size = new PointModel
                {
                    X = 16,
                    Y = 32,
                },
                Breather = true,
                BreatherChestPosition = null,//No custom implementation
                BreatherChestRect = null,//No custom Implementation
                Shadow = null, //No custom implementation
                EmoteOffset = new PointModel
                {
                    X = 0,
                    Y = 0,
                },
                ShakePortraits = null, //Not Implemented
                KissSpriteIndex = 33,//Placeholder
                KissSpriteFacingRight = false, //placeholder
                HiddenProfileEmoteSound = null, //No customization
                HiddenProfileEmoteDuration = -1, //Default
                HiddenProfileEmoteStartFrame = 16,//placeholder
                HiddenProfileEmoteFrameCount = 4,//placeholder
                HiddenProfileEmoteFrameDuration = 200,//Placeholder, default
                FormerCharacterNames = null,//not implemented                
            }; 
            DataModels.CDPatchModel CharacterData = new DataModels.CDPatchModel
            {
                Action = "EditData",
                Target = "Data/Characters",
                Entries = new Dictionary<string, DataModels.NPCCharacterDataModel>
                {
                    [CharacterId] = NPCDatum
                }
            };
            //Ensure you have A Data Path
            Forms.SelectProject setFolder = new Forms.SelectProject();
            setFolder.Text = "Choose a Project";
            setFolder.ShowDialog();
            string project = Path.Combine(Data.StaticData.CreatorDirectory, "Projects", Data.StaticData.CurrentProject);
            Directory.CreateDirectory(Path.Combine(project, "assets", "Data"));
            string datasave = Path.Combine(project, "assets", "Data", "NPCData.json");
            File.WriteAllText(datasave, JsonConvert.SerializeObject(CharacterData, new JsonSerializerSettings { Formatting = Formatting.Indented, NullValueHandling = NullValueHandling.Ignore }));
        }
    }
}
