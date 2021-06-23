using System;
using System.Text;
using Xunit;
using System.Collections.Generic;
using DubnaIronScheme.MainModule.Services;
using DubnaIronScheme.MainModule;

namespace DubnaIronScheme.Test
{
    public class CompilerTest : IClassFixture<CompilerService>
    {
        private readonly CompilerService _compilerService;

        public CompilerTest(CompilerService compilerService)
        {
            _compilerService = compilerService;      
        }

        // Тестируем работоспособность компилирующего модуля при возврате коллекций
        [Theory]
        [MemberData(nameof(CollectionData))]
        public void CollectionTest(string script, string call, string expectedResult)
        {
            var builder = new StringBuilder();
            builder.Append($"{script}{call}");
            var finalScript = $"{script}{call}";
            string result = _compilerService.Run(finalScript);
            Assert.Equal(expectedResult, result);
        }        
        
        // Тестируем работоспособность компилирующего модуля при возврате переменных логического типа
        [Theory]
        [MemberData(nameof(BooleanData))]
        public void BooleanTest(string script, string call, string expectedResult)
        {
            var builder = new StringBuilder();
            builder.Append($"{script}{call}");
            var finalScript = $"{script}{call}";
            string result = _compilerService.Run(finalScript);
            Assert.Equal(expectedResult, result);
        }        
        
        // Тестируем работоспособность компилирующего модуля при возврате переменных типа double
        [Theory]
        [MemberData(nameof(FloatingPointNumericData))]
        public void FloatingPointNumericTest(string script, string call, string expectedResult)
        {
            var builder = new StringBuilder();
            builder.Append($"{script}{call}");
            var finalScript = $"{script}{call}";
            string result = _compilerService.Run(finalScript);
            Assert.Equal(expectedResult, result);
        }

        // Тестируем работоспособность компилирующего модуля при возврате строковых переменных
        [Theory]
        [MemberData(nameof(StringData))]
        public void StringTest(string script, string call, string expectedResult)
        {
            var builder = new StringBuilder();
            builder.Append($"{script}{call}");
            var finalScript = $"{script}{call}";
            string result = _compilerService.Run(finalScript);
            Assert.Equal(expectedResult, result);
        }

        // Тестируем работоспособность компилирующего модуля при возврате null
        [Theory]
        [MemberData(nameof(NullData))]
        public void NullTest(string script, string call, string expectedResult)
        {
            var builder = new StringBuilder();
            builder.Append($"{script}{call}");
            var finalScript = $"{script}{call}";
            string result = _compilerService.Run(finalScript);
            Assert.Equal(expectedResult, result);
        }

        // Тестируем работоспособность компилирующего модуля при возврате ошибок
        [Theory]
        [MemberData(nameof(ErrorData))]
        public void ErrorTest(string call, string expectedResult)
        {
            string result = _compilerService.Run(call);
            Assert.Equal(expectedResult, result);
        }

        // Тестовые данные для тестирования работы с коллекциями
        public static IEnumerable<object[]> CollectionData()
        {
            yield return new object[] {ScriptResource.getNlist, "(getNlist 2)", "(() ())"};
            yield return new object[] {ScriptResource.getNlist, "(getNlist 5)", "(() () () () ())"};
            yield return new object[] {ScriptResource.union, "(union '(2 3 4) '(3 4 5))", "(2 3 4 5)"};
            yield return new object[] {ScriptResource.union, "(union '(2 3 4) '())", "(2 3 4)"};
            yield return new object[] {ScriptResource.union, "(union '() '(3 4 5))", "(3 4 5)"};
            yield return new object[] {ScriptResource.add_val_tree, "(add-val-tree 5 '())", "(5 () ())"};
            yield return new object[] {ScriptResource.add_val_tree, "(add-val-tree 3 (add-val-tree 5 '()))", "(5 (3 () ()) ())"};
            yield return new object[] {ScriptResource.add_val_tree, "(add-val-tree 7 (add-val-tree 3 (add-val-tree 5 '())))", "(5 (3 () ()) (7 () ()))"};
            yield return new object[] {ScriptResource.add_list_tree, "(add-list-tree '(5 3 7) '())", "(5 (3 () ()) (7 () ()))"};
            yield return new object[] {ScriptResource.add_list_tree, "(add-list-tree '(2 8 4) '(5 (3 () ()) (7 () ())))", "(5 (3 (2 () ()) (4 () ())) (7 () (8 () ())))"};
        }

        // Тестовые данные для тестирования работы с переменными логического типа
        public static IEnumerable<object[]> BooleanData()
        {
            yield return new object[] { ScriptResource.valid_date, "(valid-date? 10 4 1949)", "#t"};
            yield return new object[] { ScriptResource.valid_date, "(valid-date? -1 2 2021)", "#f"};
            yield return new object[] { ScriptResource.valid_date, "(valid-date? 31 4 2000)", "#f"};
            yield return new object[] { ScriptResource.valid_date, "(valid-date? 29 2 1900)", "#f"};
            yield return new object[] { ScriptResource.valid_date, "(valid-date? 29 2 2000)", "#t"};
            yield return new object[] { ScriptResource.in_predicate, "(in-predicate? 2 '(2 3 4))", "#t"};
            yield return new object[] { ScriptResource.in_predicate, "(in-predicate? 5 '(2 3 4))", "#f"};
            yield return new object[] { ScriptResource.in_predicate, "(in-predicate? 5 '())", "#f"};
        }

        // Тестовые данные для тестирования работы с числами с плавающей запятой
        public static IEnumerable<object[]> FloatingPointNumericData()
        {
            yield return new object[] { ScriptResource.cel_far, "(cel-far 451 1)", "232.7777777777778" };
            yield return new object[] { ScriptResource.cel_far, "(cel-far 32 1)", "0.0" };
            yield return new object[] { ScriptResource.sci, "(sci 42. -5)", "0.00042" };
            yield return new object[] { ScriptResource.sci, "(sci 0.5 5)", "50000.0" };
            yield return new object[] { ScriptResource.tip, "(tip 14.58)", "2.42" };
            yield return new object[] { ScriptResource.tip, "(tip 29.23)", "4.77" };
            yield return new object[] { ScriptResource.tip, "(tip 7.54)", "1.46" };
            yield return new object[] { ScriptResource.sumItems, "(sumItems '(1 2. 3 4 5 6))", "21.0" };
        }

        // Тестовые данные для тестирования работы со строковыми переменными
        public static IEnumerable<object[]> StringData()
        {
            yield return new object[] { ScriptResource.sci, "(sci 7 3)", "7000" };
            yield return new object[] { ScriptResource.sci, "(sci -7 3)", "-7000" };
            yield return new object[] { ScriptResource.sumItems, "(sumItems '(1 2 3 4 5 6))", "21" };
            yield return new object[] { ScriptResource.sumItems, "(sumItems '())", "0" };
            yield return new object[] { ScriptResource.leaf_tree, "(leaf-tree '(5 () ()))", "1" };
            yield return new object[] { ScriptResource.leaf_tree, "(leaf-tree '(5 (3 () ()) (7 () ())))", "2" };
        }

        // Тестовые данные для тестирования работы с пустой ссылкой
        public static IEnumerable<object[]> NullData()
        {
            yield return new object[] {ScriptResource.union, "(union '() '())", "()"};
        }

        // Тестовые данные для тестирования работы с ошибками
        public static IEnumerable<object[]> ErrorData()
        {
            yield return new object[] {"(/ 1 0)", "divide by zero"};
            yield return new object[] {"(/ 1 0", "invalid syntax|(interaction-environment (new-interaction-environment))(/ 1 0"};
            yield return new object[] {"(fun 1 0)", "attempted to use undefined symbol"};
        }


        // Тестируем работоспособность тестирующего модуля
        [Fact]
        public void Test()
        {
            TestClass t1 = new TestClass("sci", "7 3", "7000");
            TestClass t2 = new TestClass("sci", "-7 3", "-7000");
            TestClass t3 = new TestClass("sci", "42. -5", "0.00042");           

            List<TestClass> tsa = new List<TestClass>() { t1, t2, t3 };
            TestingService ts = new TestingService(_compilerService);
            string script = "(define (sci n pow)(* n (expt 10 pow)))";
            Assert.Equal("Total 3, successfull 3 / failed 0 \n" +
                        "Test: 1 \n" +
                        "Result: 7000 \n" +
                        "Test: 2 \n" +
                        "Result: -7000 \n" +
                        "Test: 3 \n" +
                        "Result: 0.00042 \n",
                         ts.Test(script, tsa));
        }

    }
}
