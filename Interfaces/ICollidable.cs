using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Interfaces
{
    public interface ICollidable
    {
        public Rectangle Hitbox { get; }
        public Direction MovingDirection { get; set; }
        public void UpdateHitbox();
    }
}