namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question14ViewModel
    {
        public int CurrentQuestionNumber { get; } = 14;
        public string Question { get; set; } = "14. Why is server-side validation still necessary if client-side validation exists?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Client-side validation can be bypassed",  // Index 0, Tamang sagot
        "B. Client-side validation automatically modifies the database", // Index 1
        "C. Server-side validation only works with SQLite",  // Index 2
        "D. Client-side validation cannot display messages"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 0;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question13";
        public string NextController => "Question15";
    }
}
