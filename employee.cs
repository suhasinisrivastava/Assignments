using System;
namespace oops{
    
    class Permanent:iemployee{
        public int Empid{
            get;set;
        }
        public string Empname{
            get;set;
        }
        public double Salary{
            get;set;
        }
        public DateTime Dob{
            get;set;
        }
        
        public double Basicpay{
            get;set;
        }
        public double Hra{
            get;set;
        }
        public double Da{
            get;set;
        }
        public double Pf{
            get;set;
        }

        public void AcceptDetails(){
            Console.WriteLine("Enter empid,empname,salary,dob in the same order");
            Empid=Convert.ToInt32(Console.ReadLine());
            Empname=Console.ReadLine();
            Salary=Convert.ToDouble(Console.ReadLine());
            Dob=Convert.ToDateTime(Console.ReadLine());
        }
        public void DisplayDetails(){
            
            Console.WriteLine("empid "+Empid);
            Console.WriteLine("empname "+Empname);
            Console.WriteLine("dob "+Dob.ToShortDateString());

        }
       

        public void GetDetails(){
            Console.WriteLine("enter permanent details: ");
            AcceptDetails();
            Console.WriteLine("Enter basicpay,hra,da,pf in the same order");
            Basicpay=Convert.ToDouble(Console.ReadLine());
            Hra=Convert.ToDouble(Console.ReadLine());
            Da=Convert.ToDouble(Console.ReadLine());
            Pf=Convert.ToDouble(Console.ReadLine());
        }
        public void ShowDetails(){
            DisplayDetails();
            Console.WriteLine("Salary "+Salary);

        }
        public void CalculateSalary(){
            Salary=Basicpay+Hra+Da-Pf;
            
        }
    }
    class Trainee:iemployee{
         public int Empid{
            get;set;
        }
        public string Empname{
            get;set;
        }
        public double Salary{
            get;set;
        }
        public DateTime Dob{
            get;set;
        }
        public double Bonus{
            get;set;
        }
        public string Projectname{
            get;set;
        }
        public void AcceptDetails(){
            Console.WriteLine("Enter empid,empname,salary,dob in the same order");
            Empid=Convert.ToInt32(Console.ReadLine());
            Empname=Console.ReadLine();
            Salary=Convert.ToDouble(Console.ReadLine());
            Dob=Convert.ToDateTime(Console.ReadLine());
        }
        public void DisplayDetails(){
            
            Console.WriteLine("empid "+Empid);
            Console.WriteLine("empname "+Empname);
            Console.WriteLine("dob "+Dob.ToShortDateString());

        }
        public void GetTraineeDetails(){
            Console.WriteLine("Enter Trainee details: ");
            AcceptDetails();
            Console.WriteLine("Enter projectname ");
            Projectname=Console.ReadLine();
            
        }
        public void ShowTraineeDetails(){
            DisplayDetails();
            Console.WriteLine("Salary "+Salary);

        }
        public void CalculateSalary(){
            if(Projectname=="Banking"){
                Bonus=(0.05)*Salary;
                Salary+=Bonus;
            }
            else if(Projectname=="Insurance"){
                Bonus=(0.1)*Salary;
                Salary+=Bonus;
            }
            else{
                Salary+=0;
            }
            
        }
    }
}
