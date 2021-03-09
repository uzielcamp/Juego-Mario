using System.Drawing;
using System.Windows.Forms;
namespace proyecto_Juego_Mario
{
    class MarioPlayer1
    {
        #region atributos
        private Point pocition;
        private Size  tamanio;
        private int velocidad;
        private int vida;
        private string nombre;
        private string fileName;
        private Image Sprite;
        #endregion
        #region Propiedades
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
    }
}
