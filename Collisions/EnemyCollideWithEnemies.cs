using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Players;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions
{
    public class EnemyCollideWithEnemies
    {
        public static EnemyCollideWithEnemies Instance = new();
        private EnemyCollideWithEnemies() { }
        public void HandleCollisions(IEnemy enemy, List<IEnemy> enemies)
        {
            foreach (IEnemy enemy2 in enemies)
            {
                if (enemy2 != enemy)
                {
                    Rectangle intersect = Rectangle.Intersect(enemy.Hitbox, enemy2.Hitbox);

                    if (!intersect.IsEmpty)
                    {
                        //handle collisions
                        enemy.HitEnemy(enemy2);
                        enemy2.HitEnemy(enemy);
                    }
                }
            }
        }
    }
}