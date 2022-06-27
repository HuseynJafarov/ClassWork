using ClassWork_Namespace_DLL_AccessModifiers_.Data;
using ClassWork_Namespace_DLL_AccessModifiers_.Models;
using Domain.Models;
using System;
using System.Reflection;


namespace ClassWork_Namespace_DLL_AccessModifiers_
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Person person = new Person();
            //Teacher teacher = new Teacher(55,"name",52);
            //person.name = "Jafarov";
            //teacher.surname = "Jafarov";
            //Console.WriteLine(teacher.name);
            //teacher.age = 52;

            //person.name = "Huseyn";

            //typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).SetValue(person, "Jafarov");



            // var personSurname = typeof(Person).GetField("surname", BindingFlags.NonPublic | BindingFlags.Instance).GetValue(person);

            //Console.WriteLine(personSurname);

            Car car = new Car();
            car.HorsePower = 99;
            Console.WriteLine(car.HorsePower);

            Animal animal = new Animal();
            Context context = new Context();
            Book book = new Book();
            
        }
    }
}
