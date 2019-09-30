using System;
namespace excercises_classes{
    public class Fish
    {


        private string Name = "";
        public string name{
            get{
                return Name;
            }
            set{
                Name = value;
            }
        }
        public string race;
        public int age;
        public static void Trick(){
            Console.WriteLine("...");
        }
        public static void Speak(){
            Console.WriteLine("...");
        }
    }
}