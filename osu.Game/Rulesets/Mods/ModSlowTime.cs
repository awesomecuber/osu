// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Linq;
using osu.Framework.Graphics.Sprites;

namespace osu.Game.Rulesets.Mods
{
    public abstract class ModSlowTime : ModTimeAdjust, IApplicableToClock
    {
        public override string Name => "Slow Time";

        public override string Acronym => "ST";

        public override IconUsage Icon => FontAwesome.Solid.ArrowDown;

        public override ModType Type => ModType.DifficultyReduction;

        public override string Description => "slow.";

        public override bool Ranked => true;

        public override Type[] IncompatibleMods => base.IncompatibleMods.Append(typeof(ModHalfTime)).ToArray();

        protected override double RateAdjust => 0.9;
    }
}
