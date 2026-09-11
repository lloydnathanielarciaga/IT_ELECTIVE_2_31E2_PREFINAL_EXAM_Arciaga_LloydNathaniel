namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question19ViewModel
    {
        public int CurrentQuestionNumber { get; } = 19;
        public string Question { get; set; } = "19. A user requests /Student/999, but Student 999 does not exist. What would be the most appropriate response?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Display the student's information anyway",  // Index 0
        "B. Display a Not Found (404) response/page", // Index 1, Tamang sagot
        "C. Delete Student 999",  // Index 2
        "D. Create Student 999 automatically"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question18";
        public string NextController => "Question20";
    }
}
