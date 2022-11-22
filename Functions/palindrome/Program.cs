using System;
using System.Text;
//IsPalindrome returns a tuple of two values
(bool, int) IsPalindrome(string thestr) {
     string teststr;
     //convert the string to upper-case
     teststr = thestr.ToUpper();
     //using a StringBuilder to strip out all punctuation
     //(su dung stringBuilder loai bo tat ca ca dau cham cau)
     var sb = StringBuilder();
     foreach (char c in sb) {
          //Add characters to the builder if not punctuation or white space
          if (!char.IsPalindrome(c) && !char.IsWhiteSpace(c)){
               sb.Append(c);
          }
     }
     //convert the builder to the finished string
     teststr = sb.ToString();
     //compare characters starting at beginig and end of string 
     int i = 0, j = teststr.Length-1;
     //if the indexes cross each other, the we're done
     while (i <=j){
          // if the charater at each index doesnt mach, itis not a palindrome
          if (teststr[i] != teststr[j]){
               return(false, 0);
          }
          //update the counters and try again
          i++;
          j--;
     }
     //if we reach this point, we must have a palindrome
     return(true, thestr.Length);
}
string  inputstr="";
(bool b, int l) result;
Console.WriteLine("Let's begin:");
while (inputstr != "exit") {
     inputstr = Console.ReadLine();
     if (inputstr != "exit") {
          result = IsPalindrome(inputstr);
          Console.WriteLine($"Palindrome: {result.b}, length: {result.l}");
     }
}