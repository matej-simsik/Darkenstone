using System.Drawing;

namespace Darkenstone.Common
{
    public class Stats
    {
        public string CharacterName { get; set; }
        public int MaxHealthPoints { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Gold { get; set; }
        public int MaxMana { get; set; }
        public int Intellect { get; set; }
        public int Spirit { get; set; }
        public Color IconColor { get; set; }

        public Stats(string nickName)
        {
            CharacterName = nickName;
            MaxHealthPoints = 300;
            Level = 1;
            Experience = 0;
            Gold = 0;
            MaxMana = 100;
            Intellect = 10;
            Spirit = 10;
            IconColor = Color.FromArgb(64, 0, 64);
        }

        public Stats(string name, int maxHealthPoints, int level, 
            int experience, int gold)
        {
            CharacterName = name;
            MaxHealthPoints = maxHealthPoints;
            Level = level;
            Experience = experience;
            Gold = gold;
            MaxMana = 0;
            Intellect = 0;
            Spirit = 0;
            IconColor = Color.FromArgb(64, 0, 64);
        }

        public Stats(string name, int maxHealthPoints, int level, 
            int experience, int gold, int maxMana, int intellect, int spirit, Color iconColor):
            this(name, maxHealthPoints, level, experience, gold)
        {
            MaxMana = maxMana;
            Intellect = intellect;
            Spirit = spirit;
            IconColor = iconColor;
        }        
    }
}