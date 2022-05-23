using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoDeCurvas
{
    class Arista
    {
        Vertice vOrigen, vDestino;
        PointF PuntoDestino;
        PointF PB1,PB2;
        public float[] aAmplitud = {0.0f,0.0f};
        float aGrosor;
        float TamRectaPerpendicular = 0;
        PointF PM;         
        Color aColor;
        public PointF vdr1, vdr2;
        Pen Pluma;
        AdjustableArrowCap Flecha;

        public Arista(Vertice vO,Vertice vD) {
            vOrigen = vO;
            vDestino = vD;
            aAmplitud[0] = 0.0f;
            aAmplitud[1] = 0.0f;
            aGrosor = 5;
            aColor = Color.Black;
            Pluma = new Pen(aColor);
            Flecha = new AdjustableArrowCap(aGrosor, aGrosor, true);
            Pluma.CustomEndCap = Flecha;
            PM = new PointF((vOrigen._vPosicion.X + vDestino._vPosicion.X) / 2, (vOrigen._vPosicion.Y + vDestino._vPosicion.Y) / 2);
            PB1 = new PointF((vOrigen._vPosicion.X + PM.X) / 2, (vOrigen._vPosicion.Y + PM.Y) / 2);
            PB2 = new PointF((vDestino._vPosicion.X + PM.X) / 2, (vDestino._vPosicion.Y + PM.Y) / 2);
        }

        public float calculaTamRecta(PointF P1,PointF P2)
        {
            return  (float)Math.Sqrt((Math.Pow((P2.X - P1.X), 2) + Math.Pow((P2.Y - P1.Y), 2)));
        }
        public bool TocaP(float x, float y) {
            double resultado1 = Math.Pow((x - PB1.X), aGrosor / (aGrosor / 2)) + Math.Pow((y - PB1.Y), aGrosor / (aGrosor / 2));
            if (Math.Pow(aGrosor, 2) >= resultado1)
                return true;
            resultado1 = Math.Pow((x - PB2.X), aGrosor / (aGrosor / 2)) + Math.Pow((y - PB2.Y), aGrosor / (aGrosor / 2));
            if (Math.Pow(aGrosor, 2) >= resultado1)
                return true;
            return false;
        }
        public bool TocaP(float x, float y,PointF PB,float pGrosor)
        {
            double resultado = Math.Pow((x - PB.X), pGrosor / (pGrosor / 2)) + Math.Pow((y - PB.Y), pGrosor / (aGrosor / 2));
            if (Math.Pow(pGrosor, 2) >= resultado)
                return true;
            return false;
        }
        public int damePunto(float x, float y)
        {
            double resultado1 = Math.Pow((x - PB1.X), aGrosor / (aGrosor / 2)) + Math.Pow((y - PB1.Y), aGrosor / (aGrosor / 2));
            if (Math.Pow(aGrosor, 2) >= resultado1)
                return 1;
            resultado1 = Math.Pow((x - PB2.X), aGrosor / (aGrosor / 2)) + Math.Pow((y - PB2.Y), aGrosor / (aGrosor / 2));
            if (Math.Pow(aGrosor, 2) >= resultado1)
                return 2;
            return 0;
        }
        public void cambiaPosicion(float x1, float y1)
        {
            vdr1.X = (x1 - vDestino._vPosicion.X);
            vdr1.Y = y1 - vDestino._vPosicion.Y;

            vdr2.X = (vOrigen._vPosicion.X - vDestino._vPosicion.X);
            vdr2.Y = vOrigen._vPosicion.Y - vDestino._vPosicion.Y;
            aAmplitud[0] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);

            vdr1.X = (x1 - vOrigen._vPosicion.X);
            vdr1.Y = y1 - vOrigen._vPosicion.Y;

            vdr2.X = (vDestino._vPosicion.X - vOrigen._vPosicion.X);
            vdr2.Y = vDestino._vPosicion.Y - vOrigen._vPosicion.Y;
            aAmplitud[1] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);
        }
        public void cambiaPosicion(float x1,float y1,int num) {
            if (num == 1)
            {
                if (aAmplitud[0] >= aAmplitud[1])
                {
                    vdr1.X = (x1 - vDestino._vPosicion.X);
                    vdr1.Y = y1 - vDestino._vPosicion.Y;

                    vdr2.X = (vOrigen._vPosicion.X - vDestino._vPosicion.X);
                    vdr2.Y = vOrigen._vPosicion.Y - vDestino._vPosicion.Y;
                    aAmplitud[0] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);

                    vdr1.X = (x1 - vOrigen._vPosicion.X);
                    vdr1.Y = y1 - vOrigen._vPosicion.Y;

                    vdr2.X = (vDestino._vPosicion.X - vOrigen._vPosicion.X);
                    vdr2.Y = vDestino._vPosicion.Y - vOrigen._vPosicion.Y;
                    aAmplitud[1] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);
                }
                else {
                    vdr1.X = (x1 - vDestino._vPosicion.X);
                    vdr1.Y = y1 - vDestino._vPosicion.Y;

                    vdr2.X = (vOrigen._vPosicion.X - vDestino._vPosicion.X);
                    vdr2.Y = vOrigen._vPosicion.Y - vDestino._vPosicion.Y;
                    aAmplitud[0] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);
                }
            }
            else
                if (num == 2)
                {
                    if (aAmplitud[1] >= aAmplitud[0])
                    {
                        vdr1.X = (x1 - vDestino._vPosicion.X);
                        vdr1.Y = y1 - vDestino._vPosicion.Y;

                        vdr2.X = (vOrigen._vPosicion.X - vDestino._vPosicion.X);
                        vdr2.Y = vOrigen._vPosicion.Y - vDestino._vPosicion.Y;
                        aAmplitud[0] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);

                        vdr1.X = (x1 - vOrigen._vPosicion.X);
                        vdr1.Y = y1 - vOrigen._vPosicion.Y;

                        vdr2.X = (vDestino._vPosicion.X - vOrigen._vPosicion.X);
                        vdr2.Y = vDestino._vPosicion.Y - vOrigen._vPosicion.Y;
                        aAmplitud[1] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);
                    }
                    else {
                        vdr1.X = (x1 - vOrigen._vPosicion.X);
                        vdr1.Y = y1 - vOrigen._vPosicion.Y;

                        vdr2.X = (vDestino._vPosicion.X - vOrigen._vPosicion.X);
                        vdr2.Y = vDestino._vPosicion.Y - vOrigen._vPosicion.Y;
                        aAmplitud[1] = -(float)(Math.Atan2(vdr2.Y, vdr2.X) + Math.PI) + (float)(Math.Atan2(vdr1.Y, vdr1.X) + Math.PI);
                    }
            }
        }

        public PointF puntoCurvaB1(PointF Origen, PointF Destino, float tamRecta,float angulo)
        {
            PointF punto = new PointF();
            double angle = Math.Atan2(Destino.Y - Origen.Y, Destino.X - Origen.X) + Math.PI;
            punto.X = (float)(Destino.X + tamRecta * (Math.Cos(angle + angulo)));
            punto.Y = (float)(Destino.Y + tamRecta * (Math.Sin(angle + angulo)));
            
            return punto;
        }
        public PointF puntoCurvaB2(PointF Origen, PointF Destino, float tamRecta, float angulo)
        {
            PointF punto = new PointF();
            double angle = Math.Atan2(Destino.Y - Origen.Y, Destino.X - Origen.X) + Math.PI;
            punto.X = (float)(Destino.X + tamRecta * (Math.Cos(angle - angulo)));
            punto.Y = (float)(Destino.Y + tamRecta * (Math.Sin(angle - angulo)));

            return punto;
        }
        public void dibujaArista(Graphics g) {
            PM = new PointF((vOrigen._vPosicion.X + vDestino._vPosicion.X) / 2, (vOrigen._vPosicion.Y + vDestino._vPosicion.Y) / 2);

            double teta2 = Math.Atan2(vOrigen._vPosicion.Y - vDestino._vPosicion.Y, vOrigen._vPosicion.X - vDestino._vPosicion.X);
            PuntoDestino = new PointF(vDestino._vPosicion.X + (float)((Math.Cos(teta2)) * (vDestino._vRadio)), vDestino._vPosicion.Y + (float)((Math.Sin(teta2)) * (vDestino._vRadio)));

            TamRectaPerpendicular = calculaTamRecta(PM, vOrigen._vPosicion);

            PB1 = puntoCurvaB1(vOrigen._vPosicion, vDestino._vPosicion, TamRectaPerpendicular*0.7f, aAmplitud[0]);
            g.DrawLine(new Pen(Color.Red), vDestino._vPosicion, PB1);
            g.FillEllipse(new SolidBrush(aColor), PB1.X - aGrosor, PB1.Y - aGrosor, aGrosor * 2, aGrosor * 2);

            PB2 = puntoCurvaB1(vDestino._vPosicion, vOrigen._vPosicion, TamRectaPerpendicular * 0.7f, aAmplitud[1]);
            g.FillEllipse(new SolidBrush(aColor), PB2.X - aGrosor, PB2.Y - aGrosor, aGrosor * 2, aGrosor * 2);
            g.DrawLine(new Pen(Color.Red), vOrigen._vPosicion, PB2);

            g.DrawLine(new Pen(Color.Red), PB1, PB2);

            PointF[] curvePoints1 = { vOrigen._vPosicion, PB2,PB1, PuntoDestino };
            g.DrawCurve(Pluma, curvePoints1);         
        }
    }
}
