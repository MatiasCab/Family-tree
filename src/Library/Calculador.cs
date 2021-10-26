namespace Library
{
    public class Calculador : Visitor
    {
        public override void Visit(Node node)
        {
            this.Total = node.Person.Age + this.Total;
            foreach (Node item in node.Children)
            {
                this.Visit(item);
            }
        }
    }
}
