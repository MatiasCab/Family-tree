using System.Collections.Generic;

namespace Library
{
    //Clase que hereda de visitor, tiene como reponsabilidad el determinar el hijo mayor de entre todos los nodes hijos (aquellos que no tiene nodehijos, es decir, el final del arbol)

    public class OldSon : Visitor
    {
        public override void Visit(Node node)
        {
            
            if (node.Children.Count == 0) //Primero determina si este es un node hijo (node que no tenga ningun otro node hijo en su coleccion children)
            {
                if (node.Person.Age >= this.OldSonAge)//en caso de que sea un node valido, compara la edad actual, almacena en el atributo OldSonAge, con la del node hijo actual
                {
                    this.OldSonAge = node.Person.Age; //Si la edad de la person del node hijo actual es mayor a la de la almacenada en el atributo OldSonAge,la cambia
                }
            }else //si no es un node hijo valido, va a los siguientes node 
            {
                foreach (Node item in node.Children)
                {
                    this.Visit(item);
                }
            }
        }
    }
}