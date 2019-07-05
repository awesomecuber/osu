using osu.Game.Rulesets.Difficulty.Preprocessing;
using osu.Game.Rulesets.Difficulty.Skills;

namespace osu.Game.Rulesets.Nico.Difficulty.Skills
{
    public class Strain : Skill
    {
        protected override double SkillMultiplier => 1;

        protected override double StrainDecayBase => 0.3;

        protected override double StrainValueOf(DifficultyHitObject current)
        {
            return 5;
        }
    }
}
