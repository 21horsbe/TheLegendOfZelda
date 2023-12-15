using TheLegendOfZelda.Enemies;
using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Items;
using TheLegendOfZelda.Projectiles;
using TheLegendOfZelda.Shared.Managers;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Collisions;

public class EnemyCollideWithProjectiles
{
    public static EnemyCollideWithProjectiles Instance = new();

    private EnemyCollideWithProjectiles()
    {
    }

    public void HandleCollisions(IEnemy enemy)
    {
        foreach (IPlayerProjectile projectile in PlayerProjectilesManager.Instance.ActiveProjectiles)
        {
            Rectangle intersect = Rectangle.Intersect(enemy.Hitbox, projectile.Hitbox);

            if (!intersect.IsEmpty /*&& enemy.GetType() != typeof(DamagedEnemy)*/)
            {
                //handle collisions
                //enemy.TakeDamage(1, global.InvertDirection(projectile.MovingDirection
                projectile.StruckSomething = true;

                if (projectile is BoomerangDown || projectile is BoomerangUp || projectile is BoomerangRight ||
                    projectile is BoomerangLeft)
                {
                    enemy.Freeze(120);
                    if (enemy is KeeseEnemy || enemy is GelEnemy || projectile.DamageAmount > 0)
                    {
                        enemy.TakeDamage(1, CollisionHelper.Instance.SquareCollidedFrom(intersect, enemy.Position));
                    }
                }

                else if (projectile is IBomb && enemy is DodongoEnemy)
                {
                    DodongoEnemy dodongo = (DodongoEnemy)enemy;
                    dodongo.Stun();
                }

                else
                {
                    enemy.TakeDamage(projectile.DamageAmount,
                        CollisionHelper.Instance.SquareCollidedFrom(intersect, enemy.Position));
                }
            }
        }
    }
}