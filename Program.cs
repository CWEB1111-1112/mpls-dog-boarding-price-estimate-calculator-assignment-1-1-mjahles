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
    {
        public string DogOwner {get; set;}
        public string DogName {get; set;}
        public string DogWeight {get; set;}
        public string StayDuration {get; set;}
        public string ServiceAddon {get; set;}
        public string TotalEstimate {get; set;}

        public Estimate(string DogOwner, string DogName, int DogWeight,
            int StayDuration, string ServiceAddon, string TotalEstimate)
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
