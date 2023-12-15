using TheLegendOfZelda.Interfaces;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheLegendOfZelda.Items
{
    public class WoodenSwordUp : AbstractSword
    {
        public WoodenSwordUp(IPlayer player)
        {
            TextureAtlasSprite = SpritesheetFactory.Instance.CreateTallProjectileSprite();
            TextureAtlasSprite.SetFrame(2, 1);
            Location = new Vector2(player.XPosition + OffsetSize, player.YPosition + OffsetSize);
            Location.Y -= 4 * OffsetSize;
            UpdateHitbox();
            SoundFactory.Instance.PlaySwordSlash();
        }
    }
}
