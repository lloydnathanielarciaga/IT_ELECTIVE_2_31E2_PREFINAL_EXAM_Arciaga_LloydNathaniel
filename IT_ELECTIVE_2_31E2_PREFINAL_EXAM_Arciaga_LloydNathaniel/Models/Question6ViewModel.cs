namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question6ViewModel
    {
        public int CurrentQuestionNumber { get; } = 6;
        public string Question { get; set; } = "6. Where is a database connection string commonly stored in an ASP.NET Core MVC application?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Program.cs only",  // Index 0
        "B. appsettings.json", // Index 1, Tamang sagot
        "C. Index.cshtml",  // Index 2
        "D. Student.cs"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question5";
        public string NextController => "Question7";
    }
}
