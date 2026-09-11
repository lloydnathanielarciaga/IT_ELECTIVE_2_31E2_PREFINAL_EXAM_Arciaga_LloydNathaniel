namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question13ViewModel
    {
        public int CurrentQuestionNumber { get; } = 13;
        public string Question { get; set; } = "13. Which type of validation occurs in the browser before a request is sent to the server?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Database-level validation",  // Index 0
        "B. Client-side validation", // Index 1, Tamang sagot
        "C. Server-side validation",  // Index 2
        "D. EF Core migration validation"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question12";
        public string NextController => "Question14";
    }
}
