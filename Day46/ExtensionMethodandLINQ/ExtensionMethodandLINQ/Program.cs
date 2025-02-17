// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata.Ecma335;
using ExtensionMethodandLINQ.Extensions;
using ExtensionMethodandLINQ.Models;

//CaseStudy1();
//CaseStudy2();
//CaseStudy3();
//CaseStudy4();
//CaseStudy5();
//CaseStudy6();
CaseStudy7();

void CaseStudy7()
{
    var mynames = new string[] { "Sachin", "Minu", "Venkatesh", "Akhilesh", "sahlini" };
    var query1 = mynames.Where((n) => n.ToLower().Contains("s"));//deferred
    var query2 = query1.OrderBy((SortByLength));//deferred

    var listOfNamesWithS = query2.ToList();//Immediate execution

    Console.WriteLine(listOfNamesWithS.Count);

    listOfNamesWithS.ForEach((n) => Console.WriteLine(n.ToUpper()));
}

void CaseStudy6()
{
    IEnumerable<string> mynames = new string[] { "Sachin", "Minu", "Venakat", "Akhil" };
    IEnumerable<string> orderednames = mynames.OrderBy(SortByAlphabet);
    //IEnumerable<string> orderednames = mynames.OrderBy(SortByLength);
    foreach (var item in orderednames)
    {
        Console.WriteLine(item);
    }
}

string SortByAlphabet(string name)
{
    return name;
}
int SortByLength(string name)
{
    return name.Length;
}
void CaseStudy5()
{
    IEnumerable<string> mynames = new string[] { "Akhilesh", "Sachin", "Minu", "Venkatesh" };
    //instead of using CaseStudy5 we can use foreach

    foreach (var name in mynames)
    {
        Console.WriteLine(name);
    }
}
void CaseStudy4()
{
    IEnumerable<string> mynames = new string[] { "Akhilesh","Sachin", "Minu", "Venkatesh" };

    IEnumerator<string> dataReader = mynames.GetEnumerator();
    while (dataReader.MoveNext())
    {
        Console.WriteLine(dataReader.Current);
    }

}
void CaseStudy3()
{
    var name = "venkatesh";
    Console.WriteLine(name.HelloRRD());

    var acc = new Account { Name = "venkatesh"};
    acc.PrintAccountDetails();
}

void CaseStudy1()
{
       Func<string, bool> isAlongName = CheckIfNameIsLong; //variables of delegate  //we using named funcion
    Console.WriteLine("This is CaseStudy1==>" + isAlongName("Venkat"));
}
bool CheckIfNameIsLong(string name)
{
    return name.Length > 8;
}

void CaseStudy2()  //we using lamda function without named function
{
    Func<string, bool> isLongName = (name) => name.Length > 8;
    Console.Write("This is CaseStudy2 ==> ");
    Console.WriteLine(isLongName("Venkatesh"));

    Action<int, int> add = (n1, n2) =>     //Function inside function--Casestudy2 is one function and we using another inline lamda function
    {
        Console.WriteLine("Inside add procedure");
        Console.WriteLine($"Addition result is {n1 + n2}");
    };
    //Console.WriteLine(add(10,20));  //this will not work because Action not return values so we can't put like this..
    add(10,20);
    Predicate<int> isEven = (n) => n%2 == 0;  //Preditcate will return bool value so its work
    Console.WriteLine(isEven(10));
    //Predicate<int> isEven 
}
