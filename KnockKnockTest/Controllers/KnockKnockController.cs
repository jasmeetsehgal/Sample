using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace KnockKnockTest.Controllers
{
    [ApiController]
    public class KnockKnockController : Controller
    {
        [HttpGet]
        [Route("api/Fibonacci")]
        public ActionResult Fibonacci(long n)
        {
            return Ok(n);
        }

        [HttpGet]
        [Route("api/ReverseWords")]
        public JsonResult ReverseWords(string sentence)
        {
            if (string.IsNullOrWhiteSpace(sentence))
                return Json(string.Empty);

            //var jsEncodedString = HttpUtility.JavaScriptStringEncode(sentence);

            var reveresedSentence = new string(sentence.Reverse().ToArray());

            var reversedWords = string.Join(" ", reveresedSentence.Split(" ").Reverse());

            //var words = jsEncodedString.Split(" ");

            //var result = new StringBuilder();


            //foreach (var word in words)
            //{
            //    if(result.Length > 0)
            //    {
            //        result.Append(" ");
            //    }
            //    result.Append(word.Reverse().ToArray());
            //}

            return Json(reversedWords);
        }

        [HttpGet]
        [Route("api/Token")]
        public ActionResult Token()
        {
            return Ok(new Guid("11942d58-67dc-4b9b-8373-676be8c6fe2a"));
        }

        [HttpGet]
        [Route("api/TriangleType")]
        public ActionResult TriangleType(string a, string b, string c)
        {
            return Ok((a, b, c));
        }
    }
}