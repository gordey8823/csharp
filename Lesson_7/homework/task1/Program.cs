string DigitsMToN(int m, int n)
{
    string rezult = $"{m}";
    if (m == n)
    {
        return rezult;
    }
    else
    {
        return $"{rezult}, {DigitsMToN(m + 1, n)}";
    }
}

Console.Write(DigitsMToN(3, 9));