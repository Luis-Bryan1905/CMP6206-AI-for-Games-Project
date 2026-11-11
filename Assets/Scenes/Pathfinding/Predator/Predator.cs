using UnityEngine;

public class Predator : MonoBehaviour
{
    public GameObject Pathfinding;

    Grid grid;
    
    public  bool PreySpotted;
    public GameObject Prey;

    bool active;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FollowPath()
    {

    }

    public void SpotPrey()
    {
        PreySpotted = true;
        Debug.Log("PREY SPOTTED");
    }
}
