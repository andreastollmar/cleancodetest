using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberVerifier.Test
{
    public class TestData
    {
        public static IEnumerable<object[]> PersonalNumberData()
        {
            var list = new List<object[]>{
                new object[] {"199112303855"},
                new object[] {"19911230-3855"},
                new object[] {"911230-3855"},
                new object[] {"9112303855"}
            };

            return list;
        }

        public static IEnumerable<object[]> PersonalNumberLongShortData()
        {
            var list = new List<object[]>{
                new object[] {"19911230385524"},
                new object[] {"19911230-385513"},
                new object[] {"91123"},
                new object[] {"91123038"}
            };

            return list;
        }
        public static IEnumerable<object[]> PersonalNumberFalseData()
        {
            var list = new List<object[]>{
                new object[] {"19911230-3856"},
                new object[] {"9212200256"},
                new object[] {"9111200345"}
            };

            return list;
        }



    }
}
