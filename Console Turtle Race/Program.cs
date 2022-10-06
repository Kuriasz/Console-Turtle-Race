// See https://aka.ms/new-console-template for more information
using Console_Turtle_Race.Interfaces;
using Console_Turtle_Race.Services;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                .AddSingleton<ITurtleService, TurtleServiceImpl>()
                .BuildServiceProvider();
            var _turtleService = serviceProvider.GetService<ITurtleService>();

            Console.WriteLine("Welcome to Turtle Race!");

            int numOfTurtles = _turtleService.GetNumberOfTurtles();


            
        }
    }
}


