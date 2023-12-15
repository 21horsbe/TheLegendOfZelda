﻿using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using TheLegendOfZelda.Shared.Managers;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Items;

public class KeyRewardItem : KeyItem
{
    private const int ItemId = 31;
    private bool _hasPlayedSound = false;

    public KeyRewardItem(Vector2 position) : base(position)
    {
        Sprite = SpritesheetFactory.Instance.CreateTallItemSprite();
        Sprite.SetFrame(SpriteLocationRow, ItemId);
        Position = position;
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