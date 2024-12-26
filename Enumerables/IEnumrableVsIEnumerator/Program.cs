
///IENumberable  Demo 
///

//Ietrating using IEnumerable 
Console.WriteLine("\nIENumberable  Demo with Comaring IEnumerator \n");
List<int> years = new List<int> { 1999, 2000, 3000, 2001, 2003, 2002, 2004, 2205 };

IEnumerable<int> ienum = (IEnumerable<int>)years;
Console.WriteLine("\n using foreach and IEnumerable ");
foreach (var elem in ienum)
{
    Console.WriteLine(elem);
}


Console.WriteLine("\nusing Enumerator methods ");
//Ietrating using IEnumerator 

IEnumerator<int> enumerator = years.GetEnumerator();

while (enumerator.MoveNext())
{
    Console.WriteLine(enumerator.Current);
}
