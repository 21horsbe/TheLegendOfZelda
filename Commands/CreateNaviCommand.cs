using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Players;

namespace TheLegendOfZelda.Commands;

public class CreateNaviCommand : ICommand
{
    private readonly Game1 _game;

    public CreateNaviCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0)
        {
            _game.NaviEntity.ReleaseEnemy();
            _game.NaviEntity = new Navi(_game);
        }
    }
}