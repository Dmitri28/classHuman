using System;

namespace classHuman
{
    class Program
    {
        static void Main(string[] args)
        {
            Man man = new Man();
            Woman wm = new Woman();
           
            wm.setName("Liza");
            wm.setAge(27);
            man.setName("John");
            man.setAge(45);
            Console.WriteLine(man.getName());
            Console.WriteLine(man.getAge());
            Console.WriteLine(wm.getName());
            Console.WriteLine(wm.getAge());
            man.genus();
            wm.genus();

        }
    }
}
