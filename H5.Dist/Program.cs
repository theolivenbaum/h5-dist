using System;
using H5;
using H5.Core;
using static H5.Core.es5;
using static H5.Core.dom;
using Tesserae;
using static Tesserae.UI;
using Newtonsoft.Json;

namespace H5.Dist
{
    class Program
    {
        static void Main(string[] args)
        {
            var hello = TextBlock("Hello world!");

            document.body.appendChild(hello.Render());

            var json = JsonConvert.SerializeObject(new { ThisIs = "a test" } );
        }
    }
}
