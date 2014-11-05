using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.UI.WebControls;
using ReadifyServiceApplication;
using ReadifyServiceApplication.Managers;

namespace knockknock.readify.net
{
    public class RedPill : IRedPill
    {
        // a method to get my token; used by readify to recognize me
        public Guid WhatIsYourToken()
        {
            return new Guid(Constants.Token);
        }

        // a method to get the nth fibonacci number
        public long FibonacciNumber(long n)
        {
            var fibonacciManager = new FibonacciNumberManager();
            return fibonacciManager.FibonacciNumber(n);
        }

        // a method to get the triagle type: Equilateral,Isosceles,Scalene or Error
        public TriangleType WhatShapeIsThis(int a, int b, int c)
        {
            var shapesManager = new ShapesManager();
            return shapesManager.WhatShapeIsThis(a, b, c);
        }

        // a method to reverse words.
        public string ReverseWords(string s)
        {
            var wordsManager = new WordsManager();
            return wordsManager.ReverseWords(s);
        }
        
    }

}
