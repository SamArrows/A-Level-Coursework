using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolynomialQuiz
{
    interface IQuestionAnswered
    {
        bool QuestionAnswered();
        Object GetAnswer();
    }
}
