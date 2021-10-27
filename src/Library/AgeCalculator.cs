namespace Library
{
    //Clase que hereda de visitor, tiene como reponsabilidad el sumar todas las edades de las personas de los nodes que se la van ingresando

    public class AgeCalculator : Visitor
    {
        public override void Visit(Node node)
        {
            this.TotalAge = node.Person.Age + this.TotalAge; //Calcula la edad de la persona del objteo tipo node que se le ingreso en el metodo visit (node es un objeto directo), por lo que cumple la ley de demeter
            foreach (Node item in node.Children)
            {
                this.Visit(item);// Pasa a los siguientes nodes almacenedos en el atributo Children y vuelve a repetir el procedmiento anterior
            }
        }
    }
}
