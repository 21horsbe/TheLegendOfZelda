using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class JewelCutBlueBlock : AbstractBlock
{
    public JewelCutBlueBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(JewelCutBlueBlock));
        PhysicalPassThrough = false;
        MagicalPassThrough = true;
    }
}