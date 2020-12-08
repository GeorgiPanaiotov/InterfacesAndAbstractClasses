using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : IDrawable
    {
        private int width;
        private int height;
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }
        public int Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                try
                {
                    if (value > 0)
                    {
                        this.width = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Write a number that is bigger than 0");
                }
            }
        }
        public int Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                try
                {
                    if (value > 0)
                    {
                        this.height = value;
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Write a number that is bigger than 0");
                }
            }
        }
        public void Draw()
        {
            for (int row = 0; row < this.Height; row++)
            {
                for (int col = 0; col < this.Width; col++)
                {
                    if (row == 0 || row == Height - 1)
                    {
                        Console.Write("*");
                        continue;
                    }
                    if (col == 0 || col == Width - 1)
                    {
                        Console.Write("*");
                        continue;
                    }
                    else
                    {
                        Console.Write(" ");
                        continue;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
