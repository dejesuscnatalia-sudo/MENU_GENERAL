using System;

namespace MENU_GENERAL.CLASES
{
    /// <summary>
    /// Representa un respaldo de base de datos (ruta, fecha y tamaño).
    /// </summary>
    internal class clInfoRespaldo
    {
        public string Ruta { get; private set; }
        public DateTime Fecha { get; private set; }
        public double TamanoMB { get; private set; }

        public clInfoRespaldo(string ruta, DateTime fecha, double tamanoMB)
        {
            this.Ruta = ruta;
            this.Fecha = fecha;
            this.TamanoMB = tamanoMB;
        }

        public override string ToString()
        {
            return $"{Fecha:dd/MM/yyyy HH:mm:ss}  ({TamanoMB:0.00} MB)  {Ruta}";
        }
    }
}
