using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PlayerUseBoomerangCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerUseBoomerangCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0) _game.Player.UseItem(typeof(IBoomerang));
    }
}