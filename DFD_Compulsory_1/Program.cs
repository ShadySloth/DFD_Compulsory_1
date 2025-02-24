// See https://aka.ms/new-console-template for more information

using DFD_Compulsory_1.Entities;
using Microsoft.Extensions.DependencyInjection;

using (var context = new SchoolContext())
{
    Console.WriteLine("Hello, World!");
    context.SaveChanges();
}