using System.Drawing;

namespace Eindopdracht
{
    class Cappy : Sprite
    {
        public Cappy(RectangleF screenPosition)
        {
            this.screenPosition = screenPosition;
            imageFrame = new Rectangle(95, 477, 16, 16);
        }
    }
}
