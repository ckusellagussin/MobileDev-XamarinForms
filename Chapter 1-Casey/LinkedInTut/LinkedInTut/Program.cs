using System;
using System.Collections.Generic;

namespace LinkedInTut
{
    class Data
    {


    }


    class Program  
    {



        static void Main(string[] args)
        {
            exc3();


     
        }


        static void Import()
        {
            var importedStudent = new Student("Jenny", 86, "Birthday", "Address", 123556);
            Console.WriteLine(importedStudent.name);

        }

      


        public static void exc4()
        {

                    

            Console.WriteLine("How many years of experience do you have?");
            var years = int.Parse(Console.ReadLine());
            switch (years)
            {

                case 0:
                    Console.WriteLine("Inexperienced");
                break;
                
                case 1:
                    Console.WriteLine("Junior");
                    break;
                case 2:
                    Console.WriteLine("Experienced");
                    break;
                case 3:
                    Console.WriteLine("Advanced");
                    break;
                default:
                    Console.WriteLine("Senior");
                    break;
            }



        }




       static void exc3()
        {
          

            var students = new List<Student>();
          

            var adding = true;

            while(adding)
            {
                var newStudent = new Student();

                newStudent.name = Util.Console.ask("Student Name: ");              
               
                newStudent.grade = int.Parse(Util.Console.ask("Student Grade: "));
                
                newStudent.birthday = Util.Console.ask("Student Birthday: ");
           
                newStudent.address = Util.Console.ask("Student Address: "); 

                newStudent.Phone= int.Parse(Util.Console.ask("Student Phone Number: "));


                students.Add(newStudent);
                Student.Count++;
                Console.WriteLine("Student Count: {0}", Student.Count);

                Console.WriteLine("Add another? Yes/No");
            
                
                
                if(Console.ReadLine() != "Yes")
                    {
                    adding = false;


                    }


            }


            foreach (var student in students)
            {         

                Console.WriteLine("Name: {0}, Grade: {1}", student.name, student.grade);

            }
           


                static void exc2()
        {


            for (int i = 1; i <=5; i++)
            {



                for (int e = 1; e <= 10; e++)
                {
                    Console.WriteLine(e);


                }

                for (int a = 10; a >= 1; a--)
                {
                    Console.WriteLine(a);

                }

            }

        }

      
        static void exc1()
            {

                var code = "";

                while (code != "Dude")
                {

                    Console.WriteLine("What is the Passcode");
                    var q = tryAnswer();


                    if (q == "Dude")
                    {
                        code = "Dude";


                    }

                    else if (q == "")
                    {
                        tryAnswer();

                    }


                    else if (q != "Dude")
                    {
                        Console.WriteLine("Not the passcode");

                    }




                    if (code == "Dude")
                    {

                        Console.WriteLine("You are allowed to carry on");

                        Console.WriteLine("What is your name?");

                        var Name = tryAnswer();

                        Console.WriteLine("How old are you?");
                        var Age = tryAnswer();

                        Console.WriteLine("What month were you born in");
                        var Month = tryAnswer();


                        Console.WriteLine("Your Name is: {0}", Name);
                        Console.WriteLine("Your birth month is: {0}", Month);
                        Console.WriteLine("Your Age is: {0}", Age);

                        if (Month == "March")
                        {
                            Console.WriteLine("You are an Aries");


                        }

                        else if (Month == "April")
                        {
                            Console.WriteLine("You are a Taurus");


                        }

                    }
                }


                static string tryAnswer()
                {
                    var Answer = Console.ReadLine();
                    if (Answer == "")
                    {
                        Console.WriteLine("You didn't write anything");
                        return Console.ReadLine();

                    }
                    return Answer;
                }


            }

        }

        }
     


}




class Member
{
    public string name;
    public int grade;
    public string address;
    protected int phoneNumber;

    public int Phone
    {

        set { phoneNumber = value; }
    }

}


class Student:Member
{

    public int grade;
    public string birthday;
 

 

    public Student(string Name, int Grade, string Birthday, string Address, int Phone)
        {
        name = Name;
        grade = Grade;
        birthday = Birthday;
        address = Address;
        phoneNumber = Phone;


        }

    public Student()
    {


    }


    static public int Count = 0;


}

class Teacher:Member
{

   
    public string Subject;


}
