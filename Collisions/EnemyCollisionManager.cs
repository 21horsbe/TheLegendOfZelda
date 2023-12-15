using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared.Managers;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class EnemyCollisionManager : ICollisionManager
{
    private readonly List<IEnemy> _enemies = GameObjectManagers.EnemyManager.ActiveGameObjects;
    private readonly List<IBlock> _blocks = GameObjectManagers.BlockManager.ActiveGameObjects;
    private readonly List<IDoor> _doors = GameObjectManagers.DoorManager.ActiveGameObjects;

    public void HandleCollisions()
    {
        foreach (IEnemy enemy in _enemies)
        {
            EnemyCollideWithProjectiles.Instance.HandleCollisions(enemy);
            EnemyCollideWithBlocks.Instance.HandleCollisions(enemy, _blocks);
            EnemyCollideWithDoors.Instance.HandleCollisions(enemy, _doors);
            EnemyCollideWithEnemies.Instance.HandleCollisions(enemy, _enemies);
        }
    }
}