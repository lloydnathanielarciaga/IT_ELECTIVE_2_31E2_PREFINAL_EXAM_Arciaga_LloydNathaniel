namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question7ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "7. A Student belongs to exactly one Section, while a Section can contain many students. What type of relationship is this?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. One-to-One",  // Index 0
        "B. One-to-Many", // Index 1, Tamang sagot
        "C. Many-to-Many",  // Index 2
        "D. Many-to-One only"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question6";
        public string NextController => "Question8";
    }
}
