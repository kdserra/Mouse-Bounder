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
            return new Point(Left, Top);
        }

        public Point GetTopRight()
        {
            return new Point(Right, Top);
        }

        public Point GetBottomLeft()
        {
            return new Point(Left, Bottom);
        }

        public Point GetBottomRight()
        {
            return new Point(Right, Bottom);
        }

        public float GetWidth()
        {
            return Right - Left;
        }

        public float GetHeight()
        {
            return Bottom - Top;
        }

        public bool Contains(int x, int y)
        {
            return x >= Left && x <= Right && y >= Top && y <= Bottom;
        }

        public bool Contains(Point position)
        {
            return Contains(position.X, position.Y);
        }

        public Point Bound(Point position)
        {
            if (Contains(position))
            {
                return position;
            }

            if (position.X < Left)
            {
                position = new Point(Left, position.Y);
            }
            else if (position.X > Right)
            {
                position = new Point(Right, position.Y);
            }

            if (position.Y < Top)
            {
                position = new Point(position.X, Top);
            }
            else if (position.Y > Bottom)
            {
                position = new Point(position.X, Bottom);
            }

            return position;
        }
    }
}
