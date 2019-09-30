using System;

namespace excercises_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish MinFisk = new Fish();
            MinFisk.name = "Göte";
            Fish.Trick();
            Console.WriteLine("Min fisk heter: "+MinFisk.name);
            Console.WriteLine("Den är "+MinFisk.age);
        }
    }
}