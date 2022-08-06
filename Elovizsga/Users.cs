using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elovizsga
{
    internal class Users
    {
        public string FelhN { get;  private set; }
        public string Jelszo { get; private set; }
        public string Jogosultsag { get; private set; }

        public Users()
        {

        }
        
        public Users(string felh, string jelszo, string jogosultsag)
        {
            FelhN = felh;
            Jelszo = jelszo;
            Jogosultsag = jogosultsag;
        }

        public void setFelhn(string felhn)
        {
            if(felhn.Any(char.IsUpper))
            {
                FelhN = felhn;
            }
            else
            {
                char[] ch = felhn.ToCharArray();
                ch[0] = char.ToUpper(ch[0]);
                felhn = new string(ch);
                FelhN = felhn;
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
