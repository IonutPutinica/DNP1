using System;
namespace Ex0109
{
    public class StringUtility
    {
        private static string text;
        private static string newText;
        private int noOfCharacters;

        public StringUtility(string text)
        {
            
        }
        
        public int getStringLenght()
        {
            noOfCharacters=text.Length;
            return noOfCharacters;
        }
        public static string SummarizeText()
        {
        
                newText=Convert.ToString(text.Split("...",20));
            
            return newText;
        }
    }
}