/*
Challenge information:

Complete the solution so that the function will break up camel casing, using a space between words.

Examples:

"camelCasing"  =>  "camel Casing"
"identifier"   =>  "identifier"
""             =>  ""
*/

//set up test example

using System.Text.RegularExpressions;

string str = "camelCasingTestAgain";

//Try direct approach with RegEx:

var result = Regex.Replace(str, @"(\p{Lu})", " $1");

/*
regEx explanation:

\p{L} is a Unicode property shorthand for \p{Letter}, matching any letter from any language. \p{Lu} matches an uppercase letter with a lowercase variant,
and \p{Ll} will match a lowercase letter that has an uppercase variant.

$1 is the captured capital letter, so having the replacement string be " $1" replaces the capital letter with a space and then the capital letter.
*/

Console.WriteLine(result);
