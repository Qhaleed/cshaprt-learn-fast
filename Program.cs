// Console.WriteLine("Hello, World!");
//
//
// string name = "Resham";
//
// Console.WriteLine(name);
// Console.WriteLine('b');
//
// Console.WriteLine(123);
// Console.WriteLine(0.25F);
//
// string firstName = "Res";
// char userOption;
// int gameScore;
// decimal particlesPerMillion;
// bool processedCustomer;
//
//
//

// string name = "bob";
// int number = 3;
// double myNumber = 34.4;

//
//
// Console.WriteLine("Hello, {0}! You have {1} messages " +
//               "in your inbox. The temperature is" +
//               " {2} celsius", name, number, myNumber);
//
//
// string[] fruits = {
//     "apple",
//     "orange","bananas"};
// foreach (string fruit in fruits)
// {
//     Console.WriteLine(fruit);
// }

//
// Stack<int> stack = new Stack<int>();
//
// stack.Push(1);
// stack.Push(2);
// stack.Push(5);
// Console.WriteLine(stack.Peek());
// Console.WriteLine(stack.Count());



// Player player = new Player();
// player.Name = "Res";
// player.Attack();



// Learning dictionaries in c#





// Dictionary<int, string> students = new Dictionary<int, string>();

// example what if we are finding an item?
//
// string target = "{";
//
// students.Add(1,"res");
// students.Add(2,"jon");
// students.Add(3,"mus");
// students.Add(4, "{");
// if (students.ContainsValue(target))
// {
//     Console.WriteLine("value found");
// }
// else
// {
//     Console.WriteLine("value not found");
// }
//

// another one

// string[] student = ["res", "sam", "dawn"];
//
// Dictionary<int, string> student_dictionary = new Dictionary<int, string>();
// // I want to add this into a dictionary
//
// for (int i = 0; i < student.Length; i++)
// {
//     student_dictionary.Add(i, student[i]);
// }
//
//
// if (student_dictionary.TryGetValue(1, out string name))
// {
//     Console.WriteLine(name);
// }
//
// foreach (var item in student_dictionary)
// {
//     Console.WriteLine(item);
// }

// string target = "res";
// if (student_dictionary.ContainsValue(target))
// {
//     Console.WriteLine("Target found");
//     Console.WriteLine("Changing its id to 2x");
// }

// Dictionary <int,int> dict = new Dictionary<int,int>();
// int[] nums = [1,2,3,1];
//
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.WriteLine(nums[i]);
//     if (dict.ContainsValue(nums[i]))
//     {
//         Console.WriteLine("repeated");
//         return;
//     }
//     dict.Add(nums[i], nums[i]);
//     
// }
//
// ;
// Console.WriteLine("no repeated values");



// HashSet<int> hash = new HashSet<int>();
//
// hash.Add(1);
// hash.Add(2);
// hash.Add(3);
//
// Console.WriteLine(hash.Count);

// reassigning vals breh

using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

//
// int[] nums = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
// List<int> new_nums = new();
// for (int i = 0; i < nums.Length; i++)
// {
//     if (!new_nums.Contains(nums[i]))
//     {
//        new_nums.Add(nums[i]);
//     }
// }
//
// foreach (var i in new_nums)
// {
// Console.WriteLine(i);
//     
// }
//
// Console.WriteLine(new_nums.Count);


// int k = 0;
//
// HashSet<int> set = new HashSet<int>(nums);
// foreach (int i in nums)
// {
//     set.Add(i);
// }
//
// k = set.Count;
// for (int i = 0; i < nums.Length; i++)
// {
//     for (int j =  1 + i; j < nums.Length -1; j++)
//     {
//         int temp;
//         if (nums[i] == nums[j])
//         {
//             temp = nums[j];
//             nums[j] = nums[j + 1];
//             nums[j + 1] = temp;
//         }
//         
//     }
// }
//
// foreach (var s in nums)
// {
//         Console.WriteLine(s);
// }
// Console.WriteLine("------------");
// Console.Write(k);
// for (int i = 0; i < duplicate_counter - 1; i++)
// {
//     Console.WriteLine(nums[i]);
// }

// 20. Valid Parentheses
// foreach (var i in dict)
// {
// Console.WriteLine(i);
//     
// }

// string s = "{}";
//
//
// Stack<char> my_stack = new();
//
// bool result =true ;
// foreach (char i in s)
// {
//     if (i == '{' || i == '(' || i == '[' )
//     {
//      my_stack.Push(i);   
//     }
//     else
//     {
//         if (my_stack.Count == 0)
//         {
//             result = false;
//         }
//
//         char top = my_stack.Pop();
//         if (i == '}' && top != '{')
//         {
//             result = false;
//         }
//         if (i == ')' && top != '(')
//         {
//             result = false;
//         }if (i == ']' && top != '[')
//         {
//             result = false;
//         }
//
//     }
// }
//
//


// length of last word

// string s = "Oh My!";
// string s = " Fly me to the moon  ";
//
// string s = "b a ";
// // Console.WriteLine(s.Length);
// string last_word = "";
// int lastword_length = 0;
// for (int i = s.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(s[i]);
//     char placeholder = s[i];
//
//     if (placeholder == ' ')
//     {
//         Console.WriteLine("space detected");
//         if (lastword_length > 0)
//         {
//             Console.WriteLine(lastword_length);
//             return lastword_length;
//             // break;
//         }else
//         {
//             Console.WriteLine("Skipping first space");
//         }
//        
//     }
//     else {
//         
//         last_word = last_word + placeholder;
//         lastword_length++;
//         Console.WriteLine("current: {0}", last_word);
//     }
// }
// Console.Write(lastword_length);
// return lastword_length;


// 50. Pow(x, n) 
// Medium Problem

//Example 1:
// 
// Input: x = 2.00000, n = 10
// Output: 1024.00000

// double x = 2.00000;
// int n = -2;
//
// // just raise power?
//
// // what happens if n is negative?
// double current = 0;
// double inverted = Math.Abs(n);
// double result;
// if (n < 0)
// {
//  for (int i = 0; i < inverted; i++) current = x;
//  {
//   if (current == 0)
//   {
//    current = x;
//   }
//   current = current * x;
//   // then get its reciprocal
//   result = 1 / inverted;
//   Console.WriteLine("result: {0}", result);
//   
//  }
//
//  // Console.WriteLine(current);
//  // return current;
//
// }
// else
// {
// for (int i = 0; i < n; i++)
//  {
//   // current = x;
//   if (current == 0)
//   {
//    current = x;
//   }
//   else
//   {
//    current = current * x;
//    Console.WriteLine("{0} * {0}", x);
//    Console.WriteLine(current);
//   }
//  
//  
//  }
//  
// }


// letter combination of a phone number

// 2  -> abc
// 3 -> def
// 4 -> ghi
// 5 -> jkl
// 6 -> mno
// 7 -> pqrs
// 8 ->  tuv
// 9 ->  wxyz
// string digits = "23";
// Dictionary<int, List<string>> dictionary = new();
// dictionary[0] = new List<string> { "a", "b", "c" };
// dictionary[1] = new List<string> { "d", "e", "f" };
// dictionary[2] = new List<string> { "g", "h", "i" };
// dictionary[3] = new List<string> { "j", "k", "l" };
// dictionary[4] = new List<string> { "m", "n", "o" };
// dictionary[5] = new List<string> { "p", "q", "r", "s" };
// dictionary[6] = new List<string> { "t", "u", "v" };
// dictionary[7] = new List<string> { "w", "x", "y", "z" };
//
// for (int i = 0; i < dictionary.Count; i++)
// {
//     for (int j = 0; j < 4; j++)
//     {
//         Console.WriteLine(dictionary[i][j]);
//     }
// }
//

// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
//
//     Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:
//
// Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
//     Return k.
//     Custom Judge:
//
// The judge will test your solution with the following code:
//
// int[] nums = [...]; // Input array
// int val = ...; // Value to remove
// int[] expectedNums = [...]; // The expected answer with correct length.
// // It is sorted with no values equaling val.
//
// int k = removeElement(nums, val); // Calls your implementation
//
// assert k == expectedNums.length;
// sort(nums, 0, k); // Sort the first k elements of nums
// for (int i = 0; i < actualLength; i++) {
//     assert nums[i] == expectedNums[i];
// }

// Sample output
// Input: nums = [3,2,2,3], val = 3
// Output: 2, nums = [2,2,_,_]
// Explanation: Your function should return k = 2, with the first two elements of nums being 2.
//     It does not matter what you leave beyond the returned k (hence they are underscores).
//



// int[] nums = [3, 2, 2, 3];

int[] nums = [3,2,2,3];
// int val = 2;
// int[] result = nums;
// int counter = 0;
// Array.Sort(nums);
//
// for (int i = 0; i < nums.Length; i++)
// {
//     for (int j = i + 1; j < nums.Length; j++)
//     {
//         if (nums[i] == val)
//         {
//             int temp = nums[i];
//             nums[i] = nums[j];
//             nums[j] = temp;
//         }
//     }
// }
//
//
// for (int i = 0; i < nums.Length; i++)
// {
//     
//     if (nums[i] == val)
//     {
//         break;
//     }
//     else
//     {
//         counter++;
//     }
// }
//
// foreach (var items  in nums)
// {
//     Console.WriteLine(items);
//     
// }
// Console.WriteLine(counter);









//
// Given two strings needle and haystack, return the index of the 
//     first occurrence of needle in haystack, or -1 if needle is not part of haystack.
//
//  
//
//     Example 1:
//
// Input: haystack = "sadbutsad", needle = "sad"
// Output: 0
// Explanation: "sad" occurs at index 0 and 6.
//     The first occurrence is at index 0, so we return 0.
//     Example 2:
//
// Input: haystack = "leetcode", needle = "leeto"
// Output: -1
// Explanation: "leeto" did not occur in "leetcode", so we return -1.






string haystack = "sadbutsad";
string needle = "sad";
bool found = false;
int index_holder = 0;
int needle_head = needle[0];
for (int i = 0; i < haystack.Length; i++)
{
    if (haystack[i] ==needle_head)
    {
        index_holder = i;
        int correct_counter = 0;
        for (int j = 0; j < needle.Length; j++)
        {
            if (haystack[i] != needle[j])
            {
                Console.WriteLine("they aint the same");
                break;
            }
            else
            {
                correct_counter++;
            }

            if (correct_counter == needle.Length)
            {
                Console.WriteLine("This is it! @ index: {0}", i);
            }
        }
    }
    
    // Console.WriteLine(haystack[i]);
}
// Console.WriteLine("return -1");









