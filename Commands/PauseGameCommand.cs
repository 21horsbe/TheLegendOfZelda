using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class PauseGameCommand : ICommand
{
    private Game1 _game;

    public PauseGameCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (!_game.GameWin && !_game.SelectingCharacter && !_game.GameLose)
        {
            _game.Paused = (_game.Paused + 1) % 2;
            _game.PauseHud.UpdateObtainedItems();
            _game.PauseHud.HighlightedItem = _game.PauseHud.GetCurrentItemPos();
        }
    }
}