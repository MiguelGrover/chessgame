using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chessgame
{
    public partial class Form1 : Form
    {
        Pieza[,] piezas;
        List<int[]> movimientos = new List<int[]>();
        bool seleccion = false;
        Pieza seleccionado;
        int xsel, ysel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            crear_juego();
        }

        private void crear_juego()
        {
            piezas = new Pieza[8, 8];
            piezas[0, 0] = new Pieza("r", "b");
            piezas[0, 1] = new Pieza("n", "b");
            piezas[0, 2] = new Pieza("b", "b");
            piezas[0, 3] = new Pieza("q", "b");
            piezas[0, 4] = new Pieza("k", "b");
            piezas[0, 5] = new Pieza("b", "b");
            piezas[0, 6] = new Pieza("n", "b");
            piezas[0, 7] = new Pieza("r", "b");
            for(int x = 0; x < 8; x++)
            {
                piezas[1, x] = new Pieza("p", "b");
            }
            for (int x = 0; x < 8; x++)
            {
                piezas[6, x] = new Pieza("p", "w");
            }
            piezas[7, 0] = new Pieza("r", "w");
            piezas[7, 1] = new Pieza("n", "w");
            piezas[7, 2] = new Pieza("b", "w");
            piezas[7, 3] = new Pieza("q", "w");
            piezas[7, 4] = new Pieza("k", "w");
            piezas[7, 5] = new Pieza("b", "w");
            piezas[7, 6] = new Pieza("n", "w");
            piezas[7, 7] = new Pieza("r", "w");

            pintar_mapa();
        }

        private void pintar_mapa()
        {
            for(int y = 0; y < piezas.GetLength(0); y++)
            {
                for (int x = 0; x < piezas.GetLength(0); x++)
                {
                    if (piezas[y, x] != null)
                    {
                        asociacion_imagen(y, x);
                        
                    }
                    else
                    {
                        limpieza(y, x);
                    }
                }
            }
        }


        private void asociacion_imagen(int y, int x)
        {
            switch (y)
            {
                case 0:
                    switch (x)
                    {
                        case 0:
                            a8.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b8.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c8.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d8.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e8.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f8.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g8.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h8.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
                case 1:
                    switch (x)
                    {
                        case 0:
                            a7.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b7.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c7.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d7.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e7.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f7.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g7.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h7.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
                case 2:
                    switch (x)
                    {
                        case 0:
                            a6.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b6.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c6.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d6.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e6.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f6.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g6.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h6.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
                case 3:
                    switch (x)
                    {
                        case 0:
                            a5.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b5.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c5.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d5.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e5.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f5.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g5.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h5.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
                case 4:
                    switch (x)
                    {
                        case 0:
                            a4.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b4.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c4.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d4.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e4.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f4.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g4.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h4.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
                case 5:
                    switch (x)
                    {
                        case 0:
                            a3.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b3.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c3.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d3.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e3.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f3.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g3.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h3.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
                case 6:
                    switch (x)
                    {
                        case 0:
                            a2.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b2.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c2.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d2.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e2.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f2.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g2.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h2.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
                case 7:
                    switch (x)
                    {
                        case 0:
                            a1.Image = piezas[y, x].Imagen;
                            break;
                        case 1:
                            b1.Image = piezas[y, x].Imagen;
                            break;
                        case 2:
                            c1.Image = piezas[y, x].Imagen;
                            break;
                        case 3:
                            d1.Image = piezas[y, x].Imagen;
                            break;
                        case 4:
                            e1.Image = piezas[y, x].Imagen;
                            break;
                        case 5:
                            f1.Image = piezas[y, x].Imagen;
                            break;
                        case 6:
                            g1.Image = piezas[y, x].Imagen;
                            break;
                        case 7:
                            h1.Image = piezas[y, x].Imagen;
                            break;
                    }
                    break;
            }
        }

        private void limpieza(int y, int x)
        {
            switch (y)
            {
                case 0:
                    switch (x)
                    {
                        case 0:
                            a8.Image = null;
                            break;
                        case 1:
                            b8.Image = null;
                            break;
                        case 2:
                            c8.Image = null;
                            break;
                        case 3:
                            d8.Image = null;
                            break;
                        case 4:
                            e8.Image = null;
                            break;
                        case 5:
                            f8.Image = null;
                            break;
                        case 6:
                            g8.Image = null;
                            break;
                        case 7:
                            h8.Image = null;
                            break;
                    }
                    break;
                case 1:
                    switch (x)
                    {
                        case 0:
                            a7.Image = null;
                            break;
                        case 1:
                            b7.Image = null;
                            break;
                        case 2:
                            c7.Image = null;
                            break;
                        case 3:
                            d7.Image = null;
                            break;
                        case 4:
                            e7.Image = null;
                            break;
                        case 5:
                            f7.Image = null;
                            break;
                        case 6:
                            g7.Image = null;
                            break;
                        case 7:
                            h7.Image = null;
                            break;
                    }
                    break;
                case 2:
                    switch (x)
                    {
                        case 0:
                            a6.Image = null;
                            break;
                        case 1:
                            b6.Image = null;
                            break;
                        case 2:
                            c6.Image = null;
                            break;
                        case 3:
                            d6.Image = null;
                            break;
                        case 4:
                            e6.Image = null;
                            break;
                        case 5:
                            f6.Image = null;
                            break;
                        case 6:
                            g6.Image = null;
                            break;
                        case 7:
                            h6.Image = null;
                            break;
                    }
                    break;
                case 3:
                    switch (x)
                    {
                        case 0:
                            a5.Image = null;
                            break;
                        case 1:
                            b5.Image = null;
                            break;
                        case 2:
                            c5.Image = null;
                            break;
                        case 3:
                            d5.Image = null;
                            break;
                        case 4:
                            e5.Image = null;
                            break;
                        case 5:
                            f5.Image = null;
                            break;
                        case 6:
                            g5.Image = null;
                            break;
                        case 7:
                            h5.Image = null;
                            break;
                    }
                    break;
                case 4:
                    switch (x)
                    {
                        case 0:
                            a4.Image = null;
                            break;
                        case 1:
                            b4.Image = null;
                            break;
                        case 2:
                            c4.Image = null;
                            break;
                        case 3:
                            d4.Image = null;
                            break;
                        case 4:
                            e4.Image = null;
                            break;
                        case 5:
                            f4.Image = null;
                            break;
                        case 6:
                            g4.Image = null;
                            break;
                        case 7:
                            h4.Image = null;
                            break;
                    }
                    break;
                case 5:
                    switch (x)
                    {
                        case 0:
                            a3.Image = null;
                            break;
                        case 1:
                            b3.Image = null;
                            break;
                        case 2:
                            c3.Image = null;
                            break;
                        case 3:
                            d3.Image = null;
                            break;
                        case 4:
                            e3.Image = null;
                            break;
                        case 5:
                            f3.Image = null;
                            break;
                        case 6:
                            g3.Image = null;
                            break;
                        case 7:
                            h3.Image = null;
                            break;
                    }
                    break;
                case 6:
                    switch (x)
                    {
                        case 0:
                            a2.Image = null;
                            break;
                        case 1:
                            b2.Image = null;
                            break;
                        case 2:
                            c2.Image = null;
                            break;
                        case 3:
                            d2.Image = null;
                            break;
                        case 4:
                            e2.Image = null;
                            break;
                        case 5:
                            f2.Image = null;
                            break;
                        case 6:
                            g2.Image = null;
                            break;
                        case 7:
                            h2.Image = null;
                            break;
                    }
                    break;
                case 7:
                    switch (x)
                    {
                        case 0:
                            a1.Image = null;
                            break;
                        case 1:
                            b1.Image = null;
                            break;
                        case 2:
                            c1.Image = null;
                            break;
                        case 3:
                            d1.Image = null;
                            break;
                        case 4:
                            e1.Image = null;
                            break;
                        case 5:
                            f1.Image = null;
                            break;
                        case 6:
                            g1.Image = null;
                            break;
                        case 7:
                            h1.Image = null;
                            break;
                    }
                    break;
            }
        }


        private void a7_Click(object sender, EventArgs e)
        {
            int x = 0, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void a3_Click(object sender, EventArgs e)
        {
            int x = 0, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void a8_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b8_Click(object sender, EventArgs e)
        {
            int x = 1, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c8_Click(object sender, EventArgs e)
        {
            int x = 2, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void newgamebutton_Click(object sender, EventArgs e)
        {
            crear_juego();
        }

        private void d8_Click(object sender, EventArgs e)
        {
            int x = 3, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e8_Click(object sender, EventArgs e)
        {
            int x = 4, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f8_Click(object sender, EventArgs e)
        {
            int x = 5, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g8_Click(object sender, EventArgs e)
        {
            int x = 6, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h8_Click(object sender, EventArgs e)
        {
            int x = 7, y = 0;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b7_Click(object sender, EventArgs e)
        {
            int x = 1, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c7_Click(object sender, EventArgs e)
        {
            int x = 2, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void d7_Click(object sender, EventArgs e)
        {
            int x = 3, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e7_Click(object sender, EventArgs e)
        {
            int x = 4, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f7_Click(object sender, EventArgs e)
        {
            int x = 5, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g7_Click(object sender, EventArgs e)
        {
            int x = 6, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h7_Click(object sender, EventArgs e)
        {
            int x = 7, y = 1;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void a6_Click(object sender, EventArgs e)
        {
            int x = 0, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b6_Click(object sender, EventArgs e)
        {
            int x = 1, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c6_Click(object sender, EventArgs e)
        {
            int x = 2, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void d6_Click(object sender, EventArgs e)
        {
            int x = 3, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e6_Click(object sender, EventArgs e)
        {
            int x = 4, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f6_Click(object sender, EventArgs e)
        {
            int x = 5, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g6_Click(object sender, EventArgs e)
        {
            int x = 6, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h6_Click(object sender, EventArgs e)
        {
            int x = 7, y = 2;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void a5_Click(object sender, EventArgs e)
        {
            int x = 0, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b5_Click(object sender, EventArgs e)
        {
            int x = 1, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c5_Click(object sender, EventArgs e)
        {
            int x = 2, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void d5_Click(object sender, EventArgs e)
        {
            int x = 3, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e5_Click(object sender, EventArgs e)
        {
            int x = 4, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f5_Click(object sender, EventArgs e)
        {
            int x = 5, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g5_Click(object sender, EventArgs e)
        {
            int x = 6, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h5_Click(object sender, EventArgs e)
        {
            int x = 7, y = 3;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void a4_Click(object sender, EventArgs e)
        {
            int x = 0, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b4_Click(object sender, EventArgs e)
        {
            int x = 1, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c4_Click(object sender, EventArgs e)
        {
            int x = 2, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void d4_Click(object sender, EventArgs e)
        {
            int x = 3, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e4_Click(object sender, EventArgs e)
        {
            int x = 4, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f4_Click(object sender, EventArgs e)
        {
            int x = 5, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g4_Click(object sender, EventArgs e)
        {
            int x = 6, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h4_Click(object sender, EventArgs e)
        {
            int x = 7, y = 4;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b3_Click(object sender, EventArgs e)
        {
            int x = 1, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c3_Click(object sender, EventArgs e)
        {
            int x = 2, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void d3_Click(object sender, EventArgs e)
        {
            int x = 3, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e3_Click(object sender, EventArgs e)
        {
            int x = 4, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f3_Click(object sender, EventArgs e)
        {
            int x = 5, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g3_Click(object sender, EventArgs e)
        {
            int x = 6, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h3_Click(object sender, EventArgs e)
        {
            int x = 7, y = 5;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b2_Click(object sender, EventArgs e)
        {
            int x = 1, y = 6;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c2_Click(object sender, EventArgs e)
        {
            int x = 2, y = 6;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void d2_Click(object sender, EventArgs e)
        {
            int x = 3, y = 6;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e2_Click(object sender, EventArgs e)
        {
            int x = 4, y = 6;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f2_Click(object sender, EventArgs e)
        {
            int x = 5, y = 6;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g2_Click(object sender, EventArgs e)
        {
            int x = 6, y = 6;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h2_Click(object sender, EventArgs e)
        {
            int x = 7, y = 6;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void a1_Click(object sender, EventArgs e)
        {
            int x = 0, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void b1_Click(object sender, EventArgs e)
        {
            int x = 1, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void c1_Click(object sender, EventArgs e)
        {
            int x = 2, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void d1_Click(object sender, EventArgs e)
        {
            int x = 3, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void e1_Click(object sender, EventArgs e)
        {
            int x = 4, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void f1_Click(object sender, EventArgs e)
        {
            int x = 5, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void g1_Click(object sender, EventArgs e)
        {
            int x = 6, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void h1_Click(object sender, EventArgs e)
        {
            int x = 7, y = 7;
            if (!seleccion)
            {

                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for (int z = 0; z < movimientos.Count(); z++)
                {
                    if (movimientos.ElementAt(z)[0] == y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }

        private void a2_Click(object sender, EventArgs e)
        {
            int x = 0, y = 6;
            if (!seleccion)
            {
                
                if (piezas[y, x] != null)
                {
                    movimientos = piezas[y, x].obtener_posiciones(y, x, piezas);
                }
                seleccion = true;
                seleccionado = piezas[y, x];
                xsel = x;
                ysel = y;
            }
            else
            {
                for(int z = 0; z < movimientos.Count(); z++)
                {
                    if(movimientos.ElementAt(z)[0]==y && movimientos.ElementAt(z)[1] == x)
                    {
                        seleccion = false;
                        piezas[y, x] = seleccionado;
                        piezas[ysel, xsel] = null;
                        pintar_mapa();
                    }
                }
            }
        }
    }
}
