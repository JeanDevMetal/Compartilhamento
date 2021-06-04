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
        int i = 0;
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

        private void frm_inicial_Load(object sender, EventArgs e)
        {
            this.lbl_informacao_cadastro.Visible = false;
            this.txt_informacao_nome_cadastro.Visible = false;
            this.txt_informacao_cidade_cadastro.Visible = false;
            this.txt_informacao_idade_cadastro.Visible = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(txt_nome.Text == "")
            {
                MessageBox.Show("Campo nome esta vazio, por favor preencha-o", "Informação");
                txt_nome.Focus();
            }else
            {
                for(i = 0;i < 10;i++)
                {
                    MessageBox.Show("O nome digitado foi:"+txt_nome.Text);
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.lbl_informacao_cadastro.Visible = true;
            this.lbl_informacao_cadastro.Text = "===== CADASTRO REALIZADO COM SUCESSO =====";
            
            this.txt_informacao_nome_cadastro.Visible = true;
            this.txt_informacao_nome_cadastro.Text = txt_nome_formulario.Text;

            this.txt_informacao_cidade_cadastro.Visible = true;
            this.txt_informacao_cidade_cadastro.Text = txt_cidade_formulario.Text;

            this.txt_informacao_idade_cadastro.Visible = true;
            this.txt_informacao_idade_cadastro.Text = txt_idade_formulario.Text;
        }
    }
}