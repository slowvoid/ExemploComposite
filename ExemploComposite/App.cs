using ExemploComposite.Composite;
using System;

namespace ExemploComposite
{
    internal class App
    {
        public static void Main()
        {
            Console.WriteLine( "Exemplo Composite" );

            // Instancia uma box e calcula o preço sem nada
            Box b1 = new Box();

            Console.WriteLine($"Preço total caixa 1: R${b1.CalculatePrice()}");

            // Vamos criar outra caixa e adicionar alguns items nela
            Box b2 = new Box();
            Composite.Object obj1 = new Composite.Object( 10 );
            Composite.Object obj2 = new Composite.Object( 1 );
            Composite.Object obj3 = new Composite.Object( 2.53 );

            b2.Add( obj1 );
            b2.Add( obj2 );
            b2.Add( obj3 );

            // Calcula preço agora
            Console.WriteLine( $"Preço total caixa 2: R${b2.CalculatePrice()}" );

            // Se quisermos, podemos exibir apenas o preço do objeto 3
            Console.WriteLine($"Preço objeto 3: R${obj3.CalculatePrice()}");

            // Agora vamos criar uma nova caixa, adicionar alguns itens e também adicionar a caixa 2 dentro
            Box b3 = new Box();
            b3.Add( new Composite.Object(5) );
            b3.Add( new Composite.Object(1) );
            b3.Add( new Composite.Object(7) );
            b3.Add( new Composite.Object(25) );
            b3.Add( b2 );

            Console.WriteLine($"Preço total da caixa 3: R${b3.CalculatePrice()}");

            // Fim
            Console.WriteLine( "Aperte qualquer tecla para fechar" );
            Console.Read();
        }
    }
}
