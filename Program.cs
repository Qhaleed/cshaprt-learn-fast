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

string s = "b a ";
// Console.WriteLine(s.Length);
string last_word = "";
int lastword_length = 0;
for (int i = s.Length - 1; i >= 0; i--)
{
    Console.WriteLine(s[i]);
    char placeholder = s[i];

    if (placeholder == ' ' )
    {
        Console.WriteLine("space detected");
        if (lastword_length > 1)
        {
            break;
        }
       
    }
    {
        
        last_word = last_word + placeholder;
        lastword_length++;
        Console.WriteLine("current: {0}", last_word);
    }
}
Console.Write(lastword_length);
return lastword_length;



