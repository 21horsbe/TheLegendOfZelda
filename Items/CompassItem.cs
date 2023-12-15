using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Items;

public class CompassItem : AbstractItem
{
    private const int ItemId = 17;

    public CompassItem(Vector2 position)
    {
        Sprite = SpritesheetFactory.Instance.CreateLargeItemSprite();
        Sprite.SetFrame(SpriteLocationRow, ItemId);
        Position = position;
        Width = 16 * Globals.GlobalSizeMult;
    }
}