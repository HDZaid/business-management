using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public static class BotonRedondeadoHelper
{
    public static void AplicarRedondeo(Button boton, int radio)
    {
        // Crear el borde redondeado
        GraphicsPath path = new GraphicsPath();
        path.AddArc(new Rectangle(0, 0, radio, radio), 180, 90); // Esquina superior izquierda
        path.AddArc(new Rectangle(boton.Width - radio, 0, radio, radio), 270, 90); // Esquina superior derecha
        path.AddArc(new Rectangle(boton.Width - radio, boton.Height - radio, radio, radio), 0, 90); // Esquina inferior derecha
        path.AddArc(new Rectangle(0, boton.Height - radio, radio, radio), 90, 90); // Esquina inferior izquierda
        path.CloseFigure();

        // Aplicar la región redondeada al botón
        boton.Region = new Region(path);
    }
}
