using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Players;
using TheLegendOfZelda.Projectiles;
using TheLegendOfZelda.Shared;
using TheLegendOfZelda.Shared.Managers;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions
{
    public class PlayerCollideWithProjectiles
    {
        public static PlayerCollideWithProjectiles Instance = new();
        private PlayerCollideWithProjectiles() { }
        public void HandleCollisions(IPlayer player, List<IEnemyProjectile> projectiles)
        {
            foreach (IEnemyProjectile projectile in projectiles)
            {
                Rectangle intersect = Rectangle.Intersect(player.Hitbox, projectile.Hitbox);

                if (!intersect.IsEmpty)
                {
                    //handle collisions
                    // Implements Link's shield
                    if (player.GetType() != typeof(DamagedPlayer))
                    {
                        if (projectile.MovingDirection != CollisionHelper.Instance.InvertDirection(player.MovingDirection))
                        {
                            player.TakeDamage(projectile.DamageAmount, CollisionHelper.Instance.InvertDirection(projectile.MovingDirection));
                        }
                        else SoundFactory.Instance.PlayShieldBlock();
                    }
                    if (projectile.GetType() != typeof(GoriyaBoomerang))
                    {
                        projectile.Active = false;
                    }
                    else
                    {
                        projectile.StruckSomething = true;
                    }
                }
            }
        }
    }
}