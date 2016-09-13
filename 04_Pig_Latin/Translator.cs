namespace _04_Pig_Latin
{
    internal class Translator
    {
        public string Translate(string x)
        {
            string[] xarray = x.Split(' ');
            string text = "";

            for (int i = 0; i < xarray.Length; i++)
            {
                text = text + " " + convert(xarray[i]);
            }

            return text.Trim();
        }

        internal string convert(string word)
        {
            bool vowel = false;
            string letter = "";
            string memory = "";
            string text = "";

            for(int i = 0; i<word.Length; i++)
            {
                letter = "" + word[i];
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" || letter == "y")
                {
                    vowel = true;
                }
                if (!vowel && letter != "q")
                {
                    memory = memory + word[i];
                }
                if (vowel && letter != "q")
                {
                    text = text + word[i];
                }
                if (letter == "q")
                {
                    memory = memory + word[i] + word[i + 1];
                    i++;
                }
            }
            text = text + memory + "ay";

            return text;
        }
    }
}