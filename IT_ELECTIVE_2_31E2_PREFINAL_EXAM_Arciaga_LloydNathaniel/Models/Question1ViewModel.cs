namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question1ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "1. What is the main problem solved by using a database instead of an in-memory collection?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. It makes C# code shorter",  // Index 0
        "B. It prevents the application from restarting", // Index 1
        "C. It allows data to persist after the application stops",  // Index 2, Tamang sagot
        "D. It removes the need for MVC"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 2;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question20";
        public string NextController => "Question2";
    }
}
