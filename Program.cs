using System;

namespace Animales
{
    interface IAnimal  // Define una interfaz llamada IAnimal
    {
        void animalSound();  // Método para el sonido del animal
        void typeanimal();  // Método para el tipo de animal
        void sleep();
    }

    class Leon : IAnimal  // Define una clase llamada Leon que implementa la interfaz IAnimal
    {
        public void animalSound()  // Implementa el método animalSound de la interfaz
        {
            Console.WriteLine("Rugido");  // Imprime el sonido característico del león
        }

        public void typeanimal()  // Implementa el método typeanimal de la interfaz
        {
            Console.WriteLine("mamífero");  // Imprime el tipo de animal (mamífero)
        }
        public void sleep()  // Define un método concreto para que el animal duerma
        {
            Console.WriteLine("Zzz");  // Imprime un mensaje indicando que el animal está durmiendo
        }
    }

    class Sapo : IAnimal  // Define una clase llamada Sapo que implementa la interfaz IAnimal
    {
        public void animalSound()  // Implementa el método animalSound de la interfaz
        {
            Console.WriteLine("croac, croac");  // Imprime el sonido característico del sapo
        }

        public void typeanimal()  // Implementa el método typeanimal de la interfaz
        {
            Console.WriteLine("anfibio");  // Imprime el tipo de animal (anfibio)
        }
        public void sleep()  // Define un método concreto para que el animal duerma
        {
            Console.WriteLine("Zzz");  // Imprime un mensaje indicando que el animal está durmiendo
        }
    }

    class Cocodrilo : IAnimal  // Define una clase llamada Cocodrilo que implementa la interfaz IAnimal
    {
        public void animalSound()  // Implementa el método animalSound de la interfaz
        {
            Console.WriteLine("gruñido gutural");  // Imprime el sonido característico del cocodrilo
        }

        public void typeanimal()  // Implementa el método typeanimal de la interfaz
        {
            Console.WriteLine("reptil");  // Imprime el tipo de animal (reptil)
        }
        public void sleep()  // Define un método concreto para que el animal duerma
        {
            Console.WriteLine("Zzz");  // Imprime un mensaje indicando que el animal está durmiendo
        }
    }


    class Program  // Define la clase principal Program
    {
        static void Main(string[] args)  // Método principal de la aplicación
        {
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
            Leon leon = new Leon();  // Crea una instancia de la clase Leon
            Console.WriteLine("LEON");  // Imprime un título indicando el tipo de animal
            leon.animalSound();  // Llama al método para reproducir el sonido del león
            leon.typeanimal();  // Llama al método para obtener el tipo de animal
            leon.sleep();  // Llama al método para hacer que el león duerma
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
            Sapo sapo = new Sapo();  // Crea una instancia de la clase Sapo
            Console.WriteLine("SAPO");  // Imprime un título indicando el tipo de animal
            sapo.animalSound();  // Llama al método para reproducir el sonido del sapo
            sapo.typeanimal();  // Llama al método para obtener el tipo de animal
            sapo.sleep();  // Llama al método para hacer que el sapo duerma
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
            Cocodrilo cocodrilo = new Cocodrilo();  // Crea una instancia de la clase Cocodrilo
            Console.WriteLine("COCODRILO");  // Imprime un título indicando el tipo de animal
            cocodrilo.animalSound();  // Llama al método para reproducir el sonido del cocodrilo
            cocodrilo.typeanimal();  // Llama al método para obtener el tipo de animal
            cocodrilo.sleep();  // Llama al método para hacer que el cocodrilo duerma
            Console.WriteLine("---------------------------");  // Imprime una línea separadora
        }
    }
}
