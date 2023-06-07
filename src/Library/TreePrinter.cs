
namespace Library
{
    public class TreePrinter
    {
         public static void PrintNode(Node node, int depth)
        {
            string indent = new string(' ', depth * 4);
            System.Console.WriteLine($"{indent}- {node.Person.Nombre} (Edad: {node.Person.Edad})");

            foreach (var child in node.Children)
            {
                PrintNode(child, depth + 1);
            }
        }

        
    }
    
}