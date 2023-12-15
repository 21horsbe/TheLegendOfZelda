using TheLegendOfZelda.Enemies;
using TheLegendOfZelda.Environment;
using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Players;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class NaviCollideWithEnemies
{
    public static readonly NaviCollideWithEnemies Instance = new();

    private NaviCollideWithEnemies()
    {
    }

    public IEnemy CheckForCollision(Navi naviEntity, List<IEnemy> enemies)
    {
        foreach (IEnemy enemy in enemies)
        {
            Rectangle intersect = Rectangle.Intersect(naviEntity.Hitbox, enemy.Hitbox);

            if (!intersect.IsEmpty && enemy is not AquamentusEnemy && enemy is not DodongoEnemy)
            {
                enemy.Controlled = true;
                return enemy;
            }
        }
        return null;
    }
}