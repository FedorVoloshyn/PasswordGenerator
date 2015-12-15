using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGenerator
{
    public class PasswordGenerator
    {
        Random rand;
        public PasswordGenerator()
        {
            rand = new Random();
        }
        public string Generete(int NumberOfSymbols, int language, bool UpperLetters, bool Numbers, bool Symbols)
        {
            string rezult = "";

            for (int i = 0; i < NumberOfSymbols; i++)
            {
                switch (rand.Next(1, 5))
                {
                    case 1: rezult += GetLowerSymbol(language);
                        break;
                    case 2:
                        if (UpperLetters)
                            rezult += GetUpperSymbol(language);
                        else
                            rezult += GetLowerSymbol(language);
                        break;
                    case 3:
                        if (Numbers)
                            rezult += GetNumberSymbol();
                        else
                            rezult += GetLowerSymbol(language);
                        break;
                    case 4:
                        if (Symbols)
                            rezult += GetSymbol();
                        else
                            rezult += GetLowerSymbol(language);
                        break;
                }
            }
            return rezult;
        }

        char GetLowerSymbol(int language)
        {
            if (language == 1)
                return (char)rand.Next(0x0061, 0x007A);
            else
                return (char)rand.Next(0x0430, 0x044F);
        }

        char GetUpperSymbol(int language)
        {
            if (language == 1)
                return (char)rand.Next(0x0041, 0x005A);
            else
                return (char)rand.Next(0x0410, 0x042F);
        }
        char GetNumberSymbol()
        {
            return (char)rand.Next(0x0030, 0x0039);
        }
        char GetSymbol()
        {
            return (char)rand.Next(0x0021, 0x002F);
        }
    }
}
