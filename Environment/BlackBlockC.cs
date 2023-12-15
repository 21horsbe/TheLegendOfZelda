using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class BlackBlockC : AbstractBlock
{
    public BlackBlockC(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(BlackBlockC));
        PhysicalPassThrough = false;
        MagicalPassThrough = false;
    }
}