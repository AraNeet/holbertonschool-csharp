class Line {
    public static void PrintLine(int length) {
        if (length > 0) {
            for (int line = 0; line < length; line++) {
                Console.Write("_");
            }
        }
        Console.Write("\n");
    }
}