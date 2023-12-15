using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Environment;
using TheLegendOfZelda.Shared;
using TheLegendOfZelda.Shared.Managers;
using Microsoft.Xna.Framework;
using System;
using System.Runtime.CompilerServices;

namespace TheLegendOfZelda.Items;

public class BowItem : AbstractItem
{
    private const int ItemId = 19;

    public BowItem(Vector2 position)
    {
        Sprite = SpritesheetFactory.Instance.CreateTallItemSprite();
        Sprite.SetFrame(SpriteLocationRow, ItemId);
        Position = position;
    }

    public override void HoldItem(Vector2 location)
    {
        GameObjectManagers.BlockManager.Spawn(new BlackBlock(this.Position));
        base.HoldItem(location);
    }
}