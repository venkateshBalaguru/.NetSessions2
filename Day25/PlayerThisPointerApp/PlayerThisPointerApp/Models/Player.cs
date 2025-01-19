using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerThisPointerApp.Models
{
    class Player
    {
        //Instance variables
        private string name; //we intentionally made these fields name (instance variable) and local variable name same to show the use of this keyword
        private int age;
        private int id;
        private const int MIN_AGE = 18;

        //public Player(string name, int age, int id)
        //{
        //    name = name;
        //    age = age;
        //    id = id;
        //    Console.WriteLine("Name: " + name + " Age: " + age + " Id: " + id); This will print the local variable value but the instance varibale remains the same null values
        //}
        public Player(int id, string name, int age) //if we use this keywork it will identify the variable is from instance
        {
            this.id = id;
            this.name = name;
            this.age = age;

            Console.WriteLine("player created");
        }


        //public Player(string name, int id)
        //{
        //    this.name = name;
        //    this.age = MIN_AGE;// we assigning the age to default value MIN_AGE
        //    this.id = id;
        //}
         //Instead of above lines we doing the Constructor chaining it will invoke from the main constructor 


        //constructor chaining
        public Player(int id, string name) : this(id, name, MIN_AGE)
        {

        }
        public Player WhoIsElder(Player secondPlayer) //In this method the return type is class the return value is from the object
        {

            //Player x;x expects an object of Player class

            //if (this.age == secondPlayer.age)
            //{
            //    return null;  // if the value return null means it will  throw null system error
            //}

            //return secondPlayer.age > this.age ? secondPlayer : this;
            if (this.age > secondPlayer.age)
            {
                return this;
            }
            else
            {
                return secondPlayer;
            }


        }

        public int Id
        {
            get { return id; }
        }
        public int Age
        {
            get { return age; }
        }
        public string Name
        {
            get { return name; }
        }


    }
}

