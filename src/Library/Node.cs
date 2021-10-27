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

        public Node(Persona person) //Node recibe un peron como parametro del constructor
        {
            this.Person = person;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }

        public void Accept(Visitor visitor)// Esto metodo accept recivi un objeto del tipo visitor, y le manda un mensaje con la firma visit y el mismo objeto, 
        {
            visitor.Visit(this);
        }

        public int GetAgeTotal() // Este metodo instancia un objeto de  Visitor, y se lo manda a accept, al final del todo el procedimeinto, retorna la suma de las edades de las personas, en cada nodo
        {
            Visitor visitor = new AgeCalculator();
            this.Accept(visitor);
            return visitor.AgeTotal;
        }

        public string GetLongestName() // Este metodo instancia un objeto de  Visitor, y se lo manda a accept, al final del todo el procedimeinto, retorna el nombre mas largo de las personas ubcadas en cada node
        {
            Visitor visitor = new NameComparator();
            this.Accept(visitor);
            return visitor.LongestName;
        }

        public int GetOldSonAge() // Este metodo instancia un objeto de  Visitor, y se lo manda a accept, al final del todo el procedimeinto, retorna la edad del node hijo mayor (el nodo hijo lo tomo como aquerl node que no tiene hijos)
        {
            Visitor visitor = new OldSon();
            this.Accept(visitor);
            return visitor.OldSon;
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
