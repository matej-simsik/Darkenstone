using Darkenstone.Common;

namespace Darkenstone.Abilities
{
    public static class AbilityConstructor
    {
        public static Ability Construct(string abilityName)
        {
            switch (abilityName)
            {
                case Fireshot.ConstructorName:
                    return new Fireshot();
                case Fireball.ConstructorName:
                    return new Fireball();
                case Fireblast.ConstructorName:
                    return new Fireblast();
                case FireBurns.ConstructorName:
                    return new FireBurns();
                case Pyromaniac.ConstructorName:
                    return new Pyromaniac();
                case FirstAid.ConstructorName:
                    return new FirstAid();
                case Rejuvenation.ConstructorName:
                    return new Rejuvenation();
                case Growth.ConstructorName:
                    return new Growth();
                case Meditation.ConstructorName:
                    return new Meditation();
                case Frenzy.ConstructorName:
                    return new Frenzy();
                case SwipeMurloc.ConstructorName:
                    return new SwipeMurloc();
                case HealingPotionMurloc.ConstructorName:
                    return new HealingPotionMurloc();
                case GunShotGoblin.ConstructorName:
                    return new GunShotGoblin();
                case StingGoblin.ConstructorName:
                    return new StingGoblin();
                case SicknessDarkElf.ConstructorName:
                    return new SicknessDarkElf();
                case DepressionDarkElf.ConstructorName:
                    return new DepressionDarkElf();
                case ElvenWaterDarkElf.ConstructorName:
                    return new ElvenWaterDarkElf();
                case LightningBoltSeer.ConstructorName:
                    return new LightningBoltSeer();
                case FlourishSeer.ConstructorName:
                    return new FlourishSeer();
                case ManaDrainSeer.ConstructorName:
                    return new ManaDrainSeer();
                case FireBreathDragon.ConstructorName:
                    return new FireBreathDragon();
                case FireShotDragon.ConstructorName:
                    return new FireShotDragon();
                default: return null;
            }
        }

        public static Ability Construct(string abilityName, ICaster caster)
        {
            Ability ability = Construct(abilityName);
            ability.Caster = caster;
            return ability;
        }
    }
}
