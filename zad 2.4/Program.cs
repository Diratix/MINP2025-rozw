int toBinFrom3(string from) {
    int number = 0;

    foreach (char c in from) {
        int digit = c - '0';
        number = number * 3 + digit;
    }

    return number;
}

string decTo3Based (int number) {
    string newNumber = "";

    while (number > 0) {
        newNumber = number % 3 + newNumber;
        number /= 3;
    }

    return newNumber;
}

try {
    using (StreamReader reader = new StreamReader("../../../symbole_przyklad.txt")) {
        int sumOfNumbers = 0;
        string numberInCode = "";

        while (!reader.EndOfStream) {
            string? line = reader.ReadLine();
            if (line == null) continue;
            line.Trim();

            string newNumber = "";
            int number;

            foreach (char letter in line) {
                if (letter == 'o') {
                    newNumber += "0";
                } else if (letter == '+') {
                    newNumber += "1";
                } else if (letter == '*') {
                    newNumber += "2";
                }
            }

            number = toBinFrom3(newNumber);
            sumOfNumbers += number;
        }

        string numberIn3Based = decTo3Based(sumOfNumbers);

        foreach (char letter in numberIn3Based) {
            if ( letter == '0') {
                numberInCode += "o";
            } else if (letter ==  '1') {
                numberInCode += "+";
            } else if (letter == '2') {
                numberInCode += '*';
            }
        }

        Console.WriteLine($"{sumOfNumbers} {numberInCode}");
    }
} catch (FileNotFoundException) {
    Console.WriteLine("Plik nie istnieje.");
} catch (Exception e) {
        Console.WriteLine(e);
}