using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoPOO
{
    public partial class Frm_Mercadorias : Form
    {
        public Frm_Mercadorias()
        {
            InitializeComponent();
        }

        //Criando os objetos da classe em instâncias

        Mercadorias produto1 = new Mercadorias();
        Mercadorias produto2 = new Mercadorias();
        Mercadorias produto3 = new Mercadorias();

        private void Btn_Reajuste_Click(object sender, EventArgs e)
        {
            if ((Txt_Produto1.Text != "" && Txt_Valor1.Text != "" && Txt_Quantidade1.Text != "") && (Txt_Produto2.Text != "" && Txt_Valor2.Text != "" && Txt_Quantidade2.Text != "") && (Txt_Produto3.Text != "" && Txt_Valor3.Text != "" && Txt_Quantidade3.Text != "" && Txt_Reajuste.Text !=""))
            {


                //Receber os nomes dos produtos e os seus valores digitados e armazenando nas variáveis da classe

                produto1.nome = Txt_Produto1.Text; //Atribuindo o campo digitado dentro da variável da classe
                produto1.preco = double.Parse(Txt_Valor1.Text); //Atribuindo o valor digitado e convertido para double para dentro da variável
                produto1.reajuste = double.Parse(Txt_Reajuste.Text); //Atribuindo o valor informado pelo usuário

                produto2.nome = Txt_Produto2.Text;
                produto2.preco = double.Parse(Txt_Valor2.Text);
                produto2.reajuste = double.Parse(Txt_Reajuste.Text);

                produto3.nome = Txt_Produto3.Text;
                produto3.preco = double.Parse(Txt_Valor3.Text);
                produto3.preco = double.Parse(Txt_Reajuste.Text);

                //Mostrando os produtos e vallres que estão na memória

                Lbl_Resultado.Text = "Produto 1: " + produto1.nome + "\n" + "Preço Inicial: " + produto1.preco.ToString("c2") + "\n\n";
                //produto1.Atualiza_Preco (10); //Usando o Método para reajustar o valor em 10%
                produto1.Atualiza_Preco(produto1.reajuste); //Usando o Método para reajustar o valor
                Lbl_Resultado.Text += "Novo Preço: " + produto1.reajuste.ToString("c2") + "\n";

                Lbl_Resultado.Text += "Produto 2: " + produto2.nome + "\n" + "Preço Inicial: " + produto2.preco.ToString("c2") + "\n\n";
                //produto2.Atualiza_Preco (10); //Usando o Método para reajustar o valor em 10%
                produto2.Atualiza_Preco(produto2.reajuste); //Usando o Método para reajustar o valor
                Lbl_Resultado.Text += "Novo Preço: " + produto2.reajuste.ToString("c2") + "\n";

                Lbl_Resultado.Text += "Produto 3: " + produto3.nome + "\n" + "Preço Inicial: " + produto3.preco.ToString("c2") + "\n\n";
                //produto3.Atualiza_Preco(10); //Usando o Método para reajustar o valor em 10%
                produto3.Atualiza_Preco(produto3.reajuste); //Usando o Método para reajustar o valor
                Lbl_Resultado.Text += "Novo Preço: " + produto3.reajuste.ToString("c2") + "\n";

            }
            else
            {
                MessageBox.Show("Preencha Todas as Informações!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Txt_Produto1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_FecharPedido_Click(object sender, EventArgs e)
        {
            if ((Txt_Produto1.Text != "" && Txt_Valor1.Text != "" && Txt_Quantidade1.Text != "") && (Txt_Produto2.Text != "" && Txt_Valor2.Text != "" && Txt_Quantidade2.Text != "") && (Txt_Produto3.Text != "" && Txt_Valor3.Text != "" && Txt_Quantidade3.Text != ""))
            {


                produto1.quantidade = int.Parse(Txt_Quantidade1.Text); //A variável da classe recebe a quantidade digitada
                produto2.quantidade = int.Parse(Txt_Quantidade2.Text);
                produto3.quantidade = int.Parse(Txt_Quantidade3.Text);

                produto1.preco = double.Parse(Txt_Valor1.Text); //A variável da classe recebe o valor digitado
                produto2.preco = double.Parse(Txt_Valor2.Text);
                produto3.preco = double.Parse(Txt_Valor3.Text);

                produto1.Fechar_Pedido(); //Usando o Método da Classe para trazer o Total de cada produto
                produto2.Fechar_Pedido();
                produto3.Fechar_Pedido();

                Txt_Total1.Text = produto1.total.ToString("c2"); //Apresentando o resultado convertido
                Txt_Total2.Text = produto2.total.ToString("c2");
                Txt_Total3.Text = produto3.total.ToString("c2");

                Txt_TotalGeral.Text = (produto1.total + produto2.total + produto3.total).ToString("c2");
            }
            else
            {
                MessageBox.Show ("Preencha Todas as Informações!!!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_X_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Controls.Clear();
            InitializeComponent();
            Txt_Produto1.Focus();
        }

        private void Btn_Sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Txt_Produto1.Focus();
            }
        }
    }
}
