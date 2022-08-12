using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag : MonoBehaviour
{
    [SerializeField]
    private GameObject BagPrefab;

    [SerializeField]
    private Sprite[] images;

    // Start is called before the first frame update
    void Start()
    {
        var pnl = transform;
        for (int i = 0; i < 10; ++i)
        {
            for (int j = 0; j < 10; ++j)
            {
                var icon =  Instantiate(BagPrefab);
                icon.GetComponent<RectTransform>().localPosition = new Vector3(i * 120, j * 120, 0);
                icon.transform.parent = pnl;
                icon.transform.Find("IconImg").GetComponent<Image>().sprite = images[Random.Range(0, images.Length)];
                icon.GetComponent<Image>().sprite = images[Random.Range(0, images.Length)];
                //icon.transform.Find("IconNameTxt").GetComponent<Text>().text = string.Format("i: {0}, j : {1}", i, j);
                var txt = icon.transform.Find("IconNameTxt").gameObject;
                txt.SetActive(false);
                //icon.transform.Find("IconNameTxt").transform.Find("IconImg").GetComponent<Image>().sprite = images[Random.Range(0, images.Length)];

                //if (i < 2 || i >= 8 || j >= 5) icon.SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
