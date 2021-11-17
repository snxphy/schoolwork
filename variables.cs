using System;    //uses system

namespace main   //main
{
    struct Employee     //struct for employee data
    {
        string name;  //string
        int age;  //number
        string phonenumber; //string
        double wage;   //number
        bool retired;   //true or false
        //set stuff andf get stuff
        public void SetAge(int age)  //public access, set age num
        {
            this.age = age;   //age set to variable
        }
        public int GetAge()   //public number for age
        {
            return this.age;   //returns information stored in value
        }
        public void SetName(string name) //public access, set name string
        {
            this.name = name;    //name set to variable
        }
        public string GetName() //public string for name
        {
            return this.name;    //returns information stored in value
        }
        public void SetNumber(string phonenumber)  //public access, set phone num
        {
            this.phonenumber = phonenumber;   //num set to variable
        }
        public string GetNumber()    //public number for phone
        {
            return this.phonenumber;   //returns information stored in value
        }
        public void SetWage(double wage)  //public access, set wage num
        {
            this.wage = wage;   //wage set to variable
        }
        public double GetWage()   //public number for wage
        {
            return this.wage;   //returns information stored in value
        }
        public void SetRetired(bool retired)  //public access, set retired stat
        {
            this.retired = retired;   //stat set to variable
        }
        public bool GetRetired()   //public number for retired stat
        {
            return this.retired;   //returns information stored in value
        }
    }
    class Program  //class
    {
        static void Main(string[] args)  //main 
        {
            Console.WriteLine("Employee Information:");   //first print
            Employee jim = new Employee();   //new employee struct
            //set info for new employee struct
            jim.SetAge(59);   //set age value
            jim.SetName("jim");   //set name value
            jim.SetNumber("0111");    //set number value
            jim.SetWage(100);    //sets wage value
            jim.SetRetired(true);    //sets retirement value
            Employee jom = new Employee();  //new employee struct
            //set info for new employee struct
            jom.SetAge(21);  //set age value
            jom.SetName("jom");  //set name value
            jom.SetNumber("0112");  //set number value
            jom.SetWage(200);  //sets wage value
            jom.SetRetired(false);  //sets retirement value
            //set info for new employee struct printed.
            Console.WriteLine("\nHello " + jom.GetName() + "\nAge: " + jom.GetAge() + "\nNumber: " + jom.GetNumber() + "\nWage: " + jom.GetWage() + "\nRetirement Status: " + jom.GetRetired());  //joms info
            Console.WriteLine("\nHello " + jim.GetName() + "\nAge: " + jim.GetAge() + "\nNumber: " + jim.GetNumber() + "\nWage: " + jim.GetWage() + "\nRetirement Status: " + jim.GetRetired());  //jims info
            //end of the program which gets and sets stuff of info for employee names, age, mobular device phone numbers, payment wages, retirement status. this is not cap i repeat this is not cap,      :)
        }
    }
}