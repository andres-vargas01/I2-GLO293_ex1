// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

string inputText =
@"The Mexican Revolution, which occurred from 1910 to 1920, was a pivotal period in Mexican history. 
It began on November 20, 1910, with an armed uprising against President Porfirio Díaz, who had held power for over three decades. 
The promulgation of the Mexican Constitution on Feb 5th, 1917, introduced significant reforms, addressing issues such as land reform,
workers' rights, and the separation of church and state. March 21st, 1917, marked the presidency of Venustiano Carranza, 
whose tenure focused on consolidating power and implementing reforms. 
The assassination of Emiliano Zapata on 04/10/1919, deeply impacted the revolution, particularly the agrarian movement. 
Finally, on 05-21-1920, Álvaro Obregón led a successful revolt against Carranza's government, resulting in his presidency. 
These important dates highlight key moments in the Mexican Revolution's trajectory, shaping the course of Mexico's future.";


// The pattern I found by using chat gpt and I validated using https://regexr.com/
string pattern = @"(\b(?:January|February|March|April|May|June|July|August|September|October|November|December|Jan|Feb|Mar|Apr|May|Jun|Jul|Aug|Sep|Oct|Nov|Dec) \d{1,2}(?:th|st|nd|rd)?, \d{4}\b)|(\b\d{2}(\/|-)\d{2}(\/|-)\d{2,4}\b)";




Regex regex = new Regex(pattern);

MatchCollection matches = regex.Matches(inputText);


if(matches.Count > 0)
{
    Console.WriteLine("Found matches:");
    foreach(Match match in matches)
    {
        Console.WriteLine(match.Value);
    }
}
else
{
    Console.WriteLine("No matches found.");
}
