using System;

namespace Atributos_e_metodos_01_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem person1 =  new Personagem();
            person1.nome = "Junior";
            person1.idade = 0;
            person1.armadura = "voadora";

            Personagem person2 = new Personagem();
            person2.nome = "joão";
            person2.idade = 0;
            person2.armadura = "gelo";

            Console.WriteLine($"Personagem {person1.nome} usou um {person1.Atacar()}");

            Console.WriteLine($"Perosonagem {person2.nome} se defendeu com uma {person2.Defender()}");
         
        }
    }
}
