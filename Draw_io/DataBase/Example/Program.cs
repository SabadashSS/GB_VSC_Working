string text = "id;fName;lName;mark;status;description;\n";

int count = 10;
string[] status = { "Трус", "Балбес", "Бывалый" };
string[] descriptions = { "Что-то написано", "Такие дела", "Уруру" };

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    string fName = $"Иия_{id}";
    string lName = $"Фамилия_{id}";
    int mark = random.Next(2, 5) + 1;
    string cStatus = status[random.Next(status.Length)];
    string description = descriptions[random.Next(descriptions.Length)];
    text += $"{id};{fName};{lName};{mark};{cStatus};{description};\n";
}

System.Console.WriteLine(text);
File.WriteAllText("output.csv", text);