using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionTask
{
    class Collection<T> where T : ProgLanguages
    {
        public T[] langs;

        public Collection()
        {
            langs = new T[0];
        }

        public void AddLang(T dil)
        {
            Array.Resize(ref langs, langs.Length + 1);
            langs[langs.Length - 1] = dil;
        }

        public void NameSort()
        {
            for (int i = 0; i < langs.Length; i++)
            {
                for (int j = 1; j < langs.Length; j++)
                {
                    Array.Sort(langs, (x, y) => String.Compare(x.ProgLangName, y.ProgLangName));
                }
            }
        }

        public void DateSort()
        {
            T temp;
            for (int i = 0; i < langs.Length; i++)
            {
                for (int j = i+1; j < langs.Length; j++)
                {
                    if(langs[j].ProgLangDate < langs[i].ProgLangDate)
                    {
                        temp = langs[j];
                        langs[j] = langs[i];
                        langs[i] = temp;
                    }
                }
            }
        }
    }
}
