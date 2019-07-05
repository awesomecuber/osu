using osu.Game.Rulesets.Difficulty.Preprocessing;
using osu.Game.Rulesets.Nico.Object;
using osu.Game.Rulesets.Objects;

namespace osu.Game.Rulesets.Nico.Difficulty.Preprocessing
{
    public class NicoDifficultyHitObject : DifficultyHitObject
    {
        protected new NicoHitObject BaseObject => (NicoHitObject)base.BaseObject;

        public NicoDifficultyHitObject(HitObject hitObject, HitObject lastObject, double clockRate) : base(hitObject, lastObject, clockRate)
        {
        }
    }
}
