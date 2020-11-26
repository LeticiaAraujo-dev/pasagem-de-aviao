using System;

namespace pasagem_de_aviao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[5];
            string[] origem = new string[5];
            string[] destino = new string[5];
            string[] data = new string [5];

            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("---Sistema de pasagens----");
            Console.WriteLine("--------------------------");

            bool senhaValida;

            do{
                Console.WriteLine("Digite a senha:");
                string senha = Console.ReadLine();
                senhaValida = EfetuarLogin(senha);

            } while (!senhaValida);
                Console.Clear();
                int escolha;
                int contador = 0;
            do{
                Console.WriteLine("Menu inicial");
                Console.WriteLine("Selecione uma opção");
                Console.WriteLine("[1] - Cadastrar Pasagens");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                switch (escolha){
                    case 1:
                        string resposta;
                            do{
                                if(contador<5){
                                    Console.WriteLine($"Digite o nome do {contador + 1}º passageiro");
                                    nomes [contador] = Console.ReadLine();
                                    Console.WriteLine($"Digite a origem do {contador + 1}º passageiro");
                                    origem [contador] = Console.ReadLine();
                                    Console.WriteLine($"Digite o destino do {contador + 1}º passageiro");
                                    destino [contador] = Console.ReadLine();
                                    Console.WriteLine($"Digite a data da viagem do {contador + 1}º passageiro");
                                    data [contador] = Console.ReadLine();

                                    contador++;
                                }
                                else{
                                    Console.WriteLine("Limite de passageiros atingido");
                                    break;
                                }
                                Console.WriteLine("Gostaria de cadastrar outro passageiro?");
                                resposta = Console.ReadLine();
                            } while (resposta == "s");
                    break;
                    case 2:
                        for(var i = 0; i < 5; i++)
                        {
                            Console.WriteLine($"Passageiro {i +1}º");
                        };
                    break;
                    case 0:
                        Console.WriteLine("Obrigado volte sempre!");
                    break;
                    default:
                    break;
                }
            } while (escolha != 0);

            bool EfetuarLogin(string senha){

                if(senha == "123456"){
                    return true;
                } else{
                    Console.WriteLine("Senha incorreta");
                    return false;
                }
            }
        }
    }
}
