using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Library
{
    public class Node
    {
        private Person person;
        private List<Node> children = new List<Node>();
        public Person Person 
        {
            get { return person; }
            set { person = value; }
        }

        public ReadOnlyCollection<Node> Children 
        { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Person person)
        {
            this.person = person;
        }

        public void AddChildren(Node child)
        {
            this.children.Add(child);
        }
        public void Accept(PersonVisitor visitor)
        {
            person.Accept(visitor);

            foreach(var child in Children)
            {
                child.Accept(visitor);
            }
            visitor.Visit(this);
        }
    }
}
