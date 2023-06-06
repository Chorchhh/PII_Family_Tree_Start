namespace Library
{
    public interface IPersonVisitor
    {
        void Visit(Person person);
        void Visit(Node node);
    }
}