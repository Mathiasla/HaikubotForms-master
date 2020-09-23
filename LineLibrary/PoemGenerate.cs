using PoemLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PoemLibrary
{
    public class PoemGenerate
    {
        SQLiteDataAccess Loadfirst = new SQLiteDataAccess();
        public string CreateHaiku()
        {
            var random = new Random();
            SQLiteDataAccess.LoadFirstLine();

            var verbs1 = new List<FirstLineModel>();
            var verbs2 = new List<SecondLineModel>();
            var verbs3 = new List<ThirdLineModel>();

            int index1 = random.Next(verbs1.Count);
            int index2 = random.Next(verbs2.Count);
            int index3 = random.Next(verbs3.Count);

            var først = verbs1/*[index1]*/;
            //var andet = verbs2[index2];
            //var tredje = verbs3[index3];

            //testoList = new List<string>();
            //foreach(string a in 
            //{

            ////}
            //string samlet = først.ToString();

            //return samlet;
            string saml = string.Join(Environment.NewLine, verbs1);

            string samlet = saml.ToString();
            return samlet;


            //string Afprøv = først + andet + tredje
        }


            //var random = new Random();

            //var FirstLine = new ArrayList();
            //var SecondLine = new ArrayList();
            //var ThirdLine = new ArrayList();

            //FirstLine.AddRange(new ArrayList() { "Sommerfuglene", "En gammel dam", "Fisken svømmer rundt,", "Den lille larve", "Tigeren springer,", "Sommeren er her", "Små blade lyser", "Blade er gule" });
            //SecondLine.AddRange(new ArrayList() { "hvorfor bruge mange ord", "en frø hopper i,", "I det isne kolde vand,", "springer frem fra sit skjul", "over træer og buske –", "Græsset med fuglesang", "Nye i solens varme", "de falder fra træerne", });
            //ThirdLine.AddRange(new ArrayList() { "et kan gøre det", "Lyden af vand.", "Vinteren kommer.", "bliver sommerfugl", "på jagt efter fisk.", "varmt og dejligt", "Forår indeni", "sneen kommer snart" });

            //int index1 = random.Next(FirstLine.Count);
            //int index2 = random.Next(SecondLine.Count);
            //int index3 = random.Next(ThirdLine.Count);

            //Console.WriteLine(FirstLine[index1] + "\r\n" + SecondLine[index2] + "\r\n" + ThirdLine[index3]);
            //Console.ReadKey();
        }
    }


