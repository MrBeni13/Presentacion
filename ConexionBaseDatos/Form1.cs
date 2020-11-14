using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexionBaseDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnlog_Click(object sender, EventArgs e)
        {
            Conexion cn = new Conexion();
            cn.conectar();

            if (cn.login(txtuser.Text, txtpass.Text))
            {
                home home = new home();
                home.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario Incorrecto");
            }
        }
    }
}
