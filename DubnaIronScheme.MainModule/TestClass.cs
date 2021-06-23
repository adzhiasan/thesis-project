using System;
using System.Collections.Generic;
using System.Text;

namespace DubnaIronScheme.MainModule
{
    /// <summary>
    /// Представляет определение единицы теста для проверки кода.
    /// </summary>
    public class TestClass
    {
        public TestClass(string procedureName, string arguments, string expectedResult)
        {
            ProcedureName = procedureName;
            Arguments = arguments;
            ExpectedResult = expectedResult;
        }

        /// <summary>
        /// Название функции, которое будет использовано для её вызова. 
        /// </summary>
        public string ProcedureName { get; set; }
        /// <summary>
        /// Аргументы функции, записанные через пробел. Пример: "1 5 9".
        /// </summary>
        public string Arguments { get; set; }
        /// <summary>
        /// Ожидаемый результат.
        /// </summary>
        public string ExpectedResult { get; set; }
        /// <summary>
        /// Результат, полученный в результате компиляции кода.
        /// </summary>
        public string Result { get; set; }   
        /// <summary>
        /// Содержит информацию, совпал ли <c>ExpectedResult</c> и <c>Result</c>. <c>true</c> - результаты совпали, <c>false</c> - результаты отличаются. 
        /// </summary>
        public bool Confirmed { get; set; }
    }
}
