using System;
using System.Collections.Generic;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Primitives;
using osu.Framework.Input;
using osu.Framework.Input.Events;
using osu.Framework.Timing;
using osu.Game.Beatmaps;
using osu.Game.Configuration;
using osu.Game.Input.Handlers;
using osu.Game.Replays;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Nico.Object;
using osu.Game.Rulesets.Nico.Scoring;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;
using osu.Game.Rulesets.UI.Scrolling;
using osu.Game.Scoring;
using osu.Game.Screens.Play;
using osuTK;

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
            // TimeRange.Value = BeatmapDifficulty.DifficultyRange(beatmap.BeatmapInfo.BaseDifficulty.ApproachRate, 1800, 1200, 450);
        }

        public override ScoreProcessor CreateScoreProcessor() => new NicoScoreProcessor(this);

        public override PlayfieldAdjustmentContainer CreatePlayfieldAdjustmentContainer() => new NicoPlayfieldAdjustmentContainer();

        protected override PassThroughInputManager CreateInputManager() => new NicoInputManager(Ruleset.RulesetInfo);

        protected override Playfield CreatePlayfield() => new NicoPlayfield(Beatmap.ControlPointInfo);

        public override DrawableHitObject<NicoHitObject> CreateDrawableRepresentation(NicoHitObject h)
        {
            throw new NotImplementedException();
        }

        protected override ReplayInputHandler CreateReplayInputHandler(Replay replay) => new NicoFramedReplayInputHandler(replay);
    }
}
