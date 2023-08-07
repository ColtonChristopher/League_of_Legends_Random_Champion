using System;
namespace FinalProject.Models
{
    public class Root
    {
        public string champName { get; set; }
        public int blueEssence { get; set; }
        public int RP { get; set; }
        public int HP { get; set; }
        public int hpGainPerLvL { get; set; }
        public float HPR { get; set; }
        public float hpRegenGainPerLvL { get; set; }
        public string resource { get; set; }
        public int mp { get; set; }
        public int mpGainPerLvL { get; set; }
        public float mpRegen { get; set; }
        public float mpRegenGainPerLvL { get; set; }
        public int moveSpeed { get; set; }
        public int attDamage { get; set; }
        public float attDamageGainPerLvL { get; set; }
        public float attSpeed { get; set; }
        public float attSpeedGainPerLvL { get; set; }
        public int range { get; set; }
        public int armor { get; set; }
        public float armorGainPerLvL { get; set; }
        public int magicArmor { get; set; }
        public float magicArmorGainPerLvL { get; set; }
        public string releaseDate { get; set; }
        public string Attributes { get; set; }
    }
}


