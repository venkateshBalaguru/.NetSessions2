// See https://aka.ms/new-console-template for more information
CaseStudy1();
CaseStudy2();

void CaseStudy1()
{
    Func<string, bool> isAlongName = CheckIfNameIsLong; //variables of delegate
    Console.WriteLine(isAlongName);
}
bool CheckIfNameIsLong(string name)
{
    return name.Length > 0;
}

void CaseStudy2()
{
    Func<string, bool> isLongName = (name) => name.Length > 8;
    Console.WriteLine(isLongName("Venkatesh"));

    Action<int, int> add = (n1, n2) =>
    {
        Console.WriteLine("Inside add procedure");
        Console.WriteLine($"Addition result is {n1 + n2}");
    };
    add(10,20);
}
