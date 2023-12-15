using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Items;

public class HeartContainerItem : AbstractItem
{
    private const int ItemId = 2;

    public HeartContainerItem(Vector2 position)
    {
        Sprite = SpritesheetFactory.Instance.CreateLargeItemSprite();
        Sprite.SetFrame(SpriteLocationRow, ItemId);
        Position = position;
        Width = 16 * Globals.GlobalSizeMult;
    }
}