using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotItem : MonoBehaviour
{
    private bool Respawned = false;
    private Rigidbody2D _rb;
    private Vector2 _position;
    private SpriteRenderer _spriteRenderer;
    public GameObject bottomSprite;
    [SerializeField]private RandomimageSelector _randomimageSelector;

    public void Init()
    {
        _spriteRenderer.sprite = _randomimageSelector.PickRandomImage();
    }


    public void ResetCard()
    {
        //applying gravity scale at random range
        _rb.gravityScale = Random.Range(0.6f,0.8f);
        transform.position = _position; 
        Init();
    }


    // Start is called before the first frame update
    void Start()
    {
        _position = transform.position;
        _rb = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        Init();
    }

    private void OnBecameInvisible()
    {
        if (Respawned)
        {
            //out from screen into the pool
            ResetCard();
            Init();
        }
    }
}
