using IronScheme;
using IronScheme.Runtime;
using System;

namespace DubnaIronScheme.MainModule.Services
{
    /// <summary>
    /// Класс, реализующий функционал для компиляции программного кода на функциональном языке Scheme.
    /// </summary>
    public class CompilerService
    {
        /// <summary>
        /// Модифицирует текст программы строкой объявления нового окружения для изолированности вызовов.
        /// </summary>
        /// <param name="script">Текст программы на функциональном языке Scheme.</param>
        /// <returns>Возвращает модифицированный код.</returns>
        private string InsertNewEnvironmentString(string script) => 
            script.Insert(0, "(interaction-environment (new-interaction-environment))");

        /// <summary>
        /// Преобразует результат компиляции кода на функциональном языке Scheme в понятную для человека строку.
        /// </summary>
        /// <param name="result">Объект, представляющий результат компиляции программы, требующий обработки.</param>
        /// <returns>Возвращает обработанный результат компиляции кода.</returns>
        private string GetResultString(object result)
        {
            string prettyResult;

            if (result is Cons)
                prettyResult = ((Cons)result).PrettyPrint;

            else if (result is null)
                prettyResult = "()";

            else if (result is double)
            {
                if (Convert.ToInt32(result).ToString() == result.ToString())
                    prettyResult = ((double)result).ToString("0.0############");
                else
                    prettyResult = result.ToString();
                }

            else if (result is bool)
                prettyResult = (bool)result ? "#t" : "#f";

            else
                prettyResult = result.ToString();

            return prettyResult.Trim('\n');
        }

        /// <summary>
        /// Компилирует код программы на языке функционального программирования Scheme и возвращает обработанный результат.
        /// </summary>
        /// <param name="script">Текст программы на функциональном языке Scheme.</param>
        /// <returns>Возвращает обработанный результат компиляции кода.</returns>
        public string Run(string script)
        {
            string prettyResult;
            script = InsertNewEnvironmentString(script);

            try
            {
                prettyResult = GetResultString(script.Eval());
            }
            catch (Exception exception)
            {
                prettyResult = exception.Message;
            }

            return prettyResult;
        }
    }
}