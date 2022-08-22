using AllOopsConcept.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AllOopsConcept.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiOopsController : ControllerBase
    {
        //Inheritance
        [HttpGet, Route("forstudent1")]

        // Single
        public string StudentDetails1()
        {

            Student1 student1 = new();
            student1.ID = 1;
            student1.Name = "Shiv";
            student1.Email = "shiv@gmail.com";
            student1.Marks = 300;

            return ("\n Id :" + student1.ID +
                "\n Name :" + student1.Name +
                "\n Email :" + student1.Email +
                "\n Marks :" + student1.Marks);

        }
        [HttpGet, Route("forstudent2")]

        // Multi
        public string StudentDetails2()
        {
            Student2 student2 = new();
            student2.ID = 2;
            student2.Name = "Shiv";
            student2.Email = "shiv@gmail.com";
            student2.Marks = 300;
            student2.CollegeName = "DU";

            return ("\n Id :" + student2.ID +
                "\n Name :" + student2.Name +
                "\n Email :" + student2.Email +
                "\n Marks :" + student2.Marks +
                "\n College Name :" + student2.CollegeName);

        }
        [HttpGet, Route("forstudent3")]

        // Hierarchical
        public string StudentDetails3()
        {
            Student3 student3 = new();
            student3.ID = 3;
            student3.Name = "Shiv";
            student3.Email = "shiv@gmail.com";
            student3.Subject = "Computer Science";

            return ("\n Id :" + student3.ID +
                "\n Name :" + student3.Name +
                "\n Email :" + student3.Email +
                "\n Subject :" + student3.Subject);

        }

        [HttpGet, Route("forallstudent")]
        public string StudentDetails()
        {
            Student1 student1 = new();
            student1.ID = 1;
            student1.Name = "Shiv";
            student1.Email = "shiv@gmail.com";
            student1.Marks = 300;


            Student2 student2 = new();
            student2.ID = 2;
            student2.Name = "Shiv";
            student2.Email = "shiv@gmail.com";
            student2.Marks = 300;
            student2.CollegeName = "DU";


            Student3 student3 = new();
            student3.ID = 3;
            student3.Name = "Shiv";
            student3.Email = "shiv@gmail.com";
            student3.Subject = "Computer Science";

            return ("Id :" + student1.ID +
                "\n Name :" + student1.Name +
                "\n Email :" + student1.Email +
                "\n Marks :" + student1.Marks +
                "\n Id :" + student2.ID +
                "\n Name :" + student2.Name +
                "\n Email :" + student2.Email +
                "\n Marks :" + student2.Marks +
                "\n College Name :" + student2.CollegeName +
                "\n Id :" + student3.ID +
                "\n Name :" + student3.Name +
                "\n Email :" + student3.Email +
                "\n Subject :" + student3.Subject);
        }

        // Class and Object 
        [HttpGet, Route("forclassobject")]
        public string ClassObject()
        {
            ClassObject classObject = new();
            classObject.Employee(123, "Sunder", "sunder@gmail.com", "xyz", "9635264512");
            return classObject.GetEmployee();
        }


        // Constructor

        [HttpGet, Route("forconstructor")]
        public string Constructor()
        {
            // Default
            ConstructorClass constructorClass = new();

            // Parameterized
            ConstructorClass constructorClass1 = new ConstructorClass("Priti", 502, "AP", "Kashi Mira (Mumbai, Maharashtra)", "7896532145");

            // Copy
            ConstructorClass constructorClass2 = new ConstructorClass(constructorClass1);

            // Static 

            return (/*Default*/"Default" + "\n Name :" + constructorClass.Name +
                "\n Id :" + constructorClass.Id +
                "\n College Name :" + constructorClass.CollegeName +
                "\n Adderess :" + constructorClass.Adderess +
                "\n Phone number :" + constructorClass.PhoneNmber +
                /* Parameterized*/ "\nParameterized " + "\n" + constructorClass1.GetDetails()
                 +/* Copy*/ "\nCopy " + "\n" + constructorClass2.GetDetails() +
                 /* Static*/ "\nStatic " + "\n" + ConstructorClass.GetDetailsStatic());
        }

        //Polymorphism

        [HttpGet, Route("formethodoverloading")]

        //Method Overloading
        public string StudentDetailss()
        {
            UserInformationClass1 userInformationClass = new();
            return (userInformationClass.Student1("Joun", "Maria") +
                " \n Second Data  :" + userInformationClass.Student1("Joun", "Maria", 12));
        }

        //Operator Overloading

        [HttpGet, Route("foroperatoroverloading")]
        public string OperatorOverloading()
        {
            OperatorOverloading operatorOverloading1 = new();
            operatorOverloading1.name = "Joun";
            operatorOverloading1.number = 200;

            OperatorOverloading operatorOverloading2 = new();
            operatorOverloading2.name = "Maria";
            operatorOverloading2.number = 200;

            OperatorOverloading? operatorOverloading3 = new();
            operatorOverloading3 = operatorOverloading1 + operatorOverloading2;
            return operatorOverloading3?.name + " \n" + operatorOverloading3?.number;
        }

        // Overring

        [HttpGet, Route("formethodoverrde")]
        //Method Overloading
        public string OverrideClass()
        {
            OverrdingClass1 overrdingClass1 = new();
            OverrdingClass2 overrdingClass2 = new();

            // Reference of child class
            // OverrdingClass1 overrdingClass3 = new OverrdingClass2();

            return overrdingClass1.Employee1() +
                " \n" + overrdingClass2.Employee1()
                /*+ " \n" + overrdingClass3.Employee1()*/;
        }

        // Abstract

        [HttpGet, Route("forabstract")]

        public string EmployeeDetails()
        {

            AbstractClass1 abstractClass1 = new AbstractClass1();
            abstractClass1.Name = "Vikash";
            abstractClass1.Id = 101;
            abstractClass1.Email = "viskash@gmail.com";
            abstractClass1.CompanyName = "OSP";
            abstractClass1.PhoneNumber = "7896589652";
            abstractClass1.Adderss = "Kandivali";

            AbstractClass2 abstractClass2 = new AbstractClass2();
            abstractClass2.Name = "Hemant";
            abstractClass2.Id = 101;
            abstractClass2.Email = "Hemant@gmail.com";
            abstractClass2.CompanyName = "OSP";
            abstractClass2.PhoneNumber = "7896589652";
            abstractClass2.Adderss = "Kandivali";
            abstractClass2.Salary = 789356.00f;

            return (/*Abstract Class 1*/"Employee1" + "\n Name :" + abstractClass1.Name +
          "\n Id :" + abstractClass1.Id +
          "\n Email :" + abstractClass1.Email +
          "\n Companay Name :" + abstractClass1.CompanyName +
          "\n Phone Number :" + abstractClass1.PhoneNumber +
          "\n Adderss :" + abstractClass1.Adderss +
          /*Abstract Class 2*/"\nEmployee2" + "\n Name :" + abstractClass2.Name +
          "\n Id :" + abstractClass2.Id +
          "\n Email :" + abstractClass2.Email +
          "\n Companay Name :" + abstractClass2.CompanyName +
          "\n Phone Number :" + abstractClass2.PhoneNumber +
          "\n Adderss :" + abstractClass2.Adderss);

        }

        //Interface 
        [HttpGet, Route("forinterface")]
        public string Get()
        {
            Student student = new();
            student.Id = 2;
            student.rollNo = 123;
            return student.Show() + "\n " + "\n" + ((IStudent1)student).Show() + student.Id+"\n"+student.rollNo;
        }
    }
}
