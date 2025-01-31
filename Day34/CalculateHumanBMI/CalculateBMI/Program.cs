using CalculateBMICommonLib.Models;
using System.Collections;

namespace CalculateBMI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var human = new ArrayList();
            


                var person1 = new HumanBeing("Venkat", 35, "Male", 70, 7);
                var person2 = new HumanBeing("Sachin", 24, "male", 45, 5);
                //var person3 = new HumanBeing("Prem", 30, "Male", 50, 9);
                var person4 = new HumanBeing("Jaya", 30, "Female", 65, 5.8);
                var person5 = new HumanBeing("Shalini", 32, "Female", 60, 5.7);
            try
            {
                human.Add(person1);
                human.Add(person2);
                //human.Add(person3);
                human.Add(person4);
                human.Add(person5);
            }

            //try
            //{
            //    human.Add(new HumanBeing("Venkat", 35, "Male", 70, 7));
            //    human.Add(new HumanBeing("Prem", 30, "Male", 50, 9));
            //    human.Add(new HumanBeing("Shalini", 32, "Female", 60, 5.7));
            //    human.Add(new HumanBeing("Jaya", 30, "Female", 65, 5.8));
            //}
            catch (NotARightHeightException ex)
            //catch (Exception ex2) 
            {
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }

            }
            PrintDetails(human);
            Console.WriteLine($"\nBefore Eat or Workout\n======================");
            CheckEatWorkOut(person4);
            CheckEatWorkOut(person5 );
            Console.WriteLine($"\nAfter Eat or Workout\n=======================");
            person4.Eat();
            person5.WorkOut();
            CheckEatWorkOut(person4);
            CheckEatWorkOut(person5);
            Console.WriteLine("End Main");
        }

        public static void PrintDetails(ArrayList listOfHuman)
        {
            Console.WriteLine("Displaying the BMI and BodyStructure for the Humans\n==================================================");
            foreach (var person in listOfHuman)
            {
                HumanBeing human = (HumanBeing)person;  
                Console.WriteLine($"\nName: {human.Name} || Age: {human.Age} || Gender : {human.Gender} || Weight : {human.Weight} || Height : {human.Height} ==> BMI : {human.BMI()} ==> BodyStructure : {human.GetBodyStructure()}");
            }

        }
        public static void CheckEatWorkOut(HumanBeing human)
        {
            Console.WriteLine($"\nName: {human.Name} Age: {human.Age} Gender : {human.Gender} Weight : {human.Weight} Height : {human.Height} BMI : {human.BMI()} BodyStructure : {human.GetBodyStructure()}"); 
        }
    }
}
