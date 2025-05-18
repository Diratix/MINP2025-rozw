int counter = 0;

long przestaw(long n) {
    counter++;
    long r = n % 100;
    long a = r/10;
    long b = r % 10;
    n = n / 100;

    long w;

    if (n > 0) {
        w = a + 10 * b + 100 * przestaw(n);
    } else if (a > 0) {
        w = a + 10 * b;
    } else {
        w = b;
    }

    return w;
}

Console.WriteLine("Wynik {0}, liczba wywołań {1}", przestaw(998877665544321), counter);