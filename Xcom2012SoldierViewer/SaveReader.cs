using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LZOHelper;
using System.IO;
using System.Reflection;

namespace Xcom2012SoldierViewer
{
    public enum ESoldierStatus : byte
    {
        eStatus_Active,
        eStatus_OnMission,
        eStatus_PsiTesting,
        eStatus_CovertOps,
        eStatus_GeneMod,
        eStatus_Augmenting,
        eStatus_Healing,
        eStatus_Dead,
        eStatus_Fatigued,
        eStatus_MAX
    };
    public enum ESoldierLocation
    {
        eSoldierLoc_Barracks,
        eSoldierLoc_Dropship,
        eSoldierLoc_Infirmary,
        eSoldierLoc_Morgue,
        eSoldierLoc_PsiLabs,
        eSoldierLoc_PsiLabsCinematic,
        eSoldierLoc_Armory,
        eSoldierLoc_Gollup,
        eSoldierLoc_CyberneticsLab,
        eSoldierLoc_GeneticsLab,
        eSoldierLoc_CovertOps,
        eSoldierLoc_Outro,
        eSoldierLoc_MecCinematic,
        eSoldierLoc_GeneModCinematic,
        eSoldierLoc_GeneModNarrative,
        eSoldierLoc_MedalCeremony,
        eSoldierLoc_MAX
    };
    public enum ENameType
    {
        eNameType_First,
        eNameType_Last,
        eNameType_Nick,
        eNameType_Full,
        eNameType_Rank,
        eNameType_RankFull,
        eNameType_FullNick,
        eNameType_MAX
    };
    public enum ECharacterStat
    {
        eStat_HP,
        eStat_Offense,
        eStat_Defense,
        eStat_Mobility,
        eStat_Strength,
        eStat_ShieldHP,
        eStat_CouncilMedalAccrued,
        eStat_Will,
        eStat_AppliedSuppression,
        eStat_LowCoverBonus,
        eStat_SightRadius,
        eStat_WeaponRange,
        eStat_Damage,
        eStat_CriticalShot,
        eStat_CriticalWoundChance,
        eStat_CriticalWoundsReceived,
        eStat_CloseCombat,
        eStat_FlightFuel,
        eStat_Reaction,
        eStat_MAX
    };
    public enum EEasterEggCharacter
    {
        eEEC_None,
        eEEC_Sid,
        eEEC_Ken,
        eEEC_Otto,
        eEEC_Joe,
        eEEC_Carter,
        eEEC_Chris,
        eEEC_MAX
    };
    public enum EPerkType
    {
        ePerk_None,
        ePerk_OTS_XP,
        ePerk_PrecisionShot,
        ePerk_SquadSight,
        ePerk_GeneMod_SecondHeart,
        ePerk_LowProfile,
        ePerk_RunAndGun,
        ePerk_AutopsyRequired,
        ePerk_BattleScanner,
        ePerk_DisablingShot,
        ePerk_Opportunist,
        ePerk_Executioner,
        ePerk_OTS_Leader,
        ePerk_DoubleTap,
        ePerk_InTheZone,
        ePerk_DamnGoodGround,
        ePerk_SnapShot,
        ePerk_WillToSurvive,
        ePerk_FireRocket,
        ePerk_TracerBeams,
        ePerk_GeneMod_Adrenal,
        ePerk_FocusedSuppression,
        ePerk_ShredderRocket,
        ePerk_RapidReaction,
        ePerk_Grenadier,
        ePerk_DangerZone,
        ePerk_BulletSwarm,
        ePerk_ExtraConditioning,
        ePerk_GeneMod_BrainDamping,
        ePerk_GeneMod_BrainFeedback,
        ePerk_GeneMod_Pupils,
        ePerk_Sprinter,
        ePerk_Aggression,
        ePerk_TacticalSense,
        ePerk_CloseAndPersonal,
        ePerk_LightningReflexes,
        ePerk_RapidFire,
        ePerk_Flush,
        ePerk_GeneMod_DepthPerception,
        ePerk_BringEmOn,
        ePerk_CloseCombatSpecialist,
        ePerk_KillerInstinct,
        ePerk_GeneMod_BioelectricSkin,
        ePerk_Resilience,
        ePerk_SmokeBomb,
        ePerk_GeneMod_BoneMarrow,
        ePerk_StunImmune,
        ePerk_CoveringFire,
        ePerk_FieldMedic,
        ePerk_RifleSuppression_DEPRECATED,
        ePerk_GeneMod_MuscleFiber,
        ePerk_CombatDrugs,
        ePerk_DenseSmoke,
        ePerk_DeepPockets,
        ePerk_Sentinel,
        ePerk_Savior,
        ePerk_Revive,
        ePerk_HeightAdvantage,
        ePerk_Disabled_DEPRECATED,
        ePerk_ImmuneToDisable_DEPRECATED,
        ePerk_SuppressedActive,
        ePerk_CriticallyWounded,
        ePerk_Flying,
        ePerk_Stealth,
        ePerk_Poisoned,
        ePerk_CombatStimActive,
        ePerk_Implanted,
        ePerk_Panicked,
        ePerk_MindFray,
        ePerk_PsiPanic,
        ePerk_PsiInspiration,
        ePerk_MindControl,
        ePerk_TelekineticField,
        ePerk_Rift,
        ePerk_MindMerge,
        ePerk_MindMerger,
        ePerk_Hardened,
        ePerk_GreaterMindMerge,
        ePerk_GreaterMindMerger,
        ePerk_Evade,
        ePerk_Launch,
        ePerk_Bombard,
        ePerk_Leap,
        ePerk_Plague,
        ePerk_Poison,
        ePerk_BloodCall,
        ePerk_Intimidate,
        ePerk_FallenComrades,
        ePerk_Bloodlust,
        ePerk_BullRush,
        ePerk_HEATAmmo,
        ePerk_SmokeAndMirrors,
        ePerk_Rocketeer,
        ePerk_Mayhem,
        ePerk_Gunslinger,
        ePerk_GeneMod_MimeticSkin,
        ePerk_ClusterBomb,
        ePerk_PsiLance,
        ePerk_DeathBlossom,
        ePerk_Overload,
        ePerk_PsiControl,
        ePerk_PsiDrain,
        ePerk_Repair,
        ePerk_CannonFire,
        ePerk_Implant,
        ePerk_ChryssalidSpawn,
        ePerk_BattleFatigue,
        ePerk_OnlyForGermanModeStrings_ItemRangeBonus,
        ePerk_OnlyForGermanModeStrings_ItemRangePenalty,
        ePerk_Foundry_Scope,
        ePerk_Foundry_PistolI,
        ePerk_Foundry_PistolII,
        ePerk_Foundry_PistolIII,
        ePerk_Foundry_AmmoConservation,
        ePerk_Foundry_AdvancedFlight,
        ePerk_Foundry_ArcThrowerII,
        ePerk_Foundry_MedikitII,
        ePerk_Foundry_CaptureDrone,
        ePerk_Foundry_SHIVHeal,
        ePerk_Foundry_SHIVSuppression,
        ePerk_Foundry_EleriumFuel,
        ePerk_Foundry_MECCloseCombat,
        ePerk_Foundry_AdvancedServomotors,
        ePerk_Foundry_ShapedArmor,
        ePerk_Foundry_SentinelDrone,
        ePerk_Foundry_AlienGrenades,
        ePerk_PlasmaBarrage,
        ePerk_SeekerStealth,
        ePerk_StealthGrenade,
        ePerk_ReaperRounds,
        ePerk_Disoriented,
        ePerk_Barrage,
        ePerk_AutoThreatAssessment,
        ePerk_AdvancedFireControl,
        ePerk_DamageControl,
        ePerk_XenobiologyOverlays,
        ePerk_OneForAll,
        ePerk_JetbootModule,
        ePerk_ExpandedStorage,
        ePerk_RepairServos,
        ePerk_Overdrive,
        ePerk_PlatformStability,
        ePerk_AbsorptionFields,
        ePerk_ShockAbsorbentArmor,
        ePerk_ReactiveTargetingSensors,
        ePerk_BodyShield,
        ePerk_DistortionField,
        ePerk_GeneMod_AdrenalineSurge,
        ePerk_GeneMod_IronSkin,
        ePerk_GeneMod_RegenPheromones,
        ePerk_CovertPockets,
        ePerk_CovertHacker,
        ePerk_Medal_UrbanA,
        ePerk_Medal_UrbanB,
        ePerk_Medal_DefenderA,
        ePerk_Medal_DefenderB,
        ePerk_Medal_InternationalA,
        ePerk_Medal_InternationalB,
        ePerk_Medal_CouncilA,
        ePerk_Medal_CouncilB,
        ePerk_Medal_TerraA,
        ePerk_Medal_TerraB,
        ePerk_Dazed,
        ePerk_OnlyForGermanModeStrings_AimingAnglesBonus,
        ePerk_CatchingBreath,
        ePerk_Foundry_TacticalRigging,
        ePerk_SeekerStrangle,
        ePerk_ReinforcedArmor,
        ePerk_MindMerge_Mechtoid,
        ePerk_Electropulse,
        ePerk_OTS_Leader_Bonus,
        ePerk_OTS_Leader_TheLeader,
        ePerk_MAX
    };
    public enum EMedalType
    {
        eMedal_None,
        eMedal_UrbanCombat,
        eMedal_Defender,
        eMedal_InternationalService,
        eMedal_Council,
        eMedal_Terra,
        eMedal_MAX
    };
    public enum EAbility
    {
        eAbility_NONE,
        eAbility_Move,
        eAbility_Fly,
        eAbility_FlyUp,
        eAbility_FlyDown,
        eAbility_Launch,
        eAbility_Grapple,
        eAbility_ShotStandard,
        eAbility_RapidFire,
        eAbility_ShotStun,
        eAbility_ShotDroneHack,
        eAbility_ShotOverload,
        eAbility_ShotFlush,
        eAbility_ShotSuppress,
        eAbility_ShotDamageCover,
        eAbility_FlashBang,
        eAbility_FragGrenade,
        eAbility_SmokeGrenade,
        eAbility_AlienGrenade,
        eAbility_RocketLauncher,
        eAbility_Aim,
        eAbility_Intimidate,
        eAbility_Overwatch,
        eAbility_Torch,
        eAbility_Plague,
        eAbility_Stabilize,
        eAbility_Revive,
        eAbility_TakeCover,
        eAbility_Ghost,
        eAbility_MedikitHeal,
        eAbility_RepairSHIV,
        eAbility_CombatStim,
        eAbility_EquipWeapon,
        eAbility_Reload,
        eAbility_MindMerge,
        eAbility_PsiLance,
        eAbility_PsiBoltII,
        eAbility_PsiBomb,
        eAbility_GreaterMindMerge,
        eAbility_PsiControl,
        eAbility_PsiPanic,
        eAbility_WarCry,
        eAbility_Berserk,
        eAbility_ReanimateAlly,
        eAbility_ReanimateEnemy,
        eAbility_PsiDrain,
        eAbility_PsiBless,
        eAbility_DoubleTap,
        eAbility_PrecisionShot,
        eAbility_DisablingShot,
        eAbility_SquadSight,
        eAbility_TooCloseForComfort,
        eAbility_ShredderRocket,
        eAbility_ShotMayhem,
        eAbility_RunAndGun,
        eAbility_BullRush,
        eAbility_BattleScanner,
        eAbility_Mindfray,
        eAbility_Rift,
        eAbility_TelekineticField,
        eAbility_MindControl,
        eAbility_PsiInspiration,
        eAbility_CloseCyberdisc,
        eAbility_DeathBlossom,
        eAbility_CannonFire,
        eAbility_ClusterBomb,
        eAbility_DestroyTerrain,
        eAbility_PsiInspired,
        eAbility_Repair,
        eAbility_HeatWave,
        eAbility_CivilianCover,
        eAbility_Bloodlust,
        eAbility_BloodCall,
        eAbility_MimeticSkin,
        eAbility_AdrenalNeurosympathy,
        eAbility_MimicBeacon,
        eAbility_GasGrenade,
        eAbility_GhostGrenade,
        eAbility_GhostGrenadeStealth,
        eAbility_NeedleGrenade,
        eAbility_MEC_Flamethrower,
        eAbility_MEC_KineticStrike,
        eAbility_MEC_ProximityMine,
        eAbility_JetbootModule,
        eAbility_MEC_Barrage,
        eAbility_MEC_OneForAll,
        eAbility_MEC_GrenadeLauncher,
        eAbility_MEC_RestorativeMist,
        eAbility_MEC_ElectroPulse,
        eAbility_MEC_RestorativeMistHealing,
        eAbility_Strangle,
        eAbility_Stealth,
        eAbility_ActivateStealthMP,
        eAbility_DeactivateStealthMP,
        eAbility_PsiReflect,
        eAbility_FlashBangDaze_DEPRECATED,
        eAbility_MAX
    };
    public enum ECharacterProperty
    {
        eCP_None,
        eCP_Climb,
        eCP_Flight,
        eCP_Robotic,
        eCP_MeleeOnly,
        eCP_Hardened,
        eCP_CanGainXP,
        eCP_AirEvade,
        eCP_NoCover,
        eCP_PoisonImmunity,
        eCP_LargeUnit,
        eCP_Poisonous,
        eCP_DeathExplosion,
        eCP_DoubleOverwatch,
        eCP_MAX
    };
    public enum ETraversalType
    {
        eTraversal_None,
        eTraversal_Normal,
        eTraversal_ClimbOver,
        eTraversal_ClimbOnto,
        eTraversal_ClimbLadder,
        eTraversal_DropDown,
        eTraversal_Grapple,
        eTraversal_Landing,
        eTraversal_BreakWindow,
        eTraversal_KickDoor,
        eTraversal_WallClimb,
        eTraversal_JumpUp,
        eTraversal_Ramp,
        eTraversal_BreakWall,
        eTraversal_Unreachable,
        eTraversal_MAX
    };
    public enum ESoldierClass
    {
        eSC_None,
        eSC_Sniper,
        eSC_HeavyWeapons,
        eSC_Support,
        eSC_Assault,
        eSC_Psi,
        eSC_Mec,
        eSC_MAX
    };
    public enum EWeaponProperty
    {
        eWP_None,
        eWP_Secondary,
        eWP_Pistol,
        eWP_AnyClass,
        eWP_Support,
        eWP_Rifle,
        eWP_Assault,
        eWP_Sniper,
        eWP_Heavy,
        eWP_Explosive,
        eWP_UnlimitedAmmo,
        eWP_Overheats,
        eWP_Psionic,
        eWP_Melee,
        eWP_Integrated,
        eWP_Encumber,
        eWP_MoveLimited,
        eWP_Backpack,
        eWP_NoReload,
        eWP_CantReact,
        eWP_Mec,
        eWP_MAX
    };
    public interface IDeserializable
    {
        void deSerialize(Stream file);
    }

    public class TCharacter: IDeserializable
    {
        public string strName;
        public int iType;
        public TInventory kInventory = new TInventory();
        public int[] aUpgrades = new int[Enum.GetNames(typeof(EPerkType)).Length];
        public int[] aAbilities = new int[Enum.GetNames(typeof(EAbility)).Length];
        public int[] aProperties = new int[Enum.GetNames(typeof(ECharacterProperty)).Length];
        public int[] aStats = new int[Enum.GetNames(typeof(ECharacterStat)).Length];
        public int[] aTraversals = new int[Enum.GetNames(typeof(ETraversalType)).Length];
        public ESoldierClass eClass;
        public bool bHasPsiGift;
        public float fBioElectricParticleScale;
        public void deSerialize(Stream file)
        {
            int size = SaveReader.readInt32FromFile(file);
            byte[] bData = new byte[size];
            file.Seek(4, SeekOrigin.Current);
            SaveReader.readStringFromFile(file);
            file.Seek(4, SeekOrigin.Current);
            file.Read(bData, 0, size);
            MemoryStream data = new MemoryStream(bData);
            IDeserializable Iself = this;
            while (data.Position < data.Length)
            {
                SaveReader.readProperty(data, Iself);
            }
        }

        public Dictionary<EPerkType, bool> getPerks()
        {
            Dictionary<EPerkType, bool> perks = new Dictionary<EPerkType, bool>();
            for(int i = 0; i < Enum.GetNames(typeof(EPerkType)).Length; i++)
            {
                if (aUpgrades[i] != 0)
                {
                    EPerkType value = (EPerkType)i;
                    bool item = aUpgrades[i] == 2;
                    perks.Add(value, item);
                }
            }
            return perks;
        }
    }

    public class TClass: IDeserializable
    {
        public string strName;
        public ESoldierClass eType;
        public int eTemplate;
        public EWeaponProperty eWeaponType;
        public int[] aAbilities = new int[16];
        public int[] aAbilityUnlocks = new int[16];

        public void deSerialize(Stream file)
        {
            int size = SaveReader.readInt32FromFile(file);
            byte[] bData = new byte[size];
            file.Seek(4, SeekOrigin.Current);
            SaveReader.readStringFromFile(file);
            file.Seek(4, SeekOrigin.Current);
            file.Read(bData, 0, size);
            MemoryStream data = new MemoryStream(bData);
            IDeserializable Iself = this;
            while (data.Position < data.Length)
            {
                SaveReader.readProperty(data, Iself);
            }
        }
    }

    public class TAppearance: IDeserializable
    {
        public int iHead;
        public int iGender;
        public int iRace;
        public int iHaircut;
        public int iHairColor;
        public int iFacialHair;
        public int iBody;
        public int iBodyMaterial;
        public int iSkinColor;
        public int iEyeColor;
        public int iFlag;
        public int iArmorSkin;
        public int iVoice;
        public int iLanguage;
        public int iAttitude;
        public int iArmorDeco;
        public int iArmorTint;
        public void deSerialize(Stream file)
        {
            int size = SaveReader.readInt32FromFile(file);
            byte[] bData = new byte[size];
            file.Seek(4, SeekOrigin.Current);
            SaveReader.readStringFromFile(file);
            file.Seek(4, SeekOrigin.Current);
            file.Read(bData, 0, size);
            MemoryStream data = new MemoryStream(bData);
            IDeserializable Iself = this;
            while (data.Position < data.Length)
            {
                SaveReader.readProperty(data, Iself);
            }
        }
    }


    public class TSoldier: IDeserializable
    {
        public int iID;
        public string strFirstName;
        public string strLastName;
        public string strNickName;
        public int iRank;
        public int iPsiRank;
        public int iCountry;
        public int iXP;
        public int iPsiXP;
        public int iNumKills;
        public TAppearance kAppearance = new TAppearance();
        public TClass kClass = new TClass();
        public bool bBlueshirt;
        public void deSerialize(Stream file)
        {
            int size = SaveReader.readInt32FromFile(file);
            byte[] bData = new byte[size];
            file.Seek(4, SeekOrigin.Current);
            SaveReader.readStringFromFile(file);
            file.Seek(4, SeekOrigin.Current);
            file.Read(bData, 0, size);
            MemoryStream data = new MemoryStream(bData);
            IDeserializable Iself = this;
            while (data.Position < data.Length)
            {
                SaveReader.readProperty(data, Iself);
            }
        }
        public string getShtRank()
        {
            switch(iRank)
            {
                case 0:
                    return "PFC";
                case 1:
                    return "SPEC";
                case 2:
                    return "LCPL";
                case 3:
                    return "CPL";
                case 4:
                    return "SGT";
                case 5:
                    return "TSGT";
                case 6:
                    return "GSGT";
                case 7:
                    return "MSGT";
                default:
                    return "Unknown";
            }
        }

        public string getLngRank()
        {
            switch (iRank)
            {
                case 0:
                    return "Private First Class";
                case 1:
                    return "Specialist";
                case 2:
                    return "Lance Corporal";
                case 3:
                    return "Corporal";
                case 4:
                    return "Sergeant";
                case 5:
                    return "Tech Sergeant";
                case 6:
                    return "Gunnery Sergeant";
                case 7:
                    return "Master Sergeant";
                default:
                    return "Unknown";
            }
        }

        //const string[] XP = {}

        //public string getXPoutOF()
        //{

        //}

    }

    public class UEArray<T>: List<T>, IDeserializable
    {
        public void deSerialize(Stream file)
        {
            int size = SaveReader.readInt32FromFile(file);
            file.Seek(4 + size, SeekOrigin.Current);
        }
    }

    public class TInventory : IDeserializable
    {
        int iArmor;
        int iPistol;
        int[] arrLargeItems = new int[16];
        int iNumLargeItems;
        int[] arrSmallItems = new int[16];
        int iNumSmallItems;
        int[] arrCustomItems = new int[16];
        int iNumCustomItems;

        public void deSerialize(Stream file)
        {
            int size = SaveReader.readInt32FromFile(file);
            file.Seek(4, SeekOrigin.Current);
            SaveReader.readStringFromFile(file);
            file.Seek(size + 4, SeekOrigin.Current);
        }
    }

    public class XGStrategySoldier: IDeserializable
    {
        public TCharacter m_kChar = new TCharacter();
        public TSoldier m_kSoldier = new TSoldier();
        public int[] m_aStatModifiers = new int[Enum.GetNames(typeof(ECharacterStat)).Length];
        public ESoldierStatus m_eStatus;
        public int m_iHQLocation;
        public int m_iEnergy;
        public int m_iTurnsOut;
        public int m_iNumMissions;
        public string m_strKIAReport;
        public string m_strKIADate;
        public string m_strCauseOfDeath;
        public bool m_bPsiTested;
        public bool bForcePsiGift;
        public bool m_bMIA;
        public bool m_bAllIn;
        public TInventory m_kBackedUpLoadout = new TInventory();
        public EEasterEggCharacter m_eEasterEggChar;
        public UEArray<EPerkType> m_arrRandomPerks = new UEArray<EPerkType>();
        public int[] m_arrMedals = new int[Enum.GetNames(typeof(EMedalType)).Length];
        public bool m_bBlueShirt;
        public void deSerialize(Stream file)
        {
            int size = SaveReader.readInt32FromFile(file);
            byte[] bData = new byte[size];
            file.Read(bData,0, size);
            MemoryStream data = new MemoryStream(bData);
            IDeserializable Iself = this;
            while (data.Position < data.Length)
            {
                SaveReader.readProperty(data, Iself);
            }
        }

        public string getStatus()
        {
            return Enum.GetName(typeof(ESoldierStatus), (object)m_eStatus);
        }
    }

    public 
    static class SaveReader
    {
        public static void decompress(string inFile, string outFile)
        {
            byte[] saveData = File.ReadAllBytes(inFile);
            int index = 1024;
            FileStream outF = File.Open(outFile, FileMode.Create, FileAccess.Write);
            do
            {
                byte[] compressedDataSize = new byte[4];
                Array.Copy(saveData, index + 8, compressedDataSize, 0, 4);
                int size = BitConverter.ToInt32(compressedDataSize, 0);
                byte[] compressedData = new byte[size + 4];
                Array.Copy(saveData, index + 24, compressedData, 0, size);
                Array.Copy(new byte[] { 0x00, 0x00, 0x02, 0x00 }, 0, compressedData, size, 4);
                byte[] uncompressedData = LZOCompressor.Decompress(compressedData);
                index = index + 24 + size;
                outF.Write(uncompressedData, 0, uncompressedData.Length);
            } while (index < saveData.Length);
            outF.Close();
        }

        public static List<XGStrategySoldier> parseSoldiers(FileStream file)
        {
            List<XGStrategySoldier> ret = new List<XGStrategySoldier>();
            int numElements = readInt32FromFile(file);
            // Skip the header
            for(int index = 0; index < numElements; index++)
            {
                readStringFromFile(file);
                file.Seek(4, SeekOrigin.Current); //skip unknown 4 bytes.
            }
            //Skip the first object list
            //First skip the header.
            file.Seek(4, SeekOrigin.Current); //Skip the unknown 4 bytes.
            readStringFromFile(file); //Skip header string.
            readStringFromFile(file); //skip "none" string.
            file.Seek(4, SeekOrigin.Current); //Skip the other unknown 4 bytes.
            numElements = readInt32FromFile(file); //get number of elements in this list.
            //Skip this list.
            for (int index = 0; index < numElements; index++)
            {
                readStringFromFile(file); //skip fully qualified instance name.
                string instanceName = readStringFromFile(file); //get instance name name.
                file.Seek(24, SeekOrigin.Current); //skip unkown bytes
                string className = readStringFromFile(file); //get fully qualified class name.
                if (className == "XComStrategyGame.XGStrategySoldier")
                {
                    XGStrategySoldier test = new XGStrategySoldier();
                    test.deSerialize(file);
                    file.Seek(4, SeekOrigin.Current);
                    ret.Add(test);
                }
                else
                {
                    int dataLength = readInt32FromFile(file) + 4; //skip data block + the unknown byte at the end.
                    file.Seek((long)dataLength, SeekOrigin.Current);
                }
            }
            file.Close();
            return ret;
        }
        public static List<XGStrategySoldier> parseSoldiers(string fileN)
        {
            FileStream file = new FileStream(fileN, FileMode.Open, FileAccess.Read);
            return parseSoldiers(file);
        }

        public static string readStringFromFile(Stream file)
        {
            int strLength = readInt32FromFile(file);
            byte[] strBuffer = new byte[strLength];
            file.Read(strBuffer, 0, strLength);
            return Encoding.ASCII.GetString(strBuffer).TrimEnd(new char[1] { '\0' });
        }
        public static int readInt32FromFile(Stream file)
        {
            byte[] bInteger = new byte[4];
            file.Read(bInteger, 0, 4);
            int integer = BitConverter.ToInt32(bInteger, 0);
            return integer;
        }

        public static bool readBoolFromFile(Stream file)
        {
            return Convert.ToBoolean(file.ReadByte());
        }
        public static float readSingleFloatFromFile(Stream file)
        {
            byte[] bFloat = new byte[4];
            file.Read(bFloat, 0, 4);
            return BitConverter.ToSingle(bFloat, 0);
        }
        public static double readDoubleFloatFromFile(Stream file)
        {
            byte[] bFloat = new byte[8];
            file.Read(bFloat, 0, 8);
            return BitConverter.ToDouble(bFloat, 0);
        }

        public static void readProperty(Stream file, IDeserializable obj)
        {
            string propName = readStringFromFile(file);
            if (propName == "m_kInjuredLoadout") propName = "m_kBackedUpLoadout"; //They seem to have changed this one over at some point, non issue.
            file.Seek(4, SeekOrigin.Current);
            string propType = readStringFromFile(file);
            file.Seek(4, SeekOrigin.Current);
            FieldInfo prop = obj.GetType().GetField(propName, BindingFlags.Public | BindingFlags.Instance);
            switch(propType)
            {
                case "StructProperty":
                    object instanceObj = Activator.CreateInstance(prop.GetValue(obj).GetType());
                    MethodInfo parse = instanceObj.GetType().GetMethod("deSerialize");
                    parse.Invoke(instanceObj, new object[] { file });
                    prop.SetValue(obj, instanceObj);
                    break;
                case "ArrayProperty":
                    object instanceArray = Activator.CreateInstance(prop.GetValue(obj).GetType());
                    MethodInfo Arrayparse = instanceArray.GetType().GetMethod("deSerialize");
                    Arrayparse.Invoke(instanceArray, new object[] { file });
                    prop.SetValue(obj, instanceArray);
                    break;
                case "BoolProperty":
                    file.Seek(8, SeekOrigin.Current); //Skip two unkown int32s
                    bool value = readBoolFromFile(file);
                    prop.SetValue(obj, (object)value);
                    break;
                case "ByteProperty":
                    file.Seek(8, SeekOrigin.Current);
                    readStringFromFile(file);
                    file.Seek(4, SeekOrigin.Current);
                    string name = readStringFromFile(file);
                    int eIndex = readInt32FromFile(file);
                    if (name == "eStatus_Healing" && eIndex == 1)
                        name = "eStatus_Fatigued";
                    object enumValue = Enum.Parse(prop.GetValue(obj).GetType(), name);
                    prop.SetValue(obj, enumValue);
                    break;
                case "FloatProperty":
                    int floatSize = readInt32FromFile(file);
                    file.Seek(4, SeekOrigin.Current);
                    switch(floatSize)
                    {
                        case 4:
                            float single = readSingleFloatFromFile(file);
                            prop.SetValue(obj, single);
                            break;
                        case 8:
                            double dbl = readDoubleFloatFromFile(file);
                            prop.SetValue(obj, dbl);
                            break;
                        default:
                            throw new Exception("WTF that's not a floater");
                    }
                    
                    break;
                case "IntProperty":
                    file.Seek(4, SeekOrigin.Current);
                    int index = readInt32FromFile(file);
                    int Intvalue = readInt32FromFile(file);
                    if (prop.GetValue(obj).GetType().IsArray)
                    {
                        int[] arrayVal = (int[])prop.GetValue(obj);
                        arrayVal[index] = Intvalue;
                        prop.SetValue(obj, (object)arrayVal);
                    }
                    else
                    {
                        prop.SetValue(obj, (object)Intvalue);
                    }
                    break;
                case "StrProperty":
                    file.Seek(8, SeekOrigin.Current);
                    string strValue = readStringFromFile(file);
                    prop.SetValue(obj, strValue);
                    break;
                case "":
                    file.Seek(4, SeekOrigin.Current);
                    break;
            }
        }

    }
}
