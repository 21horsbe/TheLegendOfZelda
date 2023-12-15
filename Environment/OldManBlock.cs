﻿using TheLegendOfZelda.AbstractClasses;
using TheLegendOfZelda.Shared;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class OldManBlock : AbstractBlock
{
    public OldManBlock(Vector2 position) : base(position)
    {
        TextureAtlasSprite = SpritesheetFactory.Instance.CreateBlockSprite(typeof(OldManBlock));
        PhysicalPassThrough = true;
        MagicalPassThrough = true;
    }
}