using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTextureWithoutAtlas : MonoBehaviour
{
     

    [SerializeField] List<GameObject> gameObjects = new List<GameObject>();
    private int index = 1;
    void Start()
    {
        foreach (var obj in gameObjects)
        {
            obj.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("Textures/" + index);
            index++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
