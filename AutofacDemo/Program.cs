﻿using System;
using Autofac;

namespace AutofacDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var container =ContainerConfig.Configure();
            using (var scope=container.BeginLifetimeScope())
            {
                var app = scope.Resolve<IApplication>();
                app.Run();
            }
            Console.ReadKey();
        }
    }
}
