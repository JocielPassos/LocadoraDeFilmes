using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filmes;

namespace Locadora
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();
            
            cliente.Nome = TxtNome.Text;//set
            cliente.Cpf = TxtCpf.Text;//set
            cliente.Endereco = TxtEndereco.Text;//set
            cliente.Telefone = TxtTelefone.Text;//set
            cliente.Rg = TxtRg.Text;//set

            MessageBox.Show(cliente.Nome);//get
            MessageBox.Show(cliente.Cpf);//get
            MessageBox.Show(cliente.Rg);//get
            MessageBox.Show(cliente.Endereco);//get
            MessageBox.Show(cliente.Telefone);//get

            //new RevisaoConstrutores().Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
