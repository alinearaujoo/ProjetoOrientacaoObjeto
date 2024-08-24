using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoPOO
{
    public class Mercadorias //Criando uma classe usando o Encapsulamento (tipo de acesso a classe que permite acesso externo)
    {
        //Atributos ou Propriedades da Classe (variaveis da classe) Encapsulamento Público (permitir acesso externo)

        public string nome;
        public double preco, reajuste, total;
        public int quantidade;

        //Criando o Método da Classe com Acesso Externo (encapsulamento público)

        public void Atualiza_Preco(double porcentagem)
        {
           reajuste = preco + (preco * porcentagem /100);
        }

        public void Fechar_Pedido()
        {
            total = quantidade * preco;
        }
    }
}
