using Microsoft.AspNetCore.Mvc;

namespace ConditionLoopEvaluation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskEvaluationController : ControllerBase
    {
        //Condition Statement
        /*(A) Write a C# Sharp program to find whether a given year is a leap year or not.
        Test Data : 2016
        Expected Output :
        2016 is a leap year.*/
        [HttpGet, Route("forleapyear")]
        public string LeapYear(int year)
        {
            string leapYear = " ";
            if (year % 100 != 0)
            {
                if (year % 4 == 0)
                {
                    leapYear = $"{year} is a Leap Year";
                }
                else
                {
                    leapYear = $"{year} is not Leap Year";
                }
            }
            else
            {
                if (year % 400 == 0)
                {
                    leapYear = $"{year} is a Leap Year";
                }
                else
                {
                    leapYear = $"{year} is not Leap Year";
                }

            }
            return leapYear;
        }
        /*(B) Write a C# Sharp program to read the value of an integer m and display the value of n is 1 when m is larger than 0, 0 when m is 0 and -1 when m is less than 0.
          Test Data : -5
          Expected Output:
          The value of n = -1
        */

        [HttpGet, Route("formintger")]
        public string MIntger(int m)
        {
            string mInput = " ";
            if (m > 0)
            {
                mInput = "n is 1";
            }
            else if (m == 0)
            {
                mInput = "n is 0";
            }
            else
            {
                mInput = "The value of n = -1 ";
            }
            return mInput;
        }
        /*(C) Write a C# Sharp program to accept the height of a person in centimeter and categorize the person according to their height.
          Test Data : 135
          Expected Output :
           The person is Dwarf.
       */

        [HttpGet, Route("forheight")]
        public string CheckHeight(int heightCentimeter)
        {
            string height = " ";
            if (heightCentimeter == 135)
            {
                height = "The person is Dwarf.";
            }
            return height;
        }
        /* (D) Write a C# Sharp program to find the eligibility of admission for a professional course based on the following criteria
           Marks in Maths >=65
           Marks in Phy >=55
           Marks in Chem>=50
           Total in all three subject >=180
           or
           Total in Math and Subjects >=140
           Test Data :
           Input the marks obtained in Physics :65
           Input the marks obtained in Chemistry :51
           Input the marks obtained in Mathematics :72
           Expected Output :
           The candidate is eligible for admission.*/
        [HttpGet, Route("foraddmission")]
        public string CheckAddmissionEligibility(int physicsNumber, int chemistryNumber, int mathsNumber)
        {
            string admission = " ";
            if (mathsNumber >= 65 && physicsNumber >= 55 && chemistryNumber >= 50)
            {
                int totalNumber = mathsNumber + physicsNumber + chemistryNumber;
                if (totalNumber >= 180)
                {
                    admission = " The candidate is eligible for admission.";
                }
            }
            return admission;
        }
        /* 
        (E) Write a C# Sharp program to read roll no, name and marks of three subjects and calculate the total, percentage and division.
        Test Data :
        Input the Roll Number of the student :784
        Input the Name of the Student :James
        Input the marks of Physics, Chemistry and Computer Application : 70 80 90
        Expected Output :
        Roll No : 784
        Name of Student : James
        Marks in Physics : 70
        Marks in Chemistry : 80
        Marks in Computer Application : 90
        Total Marks = 240
        Percentage = 80.00
        Division = First
        */
        [HttpGet, Route("forstudent")]
        public string StudentInput(int rollNumber, string name, int physicsNumber, int chemistryNumber, int computerAplication)
        {
            string studentInput = " ";

            int totalMarks = physicsNumber + chemistryNumber + computerAplication;
            float percentage = (totalMarks / 3) ;
            if (percentage >= 80)
            {
                studentInput = "First";
            }

            return " Roll No : " + rollNumber + "\n Name of Student : " + name + "\n Marks in Physics :" + physicsNumber + "\n Marks in Chemistry :" + chemistryNumber + "\n Marks in Computer Application :"
              + computerAplication + "\n Total Marks =" + totalMarks + "\n Percentage = " + percentage + "\n Division = " + studentInput;
        }
        /* (F)Write a C# Sharp program to read temperature in centigrade and display a suitable message according to temperature state below :
        Temp < 0 then Freezing weather
        Temp 0-10 then Very Cold weather
        Temp 10-20 then Cold weather
        Temp 20-30 then Normal in Temp
        Temp 30-40 then Its Hot
        Temp >=40 then Its Very Hot
        Test Data :
        42
        */
        [HttpGet, Route("fortemperature")]
        public string TemperatureCentigade(int temperatureCentigrade)
        {
            string temperature = " ";
            if (temperatureCentigrade < 0)
            {
                temperature = "Freezing weather";
            }
            else if (temperatureCentigrade < 10)
            {
                temperature = "Very Cold weather";
            }
            else if (temperatureCentigrade < 20)
            {
                temperature = "Cold weather";
            }
            else if (temperatureCentigrade < 30)
            {
                temperature = " Normal in Temp";
            }
            else if (temperatureCentigrade < 40)
            {
                temperature = "Its Hot";
            }
            else
            {
                temperature = "Its Very Hot";
            }
            return temperature;
        }
        /*(G)Write a program in C# Sharp which is a Menu-Driven Program to compute the area of the various geometrical shape. 
        Test Data :
        Input your choice : 1
        Input radius of the circle : 5
        Expected Output :
        The area is : 78.500000
         */
        [HttpGet, Route("fortgeometric")]
        public string GeometricalCalculation(int enterChoiceNumber, double enterRadius = 0.0, double enterLength = 0.0, double enterWidth=0.0  )
        {
            string areaOf = " ";

            switch (enterChoiceNumber)
            {
                case 1:
                    double areaCircle = (enterRadius * enterRadius) * 3.14;
                    areaOf = Convert.ToString(areaCircle);
                    break;
                case 2:
                    double areaSquare = enterRadius * enterRadius;
                    areaOf = Convert.ToString(areaSquare);
                    break;
                case 3:
                   double areaCube = 6 * (enterRadius * enterRadius);
                    areaOf = Convert.ToString(areaCube);
                    break;
                case 4:
                    double areaSphere = 4 * 3.14 * (enterRadius * enterRadius);
                    areaOf = Convert.ToString(areaSphere);
                    break;
                case 5:
                    double areaHemisphere = 3 * 3.14 * (enterRadius * enterRadius);
                    areaOf = Convert.ToString(areaHemisphere);
                    break;
                case 6:
                    double areaRectangle = enterLength * enterWidth;
                    areaOf = Convert.ToString(areaRectangle);
                    break;
            }
            return " The area is  : " + areaOf;
        }

        // 2.LOOPS ( FORLOOP | WHILE LOOP | FOREACH )/

        /*(A) Write logic which will return even numbers from 0 to 100 */

        [HttpGet, Route("foreven")]
        public IActionResult CheckEvenNumber()
        {
            List<int> numbers = new();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    numbers.Add(i);
                    Console.WriteLine(i);
                }
            }
            return Ok(numbers);
        }

        /*(B)Write logic to show the sum and average of 1 to 10 numbers using for loop */

        [HttpGet, Route("forsumaverage")]
        public string SumAverage()
        {
            string data = " ";
            string data1 = " ";
            int sum = 0;
            int average;
            for (int i = 1; i <= 10; i++)
            {
                sum = sum + i;
                data = Convert.ToString(sum);
            }
            average = sum / 10;
            data1 = Convert.ToString(average);

            return " Sum :" + data + "\n Average :" + data1;
        }

        /*(C)Write logic to get the salary greater than 1000 from the student collection using for each */

        [HttpGet, Route("forsalary")]
        public IActionResult Salary()
        {
            List<int> numbers = new();
            int[] salary = { 1000,500, 300, 10, 900, 800, 2000, 3000, 40000, 50000, 60000, 7000000 };       
            foreach (int greaterSalary in salary)
            {
                if (greaterSalary > 1000)
                {
                    numbers.Add(greaterSalary);
                }
            }
            return Ok(numbers);
        }
        /*(D) Write logic to get all the numbers divided by 3 from 0 to 100*/

        [HttpGet, Route("fordividedbythree")]
        public IActionResult NumberDivideByThree()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    numbers.Add(i);
                }
            }
            return Ok(numbers);
        }
        /*(E) Write logic to print number which is divided by 5 from 1 to 500 */

        [HttpGet, Route("fordividedbyfive")]
        public IActionResult NumberDivideByFive()
        {
            List<int> numbers = new List<int>();
            for (int i = 1; i <= 500; i++)
            {
                if (i % 5 == 0)
                {

                    numbers.Add(i);
                }
            }
            return Ok(numbers);
        }

    }
}
