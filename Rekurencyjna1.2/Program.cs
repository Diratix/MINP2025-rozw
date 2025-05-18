int counter = 0;

long n1 = 316498;
long n2 = 43657688;
long n3 = 154005710;
long n4 = 998877665544321;

int k1 = n1.ToString().Length;
int k2 = n2.ToString().Length;
int k3 = n3.ToString().Length;
int k4 = n4.ToString().Length;

long przestaw(long n) {
    counter++;
    long r = n % 100;
    long a = r / 10;
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

bool isEven(int k) {
    if (k % 2 == 0) {
        return true;
    } else {
        return false;
    }
}

przestaw(n1);
Console.WriteLine("N wynosi: {0} natomiast K wynosi {1}", counter, isEven(k1) ? k1 / 2 : (k1 + 1) / 2);
counter = 0;

przestaw(n2);
Console.WriteLine("N wynosi: {0} natomiast K wynosi {1}", counter, isEven(k2) ? k2 / 2 : (k2 + 1) / 2);
counter = 0;

przestaw(n3);
Console.WriteLine("N wynosi: {0} natomiast K wynosi {1}", counter, isEven(k3) ? k3 / 2 : (k3 + 1) / 2);
counter = 0;

przestaw(n4);
Console.WriteLine("N wynosi: {0} natomiast K wynosi {1}", counter, isEven(k4) ? k4 / 2 : (k4 + 1) / 2);
counter = 0;
