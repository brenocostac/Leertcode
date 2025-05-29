
void Reverse(char [] charArr, int left, int right)
{
    while (left < right)
    {
        (charArr[left], charArr[right]) = (charArr[right], charArr[left]);
        left++;
        right--;
    }
}

string ReverseWords(string s) {
    char[] charArr = s.ToCharArray();
    int leftPointer = 0;
    int rightPointer = 0;
    int length = charArr.Length - 1;

    while (true)
    {
        if (charArr[rightPointer] == ' ')
        {
            Reverse(charArr, leftPointer, rightPointer - 1);
            rightPointer++;
            leftPointer = rightPointer;

        }

        if (rightPointer == length)
        {
            Reverse(charArr, leftPointer, rightPointer);
            break;
        }
        rightPointer++;
        

       
    }
    return new string(charArr);
}

 
string input = "Hello World";
Console.WriteLine(input);
string reversed = ReverseWords(input);
Console.WriteLine(reversed);