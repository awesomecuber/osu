using osu.Game.Beatmaps;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.Difficulty.Preprocessing;
using osu.Game.Rulesets.Difficulty.Skills;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Nico.Difficulty.Preprocessing;
using osu.Game.Rulesets.Nico.Difficulty.Skills;
using osu.Game.Rulesets.Nico.Mods;
using System;
using System.Collections.Generic;
using System.Text;

namespace osu.Game.Rulesets.Nico.Difficulty
{
    class NicoDifficultyCalculator : DifficultyCalculator
    {

        public NicoDifficultyCalculator(Ruleset ruleset, WorkingBeatmap beatmap) : base(ruleset, beatmap)
        {
        }

        protected override DifficultyAttributes CreateDifficultyAttributes(IBeatmap beatmap, Mod[] mods, Skill[] skills, double clockRate) => new NicoDifficultyAttributes();

        protected override IEnumerable<DifficultyHitObject> CreateDifficultyHitObjects(IBeatmap beatmap, double clockRate)
        {
            for (int i = 1; i < beatmap.HitObjects.Count; i++)
            yield return new NicoDifficultyHitObject(beatmap.HitObjects[i], beatmap.HitObjects[i - 1], clockRate);
        }

        protected override Skill[] CreateSkills(IBeatmap beatmap) => new Skill[] { new Strain() };

        protected override Mod[] DifficultyAdjustmentMods => new Mod[]
        {
            new NicoModDoubleTime(),
            new NicoModHalfTime()
        };
    }
}
