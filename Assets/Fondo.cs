using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class Fondo : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject dragonBasico;

    [SerializeField] private Vector3 prefab0ffset;

    private GameObject dragon;

    private ARTrackedImageManager aRTrackedImageManager;


    public void OnEnable()
    {
        aRTrackedImageManager= gameObject.GetComponent<ARTrackedImageManager>();

        aRTrackedImageManager.trackedImagesChanged += OnImageChanged;

    }


    public void OnImageChanged(ARTrackedImagesChangedEventArgs obj)
    {
        foreach (ARTrackedImage image in obj.added)
        {
            dragon = Instantiate(dragonBasico, image.transform);

            dragon.transform.position += prefab0ffset;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
