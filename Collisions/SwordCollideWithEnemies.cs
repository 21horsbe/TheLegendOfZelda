using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Players;
using TheLegendOfZelda.Shared;
using TheLegendOfZelda.Items;
using TheLegendOfZelda.Projectiles;
using TheLegendOfZelda.Collisions;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class SwordCollideWithEnemies
{
    public static SwordCollideWithEnemies Instance = new();

    private SwordCollideWithEnemies()
    {
    }

    public void HandleCollisions(List<IEnemy> enemies, ISword sword)
    {
        bool swordIsActive = sword != null;
        if (swordIsActive && !sword.Hitbox.IsEmpty)
        {
            foreach (IEnemy enemy in enemies)
                if (!Rectangle.Intersect(enemy.Hitbox, sword.Hitbox).IsEmpty)
                {
                    Rectangle intersect = Rectangle.Intersect(enemy.Hitbox, sword.Hitbox);
                    enemy.TakeDamage(sword.DamageAmount,
                        CollisionHelper.Instance.SquareCollidedFrom(intersect, ((IGameObject)enemy).Position));
                }
        }
    }
}