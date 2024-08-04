using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialQuiz
{
    interface IDifferentiate
    {
        Object Differentiate(Object x);
    }
    interface ISetTerms
    {
        void SetTerms(List<int> l);
    }
}
