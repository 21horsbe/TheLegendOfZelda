using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PlayerUseSwordCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerUseSwordCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        _game.Player.UseSword();
    }
}