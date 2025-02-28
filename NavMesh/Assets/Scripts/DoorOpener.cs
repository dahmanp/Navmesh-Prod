using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    bool open = false;
    public bool alt = false;

    void Start()
    {
        this.transform.Translate(0, -3, 0);
    }

    void Update()
    {
        if (Input.GetKeyDown("1") && alt)
        {
            if (open)
            {
                this.transform.Translate(0, -3, 0);
            } else
            {
                this.transform.Translate(0, 3, 0);
            }
            open = !open;
        }

        if (Input.GetKeyDown("2") && !alt)
        {
            if (open)
            {
                this.transform.Translate(0, -3, 0);
            }
            else
            {
                this.transform.Translate(0, 3, 0);
            }
            open = !open;
        }
    }
}
