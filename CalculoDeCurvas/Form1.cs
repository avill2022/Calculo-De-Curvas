using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoDeCurvas
{
    public partial class Form1 : Form
    {
        String sherramientas;
        List<Vertice> Grafo;
        Graphics g;
        Bitmap bmp;
        Graphics pagina;

        Vertice verticeActivo = null;
        Arista aristaActiva_ = null;
        PointF aristaActiva;
        int puntoCurva = 0;

        public Form1()
        {
            InitializeComponent();
            Grafo = new List<Vertice>();
            g = CreateGraphics();
            bmp = new Bitmap(ClientSize.Width, ClientSize.Height);
            pagina = Graphics.FromImage(bmp);
            Vertice v1, v2;
            v1 = new Vertice(100, 100, "a",10);
            v2 = new Vertice(200, 100, "b", 10);
            v1.agrega_Arista(new Arista(v1,v2));
            Grafo.Add(v1);
            Grafo.Add(v2);
        }

        private void barra_herramientas_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name) {
                case "Agrega_Vertice":
                    sherramientas = "Agrega_Vertice";
                    break;
                case "Elimina_Vertice":
                    sherramientas = "Elimina_Vertice";
                    break;
                case "Mueve_Vertice":
                    sherramientas = "Mueve_Vertice";
                    break;
                case "Agrega_Arista":
                    sherramientas = "Agrega_Arista";
                    break;
                case "Elimina_Arista":
                    sherramientas = "Elimina_Arista";
                    break;
                case "Mueve_Arista":
                    sherramientas = "Mueve_Arista";
                    break;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            switch (sherramientas)
            {
                case "Agrega_Vertice":
                    Grafo.Add(new Vertice(e.X, e.Y,Grafo.Count.ToString(), 15));
                    break;
                case "Elimina_Vertice":
                    foreach (Vertice v in Grafo)
                    {
                        if (v.tocaVertice(e.X, e.Y)) {
                            Grafo.Remove(v);
                            break;
                        }
                    }
                    break;
                case "Mueve_Vertice":
                    foreach (Vertice v in Grafo)
                    {
                        if (v.tocaVertice(e.X, e.Y))
                        {
                            verticeActivo = v;
                            break;
                        }
                    }
                    break;
                case "Agrega_Arista":
                    foreach (Vertice v in Grafo)
                    {
                        if (v.tocaVertice(e.X, e.Y))
                        {
                            verticeActivo = v;
                            aristaActiva = new PointF(e.X, e.Y);
                            break;
                        }
                    }
                    break;
                case "Elimina_Arista":

                    break;
                case "Mueve_Arista":
                    foreach (Vertice v in Grafo)
                    {
                        foreach (Arista a in v._listaAristas)
                        {
                            int num = a.damePunto(e.X, e.Y);
                            if (num!=0) {
                                aristaActiva_ = a;
                                puntoCurva = num;
                                break;
                            }
                        }
                    }
                    break;
            }
            this.Form1_Paint(this, null);
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                switch (sherramientas)
                {
                    case "Agrega_Vertice":

                        break;
                    case "Elimina_Vertice":

                        break;
                    case "Mueve_Vertice":
                        if(verticeActivo != null)
                        {
                            verticeActivo._vPosicion = e.Location;
                        }
                        break;
                    case "Agrega_Arista":
                        aristaActiva =  new PointF(e.X, e.Y);
                        break;
                    case "Elimina_Arista":

                        break;
                    case "Mueve_Arista":
                        if (aristaActiva_ != null)
                        {
                            aristaActiva_.cambiaPosicion(e.X, e.Y, puntoCurva);
                        }
                        break;
                }
            }
            this.Form1_Paint(this, null);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (sherramientas)
            {
                case "Agrega_Vertice":

                    break;
                case "Elimina_Vertice":

                    break;
                case "Mueve_Vertice":

                    break;
                case "Agrega_Arista":
                    foreach (Vertice v in Grafo)
                    {
                        if (v.tocaVertice(e.X, e.Y))
                        {
                            if (verticeActivo != null)
                            {
                                verticeActivo._listaAristas.Add(new Arista(verticeActivo,v));
                                break;
                            }
                        }
                    }
                    break;
                case "Elimina_Arista":

                    break;
                case "Mueve_Arista":

                    break;
            }
            aristaActiva_ = null;
            verticeActivo = null;
            this.Form1_Paint(this, null);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            pagina.SmoothingMode = SmoothingMode.AntiAlias;
            pagina.Clear(this.BackColor);
            /*Area de dibujo*/
            foreach (Vertice v in Grafo)
            {
                v.dibujaVertice(pagina);
            }
            if(sherramientas== "Agrega_Arista" && verticeActivo!=null)
                pagina.DrawLine(new Pen(Color.Black), verticeActivo._vPosicion, aristaActiva);
            /*--------------*/
            g.DrawImage(bmp, 0, 0);
        }
    }
}
