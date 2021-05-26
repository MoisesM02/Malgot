using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    public GameObject[] Characters;
    public static GameObject Player;
    public Vector2 minimum;
    public Vector2 maximum;
    public float delay;
    Vector2 velocity;

    void FixedUpdate(){
        
        if(Player != null){
        float posX = Mathf.SmoothDamp(transform.position.x, Player.transform.position.x, ref velocity.x, delay);
        float posY = Mathf.SmoothDamp(transform.position.y, Player.transform.position.y, ref velocity.x, delay);

        transform.position = new Vector3(Mathf.Clamp(posX, minimum.x, maximum.x), Mathf.Clamp(posY, minimum.y, maximum.y), transform.position.z);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        foreach(GameObject Character in Characters){
            if(Character.active ){
                Player = Character;
            }
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
