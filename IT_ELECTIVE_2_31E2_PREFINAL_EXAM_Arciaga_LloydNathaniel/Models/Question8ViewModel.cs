namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question8ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "8. In the following example, what is SectionId?\r\npublic int SectionId { get; set; }\r\npublic Section Section { get; set; }\r\n";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Primary key of Student",  // Index 0
        "B. Foreign key referencing Section", // Index 1, Tamang sagot
        "C. Navigation property",  // Index 2
        "D. Database connection string"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question7";
        public string NextController => "Question9";
    }
}
