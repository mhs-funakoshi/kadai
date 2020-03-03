using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OffButtonScript : MonoBehaviour
{
    Text text1;
    // Start is called before the first frame update
    void Start()
    {
        text1 = GameObject.Find("Text").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnClick()
    {
        text1.enabled = false;
    }
}
