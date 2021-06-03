using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Compartilhamento
{
    public partial class frm_inicial : Form
    {
        public frm_inicial()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Primeira mensagem");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Segunda mensagem");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terceira mensagem");
        }
    }
}
