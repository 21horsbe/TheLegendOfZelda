using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Items;

public class BlueRupeeItem : AbstractItem
{
    private const int ItemId = 10;

    public BlueRupeeItem(Vector2 position)
    {
        Sprite = SpritesheetFactory.Instance.CreateTallItemSprite();
        Sprite.SetFrame(SpriteLocationRow + 1, ItemId);
        Position = position;
    }

    public override void Update()
    {
        base.Update();
    }
}