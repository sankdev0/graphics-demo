using System;
using System.Drawing;

namespace GraphicsWinForms01
{
    class Bresenham
    {
        public PointF[] BresenhamLine(int x0, int y0, int x1, int y1)
        {
            int temp;
            var steep = Math.Abs(y1 - y0) > Math.Abs(x1 - x0);
            // Проверка роста по осям. Отразить по диагонали заменой координат, если угол большой
            if (steep)
            {
                temp = x0;
                x0 = y0;
                y0 = temp;
                temp = x1;
                x1 = y1;
                y1 = temp;
            }
            // Если рост не слева направо, то переворачиваем
            if (x0 > x1)
            {
                temp = x0;
                x0 = x1;
                x1 = temp;
                temp = y0;
                y0 = y1;
                y1 = temp;
            }
            int dx = x1 - x0;
            int dy = Math.Abs(y1 - y0);
            int error = dx / 2;
            // Определить направление изменения координаты y
            int ystep = (y0 < y1) ? 1 : -1;
            int y = y0;
            int count = 0;
            for (int x = x0; x <= x1; x++)
            {

                count++;
            }
            int lenght = count;
            PointF[] pointFs = new PointF[lenght];
            count = 0;
            for (int x = x0; x <= x1; x++)
            {
                if (steep) pointFs[count].X = y;
                else pointFs[count].X = x;
                if (steep) pointFs[count].Y = x;
                else pointFs[count].Y = y;

                error -= dy;
                if (error < 0)
                {
                    y += ystep;
                    error += dx;
                }
                count++;
            }
            return pointFs;
        }
    }
}
