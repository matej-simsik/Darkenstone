using Darkenstone.Buffs;

namespace Darkenstone.Common
{
    public interface IDamageable
    {
        int MaxHealthPoints { get; }
        int HealthPoints { get; set; }
        bool IsDead { get; }
        IBuffManager BuffManager { get; }
        decimal DefenseCoefficient { get; set; }
    }
}