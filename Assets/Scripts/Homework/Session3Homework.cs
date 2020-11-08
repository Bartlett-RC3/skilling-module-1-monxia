using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour
{
    public GameObject cube;
    public int series = 30;
    public float rotateDegree = 0.03f;
    public float spacing = 0.1f;
    private List<GameObject> cubeCopies = new List<GameObject>();
    private int frameCount = 0;
    
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
        if (Input.GetKey(KeyCode.Space))
        {

            for (int i = 0; i < cubeCopies.Count; i++)
            {
                GameObject cubecopy = cubeCopies[i];
                Vector3 rotateCopy = new Vector3(0, i * rotateDegree, 0);
                cubecopy.transform.Rotate(rotateCopy);
                Color cubeCopyColor = new Color(Random.Range(0.0f, 1.0f), 1.0f, 1.0f);
                cubecopy.GetComponent<MeshRenderer>().material.color = cubeCopyColor;
            }
        }

        if (Input.GetMouseButton(0))
        {
            foreach(GameObject cubeCopy in cubeCopies)
            {
                Color randomColor = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
                cubeCopy.GetComponent<MeshRenderer>().material.color = randomColor;
            }


        }

        
        //Debug.Log("Frames since game started: " + frameCount);
        //frameCount++;

        Debug.Log("Unity counted frames" + Time.frameCount);

        //Debug.Log("Unity draws a frame in: " + Time.deltaTime + "seconds");
       



    }
}
