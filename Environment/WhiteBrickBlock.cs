using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class WhiteBrickBlock : AbstractBlock
{
    public WhiteBrickBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(WhiteBrickBlock));
        PhysicalPassThrough = true;
        MagicalPassThrough = true;
    }
}