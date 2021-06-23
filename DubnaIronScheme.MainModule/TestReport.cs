using System;
using System.Collections.Generic;
using System.Text;

namespace DubnaIronScheme.MainModule
{
    /// <summary>
    /// Представляет отчёт о тестировании.
    /// </summary>
    class TestReport
    {
        public TestReport(int total, int success, IEnumerable<string> testResults)
        {
            Total = total;
            Successful = success;
            TestResults = testResults;
        }

        /// <summary>
        /// Количество проведённых тестов.
        /// </summary>
        public int Total { get; private set; }
        /// <summary>
        /// Количество успешно пройдённых тестов.
        /// </summary>
        public int Successful { get; private set; }
        /// <summary>
        /// Количество проваленны тестов.
        /// </summary>
        public int Failed { get => Total - Successful; }
        /// <summary>
        /// Коллекция результатов по каждому тесту.
        /// </summary>
        public IEnumerable<string> TestResults { get; private set; }

        /// <summary>
        /// Преобразует экземляр класса к строковому виду.
        /// </summary>
        /// <returns>Строковое представление экземпляра класса.</returns>
        public override string ToString()
        {
            var iterator = TestResults.GetEnumerator();
            var builder = new StringBuilder();

            builder.Append($"Total {Total}, successfull {Successful} / failed {Failed} \n");
            for (int i = 1; iterator.MoveNext(); i++)
            {
                builder.Append($"Test: {i} \n");
                builder.Append($"Result: {iterator.Current} \n");
            }
            return builder.ToString();
        }
    }
}
