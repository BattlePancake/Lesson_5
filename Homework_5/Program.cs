// -------------------------Homework for Lesson_4-----------------------------

// -------------------------Task 1--------------------------------------------

// --------------------------Way 1--------------------------------------------
// string text = "Hello, it's a 1 test message 2 test 3 test 4 test";
// text = text.Replace("test","testing");
// int search1 = text.IndexOf("1");
// int search2 = text.IndexOf("2");
// int search3 = text.IndexOf("3");
// int search4 = text.IndexOf("4");
// Console.WriteLine("Indexes of numbers are: {0}, {1}, {2}, {3}",search1,search2,search3,search4);

// text = text.Remove(14,2);
// text = text.Remove(30,2);
// text = text.Remove(38,2);
// text = text.Remove(46,2);
// Console.Write(text);

// --------------------------Way 1--------------------------------------------
// string text1 = "Hello, it's a 1 test message 2 test 3 test 4 test";
// text1 = text1.Replace("test","testing");
// text1 = text1.Replace("1 ","");
// text1 = text1.Replace("2 ","");
// text1 = text1.Replace("3 ","");
// text1 = text1.Replace("4 ","");
// Console.Write(text1);


// -------------------------Task 2--------------------------------------------
// string str1 = "Welcome";
// string str2 = "to";
// string str3 = "the";
// string str4 = "TMS";
// string str5 = "lessons";

// string full = string.Concat(str1 + " " +str2 + " " + str3 + " " + str4 + " " + str5);
// Console.Write(full);


// -------------------------Task 3--------------------------------------------
// string text2 = "teamwithsomeofexcersicesabcwanttomakeitbetter";

// string sym = "abc";
// int search5 = text2.IndexOf(sym);
// Console.WriteLine(search5);
// string spc = " ";
// text2 = text2.Insert(24,spc);
// string[] text3 = text2.Split(' ');
// string text4 = text3[0];
// string text5 = text3[1];
// text5 = text5.Substring(3);
// Console.WriteLine(text4);
// Console.Write(text5);


// -------------------------Task 4--------------------------------------------

// --------------------------Way 1--------------------------------------------
// string stri1 = "Bad day";
// stri1 = stri1.Substring(3);
// Console.WriteLine(stri1);
// string stri2 = "Nice";
// string stri3 = "!!!!!!";
// stri1 = stri1.Insert(0,stri2);
// stri1 = stri1.Insert(8,stri3);
// stri1 = stri1.Remove(stri1.Length - 1,1);
// string stri4 = string.Concat(stri1, "?");
// Console.WriteLine(stri4);


// --------------------------Way 2--------------------------------------------
// using System.Text;

// var str1 = new StringBuilder("Bad day");
// str1.Replace("Bad","Nice");
// str1.Insert(8,"!!!!!!!");
// str1.Remove(str1.Length - 1,1);
// str1.AppendFormat("?");
// Console.WriteLine(str1);


// -------------------------Task 5--------------------------------------------
//xxxx-yyy-xxxx-yyy-xyxy
//x — это число, y — это буква

using System.Text;

string text = "1234-abc-5678-xyz-9o1p";
string[] text1 = text.Split('-');
Console.WriteLine();
foreach (string aa in text1)
{
    Console.WriteLine(aa);
}
string text2 = text1[0];
string text3 = text1[2];
Console.WriteLine();
Console.WriteLine($"{text2}-{text3}\n");

string text4 = string.Join("-",text1);

string text5 = text4;
text5 = text5.Replace("abc","***");
text5 = text5.Replace("xyz","***");
Console.WriteLine($"{text5}\n");

string text6 = text4;
text6 = text6.Remove(text6.Length - 2,1);
text6 = text6.Remove(text6.Length - 3,1);
text6 = text6.Substring(5);
text6 = text6.Remove(4,5);
text6 = text6.Insert(text6.Length - 1,"/");
text6 = text6.Replace("-","/");
Console.WriteLine($"{text6.ToLower()}\n");

var str1 = new StringBuilder("1234-ABC-5678-1a2b-9o1p");
str1.Remove(str1.Length - 2,1);
str1.Remove(str1.Length - 3,1);
str1.Replace("1234-","");
str1.Replace("5678-","");
str1.Insert(str1.Length-1,"/");
str1.Replace("-","/");
string cons = str1.ToString();
Console.WriteLine($"{cons.ToUpper()}\n");

bool dcsn = cons.Contains("aBc", StringComparison.OrdinalIgnoreCase);
if(dcsn == false)
{
    Console.Write($"String doesn't contain 'abc' letters");
}
else
{
    Console.Write($"String contains 'abc' letters");
}
Console.WriteLine("\n");
if(cons.StartsWith("555"))
{
    Console.Write($"String starts with '555'");
}
else
{
    Console.Write($"String starts with: '{cons[0]}{cons[1]}{cons[2]}'");
}
Console.WriteLine("\n");
if(cons.EndsWith("1a2b"))
{
    Console.Write($"String starts with '1a2b'");
}
else
{
    Console.Write($"String ends with: '{cons[cons.Length - 1]}{cons[cons.Length - 2]}{cons[cons.Length - 3]}{cons[cons.Length - 4]}'");
}