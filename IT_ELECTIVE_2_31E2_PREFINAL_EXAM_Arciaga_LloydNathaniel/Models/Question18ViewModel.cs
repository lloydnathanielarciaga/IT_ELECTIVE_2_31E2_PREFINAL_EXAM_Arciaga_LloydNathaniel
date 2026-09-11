namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question18ViewModel
    {
        public int CurrentQuestionNumber { get; } = 18;
        public string Question { get; set; } = "18. Which middleware is commonly used in ASP.NET Core for centralized exception handling?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. UseDatabase()",  // Index 0
        "B. UseExceptionHandler()", // Index 1, Tamang sagot
        "C. UseValidationHandler()",  // Index 2
        "D. UseMvcDatabase()"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question17";
        public string NextController => "Question19";
    }
}
