using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Estimate  //First letter of class name is capitalized
    {//These are all properties
    //The {get; set;} means that they are encapsulated
        public string DogOwner {get; set;}
        public string DogName {get; set;}
        public int DogWeight {get; set;}
        public int StayDuration {get; set;}
        public string ServiceAddon {get; set;}
        public float TotalEstimate {get; set;}

        public estimate(string DogOwner, string DogName, int DogWeight,//This is the estimate method
            int StayDuration, string ServiceAddon)
            {
                this.DogOwner = DogOwner; //The "this" keyword refers to the thing stored in current method instance
                this.DogName = DogName;//For example, this.DogOwner = DogOwner is telling the program to assign the data passed through the method to the actual variable known as DogOwner
                this.DogWeight = DogWeight;//TLDR; this.DogOwner = DogOwner is assigning the user input into the DogOwner variable
                this.StayDuration = StayDuration;
                this.ServiceAddon = ServiceAddon;
            }

        //First letter of a method name should be lower case
        public working()//This method processes the ServiceAddon code and calculates the TotalEstimate
        {
            if (ServiceAddon="N")
            {
                TotalEstimate = StayDuration * 75.00;
            }
        }

        public toString()//This method outputs the data to the user
        {

        }

    }

}
