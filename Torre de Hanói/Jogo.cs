using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Torre_de_Hanói
{
    public partial class Jogo : Form
    {
        public Jogo()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var resposta = MessageBox.Show("Os dados atuais serão perdidos! Desejas abandonar a partida mesmo assim", "Alerta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(resposta.ToString() == "Yes")
            {
                Close();
            }
        }
    }
}
