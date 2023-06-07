using System.Collections.Generic;
namespace Library
{
    public abstract class PersonVisitor
    {
        public abstract void Visit(Person person);
        public abstract void Visit(Node node);

    }
}