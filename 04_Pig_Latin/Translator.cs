namespace _04_Pig_Latin
{
    internal class Translator
    {
        public string Translate(string x)
        {
            string[] xarray = x.Split(' ');
            string text = "";

            for (int i = 0; i > xarray.Length; i++)
            {
                text = text + " " + convert(xarray[i]);
            }
            return text;
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
                if (!vowel)
                {
                    memory = memory + word[i];
                }
                if (vowel)
                {
                    text = text + word[i];
                }
            }
            text = text + memory + "ay";

            return text;
        }
    }
}