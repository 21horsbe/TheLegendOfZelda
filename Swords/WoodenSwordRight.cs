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
    public class WoodenSwordRight : AbstractSword
    {
        public WoodenSwordRight(IPlayer player)
        {
            TextureAtlasSprite = SpritesheetFactory.Instance.CreateLargeProjectileSprite();
            TextureAtlasSprite.SetFrame(4, 1);
            Location = new Vector2(player.XPosition + OffsetSize, player.YPosition + OffsetSize);
            Location.X += 2 * OffsetSize;
            UpdateHitbox();
            SoundFactory.Instance.PlaySwordSlash();
        }
    }
}
