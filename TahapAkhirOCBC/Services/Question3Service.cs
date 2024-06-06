namespace TahapAkhirOCBC.Services;

public class Question3Service
{
    public static string Programmer(List<string> dict, string text)
    {
        if (!IsDictionary(dict, text))
        {
            return "<no way>";
        };
        
        var res = new LinkedList<string>();
        bool[] cd = new bool[dict.Count + 1];

        while (true)
        {
            int count = 0;
            int counter = 0; 
            var textTemp = text;
            
            for (int i = 0; i < dict.Count; i++)
            {
                if (
                    (textTemp.Contains(dict[i]) && !cd[i])
                    || (textTemp.Contains(dict[i]) && cd[i] && count == 1)
                )
                {
                    res.AddLast(dict[i]);
                    textTemp = textTemp.Replace(dict[i], "");
                    
                    if (dict.Contains(textTemp) && cd[dict.IndexOf(textTemp)])
                    {
                        res.AddLast(textTemp);
                        textTemp = textTemp.Replace(textTemp, "");
                    }
                    
                    cd[i] = true;
                    counter++;
                    count = 1;
                }
            }

            if (counter == 0) break;
        }


        return String.Join(", ", res);
    }
    
    private static bool IsDictionary(List<string> dictionary, string input)
    {
        Dictionary<char, int> setDictionary = new Dictionary<char, int>();
        Dictionary<char, int> setInput = new Dictionary<char, int>();
        
        foreach (var text in dictionary)
        {
            foreach (var c in text)
            {
                if (!setDictionary.ContainsKey(c))
                {
                    setDictionary[c] = 1;
                }
            }
        }
        
        foreach (var c in input)
        {
            if (!setInput.ContainsKey(c))
            {
                setInput[c] = 1;
            }
        }
        
        foreach (var keyValuePair in setInput)
        {
            if (!setDictionary.ContainsKey(keyValuePair.Key)) return false;
        }
        
        return true;
    }
}