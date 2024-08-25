class Number {
    public static int PrintLastDigit(int number) {
        int lastNum = Math.Abs(number) % 10;
        if (lastNum < 0) {
            lastNum *= -1;
        }
        Console.Write("{0}", lastNum);
        return lastNum;
    }
}
