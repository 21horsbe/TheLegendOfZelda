using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class RightFacingStatueBlock : AbstractBlock
{
    public RightFacingStatueBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(RightFacingStatueBlock));
        PhysicalPassThrough = false;
        MagicalPassThrough = true;
    }
}