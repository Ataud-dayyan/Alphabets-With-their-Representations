namespace Alphabets
{
    public class AlphabetDictionary
    {
        public Dictionary<char, string> alphabets = new Dictionary<char, string>();

        public void MapAlphabetsChart() 
        {
            string[] alphas = {
                "Ade", "Bayo", "Catherine", "Dayo", "Emmanuel", "Funke", 
                "George", "Hannah", "Ibrahim", "Jayeola", "Kayode", "Lakunle", 
                "Mufliha", "Nafisat", "OluwaFemi", "Pemisire", "Qahar", 
                "Ridwan", "Shade", "Tunde", "Ugo", "Veronica", "Wale", 
                "Xavier", "Yetunde", "Zainab"
            };

             for (int i = 0; i < 26; i++)
            {
                char letter = (char)('A' + i);
                alphabets.Add(letter, alphas[i]);
            }
        }
    }
}
