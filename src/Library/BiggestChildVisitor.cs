namespace Library
{
    public class BiggestChildVisitor : IPersonVisitor
    {
        private int maxSize;
        private string biggestChild;
        public void Visit(Person person)
        {
            
        }
        public void Visit(Node node)
        {
            if (node.Children.Count == 0)
            {
                if (node.Person.Edad > maxSize)
                {
                    maxSize = node.Person.Edad;
                    biggestChild = node.Person.Nombre; 
                }
            }
        }
        public string GetBiggestChild()
        {
            return biggestChild;
        }
    }
}