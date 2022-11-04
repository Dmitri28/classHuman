using System;
using System.Collections.Generic;
using System.Text;

namespace classHuman
{
    class Woman: Human
    {
        private String name;
        private int age;
        public void setName(String name)
        {
            this.name = name;
        }
        public String getName()
        {
            return name;
        }
        public void setAge(int age)
        {
            this.age = age;
        }
        public int getAge()
        {
            return age;
        }
        public  override void  genus()
        {
           
            {
                int g = 1;
                int h = 2;
                switch (g)
                {
                    case 1:
                        Console.WriteLine("Woman is running");
                        break;

                    case 2:
                        Console.WriteLine("Man is running");
                        break;


                }
            }

        }
    }
    }

