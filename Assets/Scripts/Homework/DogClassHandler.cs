using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RC3_HW2;

public class DogClassHandler : MonoBehaviour
{
    DogClass dog01, dog02, dog03;
    Doger dog01Doger;

    void Start()
    {
        dog01 = new DogClass("Dog01", 4.05f);
        dog02 = new DogClass("Dog02", 8.25f);
        dog03 = new DogClass("Dog03", 16.25f);
        dog01Doger = new Doger("Dor0d", 25.2f);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(dog01.GetName());
        dog01.habbit();
        dog01Doger.PurposeOfLife();
    }
}
