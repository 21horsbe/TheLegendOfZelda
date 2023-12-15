using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class LeftFacingStatueBlock : AbstractBlock
{
    public LeftFacingStatueBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(LeftFacingStatueBlock));
        PhysicalPassThrough = false;
        MagicalPassThrough = true;
    }
}