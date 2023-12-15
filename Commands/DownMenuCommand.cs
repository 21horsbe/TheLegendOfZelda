using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands
{
    public class DownMenuCommand : ICommand
    {
        private Game1 _game1;
        public DownMenuCommand(Game1 game)
        {
            _game1 = game;
        }
        public void Execute()
        {
            if (_game1.GameLose) _game1.GameOverScreen.DownMenu();
        }
    }
}
