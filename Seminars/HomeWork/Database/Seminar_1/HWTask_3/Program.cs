// Составьте таблицы для хранения сведений об общественном транспорте.
// Можно на примере автобусов.
// При составлении таблиц не берите слишком много сущностей. 
// Ориентируйтесь на структуру типа:
// «У нас есть автобусы на разных маршрутах, у автобуса есть водитель, 
// также в автобусе работает кондуктор». 
// Более сложные/глубокие структуры пока лучше не брать.


string text = "id;fName;lName;mark;status;description;\n";

int count = 5;
string[] status = { "На маршруте", "В Парке", "В ремонте" };
string[] driver = { "Иванов И И", "Петров П П", "Сидоров С С"};
string[] transport = { "Автобус", "Тролейбус", "Маршрутка"};

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    string route = $"Маршрут: {id}";
    string transP = $"Вид транспорта: {transport[random.Next(transport.Length)]}";
    string condId = $"Кондуктор {condId[random.Next(condId.Length)]}";
    int mark = random.Next(100, 1000);
    string cStatus = status[random.Next(status.Length)];
    string description = driver[random.Next(driver.Length)];
    text += $"{id}) {route} {transP} {mark} {cStatus} {description} {condId}\n";
}

System.Console.WriteLine(text);
File.WriteAllText("output.csv", text);
