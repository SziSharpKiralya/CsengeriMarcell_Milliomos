using System.Diagnostics.Metrics;

namespace Milliomos
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string fileContent = File.ReadAllText("kerdes.txt");

			string[] lines = fileContent.Split('\n');
			
			

            for (int i = 0; i < lines.Length; i++)
            {
				string[] words = lines[i].Split(';');

				//Console.WriteLine(lines[i]);
				int level = int.Parse(words[0]);
				string question = words[1];
				string[] answers = { words[2], words[3], words[4], words[5]};
                char correct = char.Parse(words[6]);
				string theme = words[7];

				Kerdes kerdes = new Kerdes(level, question, answers, correct, theme);
            }


        }
	}
}
