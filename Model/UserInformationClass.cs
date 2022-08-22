namespace AllOopsConcept.Model
{
    public class UserInformationClass
    {
        public string? Name { get; set; }
        public string? Email { get; set; }

        public int ID { get; set; }
    }

    public class Student1 : UserInformationClass
    {
        public int Marks { get; set; }
    }
    public class Student2 : Student1
    {
        public string? CollegeName { get; set; }

    }
    public class Student3 : UserInformationClass
    {
        public string? Subject { get; set; }

    }

    // Class and object
    public class ClassObject
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CompanyName { get; set; }
        public string? PhoneNumber { get; set; }
        public void Employee(int Id, string Name, string Email, string CompanyName, string PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.CompanyName = CompanyName;
            this.PhoneNumber = PhoneNumber;

        }
        public string GetEmployee()
        {
            return ("Id :" + Id + "\n Name :" + Name + "\n Email :" + Email + "\n Company Name :" + CompanyName + "\n PhoneNumber :" + PhoneNumber);
        }
    }

    //Constructor Concept

    public class ConstructorClass
    {
        // Static Variable
        public static String Name_ { get; set; }
        public static int Id_ { get; set; }
        public static string College_Name { get; set; }
        public static string Adderess_ { get; set; }
        public static string PhoneNmber_ { get; set; }

        // Instance Variable
        public String Name { get; set; }
        public int Id { get; set; }
        public string CollegeName { get; set; }
        public string Adderess { get; set; }
        public string PhoneNmber { get; set; }

        // Default
        public ConstructorClass()
        {
            Name = "Joun";
            Id = 501;
            CollegeName = "SMS";
            Adderess = "Uttar Pradesh";
            PhoneNmber = "7896542315";
        }
        // Parameterized
        public ConstructorClass(string name, int id, string collegeName, string adderess, string phoneNumber)
        {
            this.Name = name;
            this.Id = id;
            this.Id = id;
            this.CollegeName = collegeName;
            this.Adderess = adderess;
            this.PhoneNmber = phoneNumber;
        }
        public string GetDetails()
        {
            return (" Name :" + Name + "\n Id :" + Id + "\n College Name :" +
                           CollegeName + "\n Adderess :" + Adderess + "\n Phone number :" + PhoneNmber);
        }

        // Copy 
        public ConstructorClass(ConstructorClass constructorClass2)
        {
            this.Name = constructorClass2.Name;
            this.Id = constructorClass2.Id;
            this.CollegeName = constructorClass2.CollegeName;
            this.Adderess = constructorClass2.Adderess;
            this.PhoneNmber = constructorClass2.PhoneNmber;
        }

        //Static
        static ConstructorClass()
        {
            Name_ = "Maria";
            Id_ = 503;
            College_Name = "SMS";
            Adderess_ = "Uttar Pradesh";
            PhoneNmber_ = "7896542315";
        }
        public static string GetDetailsStatic()
        {
            return (" Name :" + Name_ + "\n Id :" + Id_ + "\n College Name :" +
                            College_Name + "\n Adderess :" + Adderess_ + "\n Phone number :" + PhoneNmber_);
        }

    }


    //Polymorphism


    //Method Overloading
    public class UserInformationClass1
    {
        public string Student1(string firstName, string lastName)
        {

            return (firstName + " " + lastName);
        }
        public string Student1(string firstName, string lastName, int id)
        {
            return (firstName + " " + lastName + "\n Id :" + id);
        }
    }
    // Operator Overloading

    public class OperatorOverloading
    {
        public string? name;

        public int number;
        public static OperatorOverloading? operator +(OperatorOverloading operatorOverloading1, OperatorOverloading operatorOverloading2)
        {
            OperatorOverloading operatorOverloading3 = new();
            operatorOverloading3.name = operatorOverloading1.name + " " + operatorOverloading2.name;
            operatorOverloading3.number = operatorOverloading1.number + operatorOverloading2.number;
            return operatorOverloading3;
        }

    }


    //  Overrding

    public class OverrdingClass1
    {
        public virtual string Employee1()
        {
            return "Employee 1";
        }

    }
    public class OverrdingClass2 : OverrdingClass1
    {
        public override string Employee1()
        {
            return "Employee 2";
            // return base.Employee1() +"\n"+"Employee 2";
        }
    }

    // Abstract

    public abstract class AbstractClass
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CompanyName { get; set; }
        public string? PhoneNumber { get; set; }
        public abstract string Employee();

    }
    public class AbstractClass1 : AbstractClass
    {
        public string? Adderss { get; set; }
        public override string Employee()
        {
            return (" Name :" + Name + "\n Id :" + Id + "\n Company Name :" + CompanyName + "\n Phone Number :" + PhoneNumber + "\n Adderss :" + Adderss);
        }
    }
    public class AbstractClass2 : AbstractClass
    {
        public string? Adderss { get; set; }
        public float Salary { get; set; }
        public override string Employee()
        {
            return (" Name :" + Name + "\n Id :" + Id + "\n Company Name :" + CompanyName + "\n Phone Number :" + PhoneNumber + "\n Adderss :" + Adderss + "\n Salary :" + Salary);
        }
    }

    //Interface
    interface IStudent
    {
        public int Id { get; set; }
        public abstract string Show();

    }
    interface IStudent1
    {
        public string Name { get; set; }
        public abstract string Show();

    }
    public class StudentData
    {
        public int rollNo { get; set; }
    }
    public class Student : StudentData,IStudent, IStudent1
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public int rollNo { get; set; }

        string IStudent1.Name
        {
            set
            {
                this.Name = value;
            }
            get
            {
                return this.Name;
            }
        }


        int IStudent.Id
        {
            set
            {
                this.Id = value;
            }
            get
            {
                return this.Id;
            }
        }
        // class
        int RollNo
        {
            set
            {
                this.rollNo = value;
            }
            get
            {
                return this.rollNo;
            }
        }
        public string Show()
        {
            return "aaa";
        }
        string IStudent1.Show()
        {
            return "bb";
        }
    }
}
