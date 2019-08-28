using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillboxBot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, you’re being welcomed by helper bot");

            while(true)
            {
                var Result = AnswerQuestion();
                if (!Result)
                {
                    return;
                }
            }
           
        }

        static bool AnswerQuestion()
        {
            var UserQuestion = Console.ReadLine().ToLower();
            List<string> Answers = new List<string>();

            Dictionary<string, string> Questions = new Dictionary<string, string>()
            {
                {"hi", "Henlo!"},
                { "wazzup", "Nothing. Watching a game. Drinking Bud"}
            };

            foreach(var Question in Questions)
            {
                if (UserQuestion.Contains(Question.Key))
                {
                    Answers.Add(Question.Value);
                }
            }

            if (UserQuestion.Contains("time"))
            {
                var Time = DateTime.Now.ToString("HH:mm:ss");
                Answers.Add($"It’s {Time} now");
            }

            if (UserQuestion.Contains("date"))
            {
                var Date = DateTime.Now.ToString("dd:MM:yyyy");
                Answers.Add($"Today is {Date}");
            }

            Console.WriteLine(String.Join(", ", Answers));

            if (UserQuestion.Contains("bye"))
            {
                Console.WriteLine("bb gg");
                return false;
            }

            return true;
        }
    }
}
