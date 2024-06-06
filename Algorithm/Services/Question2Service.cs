using Algorithm.Utils;

namespace Algorithm.Services;

public class Question2Service
{
    public static string HotDog(List<string> texts, string[] input)
    {
        List<string> res = new();
        string beginWord = input[0];
        string endWord = input[1];

        if (texts[0] != beginWord)
        {
            texts.Insert(0, beginWord);
        }
        res.Add(texts[0]);
        
        for (int i = 1; i < texts.Count; i++)
        {
            res.Add(texts[i]);
            
            if (texts[i] == endWord)
            {
                res.Add(texts[i]);
                return Util.ListToString(res);
            }
            else if(isValid(endWord, texts[i]))
            {
                res.Add(endWord);
                return Util.ListToString(res);
            }
        }

        return "<no way>";
    }

    private static bool isValid(string input, string target)
    {
        Dictionary<char, int> setInput = new();
        Dictionary<char, int> setTarget = new();

        foreach (var c in input)
        {
            if (!setInput.ContainsKey(c)) setInput[c] = 1;
        }
        
        foreach (var c in target)
        {
            if (!setTarget.ContainsKey(c)) setTarget[c] = 1;
        }
        
        int counter = 0;
        foreach (var kvp in setInput)
        {
            if (!setTarget.ContainsKey(kvp.Key)) counter++;
        }

        if (counter > 1) return false;
        return true;
    }
}