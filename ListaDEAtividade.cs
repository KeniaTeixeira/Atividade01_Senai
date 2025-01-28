/*
 * Criado por SharpDevelop.
 * Usuário: Kenia Teixeira
 * Data: 28/01/2025
 * Hora: 08:25
*/
using System;
namespace ListaAtividade01{
	class ListaDeAtividade{
		public static void Main(string[] args){
			int sair = 1;
			
			while(sair == 1){
			Console.WriteLine("Escolha a atividade: A - B - C - D - E - F - G - H - I - J \n   PRESIONE S PARA SAIR");
			char x = Convert.ToChar(Console.ReadLine());
			char escolha = char.ToLower(x);
			switch(escolha){
					case 'a':
					/*Peça ao usuário para digitar um número inteiro e armazene-o em uma					
					variável int. Em seguida, exiba o valor da variável na tela.*/
						questaoA();
					break;
					
					case 'b':
					/*Peça ao usuário para digitar um número inteiro e armazene-o em uma
					variável int. Em seguida, exiba o valor da variável na tela.*/
						questaoB();
						break;
					
					case 'c':
					/* Peça ao usuário para digitar um número de ponto flutuante e armazene-o em
					uma variável float. Em seguida, exiba o valor da variável na tela.*/
						questaoC();
						break;
					
					case 'd':
					/*Peça ao usuário para digitar &quot;sim&quot; ou &quot;não&quot; e armazene-o em uma variável	
					bool. Em seguida, exiba o valor da variável na tela. */
						questaoD();
						break;
						
					case 'e':
					/*Peça ao usuário para digitar um caractere e armazene-o em uma variável
					char. Em seguida, exiba o valor da variável na tela.*/
						questaoE();
						break;
					case 'f':
					/*Peça ao usuário para digitar um número decimal e armazene-o em uma
					variável decimal. Em seguida, exiba o valor da variável na tela.*/
						questaoF();
						break;
						
					case 'g':
					/*Peça ao usuário para digitar o seu nome e a sua idade, e armazene-os em
					variáveis string e int, respectivamente. Em seguida, exiba essas informações na tela.*/
						questaoG();
						break;
						
					case 'h':
					/*Peça ao usuário para digitar o preço de um produto e o seu desconto em
					porcentagem, e armazene-os em variáveis double. Em seguida, calcule o
					preço final com o desconto e exiba-o na tela.*/
						questaoH();
						break;
						
					case 'i':
					/*Peça ao usuário para digitar uma palavra e armazene-a em uma variável
					string. Em seguida, exiba o comprimento da palavra na tela.*/
						questaoI();
						break;
						
					case 'j':
					/*Peça ao usuário para digitar o seu endereço completo, incluindo o número da
					casa, rua, bairro, cidade e estado. Armazene cada informação em uma
					variável string e, em seguida, exiba todas as informações juntas em uma única linha.*/
						questaoJ();
						break;
						
					case 's':
					sair = 0;
					break;
					
					default:
						Console.WriteLine("Opção Invalida!!");
					break;
					}	
			}
			
			Console.Write("Precione qualquer tecla para continuar . . . ");
			Console.ReadKey(true);
		}
		
			static void questaoA(){
				Console.WriteLine("\n ------- QUESTAO A ------- \n");
				Console.WriteLine("Digite um valor inteiro: ");
				int x = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("O valor inteiro digitado: " + x);
			}
		
			static void questaoB(){
				Console.WriteLine(" \n------- QUESTAO B ------- \n");
				Console.WriteLine("Digite um valor Real: ");
				double x = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("O valor real digitado: " + x);
			}
			
			static void questaoC(){
				Console.WriteLine(" \n------- QUESTAO C ------- \n");
				Console.WriteLine("Digite um valor Real (Float): ");
				float x = float.Parse(Console.ReadLine());
				Console.WriteLine("O valor real digitado: " + x);
			}
			
			static void questaoD(){
				Console.WriteLine(" \n------- QUESTAO D ------- \n");
				Console.WriteLine("Digite 'Sim' ou 'Nao': ");
				string x = Console.ReadLine();
				bool valorBooleano = ( x.ToLower() == "sim" ? true : false);
				Console.WriteLine(valorBooleano);
			}
			
			static void questaoE(){
				Console.WriteLine(" \n------- QUESTAO E ------- \n");
				Console.WriteLine("Digite um caractere: ");
				char x = Convert.ToChar(Console.ReadLine());
				Console.WriteLine("O caractere digitado: " + x);
			}
			
			static void questaoF(){
				Console.WriteLine(" \n------- QUESTAO F ------- \n");
				Console.WriteLine("Digite um valor com casas decimais: ");
				double x = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine("O valor digitado: " + x);
			}
		
			static void questaoG(){
				Console.WriteLine(" \n------- QUESTAO G ------- \n");
				Console.WriteLine("Digite seu nome: ");
				string nome = Console.ReadLine();
				Console.WriteLine("Digite sua idade: ");
				int idade = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine("Seu nome: " + nome + "\nSua idade: " + idade);
			}
		
			static void questaoH(){
				Console.WriteLine(" \n------- QUESTAO H ------- \n");
				Console.Write("Digite o valor do produto: ");
				double valor = Convert.ToDouble(Console.ReadLine());
				Console.Write("Digite a porcentagem do desconto: ");
				double desconto = Convert.ToDouble(Console.ReadLine());
				
				double valorFinal = (desconto/100) * valor;
				Console.WriteLine("O valor com desconto é de: " + (valor - valorFinal));
			}
		
			static void questaoI(){
				Console.WriteLine(" \n------- QUESTAO I ------- \n");
				Console.WriteLine("Digite uma palavra: ");
				string palavra = Console.ReadLine();
				Console.WriteLine("O tamanho da palavra " + palavra + " é: " + palavra.Length);
			}
		
			static void questaoJ(){
				Console.WriteLine(" \n------- QUESTAO J ------- \n");
				Console.WriteLine("Digite o nome do seu estado");
				string estado = Console.ReadLine();
				Console.WriteLine("Digite o nome da sua cidade: ");
				string cidade = Console.ReadLine();
				Console.WriteLine("Digite o nome do seu bairro: ");
				string bairro = Console.ReadLine();
				Console.WriteLine("Digite o nome da sua rua: ");
				string rua = Console.ReadLine();
				Console.WriteLine("Digite o numero da sua casa: ");
				int numero = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine("Estado: " + estado + " Cidade: " + cidade + " Bairro: " + bairro + " Rua: " + rua + " Nº: " + rua);
			}

	}
}