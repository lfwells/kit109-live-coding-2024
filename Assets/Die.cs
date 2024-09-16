using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Die : MonoBehaviour
{
    public Image blackOverlay;
    public Renderer playerRenderer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //reset things first
            playerRenderer.material.SetFloat("_t", 0);
            blackOverlay.fillAmount = 0;

            StartCoroutine(DieAnimation());
        }
    }

    IEnumerator DieAnimation()
    {
        //animate the spiral death first
        var t = 0f;
        while (t < 1)
        {
            t+= Time.deltaTime;
            playerRenderer.material.SetFloat("_t", t);

            yield return new WaitForEndOfFrame();
        }

        //animate the black overlay
        t = 0;
        while (t < 1)
        {
            t += Time.deltaTime;
            blackOverlay.fillAmount = t;

            yield return new WaitForEndOfFrame();
        }


    }
}
