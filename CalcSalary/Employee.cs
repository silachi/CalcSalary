using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcSalary
{
    
    public abstract class Employee
    {
        // attributes
      private   double baseSal = 15000;
      private   double fuelAllowance;
      private   double medAllowance;

        // actions
        public double GetBaseSal()
        {
            return baseSal;
        }
        public void SetFuelAllowance(double _fuelAllowance)
        {
            fuelAllowance = _fuelAllowance;
        }
        public double GetFuelAllowance()
        {
            return fuelAllowance;
        }

        public void SetMedAllowance(double _medAllowance)
        {
            medAllowance = _medAllowance;
        }
        public double GetMedAllowance()
        {
            return medAllowance;
        }


        public abstract double CalSal();

    }

    public class Engineer : Employee
    {
        public override double CalSal()
        {
            SetFuelAllowance(0);
            SetMedAllowance(0);
            double annualPaid = 7000;
            double salary = GetBaseSal() + GetFuelAllowance() + GetMedAllowance() + annualPaid/12;
            
            return salary;
        }

        
    }
    public class Manager : Employee
    {
        double tax = 0.17;
        public override double CalSal()
        {
            SetFuelAllowance(250);
            SetMedAllowance(1000);
            double salary = GetBaseSal() + GetFuelAllowance() + GetMedAllowance();
            salary = salary - salary * tax;
            return salary;
        }

    }
    public class HR : Employee
    {
       

        
        public override double CalSal()
        {
            SetFuelAllowance(150);
            SetMedAllowance(800);
          
            double intrwAllowance = (GetMedAllowance() + GetFuelAllowance())*0.10;
            double salary = GetBaseSal() + GetFuelAllowance() + GetMedAllowance() + intrwAllowance;

            return salary;
        }

    }

}
