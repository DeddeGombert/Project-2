using System;
using System.Windows;
using System.Windows.Forms;
using System.Drawing;

namespace Project2
{

    class Mandelbrot : Form {
        Logic MyLogic;

        public Mandelbrot() {
            Text = "Mandelbrot";
            MyLogic = new Logic();

            Paint += Teken;
        }

        public void Teken(Object o, PaintEventArgs pea) {



            double xsize = ClientSize.Width;
            double ysize = ClientSize.Height;

            pea.Graphics.FillRectangle(Brushes.Black, 0, 0, 200, 200);

            for (double x = 0; x < xsize; x++)
            {
                for (double y = 0; y < ysize; y++)
                {
                    double actX = x / xsize * 4 - 2;
                    double actY = y / ysize * 4 - 2;

                    uint f = MyLogic.GetF(actX, actY);

                    Console.WriteLine(f + " " + actX + " " + actY);

                    if (f % 2 == 1) {
                        pea.Graphics.FillRectangle(Brushes.Black, (int) x, (int) y, 1, 1);
                    } else {
                        pea.Graphics.FillRectangle(Brushes.White, (int) x, (int) y, 1, 1);
                    }
                }
            }
        }
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Mandelbrot Target = new Mandelbrot();
            Application.Run(Target);
        }
    }
}
