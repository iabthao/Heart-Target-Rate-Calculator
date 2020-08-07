using System;
using System.Collections.Generic;
using System.Text;

namespace HeartTargetRateCalculator
{
    class HeartRates
    {
        private string firstName;
        private string lastName;
        private int yearOfBirth;
        private int currentYear;
        

        //set a constructor

        public HeartRates(string fName, string lName, int yOfbirth, int cYear)
        {
            FirstName = fName;
            LastName = lName;
            YearOfBirth = yOfbirth;
            currentYear = cYear;

        }
        //get and set lines for variables

        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        public int YearOfBirth
        {
            get
            {
                return yearOfBirth;
            }
            set
            {
                yearOfBirth = value;
            }

        }
        // Calculate and return the person's age (in years)

        public int PersonAge
        {
            get
            {
                return (currentYear - yearOfBirth);
            }
        }

        // Property that calculates the maximum heart rate
        public double MaxRates

        {
            get { return (220 - PersonAge); }
        }

        // property that calculates the minimum and maximun target heart rates

        public double MinHeartRates
        {
            get { return MaxRates * 0.50; }
        }
        public double MaxHeartRates
        {
            get { return MaxRates * 0.85; }

        }
    }
}
