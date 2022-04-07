using System;
using System.Collections.Generic;

namespace CollectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime CSharpDate = new DateTime(2001, 02, 01);
            ProgLanguages CSharp = new ProgLanguages("CSharp", CSharpDate);

            DateTime JavascriptDate = new DateTime(1995, 3, 11);
            ProgLanguages Javascript = new ProgLanguages("Javascript", JavascriptDate);

            DateTime CDate = new DateTime(1972, 1, 1);
            ProgLanguages C = new ProgLanguages("C", CDate);

            Collection<ProgLanguages> diller = new Collection<ProgLanguages>();

            diller.AddLang(CSharp);
            diller.AddLang(Javascript);
            diller.AddLang(C);

            diller.DateSort();
            //diller.NameSort();

            foreach (var item in diller.langs)
            {
                Console.WriteLine($"Dilin adi : {item.ProgLangName}\nYaranma tarixi : {item.ProgLangDate}\n");
            }
        }
    }


}
