using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nákladní_vozidlo
{
    internal class NakladniAuto
    {
        private string SPZ = "";
        private double nosnost = 0;
        private double Hmotnost_nakladu = 0;
        private double nalozeno = 0;
        public NakladniAuto(string SPZ, double nosnost, double Hmotnost_nakladu)
        {
            this.SPZ = SPZ;
            this.nosnost = nosnost;
            this.Hmotnost_nakladu = Hmotnost_nakladu;
            nalozeno = 0;
        }

        public string NalozNaklad(double naloz)
        {

            if(nalozeno == nosnost)
            {
                return "auto je jiz plne";
            }
            else
            {
                if((naloz > Hmotnost_nakladu)&&(naloz <= nosnost))
                {
                    if (Hmotnost_nakladu == 0)
                    {
                        return "nemame tu zádny náklad";
                    }
                    else
                    {
                        nalozeno = Hmotnost_nakladu;
                        return "nalozily jsme zbytek nakladu, ale nebylo to dust na to abychom mohly dodat pozadovane mnozstvi";
                    }
                }
               else if(naloz > nosnost)
                {
                    Hmotnost_nakladu = Hmotnost_nakladu- nosnost;
                    nalozeno = nosnost;
                    return "nemohly jsme nalozit vse, a tak jsme nalozily maximální kapacitu, neboli " + nosnost + "a zbytek jsme nenalozily, zbývá zde ještě " + Hmotnost_nakladu;
                }
               else if(naloz == nosnost)
                {
                    Hmotnost_nakladu -= naloz;
                    nalozeno = nosnost;
                    return "pozadovane mnozstvi nalozeno, zbývá zde " + Hmotnost_nakladu;
                }
                else
                {
                    Hmotnost_nakladu -= naloz;
                    nalozeno = naloz;
                    return "nalozily jsme " + naloz + " na aute je jeste misto na " + (nosnost - naloz) + "nakladu, a zbývá zde " + Hmotnost_nakladu;
                }

            }
        }

        public string Vyloz_Naklad(double vyloz)
        {
            if (nalozeno == 0)
            {
                return "auto je prazdne";
            }
            else if(nalozeno == vyloz)
            {
                nalozeno = 0;
                return "naklad vylozen, nic v trucku nezbyva, dekujeme za pouziti";
            }
            else if(vyloz < nalozeno)
            {
                
                double zbytek = nalozeno - vyloz;
                nalozeno = zbytek;
                return "bylo vylozeno " + vyloz + " zbytek činí " + zbytek;
            }
            else
            {
                vyloz = vyloz - nalozeno;
                nalozeno = 0;
                return "vylozily jsme vse, nicmene je jeste potreba " + vyloz + " materialu";
            }

        }

        public override string ToString()
        {
            try
            {
                return "Auto ma SPZ: " + SPZ + "\n a ma nalozeno" + nalozeno + "\n a jeho nosnost je" + nosnost;
            }
            catch
            {
                return "error";
            }
        }


    }
}
