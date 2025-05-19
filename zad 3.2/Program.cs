using System.Drawing;

try {
    using (StreamReader reader = new StreamReader("../../../dron_przyklad.txt")) {
        List<Point> positions = new List<Point>();
        Point lastPosition = new Point();
        int counter = 0;

        while (!reader.EndOfStream) {
            string? line = reader.ReadLine();
            if (line == null) continue;
            line = line.Trim();

            Point point = new Point();

            point.X = Convert.ToInt32(line.Split(' ')[0]);
            point.Y = Convert.ToInt32(line.Split(' ')[1]);

            lastPosition.Offset(point);

            positions.Add(lastPosition);
        }

        foreach (Point position in positions) {
            if (position.X > 0 && position.X < 5000) {
                if (position.Y > 0 && position.Y < 5000) {
                    counter++;
                }
            }
        }

        Console.WriteLine(counter);
    }
} catch (FileNotFoundException) {
    Console.WriteLine("Plik nie istnieje.");
} catch (Exception e) {
    Console.WriteLine(e);
}