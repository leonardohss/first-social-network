﻿using System;
using SocialNetwork.Entities;

namespace SocialNetwork
{
    class Program
    {
        static void Main(string[] args)
        {

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zeland",
                "I'm going to visit this wonderful country!",
                12
                );


            Comment c1 = new Comment("Have a nice trip");
            p1.AddComment(c1);
            Comment c2 = new Comment("Wow that's awesome!");
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow", 
                5);

            Comment c3 = new Comment("Good night");
            p2.AddComment(c3);
            Comment c4 = new Comment("May the force be with you");
            p2.AddComment(c4);

            Console.WriteLine(p1);
            Console.WriteLine();
            Console.WriteLine(p2);
        }
    }
}
