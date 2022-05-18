using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Reaktion;
using UnityEngine.UI;

public class ButtonInjector : InjectorBase
{
    public Button button;
    void Start()
    {
        button.onClick.AddListener(Explosion);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Explosion()
    {
        dbLevel = -2.0f;
        StartCoroutine(turnoff());
    }

    public IEnumerator turnoff()
    {
        yield return new WaitForSeconds(2);
        dbLevel = -60;
    }
}
