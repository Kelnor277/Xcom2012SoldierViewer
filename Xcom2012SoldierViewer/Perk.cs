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
        public List<classes> fromClasses;
        public EPerkType ePerk;
        public Perk(string name, List<classes> fromClasses, EPerkType ePerk)
        {
            this.name = name;
            this.fromClasses = fromClasses;
            this.ePerk = ePerk;
        }
        public Perk(EPerkType ePerk)
        {
            this.name = Enum.GetName(typeof(EPerkType), (object)ePerk);
            this.fromClasses = new List<classes>();
            this.ePerk = ePerk;
        }

        public static Dictionary<EPerkType, Perk> LearnablePerks = new Dictionary<EPerkType, Perk>()
        {
            {EPerkType.ePerk_RunAndGun,             new Perk("Run and Gun", new List<classes> { classes.AssaultT1 }, EPerkType.ePerk_RunAndGun)},
            {EPerkType.ePerk_Flush,                 new Perk("Flush", new List<classes> { classes.AssaultT2_1 }, EPerkType.ePerk_Flush)},
            {EPerkType.ePerk_CloseCombatSpecialist, new Perk("Close Combat Specialist", new List<classes> { classes.AssaultT2_2 }, EPerkType.ePerk_CloseCombatSpecialist)},
            {EPerkType.ePerk_Medal_DefenderA,       new Perk("Steadfast", new List<classes> { classes.AssaultT2_3, classes.InfantryT2_1 }, EPerkType.ePerk_Medal_DefenderA)},
            {EPerkType.ePerk_Gunslinger,            new Perk("Gunslinger", new List<classes> { classes.AssaultT3_1, classes.InfantryT4_2 }, EPerkType.ePerk_Gunslinger)},
            {EPerkType.ePerk_TacticalSense,         new Perk("Tactical Sense", new List<classes> { classes.AssaultT3_2, classes.InfantryT3_2, classes.RocketeerT4_2 }, EPerkType.ePerk_TacticalSense)},
            {EPerkType.ePerk_Aggression,            new Perk("Aggression", new List<classes> { classes.AssaultT3_3, classes.InfantryT3_1 }, EPerkType.ePerk_Aggression)},
            {EPerkType.ePerk_Leap,                  new Perk("Hit and Run???", new List<classes> { classes.AssaultT4_1 }, EPerkType.ePerk_Leap)},
            {EPerkType.ePerk_CloseAndPersonal,      new Perk("Close Encounters???", new List<classes> { classes.AssaultT4_2 }, EPerkType.ePerk_CloseAndPersonal)},
            {EPerkType.ePerk_RapidFire,             new Perk("Rapid Fire", new List<classes> { classes.AssaultT4_3, classes.AssaultT7_3 }, EPerkType.ePerk_RapidFire)},
            {EPerkType.ePerk_ExtraConditioning,     new Perk("Extra Conditioning", new List<classes> { classes.AssaultT5_1, classes.InfantryT6_1, classes.RocketeerT7_1 }, EPerkType.ePerk_ExtraConditioning)},
            {EPerkType.ePerk_KillerInstinct,        new Perk("Killer Instinct", new List<classes> { classes.AssaultT5_2 }, EPerkType.ePerk_KillerInstinct)},
            {EPerkType.ePerk_CannonFire,            new Perk("Ranger???", new List<classes> { classes.AssaultT5_3, classes.InfantryT4_1, classes.RocketeerT5_1 }, EPerkType.ePerk_CannonFire)},
            {EPerkType.ePerk_WillToSurvive,         new Perk("Will to Survive", new List<classes> { classes.AssaultT6_1, classes.InfantryT5_2, classes.RocketeerT5_3 }, EPerkType.ePerk_WillToSurvive)},
            {EPerkType.ePerk_BringEmOn,             new Perk("Bring 'Em On", new List<classes> { classes.AssaultT6_2, classes.InfantryT6_2 }, EPerkType.ePerk_BringEmOn)},
            {EPerkType.ePerk_Sprinter,              new Perk("Sprinter", new List<classes> { classes.AssaultT6_3, classes.RocketeerT7_2 }, EPerkType.ePerk_Sprinter)},
            {EPerkType.ePerk_Resilience,            new Perk("Resilience", new List<classes> { classes.AssaultT7_2, classes.InfantryT7_2 }, EPerkType.ePerk_Resilience)},
            {EPerkType.ePerk_LightningReflexes,     new Perk("Lightening Reflexes", new List<classes> { classes.AssaultT7_3 }, EPerkType.ePerk_LightningReflexes)},
            {EPerkType.ePerk_BulletSwarm,           new Perk("Light 'Em Up", new List<classes> { classes.InfantryT1 }, EPerkType.ePerk_BulletSwarm)},
            {EPerkType.ePerk_Executioner,           new Perk("Executioner", new List<classes> { classes.InfantryT2_2 }, EPerkType.ePerk_Executioner)},
            {EPerkType.ePerk_CoveringFire,          new Perk("Covering Fire", new List<classes> { classes.InfantryT2_3, classes.RocketeerT2_1 }, EPerkType.ePerk_CoveringFire)},
            {EPerkType.ePerk_Opportunist,           new Perk("Opportunist", new List<classes> { classes.InfantryT3_3, classes.RocketeerT4_1 }, EPerkType.ePerk_Opportunist)},
            {EPerkType.ePerk_FocusedSuppression,    new Perk("Suppression", new List<classes> { classes.InfantryT3_3, classes.RocketeerT3_2 }, EPerkType.ePerk_FocusedSuppression)},
            {EPerkType.ePerk_Medal_UrbanB,          new Perk("Sharpshooter???", new List<classes> { classes.InfantryT5_1 }, EPerkType.ePerk_Medal_UrbanB)},
            {EPerkType.ePerk_DeepPockets,           new Perk("Lock N' Load???", new List<classes> { classes.InfantryT5_2 }, EPerkType.ePerk_DeepPockets)},
            {EPerkType.ePerk_Sentinel,              new Perk("Sentinel", new List<classes> { classes.InfantryT6_3 }, EPerkType.ePerk_Sentinel)},
            {EPerkType.ePerk_FireRocket,            new Perk("Fire Rocket", new List<classes> { classes.RocketeerT1 }, EPerkType.ePerk_FireRocket)},
            {EPerkType.ePerk_RapidReaction,         new Perk("Rapid Reaction", new List<classes> { classes.RocketeerT2_2 }, EPerkType.ePerk_RapidReaction)},
            {EPerkType.ePerk_HEATAmmo,              new Perk("Heat Warheads", new List<classes> { classes.RocketeerT2_3 }, EPerkType.ePerk_HEATAmmo)},
            {EPerkType.ePerk_ClusterBomb,           new Perk("Fire in the Hole", new List<classes> { classes.RocketeerT3_1 }, EPerkType.ePerk_ClusterBomb)},
            {EPerkType.ePerk_SnapShot,              new Perk("Snap Shot", new List<classes> { classes.RocketeerT3_3 }, EPerkType.ePerk_SnapShot)},
            {EPerkType.ePerk_ShredderRocket,        new Perk("Shredder Ammo", new List<classes> { classes.RocketeerT4_3 }, EPerkType.ePerk_ShredderRocket)},
            {EPerkType.ePerk_AdvancedFireControl,   new Perk("Ready for Anything", new List<classes> { classes.RocketeerT5_2 }, EPerkType.ePerk_AdvancedFireControl)},
            {EPerkType.ePerk_DangerZone,            new Perk("Danger Zone", new List<classes> { classes.RocketeerT6_1 }, EPerkType.ePerk_DangerZone)},
            {EPerkType.ePerk_Mayhem,                new Perk("Mayhem", new List<classes> { classes.RocketeerT6_2 }, EPerkType.ePerk_Mayhem)},
            {EPerkType.ePerk_DeathBlossom,          new Perk("Javelin Rocket", new List<classes> { classes.RocketeerT6_3 }, EPerkType.ePerk_DeathBlossom)},
            {EPerkType.ePerk_Rocketeer,             new Perk("Shock and Awe", new List<classes> { classes.RocketeerT7_3 }, EPerkType.ePerk_Rocketeer)}
        };
    }
}
