class Character {
    public static bool IsLower(char c) {
        for (char letter = 'a'; letter <= 'z'; letter++) {
            if (letter == c) {
                return true;
            }
        }
        return false;
    }
}