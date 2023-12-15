using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Projectiles;

namespace TheLegendOfZelda.Commands;

public class PlayerUseHadokenCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerUseHadokenCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0) _game.Player.UseItem(typeof(Hadoken));
    }
}