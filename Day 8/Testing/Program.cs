namespace Testing
{
    public class Program
    {
        static string grade="";
        public static void CalculateCGPA()
        {
            Console.WriteLine("Enter number of subjects and marks: ");
            int subjectCount = int.Parse(Console.ReadLine());
            List<float> marks = new();
            for (int i=0;i<subjectCount;i++){
                marks.Add(float.Parse(Console.ReadLine()));
            }
            float total = marks.Sum();
            float avg = total/subjectCount;
            Console.WriteLine("Average: "+avg);
            float cgpa = avg/10;
            AssignGrade(cgpa);
        }
        public static string CalculateCGPA(int subjectcount, List<float> marks)
        {
            float total = marks.Sum();
            float avg = total / subjectcount;
            Console.WriteLine("Average: " + avg);
            float cgpa = avg / 10;
            return AssignGrade(cgpa);
        }
        enum gradeEnum{
            S,AP,A,B,E
        };
        public static string AssignGrade(float cgpa){
            Console.WriteLine("CGPA: "+cgpa);
            if(cgpa>9f){
                grade = gradeEnum.S.ToString();
            }
            else if(cgpa >8f){
                grade = gradeEnum.AP.ToString();
            }
            else if(cgpa>7f){
                grade=gradeEnum.A.ToString();
            }
            else if(cgpa>6f){
                grade = gradeEnum.B.ToString();
            }
            else{
                grade = gradeEnum.E.ToString();
            }
            Console.WriteLine("Grade: "+grade);
            return grade;
        }
        public static int Factorial(int N){
            if(N == 0 || N==1) return 1;
            return N*Factorial(N - 1);
        }
        public static void Main()
        {
            // var p = new Program();
            // CalculateCGPA();
            var run = new Polymorphism();
            run.runner();
            var Abstraction_LuckyNumberPredictor = new Abstraction_LuckyNumberPredictor();
            Console.WriteLine("Enter your dateofbirth(ddmmyyyy)");
            int.TryParse(Console.ReadLine(),out int dob);
            Abstraction_LuckyNumberPredictor.luckyNumberPredictor(dob);
        }
    }
}