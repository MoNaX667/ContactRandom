using System;
using System.IO;

namespace contactRandomListCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "ContactList.txt";
            RandomContactListCreator creator = new RandomContactListCreator();

            File.WriteAllLines(filename, creator.CreateContactList(100));

            Console.Write("Creating ... secceed.... press any key to exit");
            Console.ReadKey();
        }
    }
}
