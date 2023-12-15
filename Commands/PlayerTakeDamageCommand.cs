using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PlayerTakeDamageCommand : ICommand
{
    private readonly Game1 _game;

    public PlayerTakeDamageCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        _game.Player.TakeDamage(1, Shared.Direction.Left);
    }
}