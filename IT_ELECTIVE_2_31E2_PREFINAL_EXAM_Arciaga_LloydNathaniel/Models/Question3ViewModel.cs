namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question3ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "3. What is the primary purpose of Entity Framework Core?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. To create HTML pages automatically",  // Index 0
        "B. To replace the MVC Controller", // Index 1
        "C. To map objects in code to relational database data",  // Index 2, Tamang sagot
        "D. To replace the C# compiler"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 2;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question2";
        public string NextController => "Question4";
    }
}
