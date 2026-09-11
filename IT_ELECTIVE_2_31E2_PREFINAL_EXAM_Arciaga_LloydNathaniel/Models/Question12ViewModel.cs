namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question12ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "12. Consider this query:\r\n\r\nvar students = _context.Students.Include(s => s.Section).ToList();\r\n\r\nWhat is the main benefit of Include(s => s.Section)?\r\n";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. It loads the related Section navigation property",  // Index 0, Tamang sagot
        "B. It creates a Section object manually", // Index 1
        "C. It removes the foreign key",  // Index 2
        "D. It prevents the query from accessing the database"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 0;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question11";
        public string NextController => "Question13";
    }
}
