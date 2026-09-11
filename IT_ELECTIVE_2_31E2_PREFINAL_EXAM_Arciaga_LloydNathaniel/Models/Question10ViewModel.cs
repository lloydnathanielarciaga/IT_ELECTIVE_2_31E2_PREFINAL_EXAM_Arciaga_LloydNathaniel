namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question10ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "10. What does .Include() generally allow EF Core to do?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Delete the Section table",  // Index 0
        "B. Load related Section data together with Students", // Index 1, Tamang sagot
        "C. Create a new Student",  // Index 2
        "D. Validate Student input"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question9";
        public string NextController => "Question11";
    }
}
