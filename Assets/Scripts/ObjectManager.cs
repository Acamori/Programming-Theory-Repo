using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ObjectManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> playerAnimal = new List<GameObject>();
    [SerializeField]
    private Transform startingPoint;

    // Start is called before the first frame update
    void Start()
    {

        //Instantiate(playerVehicle[1]).transform.position = startingPoint.position;
        Instantiate(playerAnimal[0], startingPoint.position, startingPoint.transform.rotation);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
