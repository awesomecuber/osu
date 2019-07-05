using osu.Game.Beatmaps;
using osu.Game.Rulesets.Nico.Object;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace osu.Game.Rulesets.Nico.Beatmaps
{
    class NicoBeatmapConverter : BeatmapConverter<NicoHitObject>
    {
        public NicoBeatmapConverter(IBeatmap beatmap) : base(beatmap)
        {
        }

        protected override IEnumerable<Type> ValidConversionTypes { get; } = new[] { typeof(IHasXPosition) };

        protected override IEnumerable<NicoHitObject> ConvertHitObject(HitObject original, IBeatmap beatmap)
        {
            yield return new NicoHitObject { StartTime = original.StartTime};
        }
    }
}
