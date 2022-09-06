using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elovizsga
{
    internal class Users
    {
        public int Id { get; private set; }
        public string VezetekNev{ get;  private set; }
        public string KeresztNev { get; private set; }
        public string Jelszo { get; private set; }
        public string Jogosultsag { get; private set; }
        public string Email { get; private set; }
        public string Szuletesiido { get; private set; }

        public Users()
        {

        }
        
        public Users(int id, string vezeteknev, string keresztnev, string jelszo, string jogosultsag, string email, string szuletssnap)
        {
            Id = id;
            VezetekNev = vezeteknev;
            KeresztNev = keresztnev;
            Jelszo = jelszo;
            Jogosultsag = jogosultsag;
            Email = email;
            Szuletesiido = szuletssnap;
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
                for (int i = 8; i >= jelszo.Length; i--)
                {
                    Jelszo = jelszo;
                }
            }
            else
            {
                Jelszo = "asd987654321";
            }

        }

        public void setJogosultsag(string jogosultsag)
        {
            if (jogosultsag == "Admin")
            {
                Jogosultsag = jogosultsag;
                
            }
            else if (jogosultsag == "Vezető")
            {
                Jogosultsag = jogosultsag;  
            }
            else
            {
                Jogosultsag = "Felhasználó";   
            }
        }

        public int setID(int id)
        {
            Id = id;
            return id;
        }

        public void setSzulDate(string szulido)
        {
          Szuletesiido = szulido;
        }

        public void setEmail(string mail)
        {
            Email = mail;
        }
        public List<Users> Felhasznalok = new List<Users>();

    }

    //Jelszó titkositás
    internal class PassWDCryp : Users
    {
        public string EncodePassWD(string password)
        {
            try
            {
                byte[] titkoskulcs = new byte[password.Length];
                titkoskulcs = System.Text.Encoding.UTF8.GetBytes(password);
                string kodoltpassword = Convert.ToBase64String(titkoskulcs);
                return kodoltpassword;
            }
            catch (Exception ex)
            {

                throw new Exception("Hiba a kódolásnál" + ex.Message);
            }
        }

        public string DecodePassWD(string kodoltpassword)
        {
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            System.Text.Decoder utf8decoder = encoder.GetDecoder();
            byte[] decode_byte = Convert.FromBase64String(kodoltpassword);
            int karakterDB = utf8decoder.GetCharCount(decode_byte,0,decode_byte.Length);
            char[] decode_char = new char[karakterDB];
            utf8decoder.GetChars(decode_byte, 0, decode_byte.Length, decode_char, 0);
            string eredmeny = new string(decode_char);
            return eredmeny;
        }
    }

}
