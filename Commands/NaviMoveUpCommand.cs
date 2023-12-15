using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class NaviMoveUpCommand : ICommand
{
    private readonly Game1 _game;

    public NaviMoveUpCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0) _game.NaviEntity.MoveUp();
    }
}