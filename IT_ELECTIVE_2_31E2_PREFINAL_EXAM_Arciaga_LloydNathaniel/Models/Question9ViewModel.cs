namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question9ViewModel
    {
        public int CurrentQuestionNumber { get; } = 9;
        public string Question { get; set; } = "9. What is the purpose of a navigation property such as public Section Section { get; set; }?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. It stores the database password",  // Index 0
        "B. It represents a relationship to another entity", // Index 1, Tamang sagot
        "C. It creates a new database",  // Index 2
        "D. It validates the student's name"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question8";
        public string NextController => "Question10";
    }
}
