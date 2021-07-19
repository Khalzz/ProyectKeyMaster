using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controllers : MonoBehaviour
{
    public GameObject D,Dpressed, F,Fpressed, Space, SpacePressed, J, Jpressed, K, Kpressed;
    public GameObject dFire, fFire, spaceFire, jFire, kFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("D"))
        {
            D.SetActive(false);
            Dpressed.SetActive(true);

            dFire.SetActive(false);

            Debug.Log("presionaste la D :o");
        }
        else if (Input.GetButtonUp("D"))
        {
            D.SetActive(true);
            Dpressed.SetActive(false);

            dFire.SetActive(false);

            Debug.Log("Soltaste la D :0");
        }

        if (Input.GetButtonDown("F"))
        {
            F.SetActive(false);
            Fpressed.SetActive(true);

            fFire.SetActive(false);

            Debug.Log("presionaste la F :o");
        }
        else if (Input.GetButtonUp("F"))
        {
            F.SetActive(true);
            Fpressed.SetActive(false);

            fFire.SetActive(false);

            Debug.Log("Soltaste la F :0");
        }

        if (Input.GetButtonDown("Space"))
        {
            Space.SetActive(false);
            SpacePressed.SetActive(true);

            spaceFire.SetActive(false);

            Debug.Log("presionaste la Space :o");
        }
        else if (Input.GetButtonUp("Space"))
        {
            Space.SetActive(true);
            SpacePressed.SetActive(false);

            spaceFire.SetActive(false);

            Debug.Log("Soltaste la Space :0");
        }

        if (Input.GetButtonDown("J"))
        {
            J.SetActive(false);
            Jpressed.SetActive(true);

            jFire.SetActive(false);

            Debug.Log("presionaste la J :o");
        }
        else if (Input.GetButtonUp("J"))
        {
            J.SetActive(true);
            Jpressed.SetActive(false);

            jFire.SetActive(false);

            Debug.Log("Soltaste la J :0");
        }

        if (Input.GetButtonDown("K"))
        {
            K.SetActive(false);
            Kpressed.SetActive(true);

            kFire.SetActive(false);

            Debug.Log("presionaste la K :o");
        }
        else if (Input.GetButtonUp("K"))
        {
            K.SetActive(true);
            Kpressed.SetActive(false);

            kFire.SetActive(false);

            Debug.Log("Soltaste la K :0");
        }

    }
}
