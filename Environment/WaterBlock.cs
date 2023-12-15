using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class WaterBlock : AbstractBlock, IIgnorableBlock
{
    public WaterBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(WaterBlock));
        PhysicalPassThrough = true;
        MagicalPassThrough = true;
    }
}