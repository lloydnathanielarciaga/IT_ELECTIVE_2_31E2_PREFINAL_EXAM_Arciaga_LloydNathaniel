namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question16ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "16. Which is the best reason for having a database-level unique constraint on StudentNumber?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. It protects data integrity even if application-level validation is bypassed",  // Index 0, Tamang sagot
        "B. It makes Razor Views render faster", // Index 1
        "C. It removes the need for a Controller",  // Index 2
        "D. It automatically creates a ViewModel"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 0;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question15";
        public string NextController => "Question17";
    }
}
