using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using AssemblyA;

[assembly: InternalsVisibleTo("AssemblyB")]

namespace AssemblyA
{
    internal class MyClass
    {
        internal int internalField = 58;

        internal void DisplayInternalField()
        {
            Console.WriteLine("Internal Field from Assembly A: " + internalField);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        Console.WriteLine("Accessing Internal Field from Assembly B: " + myObject.internalField);
        myObject.DisplayInternalField();
    }
}
