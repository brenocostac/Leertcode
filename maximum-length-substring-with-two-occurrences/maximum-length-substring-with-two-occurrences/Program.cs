int MaximumLengthSubstring(string s)
{
    int max = 1;
    int left, right;
    left = right = 0;
    
    var charCount = new Dictionary<char, int>() 
    {
        { s[right], 1 }
    };
    

    for (right = 1; right < s.Length; right++)
    {
        if (charCount.ContainsKey(s[right]))
        {
            charCount[s[right]]++;
        }
        else
        {
            charCount[s[right]] = 1;
        }
        
        while (charCount[s[right]] > 2)
        {
            charCount[s[left]]--;
            left++;
        }
        
        max = Math.Max(max, right - left + 1);

    }
    
    
    
    return max;

}

var s = "eebadadbfa";
Console.WriteLine(MaximumLengthSubstring(s)); 