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
    class Estimate
    {//These are all properties
    //The {get; set;} means that they are encapsulated
        public string DogOwner {get; set;}
        public string DogName {get; set;}
        public int DogWeight {get; set;}
        public int StayDuration {get; set;}
        public string ServiceAddon {get; set;}
        public float TotalEstimate {get; set;}

        public Estimate(string DogOwner, string DogName, int DogWeight,//This is the Estimate method
            int StayDuration, string ServiceAddon, float TotalEstimate)
            {
                this.DogOwner = DogOwner;
                this.DogName = DogName;
                this.DogWeight = DogWeight;
                this.StayDuration = StayDuration;
                this.ServiceAddon = ServiceAddon;
                this.TotalEstimate = TotalEstimate;
            }
    }
}
