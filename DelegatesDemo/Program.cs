using System;
using DelegatesDemo;
using Entities;

Console.WriteLine("Hello, World!");
Demo();
static void Demo()
{
    
    DelegatesExample.SimpleDelegate();
    DelegatesExample.MultiCastDelegate();
    DelegatesExample.MutlipleMethodReturnTypeDemo();
    EventsExample.Run();
}
