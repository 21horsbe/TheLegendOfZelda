using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Items;

public class ArrowItem : AbstractItem
{
    private const int ItemId = 20;

    public ArrowItem(Vector2 position)
    {
        Sprite = SpritesheetFactory.Instance.CreateTallItemSprite();
        Sprite.SetFrame(SpriteLocationRow, ItemId);
        Position = position;
    }
}