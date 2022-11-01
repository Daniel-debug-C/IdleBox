<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text.RegularExpressions;

using System.Globalization;
using DanielRaubal;

public class Main : MonoBehaviour
{
    public GameObject IzaTekstObjekat;
    public RectTransform Canvas;
    public static RectTransform CanvasSalji;
    public GameObject PopUPText;
    public float Brzina_Animacije;
    public double BrojKutija;
    public int Parete_BrojKutija;
    public Text BrojKutija_Text;
    public Text PoSekundi_Text;
    [Header("KolkoSta")]
    public static float OnClick_ADD = 1;
    public double OnIdle_ADD_sekund;
    public float VremeIdle = 1;
    [Header("GUI")]
    public GameObject ShopMeni;
    public GameObject SettingMeni;
    public GUIKlasa GUIClass;
    [Header("Kupovina Audio SRC")]
    public AudioSource Kupih_AudioSource;
    [Header("Kutija")]
    public Image Kutija;
    public float TimeSave = 1;
    [Header("Shop UI")]
    public GameObject Shop_Auto_GameObject;
    public GameObject Shop_Manual_GameObject;
    public GameObject Shop_Skins_GameObject;
    [Header("IdleArert")]
    public GameObject IdleWindow;
    public Text IdleWindow_Text;
   
    [Header("Settings")]
    public Text TotalClicks_Text;
    public Text TotalBoxesSoFar_Text;
    [Header("PozicijaEndZaPopUpText")]
    public GameObject EndPointPopUpText;
    public static GameObject EndPointPopUpText_Static;

    [System.Serializable]
    public class GUIKlasa
    {
        public List<Speciifkacija_KlikElemenata> Klik_Elemenat_Lista;
        public List<Speciifkacija_IdleElemenata> Idle_Elemenat_Lista;
        public List<Speciifkacija_SkinsElemenata> Skins_Elemenat_Lista;

        [System.Serializable]
        public class Speciifkacija_KlikElemenata
        {
            public GameObject Dugme;
            [Header("DodajaPoKliku")]
            public int DodajPoKliku;
            [Header("Text")]
            public Text Price;
            public Text QTY;
            [Header("Nivo")]
            public float Nivo;
            public double Cena;
            public float koeficijent;
        }

        [System.Serializable]
        public class Speciifkacija_IdleElemenata
        {
            public GameObject Dugme;
            [Header("DodajaPoKliku")]
            public double DodajPoKliku;
            [Header("Text")]
            public Text Price;
            public Text QTY;
            [Header("Nivo")]
            public float Nivo;
            public double Cena;
            public float koeficijent;
        }
        [System.Serializable]
        public class Speciifkacija_SkinsElemenata
        {
            public GameObject Dugme;
            public Sprite Slike;
            public bool kupljen;
            public bool Izabran;
            [Header("Text")]
            public Text Price;
            [Header("Cena")]
            public double Cena;
        }
    }

    double PareteIDle;
    public void Ugasi()
    {
        LeanTween.scaleX(IdleWindow, 0, 0.12f);
        LeanTween.scaleY(IdleWindow, 0, 0.12f);
    }
    private void Start()
    {
        Application.targetFrameRate = 300;

        EndPointPopUpText_Static = EndPointPopUpText;

        IdleWindow.transform.localScale = new Vector3(0, 0, 1);
        PrviSaveLoad = PlayerPrefs.GetInt("PrviSave");
        if (PrviSaveLoad > 0)
        {
            LoadPodaci();
        }
        else
        {
            SavePodaci();
        }

        if (PlayerPrefs.GetInt("UpaliInt") > 0)
        {
            if (PlayerPrefs.GetString("VremeIzlaska") != "")
            {

                string VremeIzlaskaY = PlayerPrefs.GetString("VremeIzlaska");
                string VremeUlaskaY = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).ToString();
                VremeUlaska = DateTime.Parse(VremeUlaskaY);

                VremeIzlaska = DateTime.Parse(VremeIzlaskaY);

                double OnIdle_ADD_sekundPROB = 0;
                foreach (GUIKlasa.Speciifkacija_IdleElemenata objekat in GUIClass.Idle_Elemenat_Lista)
                {
                    OnIdle_ADD_sekundPROB += objekat.DodajPoKliku * objekat.Nivo;
                }

                double Broj = (double)(VremeUlaska - VremeIzlaska).TotalSeconds * OnIdle_ADD_sekundPROB;
                if (Broj > 0)
                {
                    LeanTween.scaleX(IdleWindow, 1, 0.12f);
                    LeanTween.scaleY(IdleWindow, 1, 0.12f);
                }

                BrojKutija += Broj;

                IdleWindow_Text.text = DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(Broj)+""/*Broj.ToString()*/;
                PareteIDle = Broj;
            }
        }

        CanvasSalji = Canvas;

        ShopMeni.transform.localScale = new Vector3(0, 0, 1);
        SettingMeni.transform.localScale = new Vector3(0, 0, 1);

        Shop_Manual();

        PrviSave++;
    }

    public void UzmiIdlePare()
    {
        BrojKutija += PareteIDle;
        PareteIDle = 0;
        Ugasi();
    }
    public void AddBox()
    {
        BrojKutija+=OnClick_ADD;
        BrojKutija_Text.text = BrojKutija.ToString();
        TotalBoxesSoFar += OnClick_ADD;

        LeanTween.scaleX(Kutija.gameObject, 2.4f, 0.12f);
        LeanTween.scaleY(Kutija.gameObject, 2.4f, 0.12f);

        GameObject StvorenObjekat=Instantiate(PopUPText, Canvas);
        
        StvorenObjekat.transform.SetParent(IzaTekstObjekat.transform);

        Klikovi++;
        Kutija.GetComponent<AudioSource>().Play();
    }
    public void DrmniKutiju()
    {
        LeanTween.scaleX(Kutija.gameObject, 2.4f, 0.12f);
        LeanTween.scaleY(Kutija.gameObject, 2.4f, 0.12f);
        Kutija.GetComponent<AudioSource>().Play();
    }
    private void Update()
    {
        TotalClicks_Text.text = "TOTAL CLICKS: " + Environment.NewLine + Environment.NewLine +
            DanielRaubal.ManipulacijaPara.VrtniPareteMi(Klikovi);

        TotalBoxesSoFar_Text.text = "TOTAL BOXES SO FAR: " + Environment.NewLine + Environment.NewLine +
            DanielRaubal.ManipulacijaPara.VrtniPareteMi(TotalBoxesSoFar);

        if (OnIdle_ADD_sekund > 0)
        {
            PlayerPrefs.SetInt("UpaliInt", 1);
        }

        BrojKutija_Text.text = DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(BrojKutija);

        if (Kutija.transform.localScale == new Vector3(2.4f, 2.4f, 1))
        {

            LeanTween.scaleX(Kutija.gameObject, 2, 0.12f);
            LeanTween.scaleY(Kutija.gameObject, 2, 0.12f);
        }

        if (TimeSave > 0)
        {
            TimeSave -= Time.deltaTime;
        }
        else
        {
            SavePodaci();
            TimeSave = 1;
        }
        
        if(OnIdle_ADD_sekund > 0)
        {
            if (VremeIdle > 0)
            {
                VremeIdle -= Time.deltaTime;
            }
            else
            {
                DrmniKutiju();
                BrojKutija += OnIdle_ADD_sekund;

                TotalBoxesSoFar += OnIdle_ADD_sekund;

                VremeIdle = 1;
            }
        }

        PoSekundi_Text.text = DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(OnIdle_ADD_sekund) + "/s";

        OnClick_ADD = 0;

        foreach (GUIKlasa.Speciifkacija_KlikElemenata objekat in GUIClass.Klik_Elemenat_Lista)
        {
            if (BrojKutija > objekat.Cena)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
            }
            else
            {
                objekat.Dugme.GetComponent<Image>().color = Color.red;
            }
            objekat.Price.text = "Price: " + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(objekat.Cena);
            objekat.QTY.text = "QTY: "+objekat.Nivo;
            OnClick_ADD += objekat.DodajPoKliku * objekat.Nivo;
        }
        if(OnClick_ADD == 0)
        {
            OnClick_ADD = 1;
        }

        OnIdle_ADD_sekund = 0;
        foreach (GUIKlasa.Speciifkacija_IdleElemenata objekat in GUIClass.Idle_Elemenat_Lista)
        {
            if (BrojKutija > objekat.Cena)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
            }
            else
            {
                objekat.Dugme.GetComponent<Image>().color = Color.red;
            }

            objekat.Price.text = "Price: " + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(objekat.Cena);
            objekat.QTY.text = "QTY: " + objekat.Nivo;
            OnIdle_ADD_sekund += objekat.DodajPoKliku * objekat.Nivo;
        }

        foreach (GUIKlasa.Speciifkacija_SkinsElemenata objekat in GUIClass.Skins_Elemenat_Lista)
        {
            if(objekat.Izabran)
            {
                objekat.Dugme.GetComponent<Image>().color = new Color32(255, 117, 52,255);
                objekat.Dugme.GetComponentInChildren<Text>().text = "USE";
                Kutija.sprite = objekat.Slike;
            }
            else if(objekat.kupljen)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
                objekat.Dugme.GetComponentInChildren<Text>().text = "USE";
            }
            else if (BrojKutija > objekat.Cena)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
                objekat.Dugme.GetComponentInChildren<Text>().text = "BUY";
            }
            else
            {
                objekat.Dugme.GetComponent<Image>().color = Color.red;
                objekat.Dugme.GetComponentInChildren<Text>().text = "BUY";
            }
            objekat.Price.text = "Price: " + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(objekat.Cena);
        }
    }
  
    int PrviSave;
    int PrviSaveLoad;

    double Klikovi;
    double TotalBoxesSoFar;

    void SavePodaci()
    {
        PlayerPrefs.SetString("BrojKutija", BrojKutija.ToString());
        PlayerPrefs.SetInt("PrviSave", 1);

        for (int i = 0; i < GUIClass.Idle_Elemenat_Lista.Count; i++)
        {
            PlayerPrefs.SetString("Idle"+ i, GUIClass.Idle_Elemenat_Lista[i].Nivo.ToString());
        }
        for (int i = 0; i < GUIClass.Klik_Elemenat_Lista.Count; i++)
        {
            PlayerPrefs.SetString("Klik" + i, GUIClass.Klik_Elemenat_Lista[i].Nivo.ToString());
        }
        for (int i = 0; i < GUIClass.Skins_Elemenat_Lista.Count; i++)
        {
            int KupljenIliNe=0;
            string koristi = "";
            if(GUIClass.Skins_Elemenat_Lista[i].kupljen == true)
            {
                KupljenIliNe = 1;
            }
            if (GUIClass.Skins_Elemenat_Lista[i].Izabran == true)
            {
                koristi = "KORISTI";
            }

            PlayerPrefs.SetString("Skins" + i, KupljenIliNe.ToString());
            PlayerPrefs.SetString("SkinsKoristi" + i, koristi);
        }

        VremeIzlaska = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));

        PlayerPrefs.SetString("VremeIzlaska", VremeIzlaska.ToString());

        PlayerPrefs.SetString("Klikovi", Klikovi.ToString());
        PlayerPrefs.SetString("TotalBoxesSoFar", TotalBoxesSoFar.ToString());
    }
    public void ResetData()
    {
        foreach (GUIKlasa.Speciifkacija_IdleElemenata objekat in GUIClass.Idle_Elemenat_Lista)
        {
            objekat.Nivo = 0;
        }
        foreach (GUIKlasa.Speciifkacija_KlikElemenata objekat in GUIClass.Klik_Elemenat_Lista)
        {
            objekat.Nivo = 0;
        }
        foreach (GUIKlasa.Speciifkacija_SkinsElemenata objekat in GUIClass.Skins_Elemenat_Lista)
        {
            objekat.kupljen = false;
            objekat.Izabran = false;
        }

        GUIClass.Skins_Elemenat_Lista[0].kupljen = true;
        GUIClass.Skins_Elemenat_Lista[0].Izabran = true;

        for (int i = 0; i < GUIClass.Skins_Elemenat_Lista.Count; i++)
        {
            int KupljenIliNe = 0;
            PlayerPrefs.SetString("Skins" + i, KupljenIliNe.ToString());
            PlayerPrefs.SetString("SkinsKoristi" + i, "");
        }
        BrojKutija = 0;
        TotalBoxesSoFar = 0;
        Klikovi = 0;

        PlayerPrefs.SetString("BrojKutija", "0");
        PlayerPrefs.SetInt("PrviSave", 0);
      
        Application.Quit();
    }
    void LoadPodaci()
    {
        BrojKutija = Convert.ToDouble(PlayerPrefs.GetString("BrojKutija"));

        for (int i = 0; i < GUIClass.Klik_Elemenat_Lista.Count; i++)
        {
            GUIClass.Klik_Elemenat_Lista[i].Nivo = Int32.Parse(PlayerPrefs.GetString("Klik" + i));
            float nivo = GUIClass.Klik_Elemenat_Lista[i].Nivo;

            if (nivo <= 0)
            {
                nivo = 1;
            }
            GUIClass.Klik_Elemenat_Lista[i].Cena
                    = Math.Round(nivo * GUIClass.Klik_Elemenat_Lista[i].Cena * GUIClass.Klik_Elemenat_Lista[i].koeficijent);
        }

        for (int i = 0; i < GUIClass.Idle_Elemenat_Lista.Count; i++)
        {
            GUIClass.Idle_Elemenat_Lista[i].Nivo = Int32.Parse(PlayerPrefs.GetString("Idle" + i));
            float nivo = GUIClass.Idle_Elemenat_Lista[i].Nivo;

            if (nivo <= 0)
            {
                nivo = 1;
            }
            GUIClass.Idle_Elemenat_Lista[i].Cena
                    = Math.Round(nivo * GUIClass.Idle_Elemenat_Lista[i].Cena * GUIClass.Idle_Elemenat_Lista[i].koeficijent);
        }

        for (int i = 0; i < GUIClass.Skins_Elemenat_Lista.Count; i++)
        {
            bool kupjenIliNe = false;
            if (Int32.Parse(PlayerPrefs.GetString("Skins" + i)) == 1)
            {
                kupjenIliNe = true;
            } 
            if (PlayerPrefs.GetString("SkinsKoristi" + i).Contains("KORISTI"))
            {
                GUIClass.Skins_Elemenat_Lista[i].Izabran = true;
            }
            GUIClass.Skins_Elemenat_Lista[i].kupljen = kupjenIliNe;
        }

        TotalBoxesSoFar = Convert.ToDouble(PlayerPrefs.GetString("TotalBoxesSoFar"));

        Klikovi = Convert.ToDouble(PlayerPrefs.GetString("Klikovi"));
    }

    #region Shop
    public void Buy_manual(int BrojUListi)
    {
        if (BrojKutija > GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena)
        {
            Kupih_AudioSource.Play();

            BrojKutija -= GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena;
            
            GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena =
                Math.Round(GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena * GUIClass.Klik_Elemenat_Lista[BrojUListi].koeficijent);
            
            OnClick_ADD -= GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo++;

            OnClick_ADD += GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Klik_Elemenat_Lista[BrojUListi].QTY.text = "QTY: " + GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo.ToString();
            GUIClass.Klik_Elemenat_Lista[BrojUListi].Price.text = "Price: " + GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena.ToString();
        }
    }
    public void Buy_Skins(int BrojUListi)
    {
        if(GUIClass.Skins_Elemenat_Lista[BrojUListi].kupljen)
        {
            Kutija.sprite = GUIClass.Skins_Elemenat_Lista[BrojUListi].Slike;
            foreach (GUIKlasa.Speciifkacija_SkinsElemenata item in GUIClass.Skins_Elemenat_Lista)
            {
                item.Izabran = false;
            }
            GUIClass.Skins_Elemenat_Lista[BrojUListi].Izabran = true;
        }
        else if (BrojKutija > GUIClass.Skins_Elemenat_Lista[BrojUListi].Cena)
        {
            Kupih_AudioSource.Play();

            BrojKutija -= GUIClass.Skins_Elemenat_Lista[BrojUListi].Cena;
            foreach (GUIKlasa.Speciifkacija_SkinsElemenata item in GUIClass.Skins_Elemenat_Lista)
            {
                item.Izabran = false;
            }
            GUIClass.Skins_Elemenat_Lista[BrojUListi].Izabran = true;

            GUIClass.Skins_Elemenat_Lista[BrojUListi].kupljen = true;
        }
    }
    public void Buy_Idle(int BrojUListi)
    {
        if (BrojKutija > GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena)
        {
            Kupih_AudioSource.Play();

            BrojKutija -= GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena;
            GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena =
                Math.Round(GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena * GUIClass.Idle_Elemenat_Lista[BrojUListi].koeficijent);

            OnClick_ADD -= GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo++;

            OnClick_ADD += GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Idle_Elemenat_Lista[BrojUListi].QTY.text = "QTY: " + GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo.ToString();
            GUIClass.Idle_Elemenat_Lista[BrojUListi].Price.text = "Price: " + GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena.ToString();
        }
    }
    #endregion
    void Shop_Ugasi()
    {
        Shop_Manual_GameObject.SetActive(false);
        Shop_Auto_GameObject.SetActive(false);
        Shop_Skins_GameObject.SetActive(false);
    }
    public void Shop_Auto()
    {
        Shop_Ugasi();
        Shop_Auto_GameObject.SetActive(true);
    }
    public void Shop_Manual()
    {
        Shop_Ugasi();
        Shop_Manual_GameObject.SetActive(true);
    }
    public void Shop_Skin()
    {
        Shop_Ugasi();
        Shop_Skins_GameObject.SetActive(true);
    }
    public void Meni_Shop()
    {
        if(ShopMeni.transform.localScale.x == 0)
        {
            LeanTween.scaleX(ShopMeni, 1, Brzina_Animacije);
            LeanTween.scaleY(ShopMeni, 1, Brzina_Animacije);
        }
        else if(ShopMeni.transform.localScale.x == 1)
        {
            LeanTween.scaleX(ShopMeni, 0, Brzina_Animacije);
            LeanTween.scaleY(ShopMeni, 0, Brzina_Animacije);
        }
    }

    public void Meni_Nazad()
    {
        LeanTween.scaleX(ShopMeni, 0, Brzina_Animacije);
        LeanTween.scaleY(ShopMeni, 0, Brzina_Animacije);

        LeanTween.scaleX(SettingMeni, 0, Brzina_Animacije);
        LeanTween.scaleY(SettingMeni, 0, Brzina_Animacije);
    }

    public void Meni_Setting()
    {
        if (SettingMeni.transform.localScale.x == 0)
        {
            LeanTween.scaleX(SettingMeni, 1, Brzina_Animacije);
            LeanTween.scaleY(SettingMeni, 1, Brzina_Animacije);
        }
        else if (SettingMeni.transform.localScale.x == 1)
        {
            LeanTween.scaleX(SettingMeni, 0, Brzina_Animacije);
            LeanTween.scaleY(SettingMeni, 0, Brzina_Animacije);
        }
    }
    public DateTime VremeIzlaska;
    public DateTime VremeUlaska;
    private void OnApplicationQuit()
    {
        SavePodaci();
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Text.RegularExpressions;

using System.Globalization;
using DanielRaubal;

public class Main : MonoBehaviour
{
    public GameObject IzaTekstObjekat;
    public RectTransform Canvas;
    public static RectTransform CanvasSalji;
    public GameObject PopUPText;
    public float Brzina_Animacije;
    public double BrojKutija;
    public int Parete_BrojKutija;
    public Text BrojKutija_Text;
    public Text PoSekundi_Text;
    [Header("KolkoSta")]
    public static float OnClick_ADD = 1;
    public double OnIdle_ADD_sekund;
    public float VremeIdle = 1;
    [Header("GUI")]
    public GameObject ShopMeni;
    public GameObject SettingMeni;
    public GUIKlasa GUIClass;
    [Header("Kupovina Audio SRC")]
    public AudioSource Kupih_AudioSource;
    [Header("Kutija")]
    public Image Kutija;
    public float TimeSave = 1;
    [Header("Shop UI")]
    public GameObject Shop_Auto_GameObject;
    public GameObject Shop_Manual_GameObject;
    public GameObject Shop_Skins_GameObject;
    [Header("IdleArert")]
    public GameObject IdleWindow;
    public Text IdleWindow_Text;
   
    [Header("Settings")]
    public Text TotalClicks_Text;
    public Text TotalBoxesSoFar_Text;
    [Header("PozicijaEndZaPopUpText")]
    public GameObject EndPointPopUpText;
    public static GameObject EndPointPopUpText_Static;

    [System.Serializable]
    public class GUIKlasa
    {
        public List<Speciifkacija_KlikElemenata> Klik_Elemenat_Lista;
        public List<Speciifkacija_IdleElemenata> Idle_Elemenat_Lista;
        public List<Speciifkacija_SkinsElemenata> Skins_Elemenat_Lista;

        [System.Serializable]
        public class Speciifkacija_KlikElemenata
        {
            public GameObject Dugme;
            [Header("DodajaPoKliku")]
            public int DodajPoKliku;
            [Header("Text")]
            public Text Price;
            public Text QTY;
            [Header("Nivo")]
            public float Nivo;
            public double Cena;
            public float koeficijent;
        }

        [System.Serializable]
        public class Speciifkacija_IdleElemenata
        {
            public GameObject Dugme;
            [Header("DodajaPoKliku")]
            public double DodajPoKliku;
            [Header("Text")]
            public Text Price;
            public Text QTY;
            [Header("Nivo")]
            public float Nivo;
            public double Cena;
            public float koeficijent;
        }
        [System.Serializable]
        public class Speciifkacija_SkinsElemenata
        {
            public GameObject Dugme;
            public Sprite Slike;
            public bool kupljen;
            public bool Izabran;
            [Header("Text")]
            public Text Price;
            [Header("Cena")]
            public double Cena;
        }
    }

    double PareteIDle;
    public void Ugasi()
    {
        LeanTween.scaleX(IdleWindow, 0, 0.12f);
        LeanTween.scaleY(IdleWindow, 0, 0.12f);
    }
    private void Start()
    {
        Application.targetFrameRate = 300;

        EndPointPopUpText_Static = EndPointPopUpText;

        IdleWindow.transform.localScale = new Vector3(0, 0, 1);
        PrviSaveLoad = PlayerPrefs.GetInt("PrviSave");
        if (PrviSaveLoad > 0)
        {
            LoadPodaci();
        }
        else
        {
            SavePodaci();
        }

        if (PlayerPrefs.GetInt("UpaliInt") > 0)
        {
            if (PlayerPrefs.GetString("VremeIzlaska") != "")
            {

                string VremeIzlaskaY = PlayerPrefs.GetString("VremeIzlaska");
                string VremeUlaskaY = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")).ToString();
                VremeUlaska = DateTime.Parse(VremeUlaskaY);

                VremeIzlaska = DateTime.Parse(VremeIzlaskaY);

                double OnIdle_ADD_sekundPROB = 0;
                foreach (GUIKlasa.Speciifkacija_IdleElemenata objekat in GUIClass.Idle_Elemenat_Lista)
                {
                    OnIdle_ADD_sekundPROB += objekat.DodajPoKliku * objekat.Nivo;
                }

                double Broj = (double)(VremeUlaska - VremeIzlaska).TotalSeconds * OnIdle_ADD_sekundPROB;
                if (Broj > 0)
                {
                    LeanTween.scaleX(IdleWindow, 1, 0.12f);
                    LeanTween.scaleY(IdleWindow, 1, 0.12f);
                }

                BrojKutija += Broj;

                IdleWindow_Text.text = DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(Broj)+""/*Broj.ToString()*/;
                PareteIDle = Broj;
            }
        }

        CanvasSalji = Canvas;

        ShopMeni.transform.localScale = new Vector3(0, 0, 1);
        SettingMeni.transform.localScale = new Vector3(0, 0, 1);

        Shop_Manual();

        PrviSave++;
    }

    public void UzmiIdlePare()
    {
        BrojKutija += PareteIDle;
        PareteIDle = 0;
        Ugasi();
    }
    public void AddBox()
    {
        BrojKutija+=OnClick_ADD;
        BrojKutija_Text.text = BrojKutija.ToString();
        TotalBoxesSoFar += OnClick_ADD;

        LeanTween.scaleX(Kutija.gameObject, 2.4f, 0.12f);
        LeanTween.scaleY(Kutija.gameObject, 2.4f, 0.12f);

        GameObject StvorenObjekat=Instantiate(PopUPText, Canvas);
        
        StvorenObjekat.transform.SetParent(IzaTekstObjekat.transform);

        Klikovi++;
        Kutija.GetComponent<AudioSource>().Play();
    }
    public void DrmniKutiju()
    {
        LeanTween.scaleX(Kutija.gameObject, 2.4f, 0.12f);
        LeanTween.scaleY(Kutija.gameObject, 2.4f, 0.12f);
        Kutija.GetComponent<AudioSource>().Play();
    }
    private void Update()
    {
        TotalClicks_Text.text = "TOTAL CLICKS: " + Environment.NewLine + Environment.NewLine +
            DanielRaubal.ManipulacijaPara.VrtniPareteMi(Klikovi);

        TotalBoxesSoFar_Text.text = "TOTAL BOXES SO FAR: " + Environment.NewLine + Environment.NewLine +
            DanielRaubal.ManipulacijaPara.VrtniPareteMi(TotalBoxesSoFar);

        if (OnIdle_ADD_sekund > 0)
        {
            PlayerPrefs.SetInt("UpaliInt", 1);
        }

        BrojKutija_Text.text = DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(BrojKutija);

        if (Kutija.transform.localScale == new Vector3(2.4f, 2.4f, 1))
        {

            LeanTween.scaleX(Kutija.gameObject, 2, 0.12f);
            LeanTween.scaleY(Kutija.gameObject, 2, 0.12f);
        }

        if (TimeSave > 0)
        {
            TimeSave -= Time.deltaTime;
        }
        else
        {
            SavePodaci();
            TimeSave = 1;
        }
        
        if(OnIdle_ADD_sekund > 0)
        {
            if (VremeIdle > 0)
            {
                VremeIdle -= Time.deltaTime;
            }
            else
            {
                DrmniKutiju();
                BrojKutija += OnIdle_ADD_sekund;

                TotalBoxesSoFar += OnIdle_ADD_sekund;

                VremeIdle = 1;
            }
        }

        PoSekundi_Text.text = DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(OnIdle_ADD_sekund) + "/s";

        OnClick_ADD = 0;

        foreach (GUIKlasa.Speciifkacija_KlikElemenata objekat in GUIClass.Klik_Elemenat_Lista)
        {
            if (BrojKutija > objekat.Cena)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
            }
            else
            {
                objekat.Dugme.GetComponent<Image>().color = Color.red;
            }
            objekat.Price.text = "Price: " + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(objekat.Cena);
            objekat.QTY.text = "QTY: "+objekat.Nivo;
            OnClick_ADD += objekat.DodajPoKliku * objekat.Nivo;
        }
        if(OnClick_ADD == 0)
        {
            OnClick_ADD = 1;
        }

        OnIdle_ADD_sekund = 0;
        foreach (GUIKlasa.Speciifkacija_IdleElemenata objekat in GUIClass.Idle_Elemenat_Lista)
        {
            if (BrojKutija > objekat.Cena)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
            }
            else
            {
                objekat.Dugme.GetComponent<Image>().color = Color.red;
            }

            objekat.Price.text = "Price: " + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(objekat.Cena);
            objekat.QTY.text = "QTY: " + objekat.Nivo;
            OnIdle_ADD_sekund += objekat.DodajPoKliku * objekat.Nivo;
        }

        foreach (GUIKlasa.Speciifkacija_SkinsElemenata objekat in GUIClass.Skins_Elemenat_Lista)
        {
            if(objekat.Izabran)
            {
                objekat.Dugme.GetComponent<Image>().color = new Color32(255, 117, 52,255);
                objekat.Dugme.GetComponentInChildren<Text>().text = "USE";
                Kutija.sprite = objekat.Slike;
            }
            else if(objekat.kupljen)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
                objekat.Dugme.GetComponentInChildren<Text>().text = "USE";
            }
            else if (BrojKutija > objekat.Cena)
            {
                objekat.Dugme.GetComponent<Image>().color = Color.green;
                objekat.Dugme.GetComponentInChildren<Text>().text = "BUY";
            }
            else
            {
                objekat.Dugme.GetComponent<Image>().color = Color.red;
                objekat.Dugme.GetComponentInChildren<Text>().text = "BUY";
            }
            objekat.Price.text = "Price: " + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(objekat.Cena);
        }
    }
  
    int PrviSave;
    int PrviSaveLoad;

    double Klikovi;
    double TotalBoxesSoFar;

    void SavePodaci()
    {
        PlayerPrefs.SetString("BrojKutija", BrojKutija.ToString());
        PlayerPrefs.SetInt("PrviSave", 1);

        for (int i = 0; i < GUIClass.Idle_Elemenat_Lista.Count; i++)
        {
            PlayerPrefs.SetString("Idle"+ i, GUIClass.Idle_Elemenat_Lista[i].Nivo.ToString());
        }
        for (int i = 0; i < GUIClass.Klik_Elemenat_Lista.Count; i++)
        {
            PlayerPrefs.SetString("Klik" + i, GUIClass.Klik_Elemenat_Lista[i].Nivo.ToString());
        }
        for (int i = 0; i < GUIClass.Skins_Elemenat_Lista.Count; i++)
        {
            int KupljenIliNe=0;
            string koristi = "";
            if(GUIClass.Skins_Elemenat_Lista[i].kupljen == true)
            {
                KupljenIliNe = 1;
            }
            if (GUIClass.Skins_Elemenat_Lista[i].Izabran == true)
            {
                koristi = "KORISTI";
            }

            PlayerPrefs.SetString("Skins" + i, KupljenIliNe.ToString());
            PlayerPrefs.SetString("SkinsKoristi" + i, koristi);
        }

        VremeIzlaska = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss"));

        PlayerPrefs.SetString("VremeIzlaska", VremeIzlaska.ToString());

        PlayerPrefs.SetString("Klikovi", Klikovi.ToString());
        PlayerPrefs.SetString("TotalBoxesSoFar", TotalBoxesSoFar.ToString());
    }
    public void ResetData()
    {
        foreach (GUIKlasa.Speciifkacija_IdleElemenata objekat in GUIClass.Idle_Elemenat_Lista)
        {
            objekat.Nivo = 0;
        }
        foreach (GUIKlasa.Speciifkacija_KlikElemenata objekat in GUIClass.Klik_Elemenat_Lista)
        {
            objekat.Nivo = 0;
        }
        foreach (GUIKlasa.Speciifkacija_SkinsElemenata objekat in GUIClass.Skins_Elemenat_Lista)
        {
            objekat.kupljen = false;
            objekat.Izabran = false;
        }

        GUIClass.Skins_Elemenat_Lista[0].kupljen = true;
        GUIClass.Skins_Elemenat_Lista[0].Izabran = true;

        for (int i = 0; i < GUIClass.Skins_Elemenat_Lista.Count; i++)
        {
            int KupljenIliNe = 0;
            PlayerPrefs.SetString("Skins" + i, KupljenIliNe.ToString());
            PlayerPrefs.SetString("SkinsKoristi" + i, "");
        }
        BrojKutija = 0;
        TotalBoxesSoFar = 0;
        Klikovi = 0;

        PlayerPrefs.SetString("BrojKutija", "0");
        PlayerPrefs.SetInt("PrviSave", 0);
      
        Application.Quit();
    }
    void LoadPodaci()
    {
        BrojKutija = Convert.ToDouble(PlayerPrefs.GetString("BrojKutija"));

        for (int i = 0; i < GUIClass.Klik_Elemenat_Lista.Count; i++)
        {
            GUIClass.Klik_Elemenat_Lista[i].Nivo = Int32.Parse(PlayerPrefs.GetString("Klik" + i));
            float nivo = GUIClass.Klik_Elemenat_Lista[i].Nivo;

            if (nivo <= 0)
            {
                nivo = 1;
            }
            GUIClass.Klik_Elemenat_Lista[i].Cena
                    = Math.Round(nivo * GUIClass.Klik_Elemenat_Lista[i].Cena * GUIClass.Klik_Elemenat_Lista[i].koeficijent);
        }

        for (int i = 0; i < GUIClass.Idle_Elemenat_Lista.Count; i++)
        {
            GUIClass.Idle_Elemenat_Lista[i].Nivo = Int32.Parse(PlayerPrefs.GetString("Idle" + i));
            float nivo = GUIClass.Idle_Elemenat_Lista[i].Nivo;

            if (nivo <= 0)
            {
                nivo = 1;
            }
            GUIClass.Idle_Elemenat_Lista[i].Cena
                    = Math.Round(nivo * GUIClass.Idle_Elemenat_Lista[i].Cena * GUIClass.Idle_Elemenat_Lista[i].koeficijent);
        }

        for (int i = 0; i < GUIClass.Skins_Elemenat_Lista.Count; i++)
        {
            bool kupjenIliNe = false;
            if (Int32.Parse(PlayerPrefs.GetString("Skins" + i)) == 1)
            {
                kupjenIliNe = true;
            } 
            if (PlayerPrefs.GetString("SkinsKoristi" + i).Contains("KORISTI"))
            {
                GUIClass.Skins_Elemenat_Lista[i].Izabran = true;
            }
            GUIClass.Skins_Elemenat_Lista[i].kupljen = kupjenIliNe;
        }

        TotalBoxesSoFar = Convert.ToDouble(PlayerPrefs.GetString("TotalBoxesSoFar"));

        Klikovi = Convert.ToDouble(PlayerPrefs.GetString("Klikovi"));
    }

    #region Shop
    public void Buy_manual(int BrojUListi)
    {
        if (BrojKutija > GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena)
        {
            Kupih_AudioSource.Play();

            BrojKutija -= GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena;
            
            GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena =
                Math.Round(GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena * GUIClass.Klik_Elemenat_Lista[BrojUListi].koeficijent);
            
            OnClick_ADD -= GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo++;

            OnClick_ADD += GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Klik_Elemenat_Lista[BrojUListi].QTY.text = "QTY: " + GUIClass.Klik_Elemenat_Lista[BrojUListi].Nivo.ToString();
            GUIClass.Klik_Elemenat_Lista[BrojUListi].Price.text = "Price: " + GUIClass.Klik_Elemenat_Lista[BrojUListi].Cena.ToString();
        }
    }
    public void Buy_Skins(int BrojUListi)
    {
        if(GUIClass.Skins_Elemenat_Lista[BrojUListi].kupljen)
        {
            Kutija.sprite = GUIClass.Skins_Elemenat_Lista[BrojUListi].Slike;
            foreach (GUIKlasa.Speciifkacija_SkinsElemenata item in GUIClass.Skins_Elemenat_Lista)
            {
                item.Izabran = false;
            }
            GUIClass.Skins_Elemenat_Lista[BrojUListi].Izabran = true;
        }
        else if (BrojKutija > GUIClass.Skins_Elemenat_Lista[BrojUListi].Cena)
        {
            Kupih_AudioSource.Play();

            BrojKutija -= GUIClass.Skins_Elemenat_Lista[BrojUListi].Cena;
            foreach (GUIKlasa.Speciifkacija_SkinsElemenata item in GUIClass.Skins_Elemenat_Lista)
            {
                item.Izabran = false;
            }
            GUIClass.Skins_Elemenat_Lista[BrojUListi].Izabran = true;

            GUIClass.Skins_Elemenat_Lista[BrojUListi].kupljen = true;
        }
    }
    public void Buy_Idle(int BrojUListi)
    {
        if (BrojKutija > GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena)
        {
            Kupih_AudioSource.Play();

            BrojKutija -= GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena;
            GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena =
                Math.Round(GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena * GUIClass.Idle_Elemenat_Lista[BrojUListi].koeficijent);

            OnClick_ADD -= GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo++;

            OnClick_ADD += GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo;

            GUIClass.Idle_Elemenat_Lista[BrojUListi].QTY.text = "QTY: " + GUIClass.Idle_Elemenat_Lista[BrojUListi].Nivo.ToString();
            GUIClass.Idle_Elemenat_Lista[BrojUListi].Price.text = "Price: " + GUIClass.Idle_Elemenat_Lista[BrojUListi].Cena.ToString();
        }
    }
    #endregion
    void Shop_Ugasi()
    {
        Shop_Manual_GameObject.SetActive(false);
        Shop_Auto_GameObject.SetActive(false);
        Shop_Skins_GameObject.SetActive(false);
    }
    public void Shop_Auto()
    {
        Shop_Ugasi();
        Shop_Auto_GameObject.SetActive(true);
    }
    public void Shop_Manual()
    {
        Shop_Ugasi();
        Shop_Manual_GameObject.SetActive(true);
    }
    public void Shop_Skin()
    {
        Shop_Ugasi();
        Shop_Skins_GameObject.SetActive(true);
    }
    public void Meni_Shop()
    {
        if(ShopMeni.transform.localScale.x == 0)
        {
            LeanTween.scaleX(ShopMeni, 1, Brzina_Animacije);
            LeanTween.scaleY(ShopMeni, 1, Brzina_Animacije);
        }
        else if(ShopMeni.transform.localScale.x == 1)
        {
            LeanTween.scaleX(ShopMeni, 0, Brzina_Animacije);
            LeanTween.scaleY(ShopMeni, 0, Brzina_Animacije);
        }
    }

    public void Meni_Nazad()
    {
        LeanTween.scaleX(ShopMeni, 0, Brzina_Animacije);
        LeanTween.scaleY(ShopMeni, 0, Brzina_Animacije);

        LeanTween.scaleX(SettingMeni, 0, Brzina_Animacije);
        LeanTween.scaleY(SettingMeni, 0, Brzina_Animacije);
    }

    public void Meni_Setting()
    {
        if (SettingMeni.transform.localScale.x == 0)
        {
            LeanTween.scaleX(SettingMeni, 1, Brzina_Animacije);
            LeanTween.scaleY(SettingMeni, 1, Brzina_Animacije);
        }
        else if (SettingMeni.transform.localScale.x == 1)
        {
            LeanTween.scaleX(SettingMeni, 0, Brzina_Animacije);
            LeanTween.scaleY(SettingMeni, 0, Brzina_Animacije);
        }
    }
    public DateTime VremeIzlaska;
    public DateTime VremeUlaska;
    private void OnApplicationQuit()
    {
        SavePodaci();
    }
}
>>>>>>> Stashed changes
