using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionTask
{
    class ProgLanguages
    {
        public string ProgLangName { get; set; }
        public DateTime ProgLangDate { get; set; }

        public ProgLanguages(string progLangName, DateTime progLangDate)
        {
            ProgLangName = progLangName;
            ProgLangDate = progLangDate;
        }
    }
}
