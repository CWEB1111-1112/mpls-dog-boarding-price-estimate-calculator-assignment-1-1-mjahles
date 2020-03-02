using System;

namespace assignment_one
{
    class Program
    {
        static void Main(string[] args)
        {   
            //This is what initializes the object instance
            Estimate one = new Estimate();

            //Welcome
            Console.WriteLine("Welcome to MPLS Dog Boarding!");

            //Start of User prompts
            Console.WriteLine("Please input your Name:");
            one.DogOwner = Console.ReadLine();

            Console.WriteLine("Please input your Dog's Name:");
            one.DogName = Console.ReadLine();

            Console.WriteLine("Please input your Dog's Weight (in pounds):");
            one.DogWeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input the number of days your dog will be staying with us:");
            one.StayDuration = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please input which addon package you would like:");
            Console.WriteLine("Packages:\nPackage A: Bathing and Grooming $169 Per Day\nPackage C: Bathing $112 Per Day\nPackage N: No Additional Services");
            one.ServiceAddon = Console.ReadLine();
            
            //End of User prompts

            //Cost Calculation
            one.working();

            //Presentation of Estimate Summary
            Console.WriteLine(one.toString());
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

        //Default Constructor
        public Estimate() : this("DogOwner", "DogName", 1, 1, "N")
        {

        }

            
        /**Constructor with Parameters**/
        public Estimate(string DogOwner, string DogName, int DogWeight,//This is the Estimate class constructor
            int StayDuration, string ServiceAddon)
            {
                this.DogOwner = DogOwner; //The "this" keyword refers to the thing stored in current method instance
                this.DogName = DogName;//For example, this.DogOwner = DogOwner is telling the program to assign the data passed through the method to the actual variable known as DogOwner
                this.DogWeight = DogWeight;//TLDR; this.DogOwner = DogOwner is assigning the user input into the DogOwner variable
                this.StayDuration = StayDuration;
                this.ServiceAddon = ServiceAddon;
            }

        //First letter of a method name should be lower case
        public float working()//This method processes the ServiceAddon code and calculates the TotalEstimate
        {
            if (ServiceAddon=="N")
            {
                TotalEstimate = StayDuration * 75.00F;
            }
            else if (ServiceAddon=="A")
            {
               TotalEstimate = StayDuration * 169.00F; 
            }
            else if (ServiceAddon=="C")
            {
                TotalEstimate = StayDuration * 112.00F;
            }
            else
            {
                Console.WriteLine("Please input a valid Service Add-on Code");
            }
            return TotalEstimate;
        }

        public string toString()//This method outputs the data to the user
        {
            return String.Format($"Estimate Summary:\n  Your Name: {DogOwner}\n  Dog Name: {DogName}\n  Dog Weight: {DogWeight}\n  Stay Duration: {StayDuration} Day(s)\n  Service Addon: {ServiceAddon} (A = Bathing + Grooming, C = Bathing, N = None)\n  Total Cost: ${TotalEstimate}");

        }

    }

}
