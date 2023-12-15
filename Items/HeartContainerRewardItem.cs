using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared;
using TheLegendOfZelda.Shared.Managers;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Items;

public class HeartContainerRewardItem : AbstractItem
{
    private const int ItemId = 2;
    private bool _hasPlayedSound = false;

    public HeartContainerRewardItem(Vector2 position)
    {
        Sprite = SpritesheetFactory.Instance.CreateLargeItemSprite();
        Sprite.SetFrame(SpriteLocationRow, ItemId);
        Position = position;
        Width = 16 * Globals.GlobalSizeMult;
    }

    public override void Draw()
    {
        if (GameObjectManagers.EnemyManager.ActiveGameObjects.Count == 0) Sprite.Draw(Position);
    }

    public override void UpdateHitbox()
    {
        if (GameObjectManagers.EnemyManager.ActiveGameObjects.Count == 0)
        {
            Hitbox = new Rectangle((int)Position.X, (int)Position.Y, Width, Height);
            if (!_hasPlayedSound)
            {
                SoundFactory.Instance.PlayKeyAppear();
                _hasPlayedSound = true;
            }
        }
    }
}