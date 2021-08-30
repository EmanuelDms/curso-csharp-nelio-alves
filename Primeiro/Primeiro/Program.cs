// Referência à namespace padrão do .NET para uso de funções básicas de manipulação de programas (BCL = Base Class Library)
using System;

// O namespace possui o mesmo nome do projeto, o que adquire essa sintaxe (Projeto (Assemblie) namespace)
// boa prática é ficar desta forma
namespace Primeiro
{
    // É convenção o nome da classe ser o mesmo do arquivo
    class Program
    {
        // membro da classe estático (neste caso, um método Main())
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
