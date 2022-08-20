using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elovizsga
{
    internal class Users
    {
        public string VezetekNev{ get;  private set; }
        public string KeresztNev { get; private set; }
        public string Jelszo { get; private set; }
        public string Jogosultsag { get; private set; }

        public Users()
        {

        }
        
        public Users(string vezeteknev, string keresztnev, string jelszo, string jogosultsag)
        {
            VezetekNev = vezeteknev;
            KeresztNev = keresztnev;
            Jelszo = jelszo;
            Jogosultsag = jogosultsag;
        }

        public void setVezet(string vezeteknev)
        {
            if(vezeteknev.Any(char.IsUpper))
            {
                VezetekNev = vezeteknev;      
            }
            else
            {
                char[] ch = vezeteknev.ToCharArray();
                ch[0] = char.ToUpper(ch[0]);
                vezeteknev = new string(ch);
                VezetekNev = vezeteknev;
            }
            
           
        }
        public void setKereszt(string keresztnev)
        {
            if(keresztnev.Any(char.IsUpper))
            {
                KeresztNev = keresztnev ;
            }
            else
            {
                char[] ch1 = keresztnev.ToCharArray();
                ch1[0] = char.ToUpper(ch1[0]);
                keresztnev = new string(ch1);
                KeresztNev = keresztnev;
            }
        }

        public void setJelszo(string jelszo)
        {
            if (jelszo.Any(char.IsUpper) && jelszo.Any(char.IsDigit))
            {
                for (int i = 8; i <= jelszo.Length; i--)
                {
                    Jelszo = jelszo;
                }
            }
            else
            {
                Jelszo = "asd987654321";
            }

        }
        public List<Users> Felhasznalok = new List<Users>();

    }

}
