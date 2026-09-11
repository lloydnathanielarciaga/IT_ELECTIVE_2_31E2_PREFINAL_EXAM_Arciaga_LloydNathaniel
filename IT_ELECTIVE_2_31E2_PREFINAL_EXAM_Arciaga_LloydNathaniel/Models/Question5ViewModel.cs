namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question5ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "5. What does the following command primarily do? dotnet ef dbcontext scaffold \"ConnectionString\" Microsoft.EntityFrameworkCore.SqlServer -o Models";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Deletes the database",  // Index 0
        "B. Creates a new MVC project", // Index 1
        "C. Generates EF Core models and a DbContext from an existing database",  // Index 2, Tamang sagot
        "D. Starts the MVC application"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 2;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question4";
        public string NextController => "Question6";
    }
}
