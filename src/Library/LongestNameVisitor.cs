namespace Library
{
    public class LongestNameVisitor : IPersonVisitor
    {
        private int maxLength;
        private string longestName;

        public void Visit(Person person)
        {
            if (person.Nombre.Length > maxLength)
            {
                maxLength = person.Nombre.Length;
                longestName = person.Nombre;
            }
        }
        public void Visit(Node node)
        {
            
        }
        public string GetLongestName()
        {
            return longestName;
        }
    }
}