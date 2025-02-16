namespace Lab1task3;
public class Third
{
    static void Main()
    {
        // НАЧАЛО взаимодействия с пользователем
        Console.WriteLine("Введите первое предложение: ");
        string sen1 = Console.ReadLine();
        Console.WriteLine("Введите второе предложение: ");
        string sen2 = Console.ReadLine();
        // КОНЕЦ взаимодействия с пользователем

        // НАЧАЛО логики
        string[] words1 = Spliting(sen1);
        string[] words2 = Spliting(sen2);
        string[] results = new string[words1.Length];
        int resultsCount = CompareWords(words1, words2, results);
        // КОНЕЦ логики

        // НАЧАЛО взаимодействия с пользователем
        for (int i = 0; i < resultsCount; i++)
        {
            Console.WriteLine(results[i]);
        }
        // КОНЕЦ взаимодействия с пользователем
    }

    static string[] Spliting(string sen)
    {
        int count = 0;
        for (int i = 0; i < sen.Length; i++)
            if (sen[i] == ' ') count++;

        string[] words = new string[count + 1];
        int index = 0, start = 0;

        for (int i = 0; i < sen.Length; i++)
        {
            if (sen[i] == ' ' || i == sen.Length - 1)
            {
                int len = (i == sen.Length - 1) ? (i - start + 1) : (i - start);
                words[index++] = sen.Substring(start, len);
                start = i + 1;
            }
        }
        return words;
    }

    static bool Dublicate(string[] words, string word, int pos)
    {
        for (int i = 0; i < pos; i++)
            if (words[i] == word)
                return true;
        return false;
    }

    public static int CompareWords(string[] words1, string[] words2, string[] results)
    {
        int index = 0;

        for (int i = 0; i < words1.Length; i++)
        {
            if (!Dublicate(words1, words1[i], i))
            {
                bool found = false;
                for (int j = 0; j < words2.Length; j++)
                {
                    if (words1[i] == words2[j])
                    {
                        found = true;
                        break;
                    }
                }
                results[index] = words1[i] + " - " + (found ? "входит" : "не входит");
                index++;
            }
        }
        return index;
    }
}
