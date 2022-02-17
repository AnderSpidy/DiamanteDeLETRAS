using System;

namespace DiamanteDeLETRAS.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            # region É preciso transformar todo o alfabeto em uma Array de chars
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWYXZ";
            char[] AlfabetChars = alfabeto.ToCharArray();
            #endregion
            #region Inicio da entrada do caracter pelo usuario 
            Console.WriteLine("Digite um valor ímpar para o dimante de caracteres:");
            string entrada = Console.ReadLine();  //Recebe a entrada do caractere como string
            int letra = Convert.ToChar(entrada.ToUpper());  // Aqui estamos convertendo a entrada string para char, em uma variavel int. Então o valor de caractere, é convertido para o valor em decimal. (O método "ToUpper" é para transformar caracteres em minusculos para MAIUSCULOS 
            int metadeDiamante = letra - 64; // assim pegamos o numero em decimal do caractere, (Que tambem irá estar em maiusculo) e diminuimos -64, para que esteja o valor equivalente com a posição do vetor de alfabeto que criamos na linha 11.
            int contador;  //este contador servira para fazermos a contagem dos espaços dentro do diamante posteriormente dentro do enlace de repetição
            #endregion
            #region A primeira metade do diamante
            for (int i = -1; i < metadeDiamante-1; i++)// para iniciar a contagem da linha, a variavel i, ira começar como -1, pois este valor sera importante para fazer o calculo de espaços dentro do diamante, e diminuimos -1 da variavel metadeDiamante, para compensar a variavel i.
            {
                for (int j = 0; j < metadeDiamante - i; j++)//para os espaços, sempre fazer a contagem até a metade do diamante -i vezes, para ir diminuindo formando uma diagonal até a borda.
                {
                    Console.Write(" ");
                }
                if (i == -1)  //este if, é apenas para evitar que se imprima na tela duas vezes a letra A
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;  //coloquei só para testar rsrs
                }
                else // caso contrario
                Console.Write(AlfabetChars[i + 1]); //imprime o primeirp caractere da esquerda, depois dos espaços
                contador = (2 * i) + 1; //o contador para calcular os espaços dentro do diamante.(Sempre é multiplicar o numero da linha por 2 incrementando 1, pois os espaços são numeros impares).
                for (int j = 0; j < contador; j++)// usa o contador no for, para digitar os espaços
                {
                    Console.Write(" ");
                }
                Console.WriteLine(AlfabetChars[i + 1]);//logo que sai, digita o caractere
            }
            #endregion
            #region A segunda metade do diamante
            Console.ForegroundColor= ConsoleColor.DarkCyan;
            for (int i = metadeDiamante-3 ; i >= -1;i--) // é basicamente que a mesma coisa, porem ao contrario.(foi colocado -3, para compensar os dados incrementados na primeira parte do diamante)
            {
                for (int j = 0; j < metadeDiamante - i; j++)
                {
                    Console.Write(" ");
                }
                if (i == -1)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }
                else
                    Console.Write(AlfabetChars[i + 1]);
                contador = (2 * i) + 1;
                for (int j = 0; j < contador; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine(AlfabetChars[i + 1]);
            }
            Console.ReadLine();
            #endregion
        }
    }
}
