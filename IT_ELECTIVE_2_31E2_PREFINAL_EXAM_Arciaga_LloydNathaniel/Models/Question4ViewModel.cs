namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question4ViewModel
    {
        public int CurrentQuestionNumber { get; } = 4;
        public string Question { get; set; } = "4. Which EF Core component is primarily responsible for communicating with the database?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. DbContext",  // Index 0, Tamang sagot
        "B. DbSetView", // Index 1
        "C. ControllerContext",  // Index 2
        "D. RazorContext"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 0;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question3";
        public string NextController => "Question5";
    }
}
