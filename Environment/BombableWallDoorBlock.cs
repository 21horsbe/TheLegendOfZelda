using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class BombableWallDoorBlock : AbstractDoorBlock
{
    public bool Bombed { get; private set; } = false;
    public BombableWallDoorBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateDoorSprite(typeof(BombableWallDoorBlock));
        Bombed = false;
    }

    public void BeBombed()
    {
        TextureAtlasSprite.SetFrame(TextureAtlasSprite.Row, 2);
        Bombed = true;
    }
}