using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class onclick : MonoBehaviour
{
    [SerializeField] GameController gc;
    [SerializeField] List<GameObject> objects;
    
    private void Start()
    {
        objects = new List<GameObject>();
    }

    public void ClickBox()
    {
        if (!objects.Contains(transform.gameObject)) objects.Add(transform.gameObject);
               
        for (int i = 0; i < transform.childCount; i++) transform.GetChild(i).gameObject.SetActive(true);

        transform.GetComponent<Button>().interactable = false;
        transform.GetComponent<BoxCollider2D>().enabled = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        addObj(collision.gameObject);
    }

    void addObj(GameObject obj)
    {
        if (obj.name.Contains("Cube"))
        {
            if (!objects.Contains(obj)) objects.Add(obj);
            ClearObj();
        }        
    }

    void ClearObj()
    {
        if (objects.Count >= 3)
        {
            foreach (var item in objects)
            {
                for (int i = 0; i < item.transform.childCount; i++) item.transform.GetChild(i).gameObject.SetActive(false);

                item.transform.GetComponent<Button>().interactable = true;
                item.transform.GetComponent<BoxCollider2D>().enabled = false;
            }
        }
        
    }

    private void Update()
    {
        if (transform.GetChild(0).transform.gameObject.activeSelf == false)
        {
            transform.GetComponent<onclick>().objects = new List<GameObject>();
        }
    }
}
