using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PlayerMoveRightCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerMoveRightCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0 && !_game.SelectingCharacter) _game.Player.MoveRight();
    }
}