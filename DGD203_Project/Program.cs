using System;

class Program
{
    static void Main()
    {
        // ASCPII Kullanarak Giriş yaptım 
        Console.WriteLine(@"
         __          __  _                              _      ____   ____  _ 
         \ \        / / | |                            | |    / __ \ / __ \| |
          \ \  /\  / /__| | ___ ___  _ __ ___   ___  __| |   | |  | | |  | | |
           \ \/  \/ / _ \ |/ __/ _ \| '_ ` _ \ / _ \/ _` |   | |  | | |  | | |
            \  /\  /  __/ | (_| (_) | | | | | |  __/ (_| |   | |__| | |__| | |
             \/  \/ \___|_|\___\___/|_| |_| |_|\___|\__,_|    \____/ \____/|_|
                                                                             
        ");
        Console.WriteLine("What's your name?");
        string playerName = Console.ReadLine();

        Console.WriteLine($"Nice to meet you, {playerName}! Let's get started.");

        Console.WriteLine(@"
     ");


        // Oyunun Başlangıcı
        Console.WriteLine(@"
         _   _
        | | | |
        | |_| | __ _ _ __   __ _ _ __ ___   __ _ _ __
        |  _  |/ _` | '_ \ / _` | '_ ` _ \ / _` | '_ \
        | | | | (_| | | | | (_| | | | | | | (_| | | | |
        \_| |_/\__,_|_| |_|\__, |_| |_| |_|\__,_|_| |_|
                             __/ |
                            |___/
        ");

        // Sorular ve cevaplar (şıklar dahil) ///// Zincileme sorularda if else kullanmayı unutma
        string[] questions = new string[]
        {
            "1. Do you prefer to start your meal with soup or salad?",
            "Would you prefer hot soup or cold soup?",
            "Do you like fruits in your salad?",
            "2. How many meals do you eat in a day?",
            "3. Are you a vegetarian?",
            "Do you prefer meat or chicken as the main dish?",
            "Which brand is both a tire company and gives restaurant ratings?"
        };
        string[] answers = new string[6];
        int score = 0;

        answers[0] = AskQuestion(questions[0],
            new string[] {
                "a) Soup",
                "b) Salad"
            });
        if (answers[0].StartsWith("a"))
        {
            answers[1] = AskQuestion(questions[1],
                new string[] {
                    "a) Hot Soup",
                    "b) Cold Soup"
                });
        }
        else
        {
            answers[1] = AskQuestion(questions[2],
                new string[] {
                    "a) Yes",
                    "b) No"
                });
        }

        answers[2] = AskQuestion(questions[3],
            new string[] {
                "a) 1",
                "b) 2",
                "c) 3",
                "d) 3+"
            });
        if (answers[2].StartsWith("a") || answers[2].StartsWith("b"))
        {
            Console.WriteLine("This is not very healthy. You should aim for at least 3 meals a day.");
        }
        else
        {
            Console.WriteLine("Great! But don't forget to count your calories.");
        }

        answers[3] = AskQuestion(questions[4],
            new string[] {
                "a) Yes",
                "b) No"
            });
        if (answers[3].StartsWith("a"))
        {
            Console.WriteLine("You're in a very small slice of the population.");
        }
        else
        {
            answers[4] = AskQuestion(questions[5],
                new string[] {
                    "a) Meat",
                    "b) Chicken"
                });
        }

        answers[5] = AskQuestion(questions[6],
            new string[] {
                "a) Michelin",
                "b) Goodyear"
            });

        if (answers[5].StartsWith("a"))
        {
            Console.WriteLine("Congratulations on your culinary knowledge!");
            Console.WriteLine(@"
             ______ _ _  __     __      _               
            / _____| (_)/ _|   |  \    | |              
           | (____ | |_| |_ ___|   \ _ | | _____  _____ 
            \____ \| | |  _/ _ \ |\ \  \| |/ _ \ \/ / _ \
           _____) | | | ||  __/ | \ \  | |  __/>  <  __/
           |_____/|_|_|_| \___|_|  \_\_|_|\___/_/\_\___|
            ");
        }
        else
        {
            Console.WriteLine("Oops, the answer is Michelin. Game Over!");
            Console.WriteLine(@"
             ____                       ___                 
            / ___| __ _ _ __ ___   ___  / _ \__   _____ _ __ 
           | |  _ / _` | '_ ` _ \ / _ \| | | \ \ / / _ \ '__|
           | |_| | (_| | | | | | |  __/| |_| |\ V /  __/ |   
            \____|\__,_|_| |_| |_|\___| \___/  \_/ \___|_|   
            ");
        }

        // Fonksiyon tanıtma 
        Console.WriteLine($"\nThank you for answering the questions, {playerName}!");

        for (int i = 0; i < answers.Length; i++)
        {
            if (!string.IsNullOrEmpty(answers[i]))
                Console.WriteLine($"{questions[i]} \nYour answer: {answers[i]}");
        }

        if (score <= 4)
            Console.WriteLine("You seem to prefer a peaceful and introspective lifestyle. You enjoy the quiet moments and personal space.");
        else if (score <= 6)
            Console.WriteLine("You like a balanced lifestyle. You appreciate both quiet moments and social interactions.");
        else
            Console.WriteLine("You enjoy an active and social lifestyle. You thrive in social settings and enjoy being around people.");

        Console.WriteLine(@"
         ______ _           _
        |  ____(_)         (_)
        | |__   _ _ __ ___  _ _ __   __ _
        |  __| | | '_ ` _ \| | '_ \ / _` |
        | |    | | | | | | | | | | | (_| |
        |_|    |_|_| |_| |_|_|_| |_|\__, |
                                     __/ |
                                    |___/
        ");

        Console.WriteLine("Thanks for playing!");
    }

    static string AskQuestion(string question, string[] options)
    {
        while (true)
        {
            Console.WriteLine(question);
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine($"{(char)('a' + i)}. {options[i]}");
            }

            string input = Console.ReadLine().ToLower();
            if (input.Length == 1 && input[0] >= 'a' && input[0] < 'a' + options.Length)
            {
                return options[input[0] - 'a'];
            }
            else
            {
                Console.WriteLine("Please choose one of the given options.");
            }
        }
    }
}

