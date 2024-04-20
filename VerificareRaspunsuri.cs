using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Joc
{
    public class VerificareRaspunsuri
    {
        private int scor;
        private const string FilePath = "raspunsuri.txt";

        public int Score { get { return scor; } }

        public VerificareRaspunsuri()
        {
            scor = 0;
        }

        public bool VerifRaspuns(string raspCorect, string raspuns)
        {
            if (raspuns.ToLower() == raspCorect)
            {
                scor++;
                return true;
            }
            return false;
        }


        public void ScrieRezultat(string intrebare, string rasp)
        {
            using (StreamWriter writer = new StreamWriter(FilePath, true))
            {
                writer.WriteLine($"Question: {intrebare}, Answer: {rasp}");
            }
        }
    }
}