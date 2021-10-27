namespace Library
{
    public class NameComparator : Visitor
    {
        //Clase que hereda de visitor, tiene como reponsabilidad de determinar el nombre mas largo de entre todos os nombres que se le ingresan

        public override void Visit(Node node)
        {
            if (this.LongName.Length <= node.Person.Name.Length) //Compara la cantidad de carcateres que tiene al atributo actual, con la cantidad de caracetres del nombre de la person del node que se le ingreso en el metodo visit (node es un objeto directo), por lo que cumple la ley de demeter
            {
                this.LongName = node.Person.Name;//si el nombre de la person que se le ingreso es mas grande que el que almacena el atributo actualmente, cambia a este ultimo por el nuevo
            }
            foreach (Node item in node.Children)//Al final de la comparacion, se determina si el node actual tiene hijos, y en el caso que si, se vuelve a repetir el procedimeinto con los hijos
            {
                this.Visit(item);
            }
        }
    }
}