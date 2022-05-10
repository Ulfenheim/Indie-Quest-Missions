using System;
using System.Collections.Generic;


namespace Lists_practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new List<string> { "Harry", "Willow", "Gallahad", "Alucard", "William" };
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            names.Insert(0, "Duke");
            names.Remove("Harry");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();


            names.RemoveAt(3);
            names.Insert(3, "Lara");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            names.RemoveAt(names.Count - 1);
            names.Add("Aaron");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            names.Sort();
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            names.Reverse();
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            Console.WriteLine(names.Contains("Duke"));
            Console.WriteLine();

            var index = names.IndexOf("Aaron");
            Console.WriteLine(index);
            Console.WriteLine();

            names.Insert(0, "Mario");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();

            names.Insert(3, "Luigi");
            Console.WriteLine(string.Join(", ", names));
            Console.WriteLine();


            /*
            //copy the list
            var namesCopy = new List<string>(names);

            //add duplicates into original list
            int insertionIndex = 0;

            foreach (string name in namesCopy)
            {
                names.Insert(insertionIndex, name);
                insertionIndex += 2;
            }

           
            
            //copy the list
            var namesCopy = new List<string>(names);

            //add duplicates into original list
            

            for (int i = 0; i < namesCopy.Count; i++)
            {
                int insertionIndex = i * 2;
                string name = namesCopy[i];
                names.Insert(insertionIndex, name);
            }


            int count = names.Count;

            for (int i = 0; i < count; i++)
            {
                int insertionIndex = i * 2;
                int readIndex = i * 2;
                string name = names[readIndex];
                names.Insert(insertionIndex, name);
            }

            

            for (int i = 0; i < names.Count; i += 2)
            {
                string name = names[i];
                names.Insert(i, name);
            }
            */


            for (int i = 0; i < names.Count; i += 2)
            {
                names.Insert(i, names[i]);
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", names));

            /*
            string temp = names[0];
            names[0] = names[names.Count - 1];
            names[names.Count - 1] = temp;
            */

            //swap places of two names
            (names[0], names[names.Count - 1]) = (names[names.Count - 1], names[0]);

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", names));


            names.RemoveAt(4);

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", names));

            names.Remove("Mario");

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", names));

            Console.WriteLine();
            Console.WriteLine(names.LastIndexOf("Duke"));

            names.RemoveAt(names.LastIndexOf("Aaron"));
            Console.WriteLine();
            Console.WriteLine(string.Join(", ", names));


            //Look at a name
            //if the following name is equal, remove both
            //if not equal, it stays
            //do this for the whole list

            int compareIndex = 0;

            while (compareIndex < names.Count - 1)
            {
                if (names[compareIndex] == names[compareIndex + 1])
                {
                    names.Remove(names[compareIndex]);
                    names.Remove(names[compareIndex]);
                }
                else
                {
                    compareIndex++;
                }
            }

            Console.WriteLine();
            Console.WriteLine(string.Join(", ", names));

            names.Clear();

            Console.ReadKey(true);
        }
    }
}
