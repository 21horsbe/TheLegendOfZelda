using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class BasicBlueBlock : AbstractBlock
{
    public BasicBlueBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(BasicBlueBlock));
        PhysicalPassThrough = false;
        MagicalPassThrough = true;
    }
}