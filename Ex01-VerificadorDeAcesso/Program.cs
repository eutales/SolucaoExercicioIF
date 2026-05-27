/* Crie um sistema automático para controlar
a catraca do laboratório de TI com base no
número de chamada do aluno. */

/* Declare duas variáveis: uma para o nome e 
 * outra para o número de chamada. 
 * (Dica: string para texto, int para número inteiro).*/

string nome;
int nChamada;

/* Peça ao usuário para digitar o seu Nome Completo. 
 * (Dica: use Console.ReadLine()).*/

Console.WriteLine("Digite o seu nome completo: ");
nome = Console.ReadLine();

/* Peça ao usuário para digitar o seu Número de Chamada.
 * (Dica: lembre-se de converter o texto para inteiro
 * usando int.Parse() ou Convert.ToInt32()). */

Console.WriteLine($"{nome}, por favor digite o seu " +
    $"número de chamada");
nChamada = int.Parse(Console.ReadLine());

/* Crie uma estrutura condicional para verificar 
 * se o número de chamada é par. 
 * (Dica: use o operador de módulo matemático 
 * if (numero % 2 == 0)).
 *Se for par, exiba a mensagem: 
 *"[Nome], acesso liberado às Terças e Quintas."
 *. (Dica: use interpolação de strings 
 *Console.WriteLine($"{nome}...");).
 * Caso contrário (else), exiba: 
 *"[Nome], acesso liberado às Segundas e Quartas.".
 */

if (nChamada % 2  == 0)
{
    Console.WriteLine($"{nome}, acesso liberado às Terças e Quintas.");
}
else
{
    Console.WriteLine($"{nome}, acesso liberado às Segundas e Quartas.");
}