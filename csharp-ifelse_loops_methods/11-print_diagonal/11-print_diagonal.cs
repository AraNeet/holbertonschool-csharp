class Line {
    public static void PrintDiagonal(int length) {
        if (length > 0) {
            for (int line = 1; line <= length; line++) {
                for (int space = 1; space < line; space++){
                    Console.Write(" ");
                }
                Console.Write("\\\n");
            }
        }
        Console.Write("\n");
    }
}