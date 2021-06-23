using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DubnaIronScheme.MainModule.Services
{
    public class TestingService
    {
        private CompilerService compilerService;

        /// <summary>
        /// Конструктор принимает экземпляр класса, необходимый для компиляции кода на языке функционального программирования Scheme.
        /// </summary>
        /// <param name="compilerService">Компилирующий модуль.</param>
        public TestingService(CompilerService compilerService)
        {
            this.compilerService = compilerService;
        }

        /// <summary>
        /// Тестирует передаваемый код на функциональном языке Scheme с помощью переданных тестов. 
        /// </summary>
        /// <param name="script">Текст программы на функциональном языке Scheme.</param>
        /// <param name="tests">Набор тестов для проверки кода, представляющих собой объекты класса <c>TestClass</c></param>
        /// <returns>Возвращает отчет о проведенном тестировании.</returns>
        public string Test(string script, IEnumerable<TestClass> tests)
        {
            List<string> testResults = new List<string>();
            int success = 0;
            string testScript;

            foreach (var item in tests)
            {
                testScript = script + $"({item.ProcedureName} {item.Arguments})";
                item.Result = compilerService.Run(testScript);
                item.Confirmed = item.ExpectedResult == item.Result;
                testResults.Add(item.Result);
            }

            foreach (var item in tests)
            {
                if (item.Confirmed)
                    success++;
            }

            return GetReport(new TestReport(tests.Count(), success, testResults));
        }

        /// <summary>
        /// Преобразует экземпляр класса <c>TestReport</c> в строку с отчетом о тестировании.
        /// </summary>
        /// <param name="testReport">Отчёт о тестировании.</param>
        /// <returns>Возвращает строку с информацией о проведённом тестировании</returns>
        private string GetReport(TestReport testReport) => 
            testReport.ToString();
    }
}
