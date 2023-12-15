using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment.Doors;

public class LockedDoorBlock : AbstractDoorBlock
{
    public LockedDoorBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateDoorSprite(typeof(LockedDoorBlock));
    }
}