namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question20ViewModel
    {
        public int CurrentQuestionNumber { get; } = 20;
        public string Question { get; set; } = "20. A student already belongs to Section A for a particular subject. The application attempts to assign the same student to Section A again. What is the primary concern?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Data integrity",  // Index 0, Tamang sagot
        "B. HTML formatting", // Index 1
        "C. CSS inheritance",  // Index 2
        "D. Razor syntax"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 0;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question19";
        public string NextController => "Question1";
    }
}
