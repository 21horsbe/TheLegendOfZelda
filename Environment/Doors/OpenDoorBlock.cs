using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Environment.Doors;
using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class OpenDoorBlock : AbstractDoorBlock
{
    public OpenDoorBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateDoorSprite(typeof(OpenDoorBlock));
    }

    public OpenDoorBlock(IDoor block, Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateDoorSprite(typeof(OpenDoorBlock));
        AdjacentRoomId = block.AdjacentRoomId;
        FacingDirection = block.FacingDirection;
        SetCorrectSprite();
    }
}