namespace IT_ELECTIVE_2_31E2_PREFINAL_EXAM_Arciaga_LloydNathaniel.Models
{
    public class Question15ViewModel
    {
        public int CurrentQuestionNumber { get; } = 15;
        public string Question { get; set; } = "15. A school requires every student to have a unique Student Number. Which rule best represents this requirement?";  // Dito ang Question
        public List<string> Options { get; set; } = new List<string>
    {
        "A. Student Number should always be nullable",  // Index 0
        "B. Student Number should be unique", // Index 1, Tamang sagot
        "C. Student Number should always be the same",  // Index 2
        "D. Student Number should contain only spaces"  // Index 3
    };

        // Mag set ng tamang index para sa tamang sagot
        public int CorrectOptionIndex { get; set; } = 1;

        // Prioritize agad para iwas sa errror
        public string PreviousController => "Question14";
        public string NextController => "Question16";
    }
}
