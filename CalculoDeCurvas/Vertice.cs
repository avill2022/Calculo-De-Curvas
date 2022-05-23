using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CalculoDeCurvas
{
    class Vertice
    {
        List<Arista> listaAristas;
        public List<Arista> _listaAristas { get { return listaAristas; } set { listaAristas = value; } }
        PointF vPosicion;
        public PointF _vPosicion { get { return vPosicion; } set { vPosicion = value; } }
        String vNombre;
        public String _vNombre { get { return vNombre; } set { vNombre = value; } }
        Color vColor;
        public Color _vColor { get { return vColor; } set { vColor = value; } }
        float vRadio;
        public float _vRadio { get { return vRadio; } set { vRadio = value; } }

        #region Constructores Vertice
        public Vertice(float x,float y,String _vNombre) {
            listaAristas = new List<Arista>();
            vPosicion = new PointF(x,y);
            vNombre = _vNombre;
            vColor = Color.Yellow;
            vRadio = 5;
        }
        public Vertice(float x, float y, String _vNombre, Color _vColor)
        {
            listaAristas = new List<Arista>();
            vPosicion = new PointF(x, y);
            vNombre = _vNombre;
            vColor = _vColor;
            vRadio = 5;
        }
        public Vertice(float x, float y, String _vNombre,float _vRadio)
        {
            listaAristas = new List<Arista>();
            vPosicion = new PointF(x, y);
            vNombre = _vNombre;
            vColor = Color.Yellow;
            vRadio = _vRadio;
        }
        public Vertice(float x, float y, String _vNombre, Color _vColor, float _vRadio)
        {
            listaAristas = new List<Arista>();
            vPosicion = new PointF(x, y);
            vNombre = _vNombre;
            vColor = _vColor;
            vRadio = _vRadio;
        }
        #endregion
        public void agrega_Arista(Arista _Arista) {
            listaAristas.Add(_Arista);
        }
        public bool tocaVertice(float x,float y) {
            double resultado = Math.Pow((x - vPosicion.X), vRadio / (vRadio / 2)) + Math.Pow((y - vPosicion.Y), vRadio / (vRadio / 2));
            if (Math.Pow(vRadio, 2) >= resultado)
                return true;
            return false;
        }
        public void dibujaVertice(Graphics g) {
            foreach (Arista a in listaAristas)
            {
                a.dibujaArista(g);
            }
            g.FillEllipse(new SolidBrush(vColor), vPosicion.X - vRadio, vPosicion.Y - vRadio, vRadio * 2, vRadio * 2);
            g.DrawEllipse(Pens.Black, vPosicion.X - vRadio, vPosicion.Y - vRadio, vRadio * 2, vRadio * 2);
            g.DrawString(vNombre, new Font("Arial", vRadio), Brushes.Red, vPosicion.X - (vRadio - (vRadio/3)), vPosicion.Y - (vRadio-(vRadio/3)));
        }
    }
}
