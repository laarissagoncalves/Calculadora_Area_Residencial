namespace Calculadora_Area_Residencial {
    class Program{
        public static void Main (string[] args){

            /*Construa um programa que calcule a área total de uma 
            residência (sala, cozinha, quartos, etc., sendo todos eles 
            retangulares). O usuário deverá entrar com a largura e o 
            comprimento de cada cômodo da casa. Em seguida deverá ser 
            apresentada uma pergunta, solicitando a confirmação do usuário 
            para continuar com a entrada de dados (a confirmação será dada 
            quando o usuário entrar com “S”). Caso ele entre com o valor “N”. 
            Deverá ser apresentada a área total da casa.*/

            double l, c, area, att;
            char op;

            att = 0;
            do{
                do{
                    Console.Write("Entre com a largura do cômodo: ");
                    l = double.Parse(Console.ReadLine());
                    Console.Write("Entre com o comprimento do cômodo: ");
                    c = double.Parse(Console.ReadLine());
                    if (l<0 || c<0)
                        Console.WriteLine("Não existe medida negativa! Vamos novamente.");
                }while(l<0 || c<0);
                area = l*c;
                att = att+area;
                do{
                    Console.WriteLine("Você deseja acrescentar mais um cômodo?");
                    Console.WriteLine("S - para sim");
                    Console.WriteLine("N - para não");
                    Console.Write("Digite sua opção: ");
                    op = char.Parse(Console.ReadLine().ToUpper());
                    Console.WriteLine("");
                    if (op!='S' && op!='N'){
                        Console.WriteLine("Entre com uma opção válida!");
                    }
                }while(op!='S' && op!='N');
            }while(op=='S');
            Console.WriteLine("A área total da residência é {0}m².", att);
        }
    }
}
