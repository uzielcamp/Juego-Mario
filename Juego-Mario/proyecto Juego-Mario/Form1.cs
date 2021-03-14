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
                MessageBox.Show("Muerete prro");            
            }
        }

        private void pctPlayer_Click(object sender, EventArgs e)
        {

        }

        private void pctVillano_Click(object sender, EventArgs e)
        {

        }
       
    }
}
