using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment.Doors;

public class DiamondDoorBlock : AbstractDoorBlock
{
    public DiamondDoorBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateDoorSprite(typeof(DiamondDoorBlock));
    }
}