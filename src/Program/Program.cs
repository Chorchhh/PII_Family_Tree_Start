using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo la familia
            Person abueloPaterno = new Person("Raúl", 80);
            Person abuelaPaterna = new Person("Pilar", 75);
            Person padre = new Person("César", 50);
            Person madre = new Person("Mónica", 45);
            Person hijo1 = new Person("Jorge", 20);
            Person hijo2 = new Person("Julieta", 15);
            Person abueloMaterno = new Person("Ernesto", 85);
            Person abuelaMaterna = new Person("Ondina", 80);

            // Creo nodos del árbol genealógico
            Node nodoRaiz = new Node(abueloPaterno);
            Node nodoAbuelaPaterna = new Node (abuelaPaterna);
            Node nodoPadre = new Node(padre);
            Node nodoMadre = new Node(madre);
            Node nodoHijo1 = new Node(hijo1);
            Node nodoHijo2 = new Node(hijo2);
            Node nodoAbueloMaterno = new Node(abueloMaterno);
            Node nodoAbuelaMaterna = new Node(abuelaMaterna);

            //Construcción del árbol genealógico
            nodoRaiz.AddChildren(nodoAbuelaPaterna);
            nodoRaiz.AddChildren(nodoAbueloMaterno);
            nodoAbuelaPaterna.AddChildren(nodoPadre);
            nodoAbueloMaterno.AddChildren(nodoMadre);
            nodoPadre.AddChildren(nodoHijo1);
            nodoMadre.AddChildren(nodoHijo2);

            //Imprimo árbol genealógico:

            Console.WriteLine("Arbol Genealógico");
            PrintNode(nodoRaiz, 0);

            //Cálculo e imprimo la suma de las edades:

            AgeSumVisitor ageSumVisitor = new AgeSumVisitor();
            int sum = ageSumVisitor.CalcularAgeSum(nodoRaiz);
            Console.WriteLine($"Suma de las edades: {sum}");

            //Imprimo el hijo con mayor edad:
            BiggestChildVisitor biggestChildVisitor = new BiggestChildVisitor();
            nodoRaiz.Accept(biggestChildVisitor);
            string biggestChild = biggestChildVisitor.GetBiggestChild();
            Console.WriteLine($"El hijo más grande es: {biggestChild}");

            //Imprimo el nombre mas largo de la familia:
            LongestNameVisitor longestNameVisitor = new LongestNameVisitor();
            nodoRaiz.Accept(longestNameVisitor);
            string longestName = longestNameVisitor.GetLongestName();
            Console.WriteLine($"El nombre más largo de la familia es: {longestName}");
        }

        //Método recursivo para imprimir el árbol genealógico
        static void PrintNode(Node node, int depth)
        {
            string indent = new string(' ', depth * 4);
            Console.WriteLine($"{indent}- {node.Person.Nombre} (Edad: {node.Person.Edad})");

            foreach (var child in node.Children)
            {
                PrintNode(child, depth + 1);
            }
        }
        public class AgeSumVisitor : IPersonVisitor
        {
            private int ageSum;

            //Método para cálcular la edad de toda la familia
            public int CalcularAgeSum(Node rootNode)
            {
                ageSum = 0;
                rootNode.Accept(this); //Se invoca el método "Accept" en el nodo raiz para comenzar la visita.
                return ageSum;
            }

            //Método visit se implemta de la interfaz IPersonVisitor y se usa para visitar un objetivo del tipo Person
            //En este caso, se suma la edad de la persona actual a la variable ageSum
            public void Visit(Person person)
            {
                ageSum += person.Edad;
            }
            public void Visit(Node node)
            {

            }
        }
    }
}