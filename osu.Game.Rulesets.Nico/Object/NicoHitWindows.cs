using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Scoring;
using System;
using System.Collections.Generic;
using System.Text;

namespace osu.Game.Rulesets.Nico.Object
{
    class NicoHitWindows : HitWindows
    {
        public override bool IsHitResultAllowed(HitResult result)
        {
            return base.IsHitResultAllowed(result);
        }

        public override void SetDifficulty(double difficulty)
        {
            base.SetDifficulty(difficulty);
        }
    }
}
