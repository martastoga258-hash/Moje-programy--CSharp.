namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Operator warunkowy (ternary)
            int age = 20;
            string status = age >= 18 ? "pełnoletni" : "niepełnoletni";

            // ?? - null-coalescing
            string? name = null;
            string display = name ?? "Anonim";

            // ??= - przypisz tylko gdy null
            name ??= "Domyślna";

            // ?. - null-conditional
            int? len = name?.Length;

            Console.WriteLine($"status: {status}");
            Console.WriteLine($"display: {display}");
            Console.WriteLine($"name: {name}");
            Console.WriteLine($"len: {len}");
        }
        bool a = true, b = false;

       // bool and = a && b;  // false 
    }   // bool or = a || b;  // true 
        // bool not = !a;     // false 

// Short - circuit evaluation
//#if (obj != null && obj.IsValid)
                   
        // bezpieczne - druga część nie wykona się,
        // gdy obj == null 
}
