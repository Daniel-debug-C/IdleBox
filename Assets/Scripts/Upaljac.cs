<<<<<<< Updated upstream
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upaljac : MonoBehaviour
{
    private void Update()
    {
        if (!GetComponent<Main>().enabled)
        {
            GetComponent<Main>().enabled = true;
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upaljac : MonoBehaviour
{
    private void Update()
    {
        if (!GetComponent<Main>().enabled)
        {
            GetComponent<Main>().enabled = true;
        }
    }
}
>>>>>>> Stashed changes
