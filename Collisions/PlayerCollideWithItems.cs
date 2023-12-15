using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Items;
using TheLegendOfZelda.Players;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace TheLegendOfZelda.Collisions
{
    public class PlayerCollideWithItems 
    {
        public static PlayerCollideWithItems Instance = new();
        private PlayerCollideWithItems() { }
        public void HandleCollisions(IPlayer player, List<IItem> items)
        {
            foreach (IItem item in items)
            {
                Rectangle intersect = Rectangle.Intersect(player.Hitbox, item.Hitbox);

                if (!intersect.IsEmpty)
                {
                    player.PickupItem(item);
                }
            }
        }
    }
}