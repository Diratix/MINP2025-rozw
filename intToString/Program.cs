int stringToInt(string str) {
    int number = 0;

    for (int i = 0; i < str.Length; i++) {
        int digit = str[i] - '0';

        number = number * 10 + digit;
    }

    return number;
}

int passed = 0;

for (int i = 1; i <= 100000; i++) {
    string current = i.ToString();

    int intFromCurr = stringToInt(current);

    if (intFromCurr == i) {
        passed++;
    } else {
        continue;
    }
}

Console.WriteLine($"Passed {passed}/100000 tests.");