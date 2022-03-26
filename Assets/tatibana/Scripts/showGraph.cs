using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showGraph : MonoBehaviour
{
    [SerializeField] private List<GameObject> points;
    // Start is called before the first frame update
    void Start()
    {
        graph();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void graph()
    {
        for (int i = 0; i < JkModel.getInfectionData().Count; i++)
        {
            if (i == 0)
            {
                points[i].transform.position = new Vector3(points[i].transform.position.x, points[i].transform.position.y, points[i].transform.position.z);

            }
            else if(i >= 1)
            {
                points[i].transform.position = new Vector3(points[i - 1].transform.position.x + 0.54f, points[i - 1].transform.position.y, points[i - 1].transform.position.z);
            }

            points[i].transform.localScale = new Vector3(points[i].transform.localScale.x, JkModel.getInfectionData()[i], points[i].transform.localScale.z);


        }
    }
}
