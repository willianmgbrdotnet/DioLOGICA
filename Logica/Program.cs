//Math table of 9
int numero = 0;
int limite = 10;

Console.WriteLine("Tabuada de multiplicação do Nove");
while(numero <= limite)
{
    //Converte o calculo do tipo inteiro para string
    Console.WriteLine($"9 x {numero} = {9*numero}");
    //O valor do numero será incrementado em 1 enquanto esse for menor que o limite
    numero++;
}