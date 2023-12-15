using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class BlueStairsBlock : AbstractBlock
{
    public BlueStairsBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(BlueStairsBlock));
        PhysicalPassThrough = true;
        MagicalPassThrough = true;
    }
}