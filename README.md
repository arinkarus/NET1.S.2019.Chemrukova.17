## Читать

- Паттерны проетирования на платформе .NET. Сергей Тепляков.Глава 5. Паттерн "Наблюдатель". [можно найти здесь](https://drive.google.com/drive/folders/0B7WmjuqYed3ARTMxLUpWU0tKazQ)

## Задачи (deadline - 27.04.2019, 24.00)

1. Метеостанция WeatherStation работает на базе запатентовнного объекта WeatherData, отслеживающего текущие погодные условия (температура (Temperature), влажность (Humidity), атмосферное давление (Pressure)). 
  - Разработать систему классов для создания текущей сводки (CurrentConditionsReport) и статистики (StatisticReport). Все данные должны обновляться в режиме реального времени, по мере того, как объект WeatherData получает данные последних изменений.
  - Предложить два варианта решения (интерфейсы + event).
  - Смоделировать работу метеостанции в консольном приложении.

2. Разработать класс для имитации часов с обратным отсчетом (только через event), реализующий возможность по истечении назначенного времени (время ожидания предоставляется классу пользователем) передавать сообщение и дополнительную информацию о событии любому подписавшемуся на событие типу.
  Продемонстрировать работу класса в консольном приложении.

3. Долги!


## Реализация (Done)
1. - [Через интерфейсы](https://github.com/arinkarus/NET1.S.2019.Chemrukova.17/tree/master/WeatherStationViaInterfaces)
   - [Консольное приложение ч/з интерфейсы](https://github.com/arinkarus/NET1.S.2019.Chemrukova.17/tree/master/WeatherStationViaInterfaces.Console)
   - [Через события](https://github.com/arinkarus/NET1.S.2019.Chemrukova.17/tree/master/WeatherStationViaEvent)
   - [Констольные приложение ч/з события](https://github.com/arinkarus/NET1.S.2019.Chemrukova.17/tree/master/WeatherStationViaEvent.Console)
2. - [Таймер](https://github.com/arinkarus/NET1.S.2019.Chemrukova.17/tree/master/Timer)
   - [Консольное приложение](https://github.com/arinkarus/NET1.S.2019.Chemrukova.17/tree/master/Timer.Console)
