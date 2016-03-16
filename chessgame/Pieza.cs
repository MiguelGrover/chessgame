using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chessgame
{
    class Pieza
    {
        private String pieza;
        private Bitmap imagen;
        private String tipo;
        private String color;
        private int valor;

        public Bitmap Imagen
        {
            get
            {
                return imagen;
            }

            set
            {
                imagen = value;
            }
        }

        public void cargar_imagen()
        {
            System.Reflection.Assembly myAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            Stream myStream = myAssembly.GetManifestResourceStream(pieza);
            Imagen = new Bitmap(myStream);
        }
        public Pieza(String pieza, String color)
        {
            this.tipo = pieza;
            this.color = color;
            this.pieza = ("chessgame.pieces." + color + pieza + ".png");
            cargar_imagen();
        }
        public List<int[]> obtener_posiciones(int y, int x, Pieza[,] escenario)
        {
            List<int[]> posiciones = new List<int[]>();
            int[] pos = new int[2];
            if(tipo.Equals("p") && color.Equals("w"))
            {
                if (y - 1 > 0)
                {
                    if (y == 6)
                    {
                        pos = new int[] { y - 2, x };
                        posiciones.Add(pos);
                    }
                    pos = new int[] { y - 1, x };
                    posiciones.Add(pos);
                    if (x > 0)
                    {
                        if (escenario[y - 1, x - 1] != null && x > 0)
                        {
                            if (!escenario[y - 1, x - 1].color.Equals(this.color))
                            {
                                pos = new int[] { y - 1, x - 1 };
                                posiciones.Add(pos);
                            }
                        }
                    }
                    if (x < 7)
                    {

                        if (escenario[y - 1, x + 1] != null && x < 7)
                        {
                            if (!escenario[y - 1, x - 1].color.Equals(this.color))
                            {
                                pos = new int[] { y - 1, x + 1 };
                                posiciones.Add(pos);
                            }
                        }
                    }
                }
            }
            if (tipo.Equals("p") && color.Equals("b"))
            {
                if (y + 1 < 7)
                {
                    if (y == 1)
                    {
                        pos = new int[] { y + 2, x };
                        posiciones.Add(pos);
                    }
                    pos = new int[] { y + 1, x };
                    posiciones.Add(pos);
                    if (x > 0)
                    {
                        if (escenario[y + 1, x - 1] != null && x > 0)
                        {
                            if (!escenario[y + 1, x - 1].color.Equals(this.color))
                            {
                                pos = new int[] { y + 1, x - 1 };
                                posiciones.Add(pos);
                            }
                        }
                    }
                    if (x < 7)
                    {

                        if (escenario[y + 1, x + 1] != null && x < 7)
                        {
                            if (!escenario[y + 1, x + 1].color.Equals(this.color))
                            {
                                pos = new int[] { y + 1, x + 1 };
                                posiciones.Add(pos);
                            }
                        }
                    }
                }
            }
            return posiciones;
        }
    }
}
