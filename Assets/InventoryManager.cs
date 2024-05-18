using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager instance;
    public List<Image> slots = new List<Image>();
    public Item nextItem;

    void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if(nextItem != null)
            {
                for (int i = 0; i < slots.Count; i++)
                {
                    if(slots[i].sprite == null)
                    {
                        slots[i].sprite = nextItem.spi;
                        return;
                    }
                }
            }
        }
    }
}
