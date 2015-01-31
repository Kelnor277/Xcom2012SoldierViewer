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
            //
        };
        string name;
        List<classes> fromClasses;
        EPerkType ePerk;
        public Perk(string name, List<classes> fromClasses, EPerkType ePerk)
        {
            this.name = name;
            this.fromClasses = fromClasses;
            this.ePerk = ePerk;
        }

        static Dictionary<EPerkType, Perk> LearnablePerks = new Dictionary<EPerkType, Perk>
        {
            {EPerkType.ePerk_RunAndGun, new Perk("Run and Gun", new List<classes> { classes.AssaultT1 }, EPerkType.ePerk_RunAndGun)},
            {EPerkType.ePerk_Flush, new Perk("Flush", new List<classes> { classes.AssaultT2_1 }, EPerkType.ePerk_Flush)},
            {EPerkType.ePerk_CloseCombatSpecialist, new Perk("Close Combat Specialist", new List<classes> { classes.AssaultT2_2 }, EPerkType.ePerk_CloseCombatSpecialist)},
            {EPerkType.ePerk_Medal_DefenderA, new Perk("Steadfast", new List<classes> { classes.AssaultT2_3 }, EPerkType.ePerk_Medal_DefenderA)},
            {EPerkType.ePerk_Gunslinger, new Perk("Gunslinger", new List<classes> { classes.AssaultT3_1 }, EPerkType.ePerk_Gunslinger)},
            {EPerkType.ePerk_TacticalSense, new Perk("Tactical Sense", new List<classes> { classes.AssaultT3_2 }, EPerkType.ePerk_TacticalSense)},
            {EPerkType.ePerk_Aggression, new Perk("Aggression", new List<classes> { classes.AssaultT3_3 }, EPerkType.ePerk_Aggression)},
            //{EPerkType, new Perk("Aggression", new List<classes> { classes.AssaultT3_3 }, EPerkType.ePerk_Aggression)},
        };
    }
}
