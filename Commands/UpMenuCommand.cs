using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands
{
    public class UpMenuCommand : ICommand
    {
        private Game1 _game1;
        public UpMenuCommand(Game1 game)
        {
            _game1 = game;
        }
        public void Execute()
        {
            if (_game1.GameLose) _game1.GameOverScreen.UpMenu();
        }
    }
}
