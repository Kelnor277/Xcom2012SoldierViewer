using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xcom2012SoldierViewer
{
    public class Perk
    {
        public enum classes
        {
            //Assault
            AssaultT1,
            AssaultT2_1,
            AssaultT2_2,
            AssaultT2_3,
            AssaultT3_1,
            AssaultT3_2,
            AssaultT3_3,
            AssaultT4_1,
            AssaultT4_2,
            AssaultT4_3,
            AssaultT5_1,
            AssaultT5_2,
            AssaultT5_3,
            AssaultT6_1,
            AssaultT6_2,
            AssaultT6_3,
            AssaultT7_1,
            AssaultT7_2,
            AssaultT7_3,
            //Infantry
            InfantryT1,
            InfantryT2_1,
            InfantryT2_2,
            InfantryT2_3,
            InfantryT3_1,
            InfantryT3_2,
            InfantryT3_3,
            InfantryT4_1,
            InfantryT4_2,
            InfantryT4_3,
            InfantryT5_1,
            InfantryT5_2,
            InfantryT5_3,
            InfantryT6_1,
            InfantryT6_2,
            InfantryT6_3,
            InfantryT7_1,
            InfantryT7_2,
            InfantryT7_3,
            //Rocketeer
            RocketeerT1,
            RocketeerT2_1,
            RocketeerT2_2,
            RocketeerT2_3,
            RocketeerT3_1,
            RocketeerT3_2,
            RocketeerT3_3,
            RocketeerT4_1,
            RocketeerT4_2,
            RocketeerT4_3,
            RocketeerT5_1,
            RocketeerT5_2,
            RocketeerT5_3,
            RocketeerT6_1,
            RocketeerT6_2,
            RocketeerT6_3,
            RocketeerT7_1,
            RocketeerT7_2,
            RocketeerT7_3,
        };
        public string name;
        //public List<classes> fromClasses;
        public EPerkType ePerk;
        public Perk(string name, EPerkType ePerk)
        {
            this.name = name;
            //this.fromClasses = fromClasses;
            this.ePerk = ePerk;
        }
        public Perk(EPerkType ePerk)
        {
            this.name = Enum.GetName(typeof(EPerkType), (object)ePerk);
            //this.fromClasses = new List<classes>();
            this.ePerk = ePerk;
        }

        public static Dictionary<EPerkType, Perk> LearnablePerks = new Dictionary<EPerkType, Perk>()
        {
            {EPerkType.ePerk_AdvancedFireControl,   new Perk("Ready for Anything", EPerkType.ePerk_AdvancedFireControl)},
            {EPerkType.ePerk_Aggression,            new Perk("Aggression", EPerkType.ePerk_Aggression)},
            {EPerkType.ePerk_AutoThreatAssessment,  new Perk("Automated Thread Assesment", EPerkType.ePerk_AutoThreatAssessment)},
            {EPerkType.ePerk_Barrage,               new Perk("Barrage", EPerkType.ePerk_Barrage)},
            {EPerkType.ePerk_BattleScanner,         new Perk("Battle Scanner", EPerkType.ePerk_BattleScanner)},
            {EPerkType.ePerk_BodyShield,            new Perk("Body Shield", EPerkType.ePerk_BodyShield)},
            {EPerkType.ePerk_Bombard,               new Perk("Bombard", EPerkType.ePerk_Bombard)},
            {EPerkType.ePerk_BringEmOn,             new Perk("Bring Em' On", EPerkType.ePerk_BringEmOn)},
            {EPerkType.ePerk_BulletSwarm,           new Perk("Ready For Anything", EPerkType.ePerk_BulletSwarm)},
            {EPerkType.ePerk_CloseAndPersonal,      new Perk("Close Encounters", EPerkType.ePerk_CloseAndPersonal)},
            {EPerkType.ePerk_CloseCombatSpecialist, new Perk("Close Combat Specialist", EPerkType.ePerk_CloseCombatSpecialist)},
            {EPerkType.ePerk_CombatDrugs,           new Perk("Combat Drugs", EPerkType.ePerk_CombatDrugs)},
            {EPerkType.ePerk_CoveringFire,          new Perk("Covering Fire", EPerkType.ePerk_CoveringFire)},
            {EPerkType.ePerk_CovertPockets,         new Perk("Field Surgeon", EPerkType.ePerk_CovertPockets)},
            {EPerkType.ePerk_DamageControl,         new Perk("Damage Control", EPerkType.ePerk_DamageControl)},
            {EPerkType.ePerk_DangerZone,            new Perk("Danger Zone", EPerkType.ePerk_DangerZone)},
            {EPerkType.ePerk_DamnGoodGround,        new Perk("Damn Good Ground", EPerkType.ePerk_DamnGoodGround)},
            {EPerkType.ePerk_Dazed,                 new Perk("Paramedic", EPerkType.ePerk_Dazed)},
            {EPerkType.ePerk_DeepPockets,           new Perk("Packmaster", EPerkType.ePerk_DeepPockets)},
            {EPerkType.ePerk_DenseSmoke,            new Perk("Dense Smoke", EPerkType.ePerk_DenseSmoke)},
            {EPerkType.ePerk_Disabled_DEPRECATED,   new Perk("Lock N' Load", EPerkType.ePerk_Disabled_DEPRECATED)},
            {EPerkType.ePerk_DisablingShot,         new Perk("Disabling Shot", EPerkType.ePerk_DisablingShot)},
            {EPerkType.ePerk_DistortionField,       new Perk("Distortion Field", EPerkType.ePerk_DistortionField)},
            {EPerkType.ePerk_DoubleTap,             new Perk("Double Tap", EPerkType.ePerk_DoubleTap)},
            {EPerkType.ePerk_Electropulse,          new Perk("Electorpulse", EPerkType.ePerk_Electropulse)},
            {EPerkType.ePerk_Executioner,           new Perk("Executioner", EPerkType.ePerk_Executioner)},
            {EPerkType.ePerk_ExtraConditioning,     new Perk("Extra Conditioning", EPerkType.ePerk_ExtraConditioning)},
            {EPerkType.ePerk_FieldMedic,            new Perk("Field Medic", EPerkType.ePerk_FieldMedic)},
            {EPerkType.ePerk_FireRocket,            new Perk("Fire Rocket", EPerkType.ePerk_FireRocket)},
            {EPerkType.ePerk_Flush,                 new Perk("Flush", EPerkType.ePerk_Flush)},
            {EPerkType.ePerk_FocusedSuppression,    new Perk("Suppression", EPerkType.ePerk_FocusedSuppression)},
            {EPerkType.ePerk_Foundry_AdvancedFlight,new Perk("Fire in the Hole", EPerkType.ePerk_Foundry_AdvancedFlight)},
            {EPerkType.ePerk_Foundry_SHIVSuppression, new Perk("Psychokinetic Strike", EPerkType.ePerk_Foundry_SHIVSuppression)},
            {EPerkType.ePerk_GeneMod_Adrenal,       new Perk("Adrenal Neurosympathy", EPerkType.ePerk_GeneMod_Adrenal)},
            {EPerkType.ePerk_GeneMod_BioelectricSkin, new Perk("Bioelectric Skin", EPerkType.ePerk_GeneMod_BioelectricSkin)},
            {EPerkType.ePerk_GeneMod_BoneMarrow,    new Perk("Adaptive Bone Marrow", EPerkType.ePerk_GeneMod_BoneMarrow)},
            {EPerkType.ePerk_GeneMod_BrainDamping,  new Perk("Neural Dampining", EPerkType.ePerk_GeneMod_BrainDamping)},
            {EPerkType.ePerk_GeneMod_DepthPerception, new Perk("Depth Perception", EPerkType.ePerk_GeneMod_DepthPerception)},
            {EPerkType.ePerk_GeneMod_IronSkin,      new Perk("Iron Skin", EPerkType.ePerk_GeneMod_IronSkin)},
            {EPerkType.ePerk_GeneMod_MuscleFiber,   new Perk("Muscle Fiber Density", EPerkType.ePerk_GeneMod_MuscleFiber)},
            {EPerkType.ePerk_GeneMod_Pupils,        new Perk("Hyper Reactive Pupils", EPerkType.ePerk_GeneMod_Pupils)},
            {EPerkType.ePerk_GeneMod_RegenPheromones, new Perk("Smart Macrophages", EPerkType.ePerk_GeneMod_RegenPheromones)},
            {EPerkType.ePerk_GeneMod_SecondHeart,   new Perk("Secondary Heart", EPerkType.ePerk_GeneMod_SecondHeart)},
            {EPerkType.ePerk_Grenadier,             new Perk("Grenadier", EPerkType.ePerk_Grenadier)},
            {EPerkType.ePerk_Gunslinger,            new Perk("Gunslinger", EPerkType.ePerk_Gunslinger)},
            {EPerkType.ePerk_HEATAmmo,               new Perk("Heat Ammo", EPerkType.ePerk_HEATAmmo)},
            {EPerkType.ePerk_ImmuneToDisable_DEPRECATED, new Perk("Sapper", EPerkType.ePerk_ImmuneToDisable_DEPRECATED)},
            {EPerkType.ePerk_Implanted,             new Perk("Javelin Rockets", EPerkType.ePerk_Implanted)},
            {EPerkType.ePerk_InTheZone,             new Perk("In The Zone", EPerkType.ePerk_InTheZone)},
            {EPerkType.ePerk_KillerInstinct,        new Perk("Killer Instinct", EPerkType.ePerk_KillerInstinct)},
            {EPerkType.ePerk_LightningReflexes,     new Perk("Lightening Reflexes", EPerkType.ePerk_LightningReflexes)},
            {EPerkType.ePerk_LowProfile,            new Perk("Low Profile", EPerkType.ePerk_LowProfile)},
            {EPerkType.ePerk_Mayhem,                new Perk("Mayhem", EPerkType.ePerk_Mayhem)},
            {EPerkType.ePerk_Medal_CouncilB,        new Perk("Lone Wolf", EPerkType.ePerk_Medal_CouncilB)},
            {EPerkType.ePerk_Medal_DefenderA,       new Perk("Steadfast", EPerkType.ePerk_Medal_DefenderA)},
            {EPerkType.ePerk_Medal_UrbanB,          new Perk("Sharpshooter", EPerkType.ePerk_Medal_UrbanB)},
            {EPerkType.ePerk_MindControl,           new Perk("Mind Control", EPerkType.ePerk_MindControl)},
            {EPerkType.ePerk_MindFray,              new Perk("Mind Fray", EPerkType.ePerk_MindFray)},
            {EPerkType.ePerk_MindMerge,             new Perk("Mind Merge", EPerkType.ePerk_MindMerge)},
            {EPerkType.ePerk_OneForAll,             new Perk("One For All", EPerkType.ePerk_OneForAll)},
            {EPerkType.ePerk_Opportunist,           new Perk("Opportunist", EPerkType.ePerk_Opportunist)},
            {EPerkType.ePerk_PlasmaBarrage,         new Perk("Light 'Em Up", EPerkType.ePerk_PlasmaBarrage)},
            {EPerkType.ePerk_PlatformStability,     new Perk("Platform Stability", EPerkType.ePerk_PlatformStability)},
            {EPerkType.ePerk_Poisoned,              new Perk("Heat Warheads", EPerkType.ePerk_Poisoned)},
            {EPerkType.ePerk_PrecisionShot,         new Perk("Precision Shot", EPerkType.ePerk_PrecisionShot)},
            {EPerkType.ePerk_PsiPanic,              new Perk("Psi Panic", EPerkType.ePerk_PsiPanic)},
            {EPerkType.ePerk_ReinforcedArmor,       new Perk("Hit and Run", EPerkType.ePerk_ReinforcedArmor)},
            {EPerkType.ePerk_RapidFire,             new Perk("Rapid Fire", EPerkType.ePerk_RapidFire)},
            {EPerkType.ePerk_RapidReaction,         new Perk("Rapid Reaction", EPerkType.ePerk_RapidReaction)},
            {EPerkType.ePerk_ReactiveTargetingSensors, new Perk("Reactive Targeting Sensors", EPerkType.ePerk_ReactiveTargetingSensors)},
            {EPerkType.ePerk_Repair,                new Perk("Repair", EPerkType.ePerk_Repair)},
            {EPerkType.ePerk_RepairServos,          new Perk("Repair Servos", EPerkType.ePerk_RepairServos)},
            {EPerkType.ePerk_Resilience,            new Perk("Resilience", EPerkType.ePerk_Resilience)},
            {EPerkType.ePerk_Revive,                new Perk("Revive", EPerkType.ePerk_Revive)},
            {EPerkType.ePerk_RifleSuppression_DEPRECATED, new Perk("Ranger", EPerkType.ePerk_RifleSuppression_DEPRECATED)},
            {EPerkType.ePerk_Rift,                  new Perk("Rift", EPerkType.ePerk_Rift)},
            {EPerkType.ePerk_Rocketeer,             new Perk("Shock and Awe", EPerkType.ePerk_Rocketeer)},
            {EPerkType.ePerk_RunAndGun,             new Perk("Run and Gun", EPerkType.ePerk_RunAndGun)},
            {EPerkType.ePerk_Savior,                new Perk("Savior", EPerkType.ePerk_Savior)},
            {EPerkType.ePerk_Sentinel,              new Perk("Sentinel", EPerkType.ePerk_Sentinel)},
            {EPerkType.ePerk_ShockAbsorbentArmor,   new Perk("Shock Absorbent Armor", EPerkType.ePerk_ShockAbsorbentArmor)},
            {EPerkType.ePerk_ShredderRocket,        new Perk("Shredder Ammo", EPerkType.ePerk_ShredderRocket)},
            {EPerkType.ePerk_SmokeAndMirrors,       new Perk("Smoke and Mirrors", EPerkType.ePerk_SmokeAndMirrors)},
            {EPerkType.ePerk_SmokeBomb,             new Perk("Smoke Grenade", EPerkType.ePerk_SmokeBomb)},
            {EPerkType.ePerk_SnapShot,              new Perk("Snap Shot", EPerkType.ePerk_SnapShot)},
            {EPerkType.ePerk_Sprinter,              new Perk("Sprinter", EPerkType.ePerk_Sprinter)},
            {EPerkType.ePerk_SquadSight,            new Perk("Squad Sight", EPerkType.ePerk_SquadSight)},
            {EPerkType.ePerk_TacticalSense,         new Perk("Tactical Sense", EPerkType.ePerk_TacticalSense)},
            {EPerkType.ePerk_TelekineticField,       new Perk("Telekinetic Field", EPerkType.ePerk_TelekineticField)},
            {EPerkType.ePerk_TracerBeams,           new Perk("Holo Targeting", EPerkType.ePerk_TracerBeams)},
            {EPerkType.ePerk_WillToSurvive,         new Perk("Will to Survive", EPerkType.ePerk_WillToSurvive)},
            {EPerkType.ePerk_XenobiologyOverlays,   new Perk("Vital Point Targeting", EPerkType.ePerk_XenobiologyOverlays)}
        };
    }
}
