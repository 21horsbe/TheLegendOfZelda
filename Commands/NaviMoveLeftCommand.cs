﻿using TheLegendOfZelda.Interfaces;

namespace TheLegendOfZelda.Commands;

public class NaviMoveLeftCommand : ICommand
{
    private readonly Game1 _game;

    public NaviMoveLeftCommand(Game1 game)
    {
        _game = game;
    }

    public void Execute()
    {
        if (_game.Paused == 0) _game.NaviEntity.MoveLeft();
    }
}