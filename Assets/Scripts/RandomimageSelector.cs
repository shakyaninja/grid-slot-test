using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RandomimageSelector : MonoBehaviour
{
    [SerializeField]private ImageLibrary library;
    [SerializeField] private GameObject GridItem;
    public GameObject gridPosition;
    public GameObject Level1Block;
    public GameObject Level2Block;
    public bool level1Done = false;

    // Start is called before the first frame update
    void Start()
    {
        //gridPosition.transform.position = Vector2.zero;
        //Init();
    }

    public void OnPressButton()
    {
        if (!level1Done)
        {
            Level1Block.SetActive(false);
            level1Done = true;
            //StartCoroutine("ActivateLevel1", 5f);
        }
        else
        {
            Level2Block.SetActive(false);
            StartCoroutine("ActivateLevel2", 2f);
        }
    }

    public IEnumerator ActivateLevel1(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Level1Block.SetActive(true);
    }

    public IEnumerator ActivateLevel2(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        Level2Block.SetActive(true);
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void Init()
    {
        for (int i = 0; i < 3; i++)
        {
            for ( int j = 0; j < 5; j++)
            {
                GameObject item = Instantiate(GridItem, gridPosition.transform.position, Quaternion.identity, transform);
                item.GetComponentInChildren<SpriteRenderer>().sprite = PickRandomImage();
                gridPosition.transform.position += new Vector3(20, 0, 0);
            }
            gridPosition.transform.position = new Vector3(0,gridPosition.transform.position.y,gridPosition.transform.position.z);
            gridPosition.transform.position += new Vector3(0,0,20);
        }
    }
    public Sprite PickRandomImage()
    {
        return library.images[Random.Range(0,library.images.Length)].image;
    }
}
