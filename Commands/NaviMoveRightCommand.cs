using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class NaviMoveRightCommand : ICommand
{
    private readonly Game1 _game;

    public NaviMoveRightCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0) _game.NaviEntity.MoveRight();
    }
}