<<<<<<< Updated upstream
﻿using System;

namespace DanielRaubal
{
    public class ManipulacijaPara
    {
        /// <summary>
        /// Vraca Milione Billione Trilione itd sve do x^303 double STRING _ ali radi Round
        /// </summary>
        public static string VrtniPareteMi(double Broj)
        {
            string VrniMe = "";

            // STARA FUNKCIJA samo koriscena u ovom projektu - OLD FUNCTION only used in this project

            /*
            string Valuta = "";
            string[] niz = { "A", "B", "C", "D","E", "F", "G","H","I","J","K","L"};
            int DodajIzNizDuplo = 0;
            int IFor = 0;

            for (int i = 0; i < 100; i++)
            {
                int na = 303 - i * 3;
                if (Broj >= 1E+na)
                {
                    double brojKalk = Broj / 1E+114;
                    VrniMe = Math.Round(brojKalk)+" ";
                    IFor = i;
                    break;
                }
            }
            while (IFor > 11)
            {
                DodajIzNizDuplo = IFor -= 10;
            }

            while(DodajIzNizDuplo > 0)
            {
                Valuta += niz[IFor];
            }

            VrniMe = VrniMe +  Valuta;
            */

            if (double.IsInfinity(Broj))
            {
                Broj = 1.7976931348623157E+308;
                VrniMe = "infinity";
            }

            else if (Broj >= 1E+144)
            {
                double brojKalk = Broj / 1E+144;
                VrniMe = Math.Round(brojKalk) + " Septe";
            }
            else if (Broj >= 1E+141)
            {
                double brojKalk = Broj / 1E+141;
                VrniMe = Math.Round(brojKalk) + " Sexqu";
            }
            else if (Broj >= 1E+138)
            {
                double brojKalk = Broj / 1E+138;
                VrniMe = Math.Round(brojKalk) + " Quinq";
            }
            else if (Broj >= 1E+135)
            {
                double brojKalk = Broj / 1E+135;
                VrniMe = Math.Round(brojKalk) + " Quatt";
            }
            else if (Broj >= 1E+132)
            {
                double brojKalk = Broj / 1E+132;
                VrniMe = Math.Round(brojKalk) + " Treq";
            }
            else if (Broj >= 1E+129)
            {
                double brojKalk = Broj / 1E+129;
                VrniMe = Math.Round(brojKalk) + " Duoq";
            }
            else if (Broj >= 1E+126)
            {
                double brojKalk = Broj / 1E+126;
                VrniMe = Math.Round(brojKalk) + " Unqu";
            }
            else if (Broj >= 1E+123)
            {
                double brojKalk = Broj / 1E+123;
                VrniMe = Math.Round(brojKalk) + " Quad";
            }
            else if (Broj >= 1E+120)
            {
                double brojKalk = Broj / 1E+120;
                VrniMe = Math.Round(brojKalk) + " Nove";
            }
            else if (Broj >= 1E+117)
            {
                double brojKalk = Broj / 1E+117;
                VrniMe = Math.Round(brojKalk) + " Octo";
            }
            else if (Broj >= 1E+114)
            {
                double brojKalk = Broj / 1E+114;
                VrniMe = Math.Round(brojKalk) + " Sept";
            }
            else if (Broj >= 1E+111)
            {
                double brojKalk = Broj / 1E+111;
                VrniMe = Math.Round(brojKalk) + " Sext";
            }
            else if (Broj >= 1E+108)
            {
                double brojKalk = Broj / 1E+108;
                VrniMe = Math.Round(brojKalk) + " Quint";
            }
            else if (Broj >= 1E+105)
            {
                double brojKalk = Broj / 1E+105;
                VrniMe = Math.Round(brojKalk) + " Quatt";
            }
            else if (Broj >= 1E+102)
            {
                double brojKalk = Broj / 1E+102;
                VrniMe = Math.Round(brojKalk) + " Tret";
            }
            else if (Broj >= 1E+99)
            {
                double brojKalk = Broj / 1E+99;
                VrniMe = Math.Round(brojKalk) + " Duot";
            }
            else if (Broj >= 1E+96)
            {
                double brojKalk = Broj / 1E+96;
                VrniMe = Math.Round(brojKalk) + " Untr";
            }
            else if (Broj >= 1E+93)
            {
                double brojKalk = Broj / 1E+93;
                VrniMe = Math.Round(brojKalk) + " Trig";
            }
            else if (Broj >= 1E+90)
            {
                double brojKalk = Broj / 1E+90;
                VrniMe = Math.Round(brojKalk) + " Nove";
            }
            else if (Broj >= 1E+87)
            {
                double brojKalk = Broj / 1E+87;
                VrniMe = Math.Round(brojKalk) + " Octo";
            }
            else if (Broj >= 1E+84)
            {
                double brojKalk = Broj / 1E+84;
                VrniMe = Math.Round(brojKalk) + " Sepv";
            }
            else if (Broj >= 1E+81)
            {
                double brojKalk = Broj / 1E+81;
                VrniMe = Math.Round(brojKalk) + " Sexv";
            }
            else if (Broj >= 1E+78)
            {
                double brojKalk = Broj / 1E+78;
                VrniMe = Math.Round(brojKalk) + " Quin";
            }
            else if (Broj >= 1E+75)
            {
                double brojKalk = Broj / 1E+75;
                VrniMe = Math.Round(brojKalk) + " Quat";
            }
            else if (Broj >= 1E+72)
            {
                double brojKalk = Broj / 1E+72;
                VrniMe = Math.Round(brojKalk) + " Tre";
            }
            else if (Broj >= 1E+69)
            {
                double brojKalk = Broj / 1E+69;
                VrniMe = Math.Round(brojKalk) + " Duo";
            }
            else if (Broj >= 1E+66)
            {
                double brojKalk = Broj / 1E+66;
                VrniMe = Math.Round(brojKalk) + " Unv";
            }
            else if (Broj >= 1E+63)
            {
                double brojKalk = Broj / 1E+63;
                VrniMe = Math.Round(brojKalk) + " Vig";
            }
            else if (Broj >= 1E+60)
            {
                double brojKalk = Broj / 1E+60;
                VrniMe = Math.Round(brojKalk) + " Nov";
            }
            else if (Broj >= 1E+57)
            {
                double brojKalk = Broj / 1E+57;
                VrniMe = Math.Round(brojKalk) + " Oct";
            }
            else if (Broj >= 1E+54)
            {
                double brojKalk = Broj / 1E+54;
                VrniMe = Math.Round(brojKalk) + " Sep";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Sex";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Qui";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Qua";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Tr";
            }
            else if (Broj >= 1000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Du";
            }
            else if (Broj >= 1000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Un";
            }
            else if (Broj >= 1000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " De";
            }
            else if (Broj >= 1000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " No";
            }
            else if (Broj >= 1000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Oc";
            }
            else if (Broj >= 1000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Se";
            }
            else if (Broj >= 1000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Sx";
            }
            else if (Broj >= 1000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Qi";
            }
            else if (Broj >= 1000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Q";
            }
            else if (Broj >= 1000000000000d)
            {
                double brojKalk = Broj / 1000000000000d;
                VrniMe = Math.Round(brojKalk) + " T";
                /*
                string BrojString = Broj / 1000000000000d + "";

                int index = BrojString.IndexOf(".");

                string Brojst = BrojString.Substring(0, index);
                VrniMe = Brojst + " T";*/
            }
            else if (Broj >= 1000000000d)
            {
                double brojKalk = Broj / 1000000000d;
                VrniMe = Math.Round(brojKalk) + " B";
                /*
                string BrojString = Broj / 1000000000d + "";

                int index = BrojString.IndexOf(".");
                string Brojst = BrojString.Substring(0, index);
                VrniMe = Brojst + " B";*/
            }
            else if (Broj >= 1000000d)
            {
                /*
                string BrojString = Broj / 1000000d + "";

                int index = BrojString.IndexOf(".");
                string Brojst = BrojString.Substring(0, index);
                VrniMe = Brojst + " M";
                */
                double brojKalk = Broj / 1000000d;
                VrniMe = Math.Round(brojKalk) + " M";
            }
            else if (Broj >= 1000)
            {
                //string BrojString = Broj / 1000 + "";
                //int index = BrojString.IndexOf(".");
                //string Brojst = BrojString.Substring(0, index);
                //VrniMe = Brojst + " K";
                VrniMe = Math.Round(Broj / 1000) + " K";
            }
            else
            {
                
                Broj = Math.Round(Broj, 1);
                VrniMe = Broj.ToString();
            }
            return VrniMe;
        }

        /// <summary>
        /// Vraca Milione Billione Trilione itd sve do x^303 double INT
        /// </summary>
        public static string VrtniPareteMi_Int(double Broj)
        {
            string VrniMe = "";

            // ~WORST WAY TO DO IT, better make your own by using array and for loop to go through!~

            if (double.IsInfinity(Broj))
            {
                Broj = 1.7976931348623157E+308;
                VrniMe = "infinity";
            }
            else if (Broj >= 1E+144)
            {
                double brojKalk = Broj / 1E+144;
                VrniMe = Math.Round(brojKalk,2) + " Septe";
            }
            else if (Broj >= 1E+141)
            {
                double brojKalk = Broj / 1E+141;
                VrniMe = Math.Round(brojKalk,2) + " Sexqu";
            }
            else if (Broj >= 1E+138)
            {
                double brojKalk = Broj / 1E+138;
                VrniMe = Math.Round(brojKalk,2) + " Quinq";
            }
            else if (Broj >= 1E+135)
            {
                double brojKalk = Broj / 1E+135;
                VrniMe = Math.Round(brojKalk,2) + " Quatt";
            }
            else if (Broj >= 1E+132)
            {
                double brojKalk = Broj / 1E+132;
                VrniMe = Math.Round(brojKalk,2) + " Treq";
            }
            else if (Broj >= 1E+129)
            {
                double brojKalk = Broj / 1E+129;
                VrniMe = Math.Round(brojKalk,2) + " Duoq";
            }
            else if (Broj >= 1E+126)
            {
                double brojKalk = Broj / 1E+126;
                VrniMe = Math.Round(brojKalk,2) + " Unqu";
            }
            else if (Broj >= 1E+123)
            {
                double brojKalk = Broj / 1E+123;
                VrniMe = Math.Round(brojKalk,2) + " Quad";
            }
            else if (Broj >= 1E+120)
            {
                double brojKalk = Broj / 1E+120;
                VrniMe = Math.Round(brojKalk,2) + " Nove";
            }
            else if (Broj >= 1E+117)
            {
                double brojKalk = Broj / 1E+117;
                VrniMe = Math.Round(brojKalk,2) + " Octo";
            }
            else if (Broj >= 1E+114)
            {
                double brojKalk = Broj / 1E+114;
                VrniMe = Math.Round(brojKalk,2) + " Sept";
            }
            else if (Broj >= 1E+111)
            {
                double brojKalk = Broj / 1E+111;
                VrniMe = Math.Round(brojKalk,2) + " Sext";
            }
            else if (Broj >= 1E+108)
            {
                double brojKalk = Broj / 1E+108;
                VrniMe = Math.Round(brojKalk,2) + " Quint";
            }
            else if (Broj >= 1E+105)
            {
                double brojKalk = Broj / 1E+105;
                VrniMe = Math.Round(brojKalk,2) + " Quatt";
            }
            else if (Broj >= 1E+102)
            {
                double brojKalk = Broj / 1E+102;
                VrniMe = Math.Round(brojKalk,2) + " Tret";
            }
            else if (Broj >= 1E+99)
            {
                double brojKalk = Broj / 1E+99;
                VrniMe = Math.Round(brojKalk,2) + " Duot";
            }
            else if (Broj >= 1E+96)
            {
                double brojKalk = Broj / 1E+96;
                VrniMe = Math.Round(brojKalk,2) + " Untr";
            }
            else if (Broj >= 1E+93)
            {
                double brojKalk = Broj / 1E+93;
                VrniMe = Math.Round(brojKalk,2) + " Trig";
            }
            else if (Broj >= 1E+90)
            {
                double brojKalk = Broj / 1E+90;
                VrniMe = Math.Round(brojKalk,2) + " Nove";
            }
            else if (Broj >= 1E+87)
            {
                double brojKalk = Broj / 1E+87;
                VrniMe = Math.Round(brojKalk,2) + " Octo";
            }
            else if (Broj >= 1E+84)
            {
                double brojKalk = Broj / 1E+84;
                VrniMe = Math.Round(brojKalk,2) + " Sepv";
            }
            else if (Broj >= 1E+81)
            {
                double brojKalk = Broj / 1E+81;
                VrniMe = Math.Round(brojKalk,2) + " Sexv";
            }
            else if (Broj >= 1E+78)
            {
                double brojKalk = Broj / 1E+78;
                VrniMe = Math.Round(brojKalk,2) + " Quin";
            }
            else if (Broj >= 1E+75)
            {
                double brojKalk = Broj / 1E+75;
                VrniMe = Math.Round(brojKalk,2) + " Quat";
            }
            else if (Broj >= 1E+72)
            {
                double brojKalk = Broj / 1E+72;
                VrniMe = Math.Round(brojKalk,2) + " Tre";
            }
            else if (Broj >= 1E+69)
            {
                double brojKalk = Broj / 1E+69;
                VrniMe = Math.Round(brojKalk,2) + " Duo";
            }
            else if (Broj >= 1E+66)
            {
                double brojKalk = Broj / 1E+66;
                VrniMe = Math.Round(brojKalk,2) + " Unv";
            }
            else if (Broj >= 1E+63)
            {
                double brojKalk = Broj / 1E+63;
                VrniMe = Math.Round(brojKalk,2) + " Vig";
            }
            else if (Broj >= 1E+60)
            {
                double brojKalk = Broj / 1E+60;
                VrniMe = Math.Round(brojKalk,2) + " Nov";
            }
            else if (Broj >= 1E+57)
            {
                double brojKalk = Broj / 1E+57;
                VrniMe = Math.Round(brojKalk,2) + " Oct";
            }
            else if (Broj >= 1E+54)
            {
                double brojKalk = Broj / 1E+54;
                VrniMe = Math.Round(brojKalk,2) + " Sep";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Sex";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Qui";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Qua";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Tr";
            }
            else if (Broj >= 1000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Du";
            }
            else if (Broj >= 1000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Un";
            }
            else if (Broj >= 1000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " De";
            }
            else if (Broj >= 1000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " No";
            }
            else if (Broj >= 1000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Oc";
            }
            else if (Broj >= 1000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Se";
            }
            else if (Broj >= 1000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Sx";
            }
            else if (Broj >= 1000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Qi";
            }
            else if (Broj >= 1000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Q";
            }
            else if (Broj >= 1000000000000d)
            {
                double BrojString = Broj / 1000000000000d;
                VrniMe = Math.Round(BrojString,2) + " T";
            }
            else if (Broj >= 1000000000d)
            {
                double BrojString = Broj / 1000000000d;
                VrniMe = Math.Round(BrojString,2) + " B";
            }
            else if (Broj >= 1000000d)
            {
                double BrojString = Broj / 1000000d;
                VrniMe = Math.Round(BrojString,2) + " M";
            }
            else if (Broj >= 1000)
            {
                double BrojString = Broj / 1000d;
                VrniMe = Math.Round(BrojString,2) + " K";
            }
            else
            {
                Broj = Math.Round(Broj, 2);
                VrniMe = Broj.ToString();
            }
            return VrniMe;
        }
    }
}
=======
﻿using System;

namespace DanielRaubal
{
    public class ManipulacijaPara
    {
        /// <summary>
        /// Vraca Milione Billione Trilione itd sve do x^303 double STRING _ ali radi Round
        /// </summary>
        public static string VrtniPareteMi(double Broj)
        {
            string VrniMe = "";

            // STARA FUNKCIJA samo koriscena u ovom projektu - OLD FUNCTION only used in this project

            /*
            string Valuta = "";
            string[] niz = { "A", "B", "C", "D","E", "F", "G","H","I","J","K","L"};
            int DodajIzNizDuplo = 0;
            int IFor = 0;

            for (int i = 0; i < 100; i++)
            {
                int na = 303 - i * 3;
                if (Broj >= 1E+na)
                {
                    double brojKalk = Broj / 1E+114;
                    VrniMe = Math.Round(brojKalk)+" ";
                    IFor = i;
                    break;
                }
            }
            while (IFor > 11)
            {
                DodajIzNizDuplo = IFor -= 10;
            }

            while(DodajIzNizDuplo > 0)
            {
                Valuta += niz[IFor];
            }

            VrniMe = VrniMe +  Valuta;
            */

            if (double.IsInfinity(Broj))
            {
                Broj = 1.7976931348623157E+308;
                VrniMe = "infinity";
            }

            else if (Broj >= 1E+144)
            {
                double brojKalk = Broj / 1E+144;
                VrniMe = Math.Round(brojKalk) + " Septe";
            }
            else if (Broj >= 1E+141)
            {
                double brojKalk = Broj / 1E+141;
                VrniMe = Math.Round(brojKalk) + " Sexqu";
            }
            else if (Broj >= 1E+138)
            {
                double brojKalk = Broj / 1E+138;
                VrniMe = Math.Round(brojKalk) + " Quinq";
            }
            else if (Broj >= 1E+135)
            {
                double brojKalk = Broj / 1E+135;
                VrniMe = Math.Round(brojKalk) + " Quatt";
            }
            else if (Broj >= 1E+132)
            {
                double brojKalk = Broj / 1E+132;
                VrniMe = Math.Round(brojKalk) + " Treq";
            }
            else if (Broj >= 1E+129)
            {
                double brojKalk = Broj / 1E+129;
                VrniMe = Math.Round(brojKalk) + " Duoq";
            }
            else if (Broj >= 1E+126)
            {
                double brojKalk = Broj / 1E+126;
                VrniMe = Math.Round(brojKalk) + " Unqu";
            }
            else if (Broj >= 1E+123)
            {
                double brojKalk = Broj / 1E+123;
                VrniMe = Math.Round(brojKalk) + " Quad";
            }
            else if (Broj >= 1E+120)
            {
                double brojKalk = Broj / 1E+120;
                VrniMe = Math.Round(brojKalk) + " Nove";
            }
            else if (Broj >= 1E+117)
            {
                double brojKalk = Broj / 1E+117;
                VrniMe = Math.Round(brojKalk) + " Octo";
            }
            else if (Broj >= 1E+114)
            {
                double brojKalk = Broj / 1E+114;
                VrniMe = Math.Round(brojKalk) + " Sept";
            }
            else if (Broj >= 1E+111)
            {
                double brojKalk = Broj / 1E+111;
                VrniMe = Math.Round(brojKalk) + " Sext";
            }
            else if (Broj >= 1E+108)
            {
                double brojKalk = Broj / 1E+108;
                VrniMe = Math.Round(brojKalk) + " Quint";
            }
            else if (Broj >= 1E+105)
            {
                double brojKalk = Broj / 1E+105;
                VrniMe = Math.Round(brojKalk) + " Quatt";
            }
            else if (Broj >= 1E+102)
            {
                double brojKalk = Broj / 1E+102;
                VrniMe = Math.Round(brojKalk) + " Tret";
            }
            else if (Broj >= 1E+99)
            {
                double brojKalk = Broj / 1E+99;
                VrniMe = Math.Round(brojKalk) + " Duot";
            }
            else if (Broj >= 1E+96)
            {
                double brojKalk = Broj / 1E+96;
                VrniMe = Math.Round(brojKalk) + " Untr";
            }
            else if (Broj >= 1E+93)
            {
                double brojKalk = Broj / 1E+93;
                VrniMe = Math.Round(brojKalk) + " Trig";
            }
            else if (Broj >= 1E+90)
            {
                double brojKalk = Broj / 1E+90;
                VrniMe = Math.Round(brojKalk) + " Nove";
            }
            else if (Broj >= 1E+87)
            {
                double brojKalk = Broj / 1E+87;
                VrniMe = Math.Round(brojKalk) + " Octo";
            }
            else if (Broj >= 1E+84)
            {
                double brojKalk = Broj / 1E+84;
                VrniMe = Math.Round(brojKalk) + " Sepv";
            }
            else if (Broj >= 1E+81)
            {
                double brojKalk = Broj / 1E+81;
                VrniMe = Math.Round(brojKalk) + " Sexv";
            }
            else if (Broj >= 1E+78)
            {
                double brojKalk = Broj / 1E+78;
                VrniMe = Math.Round(brojKalk) + " Quin";
            }
            else if (Broj >= 1E+75)
            {
                double brojKalk = Broj / 1E+75;
                VrniMe = Math.Round(brojKalk) + " Quat";
            }
            else if (Broj >= 1E+72)
            {
                double brojKalk = Broj / 1E+72;
                VrniMe = Math.Round(brojKalk) + " Tre";
            }
            else if (Broj >= 1E+69)
            {
                double brojKalk = Broj / 1E+69;
                VrniMe = Math.Round(brojKalk) + " Duo";
            }
            else if (Broj >= 1E+66)
            {
                double brojKalk = Broj / 1E+66;
                VrniMe = Math.Round(brojKalk) + " Unv";
            }
            else if (Broj >= 1E+63)
            {
                double brojKalk = Broj / 1E+63;
                VrniMe = Math.Round(brojKalk) + " Vig";
            }
            else if (Broj >= 1E+60)
            {
                double brojKalk = Broj / 1E+60;
                VrniMe = Math.Round(brojKalk) + " Nov";
            }
            else if (Broj >= 1E+57)
            {
                double brojKalk = Broj / 1E+57;
                VrniMe = Math.Round(brojKalk) + " Oct";
            }
            else if (Broj >= 1E+54)
            {
                double brojKalk = Broj / 1E+54;
                VrniMe = Math.Round(brojKalk) + " Sep";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Sex";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Qui";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Qua";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Tr";
            }
            else if (Broj >= 1000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Du";
            }
            else if (Broj >= 1000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Un";
            }
            else if (Broj >= 1000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " De";
            }
            else if (Broj >= 1000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " No";
            }
            else if (Broj >= 1000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Oc";
            }
            else if (Broj >= 1000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Se";
            }
            else if (Broj >= 1000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Sx";
            }
            else if (Broj >= 1000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Qi";
            }
            else if (Broj >= 1000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000d;
                VrniMe = Math.Round(brojKalk) + " Q";
            }
            else if (Broj >= 1000000000000d)
            {
                double brojKalk = Broj / 1000000000000d;
                VrniMe = Math.Round(brojKalk) + " T";
                /*
                string BrojString = Broj / 1000000000000d + "";

                int index = BrojString.IndexOf(".");

                string Brojst = BrojString.Substring(0, index);
                VrniMe = Brojst + " T";*/
            }
            else if (Broj >= 1000000000d)
            {
                double brojKalk = Broj / 1000000000d;
                VrniMe = Math.Round(brojKalk) + " B";
                /*
                string BrojString = Broj / 1000000000d + "";

                int index = BrojString.IndexOf(".");
                string Brojst = BrojString.Substring(0, index);
                VrniMe = Brojst + " B";*/
            }
            else if (Broj >= 1000000d)
            {
                /*
                string BrojString = Broj / 1000000d + "";

                int index = BrojString.IndexOf(".");
                string Brojst = BrojString.Substring(0, index);
                VrniMe = Brojst + " M";
                */
                double brojKalk = Broj / 1000000d;
                VrniMe = Math.Round(brojKalk) + " M";
            }
            else if (Broj >= 1000)
            {
                //string BrojString = Broj / 1000 + "";
                //int index = BrojString.IndexOf(".");
                //string Brojst = BrojString.Substring(0, index);
                //VrniMe = Brojst + " K";
                VrniMe = Math.Round(Broj / 1000) + " K";
            }
            else
            {
                
                Broj = Math.Round(Broj, 1);
                VrniMe = Broj.ToString();
            }
            return VrniMe;
        }

        /// <summary>
        /// Vraca Milione Billione Trilione itd sve do x^303 double INT
        /// </summary>
        public static string VrtniPareteMi_Int(double Broj)
        {
            string VrniMe = "";

            // ~WORST WAY TO DO IT, better make your own by using array and for loop to go through!~

            if (double.IsInfinity(Broj))
            {
                Broj = 1.7976931348623157E+308;
                VrniMe = "infinity";
            }
            else if (Broj >= 1E+144)
            {
                double brojKalk = Broj / 1E+144;
                VrniMe = Math.Round(brojKalk,2) + " Septe";
            }
            else if (Broj >= 1E+141)
            {
                double brojKalk = Broj / 1E+141;
                VrniMe = Math.Round(brojKalk,2) + " Sexqu";
            }
            else if (Broj >= 1E+138)
            {
                double brojKalk = Broj / 1E+138;
                VrniMe = Math.Round(brojKalk,2) + " Quinq";
            }
            else if (Broj >= 1E+135)
            {
                double brojKalk = Broj / 1E+135;
                VrniMe = Math.Round(brojKalk,2) + " Quatt";
            }
            else if (Broj >= 1E+132)
            {
                double brojKalk = Broj / 1E+132;
                VrniMe = Math.Round(brojKalk,2) + " Treq";
            }
            else if (Broj >= 1E+129)
            {
                double brojKalk = Broj / 1E+129;
                VrniMe = Math.Round(brojKalk,2) + " Duoq";
            }
            else if (Broj >= 1E+126)
            {
                double brojKalk = Broj / 1E+126;
                VrniMe = Math.Round(brojKalk,2) + " Unqu";
            }
            else if (Broj >= 1E+123)
            {
                double brojKalk = Broj / 1E+123;
                VrniMe = Math.Round(brojKalk,2) + " Quad";
            }
            else if (Broj >= 1E+120)
            {
                double brojKalk = Broj / 1E+120;
                VrniMe = Math.Round(brojKalk,2) + " Nove";
            }
            else if (Broj >= 1E+117)
            {
                double brojKalk = Broj / 1E+117;
                VrniMe = Math.Round(brojKalk,2) + " Octo";
            }
            else if (Broj >= 1E+114)
            {
                double brojKalk = Broj / 1E+114;
                VrniMe = Math.Round(brojKalk,2) + " Sept";
            }
            else if (Broj >= 1E+111)
            {
                double brojKalk = Broj / 1E+111;
                VrniMe = Math.Round(brojKalk,2) + " Sext";
            }
            else if (Broj >= 1E+108)
            {
                double brojKalk = Broj / 1E+108;
                VrniMe = Math.Round(brojKalk,2) + " Quint";
            }
            else if (Broj >= 1E+105)
            {
                double brojKalk = Broj / 1E+105;
                VrniMe = Math.Round(brojKalk,2) + " Quatt";
            }
            else if (Broj >= 1E+102)
            {
                double brojKalk = Broj / 1E+102;
                VrniMe = Math.Round(brojKalk,2) + " Tret";
            }
            else if (Broj >= 1E+99)
            {
                double brojKalk = Broj / 1E+99;
                VrniMe = Math.Round(brojKalk,2) + " Duot";
            }
            else if (Broj >= 1E+96)
            {
                double brojKalk = Broj / 1E+96;
                VrniMe = Math.Round(brojKalk,2) + " Untr";
            }
            else if (Broj >= 1E+93)
            {
                double brojKalk = Broj / 1E+93;
                VrniMe = Math.Round(brojKalk,2) + " Trig";
            }
            else if (Broj >= 1E+90)
            {
                double brojKalk = Broj / 1E+90;
                VrniMe = Math.Round(brojKalk,2) + " Nove";
            }
            else if (Broj >= 1E+87)
            {
                double brojKalk = Broj / 1E+87;
                VrniMe = Math.Round(brojKalk,2) + " Octo";
            }
            else if (Broj >= 1E+84)
            {
                double brojKalk = Broj / 1E+84;
                VrniMe = Math.Round(brojKalk,2) + " Sepv";
            }
            else if (Broj >= 1E+81)
            {
                double brojKalk = Broj / 1E+81;
                VrniMe = Math.Round(brojKalk,2) + " Sexv";
            }
            else if (Broj >= 1E+78)
            {
                double brojKalk = Broj / 1E+78;
                VrniMe = Math.Round(brojKalk,2) + " Quin";
            }
            else if (Broj >= 1E+75)
            {
                double brojKalk = Broj / 1E+75;
                VrniMe = Math.Round(brojKalk,2) + " Quat";
            }
            else if (Broj >= 1E+72)
            {
                double brojKalk = Broj / 1E+72;
                VrniMe = Math.Round(brojKalk,2) + " Tre";
            }
            else if (Broj >= 1E+69)
            {
                double brojKalk = Broj / 1E+69;
                VrniMe = Math.Round(brojKalk,2) + " Duo";
            }
            else if (Broj >= 1E+66)
            {
                double brojKalk = Broj / 1E+66;
                VrniMe = Math.Round(brojKalk,2) + " Unv";
            }
            else if (Broj >= 1E+63)
            {
                double brojKalk = Broj / 1E+63;
                VrniMe = Math.Round(brojKalk,2) + " Vig";
            }
            else if (Broj >= 1E+60)
            {
                double brojKalk = Broj / 1E+60;
                VrniMe = Math.Round(brojKalk,2) + " Nov";
            }
            else if (Broj >= 1E+57)
            {
                double brojKalk = Broj / 1E+57;
                VrniMe = Math.Round(brojKalk,2) + " Oct";
            }
            else if (Broj >= 1E+54)
            {
                double brojKalk = Broj / 1E+54;
                VrniMe = Math.Round(brojKalk,2) + " Sep";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Sex";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Qui";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Qua";
            }
            else if (Broj >= 1000000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Tr";
            }
            else if (Broj >= 1000000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Du";
            }
            else if (Broj >= 1000000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Un";
            }
            else if (Broj >= 1000000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " De";
            }
            else if (Broj >= 1000000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " No";
            }
            else if (Broj >= 1000000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Oc";
            }
            else if (Broj >= 1000000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Se";
            }
            else if (Broj >= 1000000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Sx";
            }
            else if (Broj >= 1000000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Qi";
            }
            else if (Broj >= 1000000000000000d)
            {
                double brojKalk = Broj / 1000000000000000d;
                VrniMe = Math.Round(brojKalk,2) + " Q";
            }
            else if (Broj >= 1000000000000d)
            {
                double BrojString = Broj / 1000000000000d;
                VrniMe = Math.Round(BrojString,2) + " T";
            }
            else if (Broj >= 1000000000d)
            {
                double BrojString = Broj / 1000000000d;
                VrniMe = Math.Round(BrojString,2) + " B";
            }
            else if (Broj >= 1000000d)
            {
                double BrojString = Broj / 1000000d;
                VrniMe = Math.Round(BrojString,2) + " M";
            }
            else if (Broj >= 1000)
            {
                double BrojString = Broj / 1000d;
                VrniMe = Math.Round(BrojString,2) + " K";
            }
            else
            {
                Broj = Math.Round(Broj, 2);
                VrniMe = Broj.ToString();
            }
            return VrniMe;
        }
    }
}
>>>>>>> Stashed changes
