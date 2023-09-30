using System.ComponentModel;
using System.Text;

namespace CSharpStringExercises.Classes
{
	public class StringExercises
	{
		// 1: Pig Latin
		// Move the first letter of each word to the end of it, then add "ay" to the end of the word. 
		// Leave punctuation marks untouched.
		// If any words entirely consist of punctuation marks you should leave them unchanged
		// The cat sat on the mat. => heTay atcay atsay noay hetay atmay.
		// The string function Split may be useful
		// There are already some unit tests for this function
		public static string PigLatin(string input)
		{
			throw new NotImplementedException();
		}

		// 2. Mexican wave
		// The input string will always be lower case but maybe empty.
		// If the character in the string is whitespace then pass over it as if it was an empty seat
		// Example
		// Wave("hello") => { "Hello", "hEllo", "heLlo", "helLo", "hellO"}
		// Write some unit tests for this function
		public static List<string> Wave(string input)
		{
			throw new NotImplementedException();
		}

		// 3: Hello character codes - Convert to integer character codes
		// Convert the word hello to its character codes (one integer for each code) and output them.
		// Do this for hello in Chinese as well
		// Test this procedure by calling it from main
		public static void WriteHelloCharacterCodes()
		{
			throw new NotImplementedException();
		}

		private static void Write(string input, string message)
		{
			throw new NotImplementedException();
		}

		// 4: Hello character codes - Convert to a byte array
		// Convert the word hello to its character codes expressed as a byte array
		// You can use Encoding.Default.GetBytes() for this
		// Output the result
		// Remember a byte is nothing but an integer between 0-255 that uses one byte of memory
		// Do this for hello in Chinese as well
		// What difference do you see with your answer to question 3?
		// Test this procedure by calling it from main
		public static void WriteHelloAsBytes()
		{
			throw new NotImplementedException();
		}


		// 5. Character codes - convert integer character codes to a string
		// Given an array of integers where each one represents a character code return the string
		// To test, the int array { 956 942 955 959 } represents the string μήλο
		// It might not print nicely to the console but you can inspect the variable, use an assert, or write a test
		// Use a StringBuilder in case you get a long int array as input
		// Write unit tests for this function
		public static string ReadCharacterCodes(int[] codes)
		{
			throw new NotImplementedException();
		}

		// 6. Character codes - convert character codes given as a byte array to a string
		// Remember a byte is nothing but an integer between 0-255 that uses one byte of memory
		// To test, the byte array: { 206, 188, 206, 174, 206, 187, 206, 191 } represents the string μήλο
		// It might not print nicely to the console but you can inspect the variable, use an assert or write a test
		// Write unit tests for this function
		public static string ReadCharacterCodes(byte[] codes)
		{
			throw new NotImplementedException();
		}

		// 7. Anagram
		// Given a word and a list of words return the number of words that are anagrams of the others
		// Anagram("star", new string[] { "rats", "arts", "arc" }) => 2
		// Write unit tests for this function
		public static int Anagram(string input, string[] possibleAnagrams)
		{
			throw new NotImplementedException();
		}
				
		// 8. Variable Name helper
		public enum VariableNameType
		{
			CamelCase,
			PascalCase,
			SnakeCase
		}
		// Return the string in either camelCase, PascalCase or snake_case depending on the user choice
		// You can assume the input is currently written in the normal way with spaces between words
		// E.g Cost of cakes => costOfCakes, CostOfCakes or cost_of_cakes depending on the option chosen
		// Write unit tests for this function
		public static string WriteVariableName(string input, VariableNameType caseNeeded = VariableNameType.CamelCase)
		{
			throw new NotImplementedException();
		}


		// 9: TV Remote (Extension)
		// Consider the search screen pictured below
		// a b c d e
		// f g h i j
		// k l m n o
		// p q r s t
		// u v w x y
		// z _ <
		// The TV remote has buttons to move up, down, left, right and select
		// It always starts in the top left corner at the 'a' button
		// Write a function that will take a list of words
		// It will return the number of key presses required to enter the words
		// The space key is indicated with a _
		// The enter key is indicated with a <
		// All letters can be converted to lower case 
		// Each word must be separated by a space _
		// Each entry must end with the enter key < being pressed
		// You can assume that the strings do not contain any symbols that are not on the screen or _ or < symbols
		// So for example to enter ET would take 14 key presses
		// b,c,d,e,press e,j,o,t,press t,y,x,w,<,press <
		// War and Peace would take 79 key presses
		// Hint: decompose the problem into sub programs
		// Write unit tests for the problem. 
		public static int CalculateKeyPresses(List<string> words)
		{
			throw new NotImplementedException();
		}
	}
}
