using System.Collections.Generic;

namespace Library
{
    public class OldSon : Visitor
    {
        public override void Visit(Node node)
        {
            
            if (node.Children.Count == 0)
            {
                if (node.Person.Age >= this.OldSonAge)
                {
                    this.OldSonAge = node.Person.Age;
                }
            }
            foreach (Node item in node.Children)
            {
                this.Visit(item);
            }
        }
    }
}