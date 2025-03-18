using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFeel : MonoBehaviour
{
    public static GameFeel instance;

    public float cameraShakeTime = 0f;

    void Awake()
    {
        if (instance) 
        {
            Destroy(this);
        }   
        else 
        {
            instance = this;
        }
    }
    // Start is called before the first frame update
   public static void AddCameraShake(float time) 
    {
        if (instance)
        {
            instance.cameraShakeTime = time;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraShakeTime > 0f) 
        {
            cameraShakeTime -= Time.deltaTime;
            Vector3 newCameraPosition = new Vector3();
            newCameraPosition.x = Random.RandomRange(-0.35f, 0.35f);
            newCameraPosition.y = Random.RandomRange(3.29f, 3.49f);
            newCameraPosition.z = -10;
            Camera.main.transform.position = newCameraPosition;
        }
    }
}
