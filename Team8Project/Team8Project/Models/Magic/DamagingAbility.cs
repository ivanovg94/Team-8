﻿using Team8Project.Common;
using Team8Project.Contracts;
using Team8Project.Core;
using System.Text;
using Team8Project.Core.Providers;
using Team8Project.Common.Enums;

namespace Team8Project.Models.Magic
{
    public class DamagingAbility : Ability, IDamagingAbility
    {
        private int damageDealt;

        public DamagingAbility(string name, int cd, HeroClass heroClass, EffectType type, int abilityPower)
            : base(name, cd, heroClass, type, abilityPower)
        {
        }

        public override void Apply()
        {
            var heroDmg = RandomProvider.Generate(this.Caster.DmgStartOfRange, base.Caster.DmgEndOfRange);
            this.damageDealt = heroDmg + base.AbilityPower;

            damageDealt = EffectManager.Instance.TransformDamage(damageDealt, this.Caster);
            base.Caster.Opponent.HealthPoints -= damageDealt;
            base.Apply();
        }

        public override string ToString()
        {
            return $"deals {this.damageDealt} damage";
        }

        public override string Print()
        {
            var sb = new StringBuilder();
            sb.Append($"{this.Name} {this.Caster.DmgStartOfRange + this.AbilityPower} - {this.Caster.DmgEndOfRange + this.AbilityPower} dmg");
            sb.Append(base.Print());
            return sb.ToString();
        }
    }
}
