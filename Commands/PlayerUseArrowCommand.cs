using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PlayerUseArrowCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerUseArrowCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0) _game.Player.UseItem(typeof(IArrow));
    }
}