using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rec : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject REC;
    void Start()
    {
        flash();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator flash()
    {
        yield return new WaitForSeconds(1.5f);
        REC.SetActive(false);
        yield return new WaitForSeconds(1.5f);
        REC.SetActive(true);

    }
}
