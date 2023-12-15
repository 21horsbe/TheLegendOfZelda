using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Items;

public class MapItem : AbstractItem
{
    private const int ItemId = 12;

    public MapItem(Vector2 position)
    {
        Sprite = SpritesheetFactory.Instance.CreateTallItemSprite();
        Sprite.SetFrame(SpriteLocationRow, ItemId);
        Position = position;
    }
}