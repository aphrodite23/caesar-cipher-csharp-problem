using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
           
            string str="";
            foreach(char ch in text){
                //spaces,special chars
                //uppercase
                //lowercase
    
                if(!char.IsLetter(ch)){
                    str=str+ch;
                    continue;
                }
                char d=(char.IsUpper(ch)?'A':'a');
                char s = (char)((((ch+shiftKey)-d)%26)+d);
                str=str+s;
               }
               return str;
        }
        public static void Main(string[] args){
            
        }
 }
}

