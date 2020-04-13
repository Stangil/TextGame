using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
   
    void Start()
    {
        textComponent.text = "You are a dog, and you wake up in the kitchen, do you: \n"+
            "Look in your bowl \n"+
            "Look for your owner";
    }

    void Update()
    {
        
    }
}
