using System;
using System.Collections.Generic;

namespace Hw_01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Profile> listOfUsers = new List<Profile>()
        {
        new Profile() { firstName = "John Doe",secondName = "Dactorov", Age = 42 },
        };

            for (int i = 0; i < listOfUsers.Count; i++)
            {
                Console.WriteLine(listOfUsers[i].firstName + " is " + listOfUsers[i].secondName + "is" + listOfUsers[i].Age + " years old");
            }
            Console.ReadKey();

        }
    }
}
