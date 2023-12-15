using TheLegendOfZelda.Environment;
using TheLegendOfZelda.Interfaces;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class BombCollideWithDoors
{
    public static BombCollideWithDoors Instance = new();

    private BombCollideWithDoors()
    {
    }

    public void HandleCollisions(IPlayerProjectile projectile, List<IDoor> doors)
    {
        foreach (IDoor door in doors)
            if (door is BombableWallDoorBlock)
            {
                Rectangle intersect = Rectangle.Intersect(projectile.Hitbox, door.Hitbox);

                if (!intersect.IsEmpty)
                {
                    (door as BombableWallDoorBlock).BeBombed();
                }
            }
    }
}