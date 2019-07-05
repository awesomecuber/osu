using osu.Game.Beatmaps;
using osu.Game.Beatmaps.ControlPoints;
using osu.Game.Rulesets.Judgements;
using osu.Game.Rulesets.Objects;
using System;
using System.Collections.Generic;
using System.Text;

namespace osu.Game.Rulesets.Nico.Object
{
    public class NicoHitObject : HitObject
    {
        public override double StartTime { get => base.StartTime; set => base.StartTime = value; }

        protected override HitWindows CreateHitWindows() => new NicoHitWindows();
    }
}
