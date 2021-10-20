using System.Drawing;

namespace GraphicsWinForms02
{
    public class CircleDrawer
    {
        static public int count = 0, c = 0;
        static public Point[] points1 = new Point[count];
        public Point[] BresenhamCircle(int x0, int y0, int r)
        {
            count = 0;
            int i = 0;
            int x = r;
            int y = 0;
            int radiusError = 1 - x;
            if (count == 0)
            {
                while (x >= y)
                {
                    count++;
                    y++;
                    if (radiusError < 0)
                    {
                        radiusError += 2 * y + 1;
                    }
                    else
                    {
                        x--;
                        radiusError += 2 * (y - x + 1);
                    }
                }
            }
            count--;
            Point[] points = new Point[count];
            x = r;
            y = 0;
            while (x >= y)
            {
                points[i].X = x + x0; points[i].Y = y + y0;
                y++;
                if (radiusError < 0)
                {
                    radiusError += 2 * y + 1;
                }
                else
                {
                    x--;
                    radiusError += 2 * (y - x + 1);
                }
                i++;
            }
            return points;
        }
        public Point[] MichnerCircle(int x0, int y0, int r)
        {
            int x, y, d, i = 0;
            x = 0; y = r; d = 3 - 2 * r;
            if (c == 0)
            {
                while (x < y)
                {
                    c++;
                    if (d < 0) d = d + 4 * x + 6;
                    else
                    {
                        d = d + 4 * (x - y) + 10; --y;
                    }
                    ++x;
                }
            }
            x = 0; y = r; d = 3 - 2 * r;
            Point[] points = new Point[c];
            while (x < y)
            {
                points[i].X = x0 + x;
                points[i].Y = y0 + y;
                if (d < 0) d = d + 4 * x + 6;
                else
                {
                    d = d + 4 * (x - y) + 10; --y;
                }
                i++;
                ++x;
            }
            if (x == y)
            {
                points[c - 1].X = x0 + x;
                points[c - 1].Y = y0 + y;
            }
            return points;
        }
    }
}
