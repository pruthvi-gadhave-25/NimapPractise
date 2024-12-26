
namespace IEnumerableDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {

            ///IENUMERABLE  demo 
            Console.WriteLine("\n IENUMERABLE  demo \n");
            List<int> list = new List<int> { 1, 2, 3, 4 };

            IEnumerable<int> evenList = list.Where(n => n % 2 == 0);

            foreach (int i in evenList)
            {
                Console.Write(i+ " , ");
            }

            ///IQuerayble   demo 
            ///
            Console.WriteLine("\n IQuerayble  demo \n");
            List<FamousPerson> famousPeople =
                [
                    new FamousPerson(1, "Sandy Cheeks", false),
                    new FamousPerson(2, "Tony Stark", true),
                    new FamousPerson(3, "Captain Marvel", true),
                    new FamousPerson(4, "Captain America", true),
                    new FamousPerson(5, "SpongeBob SquarePants", false),
                    new FamousPerson(6, "Hulk", false)
                ];

         
            //AsQuerayble coverts IEnumerable to IQuerayble i.e. from Sytem.Collections.IEnumerable .System.Linq.Iqerayble
            //converting list into IQuerayble and applying filter 

            IQueryable<FamousPerson> famousAndCanFly  = famousPeople.AsQueryable().Where(x => x.isFamous);


            foreach(var elem in famousAndCanFly)
            {
                Console.WriteLine(elem.Name.ToString() );
            }






            
        }
    }
}


//ref link for -- IQueayble demo https://dev.to/rasheedmozaffar/understanding-iqueryable-in-c-4n37