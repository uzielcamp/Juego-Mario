using System.Drawing;
using System.Windows.Forms;
namespace proyecto_Juego_Mario
{
   public class MarioPlayer1
   {
        #region atributos
        private Point pocition;
        private Size tamanio;
        private int velocidad;
        private int vida;
        private string nombre;
        private string fileName;
        private Image sprite;
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
        public Image Sprite
        {
            get { return this.sprite; }
            set { this.sprite = value; }
        }
        #endregion
        #region metodos
        #region constructores
        //constructor por defecto 
        public MarioPlayer1 ()
        {
            this.Nombre = "Mario";
            this.Vida = 100;
            this.Velocidad = 10;
            this.Pocition = new Point(135, 3);
            this.Tamanio = new Size(100,50);
            this.fileName = @"C://LVAPV08//Mario Bros.png";
            this.Sprite = Bitmap.FromFile(this.FileName);
        }
        
        public MarioPlayer1(string nombre, int vida, int velocidad, Point posicion, Size tamanio)
        {
            this.nombre = nombre;
            this.vida = vida;
            this.pocition = posicion;
            this.tamanio = tamanio;
        }
        #endregion
        #region metodos genericos
        public override string ToString()
        {
            return $"nombre de personajes:{this.Nombre}-\nvida{this.Vida}-\nvelocidd{this.Velocidad}-\npocición{this.Pocition}-\ntamaño{this.Tamanio}";
        }
        public void AgregarVelocidad(int velocidad)
        {
            if(velocidad >0 && this.Velocidad + velocidad<=10)
            {
                this.Velocidad += velocidad;
            }
            else if(velocidad <0 && this.Velocidad-velocidad >0)
            {
                this.Velocidad -= velocidad;
            }
        }
        public void Mover (char tecla)
        {
            if(tecla == 'a' || tecla == 'A')
            if(Pocition.X > 0)
            {
                this.Pocition = new Point(this.Pocition.X - velocidad, this.Pocition.Y);
            }
            if(tecla == 'd' || tecla == 'D')
            if(Pocition.X < 723)
            {
                this.Pocition = new Point(this.Pocition.X + velocidad, this.Pocition.Y);
            }
            if(tecla =='w' || tecla == 'W')
            if (Pocition.Y > 0)
            {
                this.Pocition = new Point(this.Pocition.X, this.Pocition.Y - velocidad);
            }
            if (tecla == 's' || tecla== 'S')
            if (Pocition.Y < 477)
            {
                this.Pocition = new Point(this.Pocition.X, this.Pocition.Y + velocidad);
            }

        }
        public Image GetFrame (int index)
        {
            if(!(index >=0 && index < 17))
            {
                index = 0;
            }
            Image frame = new Bitmap(tamanio.Width, tamanio.Height);
            using(Graphics g=Graphics.FromImage(frame))
            {
                g.DrawImage(Sprite,
                    new Rectangle(0, 0, tamanio.Width, tamanio.Height),
                    new Rectangle(index*tamanio.Width,0,tamanio.Width,tamanio.Height),
                    GraphicsUnit.Pixel);
            }
            return frame;
        }
        #endregion
        #endregion
    }
}
