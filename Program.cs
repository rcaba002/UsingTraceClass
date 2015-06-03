using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTraceClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 2, c = 3;

            Trace.WriteLine("Trace Information-Product Starting");
            Trace.Indent();

            Trace.WriteLine("The value of a is " + a.ToString());
            Trace.WriteLine("The value of b is " + b.ToString());
            Trace.WriteLine("The value of c is " + c.ToString());

            Trace.WriteLine("The value of a is " + a.ToString(), "Test");
            Trace.WriteLine("The value of b is " + b.ToString(), "Test");
            Trace.WriteLine("The value of c is " + c.ToString(), "Test");

            Trace.WriteLineIf(a < 5, "This message will appear in the output box.");
            Trace.WriteLineIf(a > 2, "This message will not appear.");

            Trace.Assert(a < 5, "This message will appear in the output box.");
            Trace.Assert(a < 2, "This message will not appear.");

            TextWriterTraceListener tr1 = new TextWriterTraceListener(System.Console.Out);
            Trace.Listeners.Add(tr1);
            TextWriterTraceListener tr2 = new TextWriterTraceListener(System.IO.File.CreateText("Output.txt"));
            Trace.Listeners.Add(tr2);

            Trace.WriteLine("The value of a is " + a.ToString());
            Trace.WriteLine("The value of b is " + b.ToString());
            Trace.WriteLine("The value of c is " + c.ToString());

            Trace.Unindent();
            Trace.WriteLine("Trace Information-Product Ending");

            Trace.Flush();
            Console.ReadKey();
        }
    }
}