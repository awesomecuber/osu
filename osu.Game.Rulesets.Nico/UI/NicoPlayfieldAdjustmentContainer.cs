using osu.Framework.Graphics;
using osu.Game.Rulesets.UI;
using osuTK;

namespace osu.Game.Rulesets.Nico.UI
{
    public class NicoPlayfieldAdjustmentContainer : PlayfieldAdjustmentContainer
    {
        //idek
        public NicoPlayfieldAdjustmentContainer()
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;

            Size = new Vector2(1, 0.8f);
        }
    }
}
