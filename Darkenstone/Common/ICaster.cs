using Darkenstone.Abilities;
using System.Collections.ObjectModel;

namespace Darkenstone.Common
{
    public interface ICaster
    {
        ReadOnlyCollection<Ability> Abilities { get; }
        decimal DamageCoefficient { get; set; }
    }
}