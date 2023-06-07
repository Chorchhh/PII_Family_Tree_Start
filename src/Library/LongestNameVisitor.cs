namespace Library
{
    public class LongestNameVisitor : PersonVisitor
    {
        private int maxLength;
        private string longestName;

        public override void Visit(Person person)
        {
            if (person.Nombre.Length > maxLength)
            {
                maxLength = person.Nombre.Length;
                longestName = person.Nombre;
            }
        }
        public override void Visit(Node node)
        {
            
        }
        public string GetLongestName()
        {
            return longestName;
        }
    }
}