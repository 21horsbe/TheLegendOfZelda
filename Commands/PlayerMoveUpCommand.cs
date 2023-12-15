using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PlayerMoveUpCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerMoveUpCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0 && !_game.SelectingCharacter) _game.Player.MoveUp();
    }
}