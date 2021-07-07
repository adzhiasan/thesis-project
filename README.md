# DubnaIronScheme
Основной задачей данного проект является компиляция и тестирования (в рамках подготовленных данных) кода на языке функционального программирования Scheme. Основой данного проекта является библиотека [IronScheme](https://github.com/IronScheme/IronScheme).

## Запуск
1. Откройте файл `DubnaIronScheme.sln` в VS2019.
2. Выберите проект для запуска `DubnaIronScheme.Console`.

В консоли можно ввести код, который после нажатия на `Enter` будет скомпилирован, а на экране можно будет увидеть результат.

## Использование библиотеки
Для использования компилирующего и тестирующего модулей, необходимо добавить ссылку `DubnaIronScheme.MainModule.dll`.
```C#
using DubnaIronScheme.MainModule;

class Program
{
    static void Main(string[] args)
    {
        CompilerService schemeCompiler = new CompilerService();

        WriteLine("Напишите код программы:");
        string script = Console.ReadLine();

        Console.WriteLine(schemeCompiler.Run(script));
    }
}
```

## Подготовка данных для тестирования
Для тестирования кода необходимо создать экземляр класса `TestingService`. В конструктор необходимо передать объект класса `CompilerService` (тестирующий модуль запускает код для тестирования). Далее нужно подготовить тестовые данные, экземпляр(-ы) класса `TestClass`. Объекты такого класса должны содержать данные для формирования вызова функции. Для этого в конструктор передаём аргументы (название_функции, аргументы_через_пробел, ожидаемый_результат). 
После подготовки формируем список тестов и вызываем метод `Test()` экземпляра класса `TestingService`, куда передаём код тестируемой программы и коллекцию тестов. На выходе получаем отчёт о тестировании.

```C#
using DubnaIronScheme.MainModule;

class Program
{
    static void Main(string[] args)
    {
        CompilerService schemeCompiler = new CompilerService();
        TestingService testingService = new TestingService(schemeCompiler);

        string script = "(define (fun n pow)" +
            "(* n (expt 10 pow)))";

        TestClass test1 = new TestClass("fun", "7 3", "7000");
        TestClass test2 = new TestClass("fun", "-7 3", "-7000");
        TestClass test3 = new TestClass("fun", "42. -5", "0.00042");

        List<TestClass> testList = new List<TestClass>() { test1, test2, test3 };

        Console.WriteLine(testingService.Test(script, testList));
    }
}
```

## Запуск тестирования модуля компиляции
Разработанное прораммное решение было протестировано с помощью `xUnit`. Все тесты расположены в проекте `DubnaIronScheme.Test`. Тестирование включает в себя 37 тестовых случаев по 7 классам эквивалентности:
* коллекции; 
* null; 
* число с плавающей запятой; 
* переменная логического типа данных; 
* строки и то, что по умолчанию корректно (без потерь) приводится к строке в C#;  
* ошибки;
* тестирование тестирующего модуля.
