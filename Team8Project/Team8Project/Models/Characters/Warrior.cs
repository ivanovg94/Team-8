﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Team8Project.Common.Enums;
using Team8Project.Contracts;

namespace Team8Project.Models.Characters
{
    public class Warrior : Hero, IHero
    {
        public Warrior(string name, HeroClass heroClass, int healthPoints, int dmgStartOfRange, int dmgEndOfRange) : base(name, heroClass, healthPoints, dmgStartOfRange, dmgEndOfRange)
        {
        }

        public override void InitializeTerrain(ITerrain terrain)
        {
            terrain.ApplyInitialWarriorEffect(this);
        }
    }
}