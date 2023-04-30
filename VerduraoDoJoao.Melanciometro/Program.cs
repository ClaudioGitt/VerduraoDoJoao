using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

//variaveis a se criar:
//Placa do caminhao
//Dias da promoção
//Melancia e tipos
//Valores da melancia
//Total da carga do caminhao

namespace Melanciometro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variáveis

            /*A variável string placa caminhao deve fazer uma entrada pedindo o numero da placa
             * e depois ela deve verificar se o usuário digitou abaixo de 8 caracteres ou acima de 8 caracteres
             * A mensagem de confirmação só acontece se a condição for verdadeira, mas se errar, retornar para o pedido 
             * de inserir a numeração.*/

            /* Observação: então para adicionar um loop é bem simples, basta definir uma variável,  e em seguida adicionar
             * um while ( true ) "enquanto for verdadeiro", e nisso o compilador irá checkar se as condições são verdadeiras, e o
             * break, fica abaixo do primeiro loop, isso evita do loop nao funcionar corretamente*/
            string placacaminhao;
            while (true)
            {
                Console.WriteLine(" Por favor, insira o número da placa do caminhão: ");
                placacaminhao = Console.ReadLine();
                if (placacaminhao.Length == 8)
                {
                    Console.WriteLine(" Número cadastrado com sucesso !\n ");
                    break;
                }
                else
                {
                    Console.WriteLine(" O número da placa deve conter 8 caracteres, tente novamente !\n ");
                }
            }
            /* Aqui também é bem simples de compreender na verdade. Criei variáveis para login e senha, o login em formato string por razões 
             * óbvias, ela recebe uma linha de caracteres. a int senha recebe um valor inteiro e armazena esse valor
             * criei uma outra string user para armazenar o mesmo valor ( no caso o nome de usuário )
             * no console WriteLine, declarei a variável user para receber o console writeline. Isso faz com que a variável user
             * leia o que o usuário digitar na tela.
             * 
             * Já a variável int senha funciona de uma forma um pouco diferente, primeiro eu criei uma variável chamada password
             * e nela defini um tipo inteiro, e em seguida converti a mesma para uma string com o int.Parse(Console.ReadLine());
             * essa linha de comando está atribuindo a conversão do tipo inteiro em string para que o usuário possa digitar sua senha definida como
             * 123.
             * 
             * O inicio do if em while (true), eu fiz uma menção das variáveis login e user dizendo que se forem iguais == e se senha for igual == a
             * passowrd, o loop para ali com o break, mas se nao for, ele passa para o else if, que faz a mesma comparação; mas ao invés de ==, 
             * utilizei em algum dos dois outros parametros, o != ( Diferente )
             * E o else termina com um Console.WriteLine e um break para dar fim ao loop caso seja acessado pelo compilador.
             * É bem simples entender.*/

            string login = "Joao";
            int senha = 123;
            string user = "Joao";

            int tentativas = 0;

            while (true)
            {
                if (tentativas >= 3)
                {
                    Console.WriteLine(" Número máximo de tentativas excedido, tente novamente mais tarde!\n ");
                    return;
                }
                /* Para tentativas, também é simples, cria-se a variável "tentativas", definir um valor a ela q nesse caso foi 0
                 * após isso o if de tentativas fica dentro do loop antes do código em si, e a tentativa++ ( incremento ) fica 
                 * no fim do primeiro else if adiante.
                 * e a cada erro, o return é acionado e adiciona um valor a variável int tentativas. */
                Console.WriteLine(" Insira seu nome de usuário: ");
                user = Console.ReadLine();
                Console.Write(" Insira sua senha: ");
                int password = int.Parse(Console.ReadLine());

                if (login == user && senha == password)
                {
                    Console.WriteLine(" Login realizado com sucesso !\n ");
                    break;
                }
                else if (login != user && password != senha)
                {
                    Console.WriteLine(" Senha ou usuário inválidos, tente novamente !\n ");
                    tentativas++;
                }
                else
                {
                    Console.WriteLine(" Nome de usuário ou senha não encontrado, tente novamente !\n ");
                    tentativas++;
                }
            }
            Console.WriteLine(" Bem-Vindo ao verdurão do Joao.\n ");
            Console.WriteLine(" Valor da melancia comum : R$: 5.50/kg\n Valor da melancia Baby : R$: 8.54/kg\n ");

            string mensagem = "";
            double desconto = 0;
            string segunda = "segunda";
            string terca = "terca";
            string quarta = "quarta";
            string quinta = "quinta";
            string sexta = "sexta";

            double precoComum = 5.50;
            double precoBaby = 8.56;

            int acumulador = 0;
            double descontoUm = 1.0 / 100;
            double descontoDois = 2.0 / 100;
            double descontoTres = 3.0 / 100;
            double descontoComum = 15.0 / 100;
            double descontoBaby = 17.0 / 100;
            double totalItemComum = 0;
            double totalItemBaby = 0;
            double totalcomprado = 0;


            string estoque = "";
            int estoque1 = 10;
            int qtkg = 0;
            Console.WriteLine(" Selecione o numero correspondente aos dias da semana:\n 1-segunda\n 2-terça \n 3-quarta \n 4-quinta \n 5-sexta ");
            int dia = int.Parse(Console.ReadLine());

            if (dia == 1)
            {
                Console.WriteLine(" Segunda feira, descontos de 1% para:\n * Melancia comum.\n * Melancia baby.");
            }
            if (dia == 2)
            {
                Console.WriteLine(" HOJE É TERÇA VERDE! DESCONTOS IMPERDÍVEIS NOS SEGUINTES PRODUTOS:\n * Melancia comum: 15%\n MELANCIA BABY: 17%");
            }
            if (dia == 3)
            {
                Console.WriteLine(" HOJE É QUARTA VERDE! DESCONTOS IMPERDÍVEIS NOS SEGUINTES PRODUTOS:\n * Melancia comum: 15%\n MELANCIA BABY: 17%");
            }
            if (dia == 4)
            {
                Console.WriteLine(" Quinta feira, promoções imperdíveis de 2% !");
            }
            if (dia == 5)
            {
                Console.WriteLine(" Sextou! Promoção de 3% em nossos produtos ! ");

            }
            Console.WriteLine(" Limite de 10 quilos por compra.");
            
            while (true)
            {
                Console.WriteLine(" Qual tipo deseja comprar?\n 1-comum\n 2-baby ");
                int tipo = int.Parse(Console.ReadLine());
                if (tipo == 1)
                {
                    Console.WriteLine(" Voce selecionou melancia comum");
                }
                if (tipo == 2)
                {
                    Console.WriteLine(" Voce selecionou melancia baby");
                }
                Console.WriteLine(" Quantos quilos deseja? ");
                qtkg = int.Parse(Console.ReadLine());
                
                if (estoque1 >=11)
                {
                    Console.WriteLine(" Estamos sem estoque.");
                    
                    break;
                }
                switch (dia)
                {
                    case 1:
                        if (tipo == 1)
                        {
                            Console.WriteLine($"{dia} Melancia comum no valor de R$: {precoComum}");
                            totalItemComum = precoComum * qtkg;
                            totalItemComum = totalItemComum - (totalItemComum * descontoUm);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemComum} ");
                            estoque1++;
                        }
                        else
                        {
                            Console.WriteLine($"{dia} Melancia baby no valor de R$: {precoBaby}");
                            totalItemBaby = precoBaby * qtkg;
                            totalItemBaby = totalItemBaby - (totalItemBaby * descontoUm);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemBaby} ");
                           estoque1++;
                        }
                        break;

                    case 2:
                        if (tipo == 1)
                        {
                            Console.WriteLine($"{dia}-Melancia comum no valor de R$: {precoComum}");
                            totalItemComum = precoComum * qtkg;
                            totalItemComum = totalItemComum - (totalItemComum * descontoComum);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemComum} ");
                            estoque1++;
                        }
                        else
                        {
                            Console.WriteLine($"{dia}-Melancia baby no valor de R$: {precoBaby}");
                            totalItemBaby = precoBaby * qtkg;
                            totalItemBaby = totalItemBaby - (totalItemBaby * descontoBaby);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemBaby} ");
                            estoque1++;
                        }
                        break;

                    case 3:
                        if (tipo == 1)
                        {
                            Console.WriteLine($"{dia}Melancia comum no valor de R$: {precoComum}");
                            totalItemComum = precoComum * qtkg;
                            totalItemComum = totalItemComum - (totalItemComum * descontoUm);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemComum} ");
                            estoque1++;
                        }
                        else
                        {
                            Console.WriteLine($"{dia}-Melancia baby no valor de R$: {precoBaby}");
                            totalItemBaby = precoBaby * qtkg;
                            totalItemBaby = totalItemBaby - (totalItemBaby * descontoUm);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemBaby} ");
                            estoque1++;
                        }
                        break;

                    case 4:
                        if (tipo == 1)
                        {
                            Console.WriteLine($"{dia}Melancia comum no valor de R$: {precoComum}");
                            totalItemComum = precoComum * qtkg;
                            totalItemComum = totalItemComum - (totalItemComum * descontoDois);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemComum} ");
                            estoque1++;
                        }
                        else
                        {
                            Console.WriteLine($"{dia}-Melancia baby no valor de R$: {precoBaby}");
                            totalItemBaby = precoBaby * qtkg;
                            totalItemBaby = totalItemBaby - (totalItemBaby * descontoDois);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemBaby} ");
                            estoque1++;
                        }
                        break;

                    case 5:
                        if (tipo == 1)
                        {
                            Console.WriteLine($"{dia}Melancia comum no valor de R$: {precoComum}");
                            totalItemComum = precoComum * qtkg;
                            totalItemComum = totalItemComum - (totalItemComum * descontoTres);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemComum} ");
                            estoque1++;
                        }
                        else
                        {
                            Console.WriteLine($"{dia}-Melancia baby no valor de R$: {precoBaby}");
                            totalItemBaby = precoBaby * qtkg;
                            totalItemBaby = totalItemBaby - (totalItemBaby * descontoTres);
                            Console.WriteLine($"{qtkg} -KG deu um total de: {totalItemBaby} ");
                            estoque1++;
                        }
                        break;

                    default:
                        Console.WriteLine();
                        return;
                }
                Console.WriteLine("Comprar novamente? 1 Sim 2 Nao ");
                int escolha = int.Parse(Console.ReadLine());
                /* Respeitar o loop while, ele começa onde voce quer que ele volte, o código ficando embaixo com opção para sair.
                 * lembrar que o break, fica somente onde eu quero que o loop acabe, o restante pode ficar vazio, nao precisa de break ou return.
                 */
                if (escolha == 1)
                {
                    Console.WriteLine(" Retornando ao menu de compras.");
                }
                if (escolha == 2)
                {
                    Console.WriteLine(" Saindo...");
                    break;
                }
            }
        }
    }
}