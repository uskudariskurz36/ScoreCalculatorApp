using System.ComponentModel.DataAnnotations;

namespace ScoreCalculatorApp.Models
{
    public class IndexViewModel
    {
        [Range(0, 100)]
        public int Score1 { get; set; }

        [Range(0, 100)]
        public int Score2 { get; set; }

        [Range(0,100)]
        public int Percent1 { get; set; }

        [Range(0, 100)]
        public int Percent2 { get; set; }

        public int CalculatedScore { get; set; }
    }
}
