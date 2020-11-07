using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{
    public GameObject cube;
    public int series = 5;
    public float spacing = 0.1f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    
    // Start is called before the first frame update
    void Start()
    {
        for(int i=0; i<series; i++)
        {
            Vector3 duplicate = new Vector3(1 ,i*spacing , 1);
            Quaternion rotation = Quaternion.identity;
            GameObject cubecopy = Instantiate(cube, duplicate, rotation);
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cubecopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
            cubeCopies.Add(cubecopy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for(int i=0; i<cubeCopies.Count; i++)
        {
            GameObject cubecopy = cubeCopies[i];
            Color cubeCopyColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            cubecopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
        }
    }
}
