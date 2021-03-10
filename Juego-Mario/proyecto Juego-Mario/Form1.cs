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
        int velocidaad;
        MarioPlayer1 Mario;
        MarioPlayer1 Bowser;
        public frmJuegoM()
        {
            InitializeComponent();
            velocidaad = 10;
        }

        private void frmJuegoM_Load(object sender, EventArgs e)
        {
            Mario = new MarioPlayer1();
            pctPlayer.Location = Mario.Pocition;
            pctPlayer.Size = Mario.Tamanio;
        }

        private void frmJuegoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            Mario.Mover(e.KeyChar);
        }
    }
}
