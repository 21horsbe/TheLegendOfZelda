using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZelda.Interfaces
{
    public interface IKeyboardController
    {
        public void RegisterCommand(Keys keys, ICommand command);
        public void Update();
    }
}
