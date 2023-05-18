using Filmes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Genero;


namespace Locadora
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            GeneroFilmes generofilmes = new GeneroFilmes();

            
            generofilmes.Nome = TxtNomeGenero.Text;//set

            MessageBox.Show(generofilmes.Nome);//get
            
       

            //new RevisaoConstrutores().Show();
        }
    }
}
