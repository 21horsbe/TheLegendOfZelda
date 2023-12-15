using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class WhiteStairsBlock : AbstractBlock
{
    public WhiteStairsBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(WhiteStairsBlock));
        Hitbox = new Rectangle(0, 0, 0, 0);
        PhysicalPassThrough = true;
        MagicalPassThrough = true;
    }
}