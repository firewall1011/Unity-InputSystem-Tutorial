using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public void OnFire()
    {
        Debug.Log("PIU!");
    }

    public void OnFireCanceled()
    {
        Debug.Log("No piu");
    }

    public void OnChargedFire()
    {
        Debug.Log("PIIIIIUUUUUUUUUUUUUUUUUUUUU AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA!");
    }
}
