using System;
using System.Drawing;
using System.Windows.Forms;
namespace proyecto_Juego_Mario
{
    public class Browser
    {
        #region atributos 
        private Point pocition;
        private Size tamanio;
        private int velocidad;
        private int vida;
        private string nombre;
        private string fileName;
        private Image Sprite;
        #endregion
        #region propiedades
        public int Vida
        {
            get { return this.vida; }
            set { this.vida = (0 <= value && value <= 100) ? value : this.vida; }
        }
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string FileName
        {
            get { return this.fileName; }
            set { this.fileName = value; }
        }
        public int Velocidad
        {
            get { return this.velocidad; }
            set { this.velocidad = (0 < value && value <= 10) ? value : this.velocidad; }
        }
        public Size Tamanio
        {
            get { return this.tamanio; }
            set { this.tamanio = value; }
        }
        public Point Pocition
        {
            get { return this.pocition; }
            set { this.pocition = value; }
        }
        #endregion
        #region metodos
        #region constructores 
        //contructor por defecto
        public Browser ()
        {
            this.Nombre = "Browser";
            this.Vida = 100;
            this.Velocidad = 10;
            this.Pocition = new Point(670, 21);
            this.Tamanio = new Size(19,43);
            this.fileName = "@C://Users//Miguel Herrera Sanch//Desktop//Browser.png";
            this.Sprite = Bitmap.FromFile(this.FileName);
        }
        public Browser(string nombre, int vida, int velocidad, Point posicion, Size tamanio)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.pocition = posicion;
            this.tamanio = tamanio;
        }
        #endregion
        #region metodos generales
        public override string ToString()
        {
            return $"nombre de personaje:{this.Nombre}-/nvida{this.Vida}-/nvelocidad{this.Velocidad}-/npocicion{this.Pocition}-7ntamanio{this.Tamanio}";
        }
        #endregion
        #endregion
    }


}
