using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared.Managers;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class ProjectileCollisionManager : ICollisionManager
{
    private readonly List<IPlayerProjectile> _projectiles = PlayerProjectilesManager.Instance.ActiveProjectiles;

    private readonly List<IEnemyProjectile> _enemyProjectiles =
        GameObjectManagers.EnemyProjectileManager.ActiveGameObjects;

    private readonly List<IBlock> _blocks = GameObjectManagers.BlockManager.ActiveGameObjects;
    private readonly List<IDoor> _doors = GameObjectManagers.DoorManager.ActiveGameObjects;

    public void HandleCollisions()
    {
        foreach (IPlayerProjectile projectile in _projectiles)
        {
            ProjectileCollideWithBlocks.Instance.HandleCollisions(projectile, _blocks);
            if (projectile is IBomb) BombCollideWithDoors.Instance.HandleCollisions(projectile, _doors);
        }

        foreach (IEnemyProjectile projectile in _enemyProjectiles)
        {
            ProjectileCollideWithBlocks.Instance.HandleCollisions(projectile, _blocks);
            //ProjectileCollideWithWalls.Instance.HandleCollisions(projectile, _walls?);
        }
    }
}