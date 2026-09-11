namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question2ViewModel
    {
        public int CurrentQuestionNumber { get; } = 2;
        public string Question { get; set; } = "2. Which approach is being used when an existing database is used to generate EF Core entity classes?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Code-First",  // Index 0
        "B. Database-First", // Index 1, Tamang sagot
        "C. Model-First",  // Index 2
        "D. Controller-First"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question1";
        public string NextController => "Question3";
    }
}
