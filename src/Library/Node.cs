using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {

        private Persona person;

        private List<Node> children = new List<Node>();


        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(Persona person)
        {
            this.Person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)
        {
            visitor.Visit(this);
        }

        public int GetAgeTotal()
        {
            Visitor visitor = new Calculador();
            this.Accept(visitor);
            return visitor.AgeTotal;
        }

        public Persona Person
        {
            get
            {
                return this.person;
            }
            private set
            {
                this.person = value;
            }
        }
        
    }
}
