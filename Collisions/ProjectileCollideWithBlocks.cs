using TheLegendOfZelda.Environment;
using TheLegendOfZelda.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class ProjectileCollideWithBlocks
{
    public static ProjectileCollideWithBlocks Instance = new();

    private ProjectileCollideWithBlocks()
    {
    }

    public void HandleCollisions(IPlayerProjectile projectile, List<IBlock> blocks)
    {
        foreach (IBlock block in blocks)
            if (!(block is IIgnorableBlock))
            {
                Rectangle intersect = Rectangle.Intersect(projectile.Hitbox, block.Hitbox);

                if (!intersect.IsEmpty)
                {
                    //handle collisions
                    Type type = projectile.GetType();
                    if (!(type == typeof(IBoomerang)))
                    {
                        projectile.StruckSomething = true;
                    }
                    if (block is BombableWallDoorBlock && projectile is IBomb)
                    {
                        (block as BombableWallDoorBlock).BeBombed();
                    }
                }
            }
    }

    public void HandleCollisions(IEnemyProjectile projectile, List<IBlock> blocks)
    {
        foreach (IBlock block in blocks)
            if (!(block is IIgnorableBlock))
            {
                Rectangle intersect = Rectangle.Intersect(projectile.Hitbox, block.Hitbox);

                if (!intersect.IsEmpty)
                {
                    projectile.StruckSomething = true;
                }
            }
    }
}