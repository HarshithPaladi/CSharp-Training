namespace Week2_Assignment{
    public class DriverLicense{
        public void licenseProcessing(string myName,int availAgents, string otherPeople){
            List<string> peopleInQueue = new List<string>();
            peopleInQueue.Add(myName);
            string[] people = otherPeople.Split(" ");
            foreach( string i in people){
                peopleInQueue.Add(i);
            }
            peopleInQueue.Sort();
            int indexInList = peopleInQueue.FindIndex(x=> x.Equals(myName));
            int timeTaken = (indexInList/availAgents)*20+20;
            Console.WriteLine($"Time taken to walk out: {timeTaken}");
        }
        public void runner(){
            licenseProcessing("Eric", 2, "Adam Caroline Rebecca Frank");
            licenseProcessing("Zebediah", 1, "Bob Jim Becky Pat");
            licenseProcessing("Aaron", 3, "Jane Max Olivia Sam");

            // Custom inputs
            licenseProcessing("Harshith",2,"Ab gk cc ej zk qw ");
        }
    }
}