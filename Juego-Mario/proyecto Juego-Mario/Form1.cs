using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyecto_Juego_Mario
{
    public partial class frmJuegoM : Form
    {
        int velocidad;
        MarioPlayer1 Mario;

        public frmJuegoM()
        {
            InitializeComponent();
            velocidad = 10;
        }

        private void frmJuegoM_Load(object sender, EventArgs e)
        {
            Mario = new MarioPlayer1();
            pctPlayer.Location = Mario.Pocition;
            pctPlayer.Size = Mario.Tamanio;
            //pctPlayer.Image = Mario.Sprite;
        }

        private void frmJuegoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mario.Mover(e.KeyChar);
            pctPlayer.Location = Mario.Pocition;
              if(pctPlayer.Bounds.IntersectsWith(pctVillano.Bounds))
              {
                MessageBox.Show("Feel the power of the dark side");            
              }
              if (pctPlayer.Bounds.IntersectsWith(pctBloque1.Bounds)) 
              {
                MessageBox.Show("-5");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloque2.Bounds))
              {
                MessageBox.Show("-5");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloque3.Bounds))
              {
                MessageBox.Show("-5");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloque4.Bounds))
              {
                MessageBox.Show("-5");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloque5.Bounds))
              {
                MessageBox.Show("-5");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloque6.Bounds))
              {
                MessageBox.Show("-5");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloque7.Bounds))
              {
                MessageBox.Show("-5");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloqueOro.Bounds))
              {
                MessageBox.Show("-10");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloqueOro2.Bounds))
              {
                MessageBox.Show("-10");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloqueOro4.Bounds))
              {
                MessageBox.Show("-10");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloqueOro5.Bounds))
              {
                MessageBox.Show("-10");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctBloqueOro6.Bounds))
              {
                MessageBox.Show("-10");
              }
              if(pctPlayer.Bounds.IntersectsWith(pctEspecial.Bounds))
              {
                MessageBox.Show("+50");
              }
              //if(pctPlayer.Bounds.IntersectsWith(pctEnemigoestatico.Bounds))
              {
                //MessageBox.Show("PEW,PEW,PEW");
              }
        }
    }
}
