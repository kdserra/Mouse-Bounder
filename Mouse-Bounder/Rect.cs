using System.Drawing;

namespace Mouse_Bounder
{
    public struct Rect
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public Rect(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Rect(Point bottomLeftPosition, Point topRightPosition)
        {
            Left = bottomLeftPosition.X;
            Top = bottomLeftPosition.Y;
            Right = topRightPosition.X;
            Bottom = topRightPosition.Y;
        }
        
        public Point GetTopLeft()
        {
            return new Point((int)Left, (int)Top);
        }

        public Point GetTopRight()
        {
            return new Point((int)Right, (int)Top);
        }

        public Point GetBottomLeft()
        {
            return new Point((int)Left, (int)Bottom);
        }

        public Point GetBottomRight()
        {
            return new Point((int)Right, (int)Bottom);
        }

        public float GetWidth()
        {
            return Right - Left;
        }

        public float GetHeight()
        {
            return Bottom - Top;
        }
        
        public bool Contains(float x, float y)
        {
            return x >= Left && x <= Right && y >= Top && y <= Bottom;
        }

        public bool Contains(Point position)
        {
            return Contains(position.X, position.Y);
        }
    }
}
