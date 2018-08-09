﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team8Project.Common;
using Team8Project.Contracts;
using Team8Project.Models.Magic;

namespace Team8Project.Models.Statuses
{
    public class Effect : Ability, IAbility, IEffect
    {
        private int duration;
        public Effect(string name, int cd, HeroClass heroClass, EffectType type, int duration, int abilityPower)
            : base(name, cd, heroClass, type, abilityPower)
        {
            this.Duration = duration;

                  }

        public int Duration
        {
            get { return duration; }
            set
            {
                duration = value;
            }
        }

        public override void Apply()
        {
            if (base.Target.AppliedEffects.Contains(this))
            {
                base.Target.AppliedEffects.FirstOrDefault(x => x == this).Duration += duration; //FIX DURATION MAX DURATION LEFT
            }
            else
            {
                base.Target.AppliedEffects.Add(this);
            }
            this.CD2 = -1;
            this.OnCD = true;
        }
        public override string ToString()
        {
            return $"applies {this.Type.ToString()} duration {this.Duration}turns";
        }

        public override string Print() { return null; }

    }
}

