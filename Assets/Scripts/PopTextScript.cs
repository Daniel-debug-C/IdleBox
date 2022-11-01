<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using DanielRaubal;

public class PopTextScript : MonoBehaviour
{
    public float Brzina = 0.24f;
    public GameObject EndPoint;
    void Start()
    {
        EndPoint = Main.EndPointPopUpText_Static;

        GetComponent<Text>().text = "+" + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(Main.OnClick_ADD);

        LeanTween.colorText(gameObject.GetComponent<RectTransform>(), new Color(255,255,255,0), Brzina);

        LeanTween.moveLocalY(gameObject, EndPoint.transform.localPosition.y, Brzina).setDestroyOnComplete(true);
    }

}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using DanielRaubal;

public class PopTextScript : MonoBehaviour
{
    public float Brzina = 0.24f;
    public GameObject EndPoint;
    void Start()
    {
        EndPoint = Main.EndPointPopUpText_Static;

        GetComponent<Text>().text = "+" + DanielRaubal.ManipulacijaPara.VrtniPareteMi_Int(Main.OnClick_ADD);

        LeanTween.colorText(gameObject.GetComponent<RectTransform>(), new Color(255,255,255,0), Brzina);

        LeanTween.moveLocalY(gameObject, EndPoint.transform.localPosition.y, Brzina).setDestroyOnComplete(true);
    }

}
>>>>>>> Stashed changes
