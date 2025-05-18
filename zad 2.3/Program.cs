int toBinFrom3 (string from) {
    int number = 0;

    foreach (char c in from) {
        int digit = c - '0';
        number = number * 3 + digit;
    }

    return number;
}

try {
    using (StreamReader reader = new StreamReader("../../../symbole.txt")) {
        List<int> convertedNumbers = new List<int>();
        List<string> codes = new List<string>();
        int maxVal = 0;
        int maxIndex = 0;

        while (!reader.EndOfStream) {
            string? line = reader.ReadLine();

            if (line == null) {
                continue;
            }

            line = line.Trim();
            string newNumber = "";

            foreach (char letter in line) {
                if (letter == 'o') {
                    newNumber += "0";
                } else if (letter == '+') {
                    newNumber += "1";
                } else if (letter == '*') {
                    newNumber += "2";
                }
            }

            int number = toBinFrom3(newNumber);

            convertedNumbers.Add(number);
            codes.Add(line);
        }

        for (int i = 0; i < convertedNumbers.Count; i++) {
            if (convertedNumbers[i] > maxVal) {
                maxVal = convertedNumbers[i];
                maxIndex = i;
            }
        }

        Console.WriteLine($"{maxVal} {codes[maxIndex]}");
    }
} catch (FileNotFoundException) {
    Console.WriteLine("Plik nie istnieje.");
} catch (Exception e) {
    Console.WriteLine(e);
}