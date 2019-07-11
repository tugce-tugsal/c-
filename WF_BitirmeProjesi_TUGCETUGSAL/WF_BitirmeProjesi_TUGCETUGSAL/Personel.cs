using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_BitirmeProjesi_TUGCETUGSAL
{
    class Personel
    {
        public int Telno;
        public string Adi;
        public string Soyadi;
        public int Yas;
        public int Tc;
        public int DepartmanID;
        public int Maas;
        public Personel(int telno,string adi,string soyadi,int yas,int tc,int departmanID,int maas)
        {
            Telno = telno;
            Adi = adi;
            Soyadi = soyadi;
            Yas = yas;
            Tc = tc;
            DepartmanID = departmanID;
            Maas = maas;
        }

    }
}
