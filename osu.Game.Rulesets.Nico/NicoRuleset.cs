using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Input.Bindings;
using osu.Game.Beatmaps;
using osu.Game.Configuration;
using osu.Game.Overlays.Settings;
using osu.Game.Rulesets.Configuration;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.Edit;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.Nico.Beatmaps;
using osu.Game.Rulesets.Nico.Difficulty;
using osu.Game.Rulesets.UI;
using osu.Game.Scoring;

namespace osu.Game.Rulesets.Nico
{
    public class NicoRuleset : Ruleset
    {
        public NicoRuleset(RulesetInfo rulesetInfo = null) : base(rulesetInfo)
        {
        }

        public override string Description => "osu!nico";
        public override string ShortName => "nico";

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) => new NicoBeatmapConverter(beatmap);

        // add configs later (laser color, scroll speed/type)
        public override IRulesetConfigManager CreateConfig(SettingsStore settings) => base.CreateConfig(settings);

        public override DifficultyCalculator CreateDifficultyCalculator(WorkingBeatmap beatmap) => new NicoDifficultyCalculator(this, beatmap);

        public override DrawableRuleset CreateDrawableRulesetWith(WorkingBeatmap beatmap, IReadOnlyList<Mod> mods)
        {
            throw new System.NotImplementedException();
        }

        public override HitObjectComposer CreateHitObjectComposer()
        {
            return base.CreateHitObjectComposer();
        }

        public override Drawable CreateIcon()
        {
            return base.CreateIcon();
        }

        public override PerformanceCalculator CreatePerformanceCalculator(WorkingBeatmap beatmap, ScoreInfo score)
        {
            return base.CreatePerformanceCalculator(beatmap, score);
        }

        public override RulesetSettingsSubsection CreateSettings()
        {
            return base.CreateSettings();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0)
        {
            return base.GetDefaultKeyBindings(variant);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override IEnumerable<Mod> GetModsFor(ModType type)
        {
            throw new System.NotImplementedException();
        }

        public override string GetVariantName(int variant)
        {
            return base.GetVariantName(variant);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
