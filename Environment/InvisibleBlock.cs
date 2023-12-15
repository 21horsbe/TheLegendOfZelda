using TheLegendOfZelda.AbstractClasses;
using Microsoft.Xna.Framework;

namespace TheLegendOfZelda.Environment;

public class InvisibleBlock : AbstractBlock
{
    public InvisibleBlock(Vector2 position) : base(position)
    {
        PhysicalPassThrough = false;
        MagicalPassThrough = false;
    }

    public override void Draw()
    {
    }
}