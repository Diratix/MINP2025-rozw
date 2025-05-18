using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;

int nwd(int a, int b) {
    if (b == 0) {
        return a;
    }

    while (true) {
        int rest = a % b;

        if (rest == 0) {
            return b;
        } else {
            a = b;
            b = rest;
        }
    }
}

try {
    using (StreamReader reader = new StreamReader("../../../dron.txt")) {
        List<Point> points = new List<Point>();
        List<int> nwds = new List<int>();
        int counter = 0;

        while (!reader.EndOfStream) {
            string? line = reader.ReadLine();
            if (line == null) continue;
            line = line.Trim();

            Point point = new Point();

            point.X = Convert.ToInt32(line.Split(' ')[0]);
            point.Y = Convert.ToInt32(line.Split(' ')[1]);
            if (point.X < 0 ) point.X *= -1;
            if (point.Y < 0 ) point.Y *= -1;

            points.Add(point);
        }

        foreach (Point point in points) {
            nwds.Add(nwd(point.X, point.Y));
        }

        foreach (int nwdInt in nwds) {
            if (nwdInt > 1) {
                counter++;
            }
        }

        Console.WriteLine(counter);
    }
} catch (FileNotFoundException) {
    Console.WriteLine("Plik nie został znaleziony.");
} catch (Exception e) {
    Console.WriteLine(e);
}