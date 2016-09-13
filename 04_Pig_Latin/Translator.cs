namespace _04_Pig_Latin
{
    internal class Translator
    {
        public string Translate(string x)
        {
            bool memory = false;
            bool wordstart = true;
            string ay = "ay";
            string text = "";
            string test = "" + x[0];
            if (test != "a" && test != "e" && test != "i" && test != "o" && test != "u" && test != "y")
            {
                memory = true;
            }

                for (int i = 0; i < x.Length; i++)
            {
                if (!wordstart || !memory)
                {
                    text = text + x[i];
                }
                if (i == x.Length - 1 && memory)
                {
                    text = text + test;
                }
                if (i == x.Length - 1)
                {
                    text = text + ay;
                }
                wordstart = false;
            }

            return text;
        }
    }
}