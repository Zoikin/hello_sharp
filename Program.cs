string[] input1 = {"hello", "2", "world", ":-)"};
string[] input2 = {"1234", "1567", "-2", "computer science"};
string[] input3 = {"Russia", "Denmark", "Kazan"};

string[][] input = {
    input1,
    input2,
    input3
};

const int maxWorldLen = 3;

for (int i = 0; i < input.Length; i++)
{
     string[] res = new string[0];

    for (int j = 0; j < input[i].Length; j++) {

        if (input[i][j].Length <= maxWorldLen) {
            Array.Resize(ref res, res.Length + 1);
            res[res.Length - 1] = input[i][j];
        }
    }

    Console.Write ("result: ");
    Console.WriteLine("["+string.Join(",", res) + "]");
}