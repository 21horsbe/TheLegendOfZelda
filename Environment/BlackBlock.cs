using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class BlackBlock : AbstractBlock
{
    public BlackBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(BlackBlock));
        Hitbox = new Rectangle(0, 0, 0, 0);
        PhysicalPassThrough = true;
        MagicalPassThrough = true;
    }
}