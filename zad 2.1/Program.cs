try {
    using (StreamReader reader = new StreamReader("../../../symbole.txt")) {
        while (!reader.EndOfStream) {
            string reversedLine;

            string? line = reader.ReadLine();
            if (line == null) continue;

            line = line.Trim();
            reversedLine = new String(line.Reverse().ToArray());

            if (reversedLine == line) {
                Console.WriteLine(line);
            }
        }
    }
} catch (FileNotFoundException) {
    Console.WriteLine("Plik nie został znaleziony.");
} catch(Exception e) {
    Console.WriteLine(e);
}

