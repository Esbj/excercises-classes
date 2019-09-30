using System;
namespace excercises_classes{
    public class Fish
    {
        public Fish(){
            age = 0;
        }

        private string Name = "";
        public string name{
            get{
                return Name;
            }
            set{
                Name = value;
            }
        }
        public int age;
        public string race;
        public static void Trick(){
            Console.WriteLine("...");
        }
        public static void Speak(){
            Console.WriteLine("...");
        }
    }
}