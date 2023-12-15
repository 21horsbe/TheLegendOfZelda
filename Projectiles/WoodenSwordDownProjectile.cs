using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Players;
using TheLegendOfZelda.Projectiles;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZelda.Items
{
    public class WoodenSwordDownProjectile : AbstractSwordProjectile
    {
        public WoodenSwordDownProjectile(Vector2 position)
        {
            TextureAtlasSprite = SpritesheetFactory.Instance.CreateTallProjectileSprite();
            TextureAtlasSprite.SetFrame(1, 1);
            CurrentLocation = position;
            CurrentLocation.Y += InitialOffset;
            CurrentLocation.X += 10;
            RemainingTimeOfFlight = MaxTimeOfFlight;
            Active = true;
            MovingDirection = Direction.Down;
            Height = 16 * Globals.GlobalSizeMult;
            SoundFactory.Instance.PlaySwordProjectileFire();
        }
        public override void Update()
        {
            CurrentLocation.Y += StepSize;
            RemainingTimeOfFlight--;
            if (RemainingTimeOfFlight % 2 == 0) TextureAtlasSprite.SetFrame(TextureAtlasSprite.Row, RemainingTimeOfFlight % 3 + 1);
            if (!StrikeRegistered && StruckSomething)
            {
                RemainingTimeOfFlight = 0;
                StrikeRegistered = true;
            }
            if (RemainingTimeOfFlight == 0)
            {
                Explosion = new WoodenSwordProjectileExplosion(CurrentLocation);
            }
            else if(RemainingTimeOfFlight < 0)
            {
                Explosion.Update();
                if (!Explosion.Active) Active = false;
            }
            UpdateHitbox();
        }
    }
}
