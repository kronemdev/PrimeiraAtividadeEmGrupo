double salario = 0;
double decimoTerceiro = 0;
int opcao = 0;
do
{
    Console.WriteLine("\n--- Menu De Opções ---");
    Console.WriteLine("1 - Novo salario");
    Console.WriteLine("2 - Ferias");
    Console.WriteLine("3 - Decimo terceiro");
    Console.WriteLine("4 - sair");
    Console.WriteLine("Digite a opcao : ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Digite o salario : ");
            salario = double.Parse(Console.ReadLine());
            if(salario <= 350.00)
            {
                salario += salario * 0.15;
                Console.WriteLine($"Seu salario atual e : {salario}");
            }
            else if (salario < 600)
            {
                salario += salario * 0.10;
                Console.WriteLine($"Seu salario atual e : {salario}");
            }
            else
            {
                salario += salario * 0.05;
                Console.WriteLine($"Seu salario atual e : {salario}");
            }break;
        case 2:
            Console.WriteLine("Digite o salario");
            salario = double.Parse(Console.ReadLine());
            salario += salario * 0.5;
            Console.WriteLine($"Voce vai receber {salario} de ferias ");
            break;
        case 3:
            Console.WriteLine("digite seu salario : ");
            salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos meses trabalhou :");
            decimoTerceiro = double.Parse(Console.ReadLine());
            if (decimoTerceiro < 1 || decimoTerceiro > 12)
            {
                Console.WriteLine("Quantidade de meses invalida");
            }
            else
            {
             salario = (salario * decimoTerceiro) / 12;
                Console.WriteLine($"Seu Decimo Terceiro e de : {salario}");  
            } break;
           
    }
} while (opcao != 4);
Console.WriteLine("Programa encerrado");



//------------------------ CODIGO MODIFICADO POR KRONEMDEV -----------------------//

/*PARTICIPANTES :

Fábio Gomes
José Henrique
Lucas Santos
Nicolas Kronemberger
Washington William 
*/
