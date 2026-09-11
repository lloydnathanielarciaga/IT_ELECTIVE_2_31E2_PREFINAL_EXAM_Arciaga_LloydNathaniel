namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question17ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "17. What is the purpose of a try...catch block in a controller?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. To create navigation properties",  // Index 0
        "B. To catch and handle exceptions that may occur during execution", // Index 1, Tamang sagot
        "C. To generate database tables",  // Index 2
        "D. To perform client-side validation"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question16";
        public string NextController => "Question18";
    }
}
