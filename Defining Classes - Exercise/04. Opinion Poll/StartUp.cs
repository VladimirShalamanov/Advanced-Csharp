﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var listOfPeople = new List<Person>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                listOfPeople
                    .Add(new Person(input[0],
                    int.Parse(input[1])));
            }

            var sortedListOfPeople = listOfPeople.Where(p => p.Age > 30).OrderBy(p => p.Name);

            foreach (var person in sortedListOfPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }
        }
    }
}
