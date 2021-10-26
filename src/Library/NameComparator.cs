namespace Library
{
    public class NameComparator : Visitor
    {
        public override void Visit(Node node)
        {
            if (this.LongName.Length <= node.Person.Name.Length)
            {
                this.LongName = node.Person.Name;
            }
            foreach (Node item in node.Children)
            {
                this.Visit(item);
            }
        }
    }
}