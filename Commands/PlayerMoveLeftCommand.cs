using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PlayerMoveLeftCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerMoveLeftCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0 && !_game.SelectingCharacter) _game.Player.MoveLeft();
    }
}