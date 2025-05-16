using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnglishMultiApp.Classes
{
    public class PhonemeChart
    {
        private List<Phoneme> Vowels { get; set; } = new List<Phoneme>();
        private List<Phoneme> Diphthongs { get; set; } = new List<Phoneme>();
        private List<Phoneme> Consonants { get; set; } = new List<Phoneme>();

        public PhonemeChart() { }
        public void InitializeVowelList()
        {
            //Phonemes.Add(new Phoneme("", "", "", "", "", ""));
            Vowels.Add(new Phoneme("N/A", "iː", "Close", "Completly Front", "Spread", "Long"));
            Vowels.Add(new Phoneme("N/A", "ɪ", "Nearly Half Close", "Front", "Neutral", "Short"));
            Vowels.Add(new Phoneme("N/A", "e", "Between Half Close and Half Open", "Front", "Neutral", "Short"));
            Vowels.Add(new Phoneme("N/A", "æ", "Nearly Open", "Front", "Spread", "Short"));
            Vowels.Add(new Phoneme("N/A", "ʌ", "Nearly Half Open", "Central", "Neutral", "Short"));
            Vowels.Add(new Phoneme("N/A", "ɑ:", "Open", "Back", "Neutral", "Long"));
            Vowels.Add(new Phoneme("N/A", "ɒ", "Between Half Open Half Open", "Back", "Rounded", "Short"));
            Vowels.Add(new Phoneme("N/A", "ɔ:", "Nearly Half Close", "Back", "Rounded", "Long"));
            Vowels.Add(new Phoneme("N/A", "ʊ", "Nearly Half Close", "Nearly Central", "Rounded", "Short"));
            Vowels.Add(new Phoneme("N/A", "u:", "Nearly Close", "Nearly Back", "Rounded", "Long"));
            Vowels.Add(new Phoneme("N/A", "ɜ:", "Nearly Half Open", "Central", "Neutral", "Long"));
            Vowels.Add(new Phoneme("N/A", "ə", "Half Close Half Open", "Central", "Neutral", "Short"));
        }

        public Phoneme GetVowelByNumber(int number)
        {
            if (number >= 1 && number <= Vowels.Count)
                return Vowels[number - 1]; // El índice de lista empieza en 0
            else
                return null;
        }

        public string GetPhonemeDetails(Phoneme phoneme)
        {
            if (phoneme == null) return "Phoneme not found.";

            return $"Phonetic Symbol: /{phoneme.GetPhoneticSymbol()}/\n" +
                $"Sound: \n" +
                $"The tongue height is {phoneme.GetTongueHieght()} positioned.\n" +
                $"The tongue {phoneme.GetTonguePart()} part is raised.\n" +
                $"The lips has a {phoneme.GetLipPosition()} shaped form\n" +
                $"The duration of the air flow is {phoneme.GetLength()}\n";
        }

        public List<Phoneme> GetListVowels()
        {
            return Vowels;
        }

        public List<Phoneme> GetListDiphthongs()
        {
            return Diphthongs;
        }

        public List<Phoneme> GetListConsonant()
        {
            return Consonants;
        }
    }
}
