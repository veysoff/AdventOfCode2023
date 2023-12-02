// See https://aka.ms/new-console-template for more information

// Task 1

var puzzle =
    "Game 1: 1 red, 10 blue, 5 green; 11 blue, 6 green; 6 green; 1 green, 1 red, 12 blue; 3 blue; 3 blue, 4 green, 1 red\nGame 2: 3 red, 5 green; 5 green, 7 red; 1 blue, 7 red, 3 green; 3 red, 2 blue; 5 green, 4 red\nGame 3: 4 blue, 4 green; 2 green, 2 blue; 8 green, 2 red, 3 blue\nGame 4: 3 blue, 15 green; 16 green; 2 red, 7 green; 2 blue, 14 green\nGame 5: 8 green, 6 red, 16 blue; 8 red, 12 green; 1 red, 9 green, 16 blue; 8 red, 3 green; 2 blue, 5 red, 10 green; 15 red, 4 blue, 8 green\nGame 6: 5 blue, 2 green; 6 red, 3 green; 4 green, 4 blue, 2 red; 14 blue, 2 red\nGame 7: 2 green, 6 blue, 1 red; 2 blue, 1 red; 8 blue; 5 blue, 1 green; 6 blue, 1 red; 2 blue\nGame 8: 1 red, 10 blue, 1 green; 6 blue, 1 red; 3 blue, 2 green; 1 red, 1 blue, 3 green; 13 blue; 10 blue, 3 green, 3 red\nGame 9: 2 blue; 8 green, 3 blue; 4 green; 14 green, 1 red, 2 blue; 3 blue, 1 red, 12 green\nGame 10: 1 blue, 7 green; 1 red, 3 green, 5 blue; 1 blue, 5 green, 1 red; 13 green, 5 blue, 2 red\nGame 11: 1 green, 10 red, 6 blue; 15 red, 12 blue; 18 red, 1 green, 1 blue\nGame 12: 16 red, 8 blue, 1 green; 15 red, 3 blue, 1 green; 5 red\nGame 13: 6 red, 7 blue, 7 green; 3 blue, 4 red, 13 green; 1 blue, 6 red, 11 green; 2 red, 1 blue, 14 green; 8 green, 5 blue, 2 red; 4 blue, 18 green, 4 red\nGame 14: 16 red, 3 blue, 1 green; 7 green, 3 red; 16 red, 15 green, 3 blue; 3 blue, 13 red, 10 green\nGame 15: 1 blue, 1 red; 3 blue, 2 green; 1 red; 2 red, 2 green, 3 blue; 3 blue, 1 red, 3 green\nGame 16: 9 red, 3 blue; 13 red, 9 blue; 9 blue, 10 red; 5 red, 10 blue, 1 green; 2 red, 6 green, 8 blue; 6 green, 13 red, 5 blue\nGame 17: 15 red, 17 green, 8 blue; 18 red, 16 blue, 15 green; 8 blue, 17 green, 10 red; 5 green, 3 red, 12 blue\nGame 18: 2 blue, 11 red, 2 green; 1 green, 11 red, 11 blue; 1 red, 4 blue; 10 blue, 9 red; 1 blue, 7 red\nGame 19: 2 blue, 3 green, 5 red; 8 blue, 16 green; 12 red, 7 blue, 8 green; 9 green, 1 blue; 3 red, 16 green, 10 blue\nGame 20: 3 blue, 5 green, 6 red; 2 red, 8 blue, 7 green; 7 green, 3 blue; 2 red, 11 blue; 1 green, 6 red, 3 blue\nGame 21: 16 red, 3 blue, 8 green; 10 red, 15 blue, 3 green; 6 green, 13 red, 15 blue; 11 green, 13 blue, 10 red\nGame 22: 8 green, 1 blue; 2 blue, 9 green, 3 red; 2 red, 2 blue; 1 red, 3 blue, 8 green; 2 blue, 1 green; 1 green, 2 blue\nGame 23: 2 blue, 8 red, 5 green; 9 green, 2 blue; 10 red, 2 green; 12 red, 1 blue; 11 green, 2 blue, 13 red; 7 green\nGame 24: 6 red; 13 green, 7 red, 10 blue; 7 green, 9 red, 1 blue; 3 blue, 2 green, 2 red\nGame 25: 7 green, 1 red, 2 blue; 8 green, 2 blue, 5 red; 5 blue, 8 green, 4 red; 5 blue, 2 green, 1 red; 5 green, 3 red, 7 blue; 3 blue, 6 green, 1 red\nGame 26: 6 green, 3 red; 1 blue, 2 green, 2 red; 2 green, 2 red, 3 blue; 4 blue, 8 red, 2 green; 1 red, 1 green, 1 blue; 6 red, 5 blue\nGame 27: 4 green, 13 blue, 2 red; 2 red, 7 green, 10 blue; 14 blue, 11 green, 1 red; 10 blue, 15 green\nGame 28: 4 green, 13 red, 7 blue; 2 red, 5 blue; 5 blue, 4 green\nGame 29: 6 green, 15 red; 1 blue, 6 red, 8 green; 6 green, 1 blue; 12 red; 1 green, 7 red, 1 blue\nGame 30: 4 blue, 4 green, 2 red; 6 blue, 9 red, 20 green; 9 blue, 4 red, 2 green; 8 red, 8 blue, 1 green; 6 green, 12 blue, 2 red; 8 green, 8 red\nGame 31: 9 blue; 1 red, 2 blue, 5 green; 2 blue, 2 red, 9 green; 2 blue, 1 red, 8 green; 11 green, 2 red, 3 blue; 7 green, 5 blue\nGame 32: 15 red, 5 green; 4 green, 2 blue, 3 red; 1 blue, 9 red; 1 blue, 15 red; 4 blue, 2 red, 8 green; 3 green, 3 blue\nGame 33: 13 blue, 1 red, 1 green; 8 blue, 6 red; 4 blue, 2 red\nGame 34: 5 blue, 9 red, 7 green; 8 red, 6 green, 5 blue; 2 blue, 7 green, 12 red\nGame 35: 4 blue, 15 red; 1 green, 10 blue, 7 red; 9 red, 3 green, 1 blue; 13 red, 9 blue; 3 blue, 2 red\nGame 36: 4 blue, 18 green, 2 red; 5 green, 6 blue, 11 red; 6 red, 12 blue, 14 green; 19 green, 10 blue, 7 red; 7 red, 8 green, 9 blue\nGame 37: 16 blue, 5 green, 18 red; 3 blue, 14 green, 1 red; 4 blue, 3 green, 14 red; 12 green, 7 red, 15 blue; 15 green, 11 blue, 2 red; 8 blue, 13 green, 6 red\nGame 38: 6 red, 4 blue, 12 green; 3 red, 11 blue; 16 green, 2 blue, 8 red; 4 blue, 11 red, 4 green; 17 green, 7 red, 10 blue; 9 blue, 15 green, 1 red\nGame 39: 1 green, 1 red, 10 blue; 1 red, 5 blue, 2 green; 4 red, 7 blue; 9 red, 6 green, 5 blue; 1 green, 2 blue, 9 red\nGame 40: 13 blue, 11 red, 12 green; 8 green, 11 red, 4 blue; 2 blue, 2 green, 12 red; 2 green, 3 red, 13 blue; 13 blue, 6 red, 2 green; 4 green, 6 red, 8 blue\nGame 41: 12 red, 4 green, 13 blue; 4 red, 7 blue, 10 green; 17 green, 17 red, 11 blue\nGame 42: 1 red, 1 green; 1 red, 4 green; 1 blue, 4 red, 4 green; 3 red; 1 blue, 3 green, 1 red\nGame 43: 7 blue, 10 green; 5 blue, 2 green; 2 blue, 1 green, 4 red; 14 red, 6 green, 7 blue; 4 green, 14 red, 8 blue; 4 green, 6 red\nGame 44: 9 green, 4 red; 4 red, 6 green; 5 red, 2 blue, 7 green; 9 blue, 1 green, 14 red\nGame 45: 20 blue, 4 red, 6 green; 3 blue, 1 green, 6 red; 8 blue, 8 green, 11 red\nGame 46: 1 green, 6 red; 6 red, 3 blue, 3 green; 6 red, 3 blue, 4 green; 1 blue, 5 red; 1 green, 4 red, 1 blue; 2 green, 4 red\nGame 47: 12 green, 8 red, 4 blue; 7 green, 6 red, 11 blue; 4 red, 11 blue, 12 green\nGame 48: 1 green, 3 blue; 13 green, 3 red, 11 blue; 7 blue, 1 green, 2 red; 7 red, 15 green, 4 blue; 4 red, 8 blue, 10 green; 15 green, 8 blue, 6 red\nGame 49: 2 red; 2 red, 9 blue; 4 blue, 1 green\nGame 50: 10 blue, 1 green, 18 red; 13 red, 1 green, 7 blue; 4 red, 2 green, 9 blue; 2 green, 4 red, 10 blue; 7 blue, 3 red; 19 red, 9 blue\nGame 51: 2 green, 2 red, 5 blue; 9 red, 5 blue; 3 red, 10 blue; 9 blue, 6 red, 7 green; 2 red, 5 blue\nGame 52: 6 blue, 3 green; 5 green, 3 blue, 5 red; 1 blue, 2 green, 2 red\nGame 53: 2 blue, 9 green, 15 red; 18 red, 1 blue; 13 red, 12 green; 7 green, 2 blue, 9 red\nGame 54: 18 green; 2 red, 6 green; 6 red, 9 green, 1 blue; 1 blue, 4 green, 5 red; 3 red; 3 green, 4 red\nGame 55: 5 red, 2 blue, 5 green; 10 blue, 4 green, 8 red; 15 green, 9 blue, 9 red; 1 green, 9 blue\nGame 56: 8 green, 11 blue, 1 red; 1 blue, 1 red, 4 green; 8 blue\nGame 57: 5 green, 4 blue; 1 blue, 4 green; 1 red, 1 green, 3 blue; 1 red, 2 blue, 6 green\nGame 58: 8 green, 10 red, 10 blue; 8 blue, 6 green, 12 red; 9 green, 11 blue, 1 red; 12 red, 5 green, 11 blue; 7 red, 2 green, 8 blue\nGame 59: 10 red, 1 green, 3 blue; 16 red, 1 green, 4 blue; 9 red, 2 blue; 1 red\nGame 60: 11 blue, 13 green, 10 red; 15 red, 12 blue; 3 blue, 9 green, 6 red; 12 blue, 5 green\nGame 61: 2 blue, 7 red; 3 green, 14 blue, 11 red; 7 red, 10 blue; 6 blue, 3 green, 4 red; 10 blue\nGame 62: 1 blue, 7 green; 6 red, 12 green, 1 blue; 8 red\nGame 63: 1 blue, 3 green, 1 red; 8 green, 10 red, 1 blue; 8 green, 11 red; 1 blue, 11 green, 5 red; 8 green, 11 red, 2 blue; 2 blue, 10 red, 6 green\nGame 64: 17 green, 2 blue; 12 blue, 8 green; 11 green, 3 red, 4 blue; 5 red, 9 green, 14 blue\nGame 65: 7 blue, 12 green, 5 red; 13 green, 5 blue, 4 red; 4 blue, 8 green, 1 red; 5 red, 10 green, 10 blue; 5 red, 5 blue, 15 green; 4 red, 9 green, 10 blue\nGame 66: 8 green, 2 red; 8 red, 4 green; 5 red, 2 blue, 7 green\nGame 67: 10 green, 7 blue, 2 red; 15 blue, 1 green, 9 red; 2 red, 7 green, 18 blue; 3 green, 5 blue, 8 red; 10 green, 11 blue, 1 red; 10 green, 4 red, 17 blue\nGame 68: 13 green, 10 blue, 7 red; 1 red, 15 green, 7 blue; 17 green, 14 red, 3 blue; 6 green, 8 blue, 6 red; 4 red, 3 blue, 5 green\nGame 69: 1 red, 6 green, 3 blue; 3 red, 4 blue, 6 green; 2 blue, 2 red, 1 green; 6 blue, 9 green, 2 red; 5 green, 6 blue\nGame 70: 1 green, 1 red, 3 blue; 2 green, 4 blue, 8 red; 5 red, 2 green, 3 blue; 3 green, 1 red, 3 blue; 3 green, 4 blue\nGame 71: 11 blue, 13 green; 1 red, 11 green, 3 blue; 6 blue, 14 green, 1 red; 5 blue, 17 green\nGame 72: 3 blue, 10 green, 4 red; 2 green, 6 red, 13 blue; 1 green, 1 blue, 6 red; 5 red, 1 blue, 1 green; 2 green, 5 red, 5 blue; 9 blue, 10 green, 6 red\nGame 73: 6 red, 4 green, 1 blue; 1 blue, 5 red, 3 green; 2 red, 11 green, 3 blue\nGame 74: 13 green, 2 red, 2 blue; 5 blue, 6 green; 12 green, 3 red, 4 blue; 2 green\nGame 75: 9 red, 10 blue, 6 green; 12 blue, 9 red; 11 red, 6 green; 12 blue, 2 red, 1 green\nGame 76: 1 green, 2 blue, 5 red; 2 blue, 1 green; 1 blue, 2 green, 1 red; 2 blue, 1 red; 3 green, 3 red\nGame 77: 5 green, 12 blue, 3 red; 11 blue, 9 green, 13 red; 8 blue, 13 green, 13 red\nGame 78: 2 red, 3 blue, 1 green; 1 green, 19 blue, 1 red; 7 blue, 2 green, 2 red\nGame 79: 5 red, 1 blue, 4 green; 1 blue, 9 green, 10 red; 13 red, 1 green; 1 blue, 1 red, 5 green\nGame 80: 13 green, 2 blue; 1 red, 4 blue, 13 green; 5 red, 7 green, 4 blue\nGame 81: 3 red, 4 blue, 12 green; 16 green, 5 red, 1 blue; 4 blue, 2 red, 2 green; 4 blue, 5 red, 13 green; 8 red, 4 blue, 13 green; 16 green, 3 red\nGame 82: 6 red, 3 green, 2 blue; 1 green, 6 red, 2 blue; 3 blue, 8 green, 9 red\nGame 83: 3 green, 3 red, 1 blue; 3 blue, 4 green, 3 red; 3 blue, 4 green, 1 red; 2 red, 8 green, 2 blue\nGame 84: 5 red, 6 blue, 3 green; 1 blue, 2 green; 3 green, 2 blue, 2 red; 1 red, 3 green, 6 blue; 12 red, 2 green; 4 blue, 2 green, 4 red\nGame 85: 11 green, 4 blue, 9 red; 13 red, 1 blue, 11 green; 7 green, 8 blue, 7 red; 1 red, 4 blue\nGame 86: 3 blue, 19 green, 7 red; 19 green, 1 red, 1 blue; 9 green, 2 red; 7 red, 6 green, 1 blue\nGame 87: 1 blue, 1 green, 4 red; 1 green, 6 red; 6 red, 2 blue; 8 red, 3 blue\nGame 88: 9 red, 6 blue; 4 red, 1 blue, 2 green; 1 green, 10 blue, 6 red; 2 blue, 1 green, 10 red; 7 red, 9 blue\nGame 89: 3 blue, 15 green, 1 red; 1 red, 13 green, 3 blue; 4 blue, 14 green, 4 red; 10 green, 1 blue\nGame 90: 1 red, 13 green; 3 green, 1 red, 5 blue; 5 blue, 6 green; 14 green, 4 blue; 3 blue, 10 green; 13 green, 1 red\nGame 91: 13 green, 11 red, 4 blue; 14 red, 1 green, 10 blue; 4 red, 2 green, 3 blue\nGame 92: 2 red, 3 blue, 6 green; 2 red, 2 blue, 8 green; 14 blue, 1 red, 1 green\nGame 93: 15 blue, 2 red, 13 green; 8 green, 2 red, 8 blue; 6 blue, 1 red, 2 green\nGame 94: 5 red, 4 green, 9 blue; 1 red, 5 green, 4 blue; 11 blue, 4 green, 2 red\nGame 95: 9 blue, 3 green; 2 green, 12 blue; 10 green, 3 blue; 1 green, 1 red, 10 blue\nGame 96: 4 blue, 2 red; 3 green, 10 blue, 7 red; 2 blue, 7 green, 1 red; 13 blue, 9 green; 10 blue, 4 green, 1 red\nGame 97: 6 red, 4 green; 1 blue, 13 red; 3 green, 13 red\nGame 98: 1 red, 13 blue, 1 green; 7 green, 5 blue, 3 red; 15 blue, 6 green; 4 blue, 5 green; 13 blue, 2 green, 1 red; 4 blue, 3 red, 2 green\nGame 99: 1 red, 2 green; 2 red, 2 blue, 1 green; 3 green, 1 blue, 6 red; 3 red, 4 green; 5 red, 1 blue, 4 green; 1 blue, 2 red, 1 green\nGame 100: 9 green, 2 blue, 12 red; 2 blue, 14 red, 2 green; 14 red, 12 green";

int maxRed = 12;
int maxGreen = 13;
int maxBlue = 14;

var lines = puzzle.Split('\n').ToList();

int sum = 0;

foreach (var line in lines)
{
    string[] firstSplit = line.Split(": ");

    int gameNr = int.Parse(firstSplit[0].Split(' ')[1]);

    string[] secondSplit = firstSplit[1].Split("; ");

    bool impossible = false;

    foreach (string s in secondSplit)
    {
        string[] thirdSplit = s.Split(", ");

        foreach (string s2 in thirdSplit)
        {
            if (s2.Contains("red"))
            {
                int sumRed = int.Parse(s2.Split(' ')[0]);

                if (sumRed > maxRed)
                {
                    impossible = true;
                }
            }
            else if (s2.Contains("green"))
            {
                int sumGreen = int.Parse(s2.Split(' ')[0]);

                if (sumGreen > maxGreen)
                {
                    impossible = true;
                }
            }
            else if (s2.Contains("blue"))
            {
                int sumBlue = int.Parse(s2.Split(' ')[0]);

                if (sumBlue > maxBlue)
                {
                    impossible = true;
                }
            }
        }
    }

    if (impossible == false)
    {
        sum += gameNr;
    }
}

Console.WriteLine(sum);

// Task 2

puzzle =
    "Game 1: 1 red, 10 blue, 5 green; 11 blue, 6 green; 6 green; 1 green, 1 red, 12 blue; 3 blue; 3 blue, 4 green, 1 red\nGame 2: 3 red, 5 green; 5 green, 7 red; 1 blue, 7 red, 3 green; 3 red, 2 blue; 5 green, 4 red\nGame 3: 4 blue, 4 green; 2 green, 2 blue; 8 green, 2 red, 3 blue\nGame 4: 3 blue, 15 green; 16 green; 2 red, 7 green; 2 blue, 14 green\nGame 5: 8 green, 6 red, 16 blue; 8 red, 12 green; 1 red, 9 green, 16 blue; 8 red, 3 green; 2 blue, 5 red, 10 green; 15 red, 4 blue, 8 green\nGame 6: 5 blue, 2 green; 6 red, 3 green; 4 green, 4 blue, 2 red; 14 blue, 2 red\nGame 7: 2 green, 6 blue, 1 red; 2 blue, 1 red; 8 blue; 5 blue, 1 green; 6 blue, 1 red; 2 blue\nGame 8: 1 red, 10 blue, 1 green; 6 blue, 1 red; 3 blue, 2 green; 1 red, 1 blue, 3 green; 13 blue; 10 blue, 3 green, 3 red\nGame 9: 2 blue; 8 green, 3 blue; 4 green; 14 green, 1 red, 2 blue; 3 blue, 1 red, 12 green\nGame 10: 1 blue, 7 green; 1 red, 3 green, 5 blue; 1 blue, 5 green, 1 red; 13 green, 5 blue, 2 red\nGame 11: 1 green, 10 red, 6 blue; 15 red, 12 blue; 18 red, 1 green, 1 blue\nGame 12: 16 red, 8 blue, 1 green; 15 red, 3 blue, 1 green; 5 red\nGame 13: 6 red, 7 blue, 7 green; 3 blue, 4 red, 13 green; 1 blue, 6 red, 11 green; 2 red, 1 blue, 14 green; 8 green, 5 blue, 2 red; 4 blue, 18 green, 4 red\nGame 14: 16 red, 3 blue, 1 green; 7 green, 3 red; 16 red, 15 green, 3 blue; 3 blue, 13 red, 10 green\nGame 15: 1 blue, 1 red; 3 blue, 2 green; 1 red; 2 red, 2 green, 3 blue; 3 blue, 1 red, 3 green\nGame 16: 9 red, 3 blue; 13 red, 9 blue; 9 blue, 10 red; 5 red, 10 blue, 1 green; 2 red, 6 green, 8 blue; 6 green, 13 red, 5 blue\nGame 17: 15 red, 17 green, 8 blue; 18 red, 16 blue, 15 green; 8 blue, 17 green, 10 red; 5 green, 3 red, 12 blue\nGame 18: 2 blue, 11 red, 2 green; 1 green, 11 red, 11 blue; 1 red, 4 blue; 10 blue, 9 red; 1 blue, 7 red\nGame 19: 2 blue, 3 green, 5 red; 8 blue, 16 green; 12 red, 7 blue, 8 green; 9 green, 1 blue; 3 red, 16 green, 10 blue\nGame 20: 3 blue, 5 green, 6 red; 2 red, 8 blue, 7 green; 7 green, 3 blue; 2 red, 11 blue; 1 green, 6 red, 3 blue\nGame 21: 16 red, 3 blue, 8 green; 10 red, 15 blue, 3 green; 6 green, 13 red, 15 blue; 11 green, 13 blue, 10 red\nGame 22: 8 green, 1 blue; 2 blue, 9 green, 3 red; 2 red, 2 blue; 1 red, 3 blue, 8 green; 2 blue, 1 green; 1 green, 2 blue\nGame 23: 2 blue, 8 red, 5 green; 9 green, 2 blue; 10 red, 2 green; 12 red, 1 blue; 11 green, 2 blue, 13 red; 7 green\nGame 24: 6 red; 13 green, 7 red, 10 blue; 7 green, 9 red, 1 blue; 3 blue, 2 green, 2 red\nGame 25: 7 green, 1 red, 2 blue; 8 green, 2 blue, 5 red; 5 blue, 8 green, 4 red; 5 blue, 2 green, 1 red; 5 green, 3 red, 7 blue; 3 blue, 6 green, 1 red\nGame 26: 6 green, 3 red; 1 blue, 2 green, 2 red; 2 green, 2 red, 3 blue; 4 blue, 8 red, 2 green; 1 red, 1 green, 1 blue; 6 red, 5 blue\nGame 27: 4 green, 13 blue, 2 red; 2 red, 7 green, 10 blue; 14 blue, 11 green, 1 red; 10 blue, 15 green\nGame 28: 4 green, 13 red, 7 blue; 2 red, 5 blue; 5 blue, 4 green\nGame 29: 6 green, 15 red; 1 blue, 6 red, 8 green; 6 green, 1 blue; 12 red; 1 green, 7 red, 1 blue\nGame 30: 4 blue, 4 green, 2 red; 6 blue, 9 red, 20 green; 9 blue, 4 red, 2 green; 8 red, 8 blue, 1 green; 6 green, 12 blue, 2 red; 8 green, 8 red\nGame 31: 9 blue; 1 red, 2 blue, 5 green; 2 blue, 2 red, 9 green; 2 blue, 1 red, 8 green; 11 green, 2 red, 3 blue; 7 green, 5 blue\nGame 32: 15 red, 5 green; 4 green, 2 blue, 3 red; 1 blue, 9 red; 1 blue, 15 red; 4 blue, 2 red, 8 green; 3 green, 3 blue\nGame 33: 13 blue, 1 red, 1 green; 8 blue, 6 red; 4 blue, 2 red\nGame 34: 5 blue, 9 red, 7 green; 8 red, 6 green, 5 blue; 2 blue, 7 green, 12 red\nGame 35: 4 blue, 15 red; 1 green, 10 blue, 7 red; 9 red, 3 green, 1 blue; 13 red, 9 blue; 3 blue, 2 red\nGame 36: 4 blue, 18 green, 2 red; 5 green, 6 blue, 11 red; 6 red, 12 blue, 14 green; 19 green, 10 blue, 7 red; 7 red, 8 green, 9 blue\nGame 37: 16 blue, 5 green, 18 red; 3 blue, 14 green, 1 red; 4 blue, 3 green, 14 red; 12 green, 7 red, 15 blue; 15 green, 11 blue, 2 red; 8 blue, 13 green, 6 red\nGame 38: 6 red, 4 blue, 12 green; 3 red, 11 blue; 16 green, 2 blue, 8 red; 4 blue, 11 red, 4 green; 17 green, 7 red, 10 blue; 9 blue, 15 green, 1 red\nGame 39: 1 green, 1 red, 10 blue; 1 red, 5 blue, 2 green; 4 red, 7 blue; 9 red, 6 green, 5 blue; 1 green, 2 blue, 9 red\nGame 40: 13 blue, 11 red, 12 green; 8 green, 11 red, 4 blue; 2 blue, 2 green, 12 red; 2 green, 3 red, 13 blue; 13 blue, 6 red, 2 green; 4 green, 6 red, 8 blue\nGame 41: 12 red, 4 green, 13 blue; 4 red, 7 blue, 10 green; 17 green, 17 red, 11 blue\nGame 42: 1 red, 1 green; 1 red, 4 green; 1 blue, 4 red, 4 green; 3 red; 1 blue, 3 green, 1 red\nGame 43: 7 blue, 10 green; 5 blue, 2 green; 2 blue, 1 green, 4 red; 14 red, 6 green, 7 blue; 4 green, 14 red, 8 blue; 4 green, 6 red\nGame 44: 9 green, 4 red; 4 red, 6 green; 5 red, 2 blue, 7 green; 9 blue, 1 green, 14 red\nGame 45: 20 blue, 4 red, 6 green; 3 blue, 1 green, 6 red; 8 blue, 8 green, 11 red\nGame 46: 1 green, 6 red; 6 red, 3 blue, 3 green; 6 red, 3 blue, 4 green; 1 blue, 5 red; 1 green, 4 red, 1 blue; 2 green, 4 red\nGame 47: 12 green, 8 red, 4 blue; 7 green, 6 red, 11 blue; 4 red, 11 blue, 12 green\nGame 48: 1 green, 3 blue; 13 green, 3 red, 11 blue; 7 blue, 1 green, 2 red; 7 red, 15 green, 4 blue; 4 red, 8 blue, 10 green; 15 green, 8 blue, 6 red\nGame 49: 2 red; 2 red, 9 blue; 4 blue, 1 green\nGame 50: 10 blue, 1 green, 18 red; 13 red, 1 green, 7 blue; 4 red, 2 green, 9 blue; 2 green, 4 red, 10 blue; 7 blue, 3 red; 19 red, 9 blue\nGame 51: 2 green, 2 red, 5 blue; 9 red, 5 blue; 3 red, 10 blue; 9 blue, 6 red, 7 green; 2 red, 5 blue\nGame 52: 6 blue, 3 green; 5 green, 3 blue, 5 red; 1 blue, 2 green, 2 red\nGame 53: 2 blue, 9 green, 15 red; 18 red, 1 blue; 13 red, 12 green; 7 green, 2 blue, 9 red\nGame 54: 18 green; 2 red, 6 green; 6 red, 9 green, 1 blue; 1 blue, 4 green, 5 red; 3 red; 3 green, 4 red\nGame 55: 5 red, 2 blue, 5 green; 10 blue, 4 green, 8 red; 15 green, 9 blue, 9 red; 1 green, 9 blue\nGame 56: 8 green, 11 blue, 1 red; 1 blue, 1 red, 4 green; 8 blue\nGame 57: 5 green, 4 blue; 1 blue, 4 green; 1 red, 1 green, 3 blue; 1 red, 2 blue, 6 green\nGame 58: 8 green, 10 red, 10 blue; 8 blue, 6 green, 12 red; 9 green, 11 blue, 1 red; 12 red, 5 green, 11 blue; 7 red, 2 green, 8 blue\nGame 59: 10 red, 1 green, 3 blue; 16 red, 1 green, 4 blue; 9 red, 2 blue; 1 red\nGame 60: 11 blue, 13 green, 10 red; 15 red, 12 blue; 3 blue, 9 green, 6 red; 12 blue, 5 green\nGame 61: 2 blue, 7 red; 3 green, 14 blue, 11 red; 7 red, 10 blue; 6 blue, 3 green, 4 red; 10 blue\nGame 62: 1 blue, 7 green; 6 red, 12 green, 1 blue; 8 red\nGame 63: 1 blue, 3 green, 1 red; 8 green, 10 red, 1 blue; 8 green, 11 red; 1 blue, 11 green, 5 red; 8 green, 11 red, 2 blue; 2 blue, 10 red, 6 green\nGame 64: 17 green, 2 blue; 12 blue, 8 green; 11 green, 3 red, 4 blue; 5 red, 9 green, 14 blue\nGame 65: 7 blue, 12 green, 5 red; 13 green, 5 blue, 4 red; 4 blue, 8 green, 1 red; 5 red, 10 green, 10 blue; 5 red, 5 blue, 15 green; 4 red, 9 green, 10 blue\nGame 66: 8 green, 2 red; 8 red, 4 green; 5 red, 2 blue, 7 green\nGame 67: 10 green, 7 blue, 2 red; 15 blue, 1 green, 9 red; 2 red, 7 green, 18 blue; 3 green, 5 blue, 8 red; 10 green, 11 blue, 1 red; 10 green, 4 red, 17 blue\nGame 68: 13 green, 10 blue, 7 red; 1 red, 15 green, 7 blue; 17 green, 14 red, 3 blue; 6 green, 8 blue, 6 red; 4 red, 3 blue, 5 green\nGame 69: 1 red, 6 green, 3 blue; 3 red, 4 blue, 6 green; 2 blue, 2 red, 1 green; 6 blue, 9 green, 2 red; 5 green, 6 blue\nGame 70: 1 green, 1 red, 3 blue; 2 green, 4 blue, 8 red; 5 red, 2 green, 3 blue; 3 green, 1 red, 3 blue; 3 green, 4 blue\nGame 71: 11 blue, 13 green; 1 red, 11 green, 3 blue; 6 blue, 14 green, 1 red; 5 blue, 17 green\nGame 72: 3 blue, 10 green, 4 red; 2 green, 6 red, 13 blue; 1 green, 1 blue, 6 red; 5 red, 1 blue, 1 green; 2 green, 5 red, 5 blue; 9 blue, 10 green, 6 red\nGame 73: 6 red, 4 green, 1 blue; 1 blue, 5 red, 3 green; 2 red, 11 green, 3 blue\nGame 74: 13 green, 2 red, 2 blue; 5 blue, 6 green; 12 green, 3 red, 4 blue; 2 green\nGame 75: 9 red, 10 blue, 6 green; 12 blue, 9 red; 11 red, 6 green; 12 blue, 2 red, 1 green\nGame 76: 1 green, 2 blue, 5 red; 2 blue, 1 green; 1 blue, 2 green, 1 red; 2 blue, 1 red; 3 green, 3 red\nGame 77: 5 green, 12 blue, 3 red; 11 blue, 9 green, 13 red; 8 blue, 13 green, 13 red\nGame 78: 2 red, 3 blue, 1 green; 1 green, 19 blue, 1 red; 7 blue, 2 green, 2 red\nGame 79: 5 red, 1 blue, 4 green; 1 blue, 9 green, 10 red; 13 red, 1 green; 1 blue, 1 red, 5 green\nGame 80: 13 green, 2 blue; 1 red, 4 blue, 13 green; 5 red, 7 green, 4 blue\nGame 81: 3 red, 4 blue, 12 green; 16 green, 5 red, 1 blue; 4 blue, 2 red, 2 green; 4 blue, 5 red, 13 green; 8 red, 4 blue, 13 green; 16 green, 3 red\nGame 82: 6 red, 3 green, 2 blue; 1 green, 6 red, 2 blue; 3 blue, 8 green, 9 red\nGame 83: 3 green, 3 red, 1 blue; 3 blue, 4 green, 3 red; 3 blue, 4 green, 1 red; 2 red, 8 green, 2 blue\nGame 84: 5 red, 6 blue, 3 green; 1 blue, 2 green; 3 green, 2 blue, 2 red; 1 red, 3 green, 6 blue; 12 red, 2 green; 4 blue, 2 green, 4 red\nGame 85: 11 green, 4 blue, 9 red; 13 red, 1 blue, 11 green; 7 green, 8 blue, 7 red; 1 red, 4 blue\nGame 86: 3 blue, 19 green, 7 red; 19 green, 1 red, 1 blue; 9 green, 2 red; 7 red, 6 green, 1 blue\nGame 87: 1 blue, 1 green, 4 red; 1 green, 6 red; 6 red, 2 blue; 8 red, 3 blue\nGame 88: 9 red, 6 blue; 4 red, 1 blue, 2 green; 1 green, 10 blue, 6 red; 2 blue, 1 green, 10 red; 7 red, 9 blue\nGame 89: 3 blue, 15 green, 1 red; 1 red, 13 green, 3 blue; 4 blue, 14 green, 4 red; 10 green, 1 blue\nGame 90: 1 red, 13 green; 3 green, 1 red, 5 blue; 5 blue, 6 green; 14 green, 4 blue; 3 blue, 10 green; 13 green, 1 red\nGame 91: 13 green, 11 red, 4 blue; 14 red, 1 green, 10 blue; 4 red, 2 green, 3 blue\nGame 92: 2 red, 3 blue, 6 green; 2 red, 2 blue, 8 green; 14 blue, 1 red, 1 green\nGame 93: 15 blue, 2 red, 13 green; 8 green, 2 red, 8 blue; 6 blue, 1 red, 2 green\nGame 94: 5 red, 4 green, 9 blue; 1 red, 5 green, 4 blue; 11 blue, 4 green, 2 red\nGame 95: 9 blue, 3 green; 2 green, 12 blue; 10 green, 3 blue; 1 green, 1 red, 10 blue\nGame 96: 4 blue, 2 red; 3 green, 10 blue, 7 red; 2 blue, 7 green, 1 red; 13 blue, 9 green; 10 blue, 4 green, 1 red\nGame 97: 6 red, 4 green; 1 blue, 13 red; 3 green, 13 red\nGame 98: 1 red, 13 blue, 1 green; 7 green, 5 blue, 3 red; 15 blue, 6 green; 4 blue, 5 green; 13 blue, 2 green, 1 red; 4 blue, 3 red, 2 green\nGame 99: 1 red, 2 green; 2 red, 2 blue, 1 green; 3 green, 1 blue, 6 red; 3 red, 4 green; 5 red, 1 blue, 4 green; 1 blue, 2 red, 1 green\nGame 100: 9 green, 2 blue, 12 red; 2 blue, 14 red, 2 green; 14 red, 12 green";

lines = puzzle.Split('\n').ToList();

sum = 0;

foreach (var line in lines)
{
    maxRed = 0;
    maxGreen = 0;
    maxBlue = 0;

    string[] firstSplit = line.Split(": ");

    int gameNr = int.Parse(firstSplit[0].Split(' ')[1]);

    string[] secondSplit = firstSplit[1].Split("; ");

    foreach (string s in secondSplit)
    {
        string[] thirdSplit = s.Split(", ");

        foreach (string s2 in thirdSplit)
        {
            if (s2.Contains("red"))
            {
                int sumRed = int.Parse(s2.Split(' ')[0]);

                if (sumRed > maxRed)
                {
                    maxRed = sumRed;
                }
            }
            else if (s2.Contains("green"))
            {
                int sumGreen = int.Parse(s2.Split(' ')[0]);

                if (sumGreen > maxGreen)
                {
                    maxGreen = sumGreen;
                }
            }
            else if (s2.Contains("blue"))
            {
                int sumBlue = int.Parse(s2.Split(' ')[0]);

                if (sumBlue > maxBlue)
                {
                    maxBlue = sumBlue;
                }
            }
        }
    }

    int total = maxRed * maxGreen * maxBlue;
    sum += total;
}


Console.WriteLine(sum);