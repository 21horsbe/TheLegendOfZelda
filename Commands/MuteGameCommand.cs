using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZelda.Commands
{
    public class MuteGameCommand : ICommand
    {
        private Game1 _game;
        public MuteGameCommand(Game1 game)
        {
            _game = game;
        }
        public void Execute()
        {
            SoundFactory.Instance.ChangeMuted();
        }
    }
}
