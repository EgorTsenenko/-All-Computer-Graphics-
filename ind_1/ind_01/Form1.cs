using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace ind_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            //Грэкхэм
            //Все точки входного множества А заносятся в массив, а потом точки, не являющиеся вершинами выпуклой оболочки, удаляются из него.
            //По завершению работы алгоритма остаются только вершины выпуклой оболочки в порядке обхода против часовой стрелки.
            InitializeComponent();
        }

        Point p0 = new Point();
        int sizeP;
        const int size = 8;  // количество точек исходного множества
        Point[] A = new Point[size]; // множество точек для которых строится оболочка
        int iter = 0;    // счетчик точек при вводе

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            Graphics g = CreateGraphics();
            

            //заносим координаты новой точки по щелчку мыши
            A[iter] = new Point(PointToClient(Control.MousePosition).X, PointToClient(Control.MousePosition).Y);
            g.FillEllipse(Brushes.Black, A[iter].X - 3, A[iter].Y - 3, 6, 6);
            iter++;

            // все точки заданы, рисуем саму оболочку
            if (iter >= size)
            {
                Point[] S = new Point[size];
                S = convex_build(A);  //передаем точки строющей функции
                int j = 1, i = 0;
                while (j < size && (S[j].X != 0 || S[j].Y != 0)) j++;
                Point[] polygon = new Point[j];

                for (i = 0; i < j; i++) polygon[i] = S[i];
                {
                    g.FillPolygon(Brushes.Red, polygon);
                }
                

                for (i = 0; i < size; i++)
                {
                    g.FillEllipse(Brushes.Black, A[i].X - 3, A[i].Y - 3, 6, 6);
                }
                    
                iter = 0;

            }


        }

        Point[] convex_build(Point[] Q) //построение саммой оболочки(удаление) "лишних" вершин
        {
            //p0 - точка с минимальной координатой у или самая левая из таких точек при наличии совпадений

            p0 = Q[0];
            int ind = 0;
            for (int i = 1; i < size; i++)
                if (Q[i].Y > p0.Y) { p0 = Q[i]; ind = i; }
                else
                    if (Q[i].Y == p0.Y && Q[i].X < p0.X) { p0 = Q[i]; ind = i; }

            //P остальные точки (все Q кроме р0) 
            sizeP = size - 1;
            Point[] P = new Point[sizeP];
            int j = 0;
            for (int i = 0; i < size; i++)
                if (i != ind)
                { P[j] = Q[i]; j++; }

            P = sort(P);  //сортируем Р в порядке возрастания полярного угла,измеряемого 
                          //против часовой стрелки относительно р0

            Point[] S = new Point[size]; //массив,который будет содержать вершины оболочки против часовой стрелки 
            S[0] = p0; S[1] = P[0]; S[2] = P[1];
            int last = 2;
            for (int i = 2; i < sizeP; i++)
            {
                while (last > 0 && angle(S[last - 1], S[last], P[i]) >= 0) last--;
                last++;
                S[last] = P[i];
            }
            return S;
        }


        Point[] sort(Point[] P) // сортирует все точки множества в порядке возрастания 
                                //полярного угла по отнощению к р0
        {
            bool t = true;
            while (t)
            {
                t = false;
                for (int j = 0; j < sizeP - 1; j++)
                    if (alpha(P[j]) > alpha(P[j + 1]))
                    {
                        Point tmp = new Point();
                        tmp = P[j];
                        P[j] = P[j + 1];
                        P[j + 1] = tmp;
                        t = true;

                    }
                    else
                    if (alpha(P[j]) == alpha(P[j + 1]))
                    {
                        if (P[j].X > P[j + 1].X)
                        {
                            for (int k = j + 2; k < sizeP; k++)
                                P[k - 1] = P[k];
                            sizeP--;
                            t = true;
                        }
                        else
                            if (P[j + 1].X > P[j].X)
                        {
                            for (int k = j + 1; k < sizeP; k++)
                                P[k - 1] = P[k];
                            sizeP--;
                            t = true;
                        }


                    }
            }
            return P;
        }

        double alpha(Point t)   // считает полярный угол данной точки по отношению к р0
        {
            t.X -= p0.X;
            t.Y = p0.Y - t.Y;
            double alph;
            if (t.X == 0) alph = Math.PI / 2;
            else
            {

                if (t.Y == 0) alph = 0;
                   else alph = Math.Atan(Convert.ToDouble(t.Y) / Convert.ToDouble(t.X));
                if (t.X < 0) alph += Math.PI;

            }
            return alph;
        }

        double angle(Point t0, Point t1, Point t2)  // через векторное произведение определяет поворот
                                                    //(если величина отрицательная - поворот против часовой стрелки, и наоборот)
        {
            return (t1.X - t0.X) * (t2.Y - t0.Y) - (t2.X - t0.X) * (t1.Y - t0.Y);
        }

        

       
    }
}
