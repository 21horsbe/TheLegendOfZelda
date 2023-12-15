using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class WhiteWalkingStairsBlock : AbstractBlock
{
    public WhiteWalkingStairsBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(WhiteStairsBlock));
        PhysicalPassThrough = true;
        MagicalPassThrough = true;
    }
}