// Составьте таблицы для хранения сведений об общественном транспорте.
// Можно на примере автобусов.
// При составлении таблиц не берите слишком много сущностей. 
// Ориентируйтесь на структуру типа:
// «У нас есть автобусы на разных маршрутах, у автобуса есть водитель, 
// также в автобусе работает кондуктор». 
// Более сложные/глубокие структуры пока лучше не брать.


string text = "id;Transport;route;driver;conductor;\n";

int count = 10;
string[] transportR = { "Автобус", "Электробус", "Тролейбус", "Маршрутка" };

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    int mark = random.Next(100, 1000);
    string transport = transportR[random.Next(transportR.Length)];
    string route = $"Маршрут номер: {mark}";
    string driver = $"ВодительID_{random.Next(10, 100)}";
    string conductor = $"КондукторID_{random.Next(10, 100)}";
    text += $"{id}; {transport}; {route}; {driver}; {conductor}\n";
}

System.Console.WriteLine(text);
File.WriteAllText("output.csv", text);
