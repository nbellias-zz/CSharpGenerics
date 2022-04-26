// See https://aka.ms/new-console-template for more information
using CSharpGenerics.Products.Models;

Console.WriteLine("CSharpGenerics program\n");

Console.WriteLine(new Book("123-456-7890", "Elsevier", "890567", "Technical Book on Libs", "2022-01012T12:23:34Z"));
Console.WriteLine(new SmallAppliance { Name="Hair Dryer", Manufacturer="Braun", Make="Dry 230", SerNo="123", LOT="2019-10-08T12:34:20Z", SKU="52-0897"});