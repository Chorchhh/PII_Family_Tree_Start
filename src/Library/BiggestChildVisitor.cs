namespace Library
{
    public class BiggestChildVisitor : PersonVisitor
    {
        private int maxSize;
        private string biggestChild;
       
        public override void Visit(Node node)
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
        public override void Visit(Person person)
        {
                
        }
        public string GetBiggestChild()
        {
            return biggestChild;
        }
    }
}