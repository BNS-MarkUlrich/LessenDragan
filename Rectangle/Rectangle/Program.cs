using System;

namespace Rectangle
{
    class Rectangle
    {
        private float x;
        private float y;
        private float width;
        private float height;
        private bool square;

        public Rectangle(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public Rectangle(float x, float y, float size)
        {
            this.x = y;
            this.y = y;
            width = size;
            height = size;
        }

        public Rectangle(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public Rectangle(float size)
        {
            width = size;
            height = size;
        }
        public void MoveTo(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public bool IsSquare()
        {
            if (height == width)
            {
                return square = true;
            }
            else
            {
                return square = false;
            }
            
        }

        public void Set(float x, float y, float width, float height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        static void Main(string[] args)
        {
            Rectangle rechthoek = new Rectangle(100, 100, 50, 60);
            Rectangle vierkant = new Rectangle(50, 50, 50);
            Rectangle vierkantBeweeg = new Rectangle(50);
            Rectangle rechthoekBeweeg = new Rectangle(20, 30);
            
            vierkantBeweeg.MoveTo(50, 50);
            rechthoekBeweeg.MoveTo(100, 100);
            rechthoekBeweeg.Set(rechthoekBeweeg.x, rechthoekBeweeg.y, rechthoek.width, rechthoek.height);

            vierkant.IsSquare();

            Console.WriteLine(vierkant);
        }
    }
}