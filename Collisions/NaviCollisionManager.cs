using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.LevelLoading;
using TheLegendOfZelda.Players;
using TheLegendOfZelda.Shared.Managers;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions;

public class NaviCollisionManager : ICollisionManager
{
    private readonly Navi _naviEntity;
    private readonly List<IBlock> _blocks = GameObjectManagers.BlockManager.ActiveGameObjects;

    public NaviCollisionManager(Navi n)
    {
        _naviEntity = n;
    }

    public void HandleCollisions()
    {
        NaviCollideWithBlocks.Instance.HandleCollisions(_naviEntity, _blocks);
    }
}