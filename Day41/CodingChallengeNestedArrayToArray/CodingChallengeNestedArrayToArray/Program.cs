namespace CodingChallengeNestedArrayToArray
{
    public class ArrayFlattener
    {
        //with LINQ
        public static void FlattenLinq(List<List<List<string>>> nestedArray)
        {
            List<string> alpha;
            alpha =  nestedArray.SelectMany(inner1 => inner1)
                              .SelectMany(inner2 => inner2)
                              .ToList();
            Console.WriteLine("Flattened (LINQ): " + string.Join(",", alpha));
        }

        // without LINQ
        public static void FlattenIterative(List<List<List<string>>> nestedArray)
        {
            List<string> alpha = new List<string>();
            foreach (var inner1 in nestedArray)
            {
                foreach (var inner2 in inner1)
                {
                    foreach (var str in inner2)
                    {

                        alpha.Add(str);
                    }
                }
            }

            Console.WriteLine("Flattened (Iterative): " + string.Join(",", alpha));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<List<List<string>>> nestedArray = new List<List<List<string>>>
            {
                new List<List<string>> { new List<string> { "x", "y" } },
                new List<List<string>> { new List<string> { "a", "b" } }
            };
            ArrayFlattener.FlattenLinq(nestedArray);
            ArrayFlattener.FlattenIterative(nestedArray);
        }
    }
}