using osu.Game.Beatmaps;
using osu.Game.Rulesets.Nico.Object;
using osu.Game.Rulesets.Objects;
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

        protected override IEnumerable<Type> ValidConversionTypes => throw new NotImplementedException();

        protected override IEnumerable<NicoHitObject> ConvertHitObject(HitObject original, IBeatmap beatmap)
        {
            throw new NotImplementedException();
        }
    }
}
