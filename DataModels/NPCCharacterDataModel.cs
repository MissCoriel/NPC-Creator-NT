using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NPC_Creator_NT.DataModels
{
    internal class NPCCharacterDataModel
    {
        public string DisplayName { get; set; }
        public string BirthSeason { get; set; }
        public int BirthDay { get; set; }
        public string HomeRegion { get; set; }
        public string Language { get; set; }
        public string Gender { get; set; }
        public string Age { get; set; }
        public string Manner { get; set; }
        public string SocialAnxiety { get; set; }
        public string Optimisim { get; set; }
        public bool IsDarkSkinned { get; set; }
        public bool CanBeRomanced { get; set; }
        public string LoveInterest { get; set; }
        public string Calendar { get; set; }
        public string SocialTab { get; set; }
        public bool CanSocialize { get; set; }
        public bool CanRecieveGifts { get; set; }
        public bool CanGreetNearbyCharacters { get; set; }
        public bool CanCommentOnPurchasedShopItems { get; set; }
        public bool CanVisitIsland { get; set; }
        public bool IntroductionQuest { get; set; }
        public bool ItemDeliveryQuests { get; set; }
        public bool PerfectionScore { get; set; }
        public string EndSlideShow { get; set; }
        public bool SpouseAdopts { get; set; }
        public bool SpouseWantsChildren { get; set; }
        public bool SpouseGiftJealousy { get; set; }
        public int SpouseGiftJealousyFriendshipChange { get; set; }
        public SpouseRoomModel SpouseRoom { get; set; }
        public SpousePatioModel SpousePatio { get; set; }
        public int[] SpouseFloors { get; set; }
        public int[] SpouseWallpapers { get; set; }
        public int DumpsterDiveFriendshipEffect { get; set; }
        public int DumpsterDiveEmote { get; set; }
        public FriendsAndFamilyModel FriendsAndFamily { get; set; }
        public bool FlowerDanceCanDance { get; set; }
        public int[] WinterStarGifts { get; set; }
        public bool WinterStarParticipant { get; set; }
        public string UnlockConditions { get; set; }
        public bool SpawnIfMissing { get; set; }
        public HomeSpawnModel Home { get; set; } //fix later
        public string TextureName { get; set; } = null;
        public string Appearance { get; set; } = null;
        public string MugShotSourceRect { get; set; } = null;
        public PointModel Size { get; set; } = null;
        public bool Breather { get; set; }
        public RectangleModel BreatherChestRect { get; set; } = null;
        public PointModel BreatherChestPosition { get; set; } = null;
        public bool? Shadow { get; set; } = null;
        public PointModel EmoteOffset { get; set; }
        public int[] ShakePortraits { get; set; }
        public int KissSpriteIndex { get; set; }
        public bool KissSpriteFacingRight { get; set; }
        public string HiddenProfileEmoteSound { get; set; } = null;
        public int HiddenProfileEmoteDuration { get; set; } = 4000;
        public int HiddenProfileEmoteStartFrame { get; set; } = 32;
        public int HiddenProfileEmoteFrameCount { get; set; } = 2;
        public int HiddenProfileEmoteFrameDuration { get; set; } = 200;
        public string[] FormerCharacterNames { get; set; }
        public Dictionary<string, string> FormerCharacterNamesMap { get; set; } = null;
    }
}
