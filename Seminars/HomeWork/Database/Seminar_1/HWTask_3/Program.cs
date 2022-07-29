﻿// Составьте таблицы для хранения сведений об общественном транспорте.
// Можно на примере автобусов.
// При составлении таблиц не берите слишком много сущностей. 
// Ориентируйтесь на структуру типа:
// «У нас есть автобусы на разных маршрутах, у автобуса есть водитель, 
// также в автобусе работает кондуктор». 
// Более сложные/глубокие структуры пока лучше не брать.


string text = "id;Transport;route;driver;conductor;\n";

int count = 10;
string[] transportR = { "Автобус", "Электробус", "Тролейбус", "Маршрутка" };
string[] driverR = { "Что-то написано", "Такие дела", "Уруру" };

Random random = new Random();
for (int id = 1; id <= count; id++)
{
    int mark = random.Next(100, 1000);
    string transport = transportR[random.Next(transportR.Length)];
    string route = $"Номер: {mark}";
    string driver = $"Иия_{id}";
    string conductor = $"Фамилия_{id}";
    // string cStatus = status[random.Next(status.Length)];
    // string description = descriptions[random.Next(descriptions.Length)];
    text += $"{id} {transport} {route} {driver} {conductor} \n";
}

System.Console.WriteLine(text);
File.WriteAllText("output.csv", text);






// string text = "id;route;mark;transP;driverR;\n";

// int count = 5;
// string[] status = { "На маршруте", "В Парке", "В ремонте" };
// string[] driver = { "Иванов И И", "Петров П П", "Сидоров С С" };
// string[] transport = { "Автобус", "Тролейбус", "Маршрутка" };

// Random random = new Random();
// for (int id = 1; id <= count; id++)
// {
//     string route = $"Маршрут:";
//     string transP = $"Вид транспорта: {transport[random.Next(transport.Length)]}";
//     string condId = $"Кондуктор: {id}";
//     int mark = random.Next(100, 1000);
//     string statusR = status[random.Next(status.Length)];
//     string driverR = driver[random.Next(driver.Length)];
//     string transportR = transport[random.Next(transport.Length)];
//     text += $"{id} {route} {mark} {transP} {driverR} {condId}\n";
//     // {description} {condId}\n";
// }

// System.Console.WriteLine(text);
// File.WriteAllText("output.csv", text);
