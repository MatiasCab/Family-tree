using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node n1 = new Node(new Persona("Manuelita",42));
            Node n2 = new Node(new Persona("Felipe",34));
            Node n3 = new Node(new Persona("Matias",29));
            Node n4 = new Node(new Persona("Lucas",25));
            Node n5 = new Node(new Persona("Juan",20));
            Node n6 = new Node(new Persona("Gonzalo",19));
            Node n7 = new Node(new Persona("Mateorecoto",15));

            n1.AddChildren(n2);
            n1.AddChildren(n3);

            n2.AddChildren(n4);
            n2.AddChildren(n5);

            n3.AddChildren(n6);
            n3.AddChildren(n7);

            // visitar el árbol aquí
            Console.WriteLine(Convert.ToString(n1.GetAgeTotal()));
            Console.WriteLine(n1.GetLongestName());
            Console.WriteLine(Convert.ToString(n1.GetOldSonAge()));
        }
    }
}
