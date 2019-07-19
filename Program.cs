using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("datetime is " + DateTime.Now);
            //var c1 = new HelloWorld.MyClass();
            Console.WriteLine($"Hello World! {new HelloWorld.MyClass().ReturnMessage()}");

            var lines = ReadFrom("sampleQuotes.txt");
            foreach(var line in lines) {
                //Console.WriteLine(value: line);
            }

            Console.WriteLine();

            foreach(var i in ComputeAges()) {
                Console.WriteLine(i);
            }
        }

    	static IEnumerable ComputeAges() {
            yield return 2;
            yield return 21;
            
            for(int i = 22; i < 32; i++) {
                yield return i;
            }
        }

        static IEnumerable<string> ReadFrom(string file)
        {
            string line;
            using (var reader = File.OpenText(file))
            {
                while ((line = reader.ReadLine()) != null)
                {
                    yield return line;
                }
            }
        }
    }
}
