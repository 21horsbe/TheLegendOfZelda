using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared.Managers;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class TripwireCollisionManager : ICollisionManager
{
    private readonly List<IEnemy> _enemies = GameObjectManagers.EnemyManager.ActiveGameObjects;
    private readonly Game1 _game;
    public TripwireCollisionManager(Game1 game)
    {
        _game = game;
    }

    public void HandleCollisions()
    {
        PlayerCollideWithTripwire.Instance.HandleCollisions(_game.Player, _enemies);
    }
}