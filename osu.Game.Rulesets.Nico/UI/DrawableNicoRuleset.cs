using System;
using System.Collections.Generic;
using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Configuration;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Nico.Object;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.UI.Scrolling;
using osu.Game.Scoring;
using osu.Game.Screens.Play;

namespace osu.Game.Rulesets.Nico.UI
{
    public class DrawableNicoRuleset : DrawableScrollingRuleset<NicoHitObject>
    {
        protected override ScrollVisualisationMethod VisualisationMethod => ScrollVisualisationMethod.Constant;

        protected override bool UserScrollSpeedAdjustment => false;

        public DrawableNicoRuleset(Ruleset ruleset, WorkingBeatmap beatmap, IReadOnlyList<Mod> mods) : base(ruleset, beatmap, mods)
        {
            Direction.Value = ScrollingDirection.Left;
            TimeRange.Value = 7000;
        }

        public override Objects.Drawables.DrawableHitObject<NicoHitObject> CreateDrawableRepresentation(NicoHitObject h)
        {
            throw new NotImplementedException();
        }

        protected override PassThroughInputManager CreateInputManager()
        {
            throw new NotImplementedException();
        }

        protected override Playfield CreatePlayfield()
        {
            throw new NotImplementedException();
        }
    }
}
