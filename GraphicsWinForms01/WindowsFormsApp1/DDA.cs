using System;
using System.Drawing;


namespace GraphicsWinForms01
{
    class DDA
    {
        public PointF[] DrawLineDDA(float x1, float y1, float x2, float y2)
        {
            int i, L, xstart, ystart, xend, yend;
            float dX, dY;
            float[,] xy = new float[2, 1000];
            xstart = (int)Math.Round(x1);
            ystart = (int)Math.Round(y1);
            xend = (int)Math.Round(x2);
            yend = (int)Math.Round(y2);
            L = Math.Max(Math.Abs(xend - xstart), Math.Abs(yend - ystart));
            dX = (x2 - x1) / L;
            dY = (y2 - y1) / L;
            i = 0;
            xy[0, i] = x1;
            xy[1, i] = y1;
            i++;
            while (i < L)
            {
                xy[0, i] = xy[0, i - 1] + dX;
                xy[1, i] = xy[1, i - 1] + dY;
                i++;
            }
            xy[0, i] = x2;
            xy[1, i] = y2;
            PointF[] pointFs = new PointF[L];
            for (int k = 0; k < L; k++)
            {
                pointFs[k].X = xy[0, k];
                pointFs[k].Y = xy[1, k];
            }
            return pointFs;
        }
    }
}
