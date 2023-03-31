namespace PracticeQns
{
    public class PayCalc
    {
        public double salary;
        public void ingressData(double[] data)
        {
            double startTime = data[0];
            double endTime = data[1];
            double hourlyRate = data[2];
            double overtimeMultiplier = data[3];
            double regularTime;
            double overTime = 0;
            if (endTime <= 17)
            {
                regularTime = endTime - startTime;
            }
            else
            {
                regularTime = 17 - startTime;
                overTime = endTime - 17;
            }
            salary = calculatePay(regularTime, overTime, hourlyRate, overtimeMultiplier);
            Console.WriteLine($"Salary is {salary}");
        }
        public double calculatePay(double regularTime, double overTime, double hourlyRate, double overtimeMultiplier)
        {
            double salary;
            if (overTime == 0)
            {
                salary = regularTime * hourlyRate;
            }
            else
            {
                salary = regularTime * hourlyRate + overTime * hourlyRate * overtimeMultiplier;
            }
            return salary;
        }
        public void runner(){
            double []arr = {9, 17, 30, 1.5};
            double []arr1 = {16, 18, 30, 1.8};
            double []arr2 = {13.25, 15, 30, 1.5};
            ingressData(arr);
            ingressData(arr1);
            ingressData(arr2);

            
        }
    }
}