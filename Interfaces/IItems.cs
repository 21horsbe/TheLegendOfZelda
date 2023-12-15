using Microsoft.Xna.Framework;
namespace TheLegendOfZelda.Interfaces
{
    public interface IItem : IGameObject, ICollidable
    {
        public void HoldItem (Vector2 location) { }
    }
}