namespace Library
{
        public class AgeSumVisitor : PersonVisitor
        {
            private int ageSum;

            //Método para cálcular la edad de toda la familia
            public int CalcularAgeSum(Node rootNode)
            {
                ageSum = 0;
                rootNode.Accept(this); //Se invoca el método "Accept" en el nodo raiz para comenzar la visita.
                return ageSum;
            }

            public override  void Visit(Person person)
            {
                ageSum+=person.Edad;
            }

            public override void Visit(Node node)
            {
            
            }
            //Método visit se implemta de la interfaz IPersonVisitor y se usa para visitar un objetivo del tipo Person
            //En este caso, se suma la edad de la persona actual a la variable ageSum
            
        }
}