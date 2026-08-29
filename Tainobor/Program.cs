using System;
using Tainobor.Game; 

namespace Tainobor;

internal static class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        GameLoop.Start();
    }
}