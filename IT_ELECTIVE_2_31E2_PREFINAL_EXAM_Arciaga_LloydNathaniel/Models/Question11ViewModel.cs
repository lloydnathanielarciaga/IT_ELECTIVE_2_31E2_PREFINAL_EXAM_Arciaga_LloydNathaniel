namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question11ViewModel
    {
        public int CurrentQuestionNumber { get; } = 1;
        public string Question { get; set; } = "11. Why might a ViewModel be used when displaying Student and Section information?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. To replace the database",  // Index 0
        "B. To combine or shape the data specifically needed by the view", // Index 1, Tamang sagot
        "C. To automatically create database tables",  // Index 2
        "D. To prevent controllers from using LINQ"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question10";
        public string NextController => "Question12";
    }
}
