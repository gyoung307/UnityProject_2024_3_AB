using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    private int index;                               //�������� �� ���� �ҹ��ڷ� ����
    private string name;
    private ItemType type;
    private Sprite image;

    public int Index                                     //Index ������Ƽ
    {
        get { return index; }
        set { index = value; }
    }

    public string Name                                  //Name ������Ƽ
    {
        get { return name; }
        set { name = value; }
    }

    public ItemType Type                               //ItemType ������Ƽ
    {
        get { return type; }
        set { type = value; }
    }
    public Sprite Image
    {
        get { return image; }
        set { image = value; }
    }

    public Item(int index, string name, ItemType itemType) //�����ڷ� ������ �Է�
    {
        this.index = index;
        this.name = name;
        this.type = itemType;
    }
}

public enum ItemType
{
    Weapon,
    Armor,
    Potion,
    QuestItem
    //�ٸ� ������ Ÿ�� �߰� ����
}

public class Inventory
{
    private Item[] items = new Item[16];

    //������ �ε���(Indexer)
    public Item this[int index]
    {
        get { return items[index]; }
        set { items[index] = value; }
    }

    //���� �κ��丮�� �ִ� ������ ��
    public int ItemCount
    {
        get
        {
            int count = 0;
            foreach (Item item in items)
            {
                if (item != null)
                {
                    count++;
                }
            }

            return count;
        }
    }

    //������ �߰�
    public bool AddItem(Item Item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = Item;
                return true;
            }
        }
        return false;  //�κ��丮�� ���� á�� ���
    }

    //������ ����
    public bool RemoveItem(Item Item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == Item)
            {
                items[i] = null;
                break;
            }
        }
        return false;
    }

}
public class ExGameSystem : MonoBehaviour
{
    private Inventory inventory = new Inventory();

     
    Item sword = new Item(0, "Sword", ItemType.Weapon);
    Item shield = new Item(1, "Shield", ItemType.Armor);
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Q))
        {
            inventory.AddItem(sword);
            DebugInventory();
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            inventory.AddItem(shield);
            DebugInventory();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            inventory.RemoveItem(sword);
            DebugInventory();
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            inventory.RemoveItem(shield);
            DebugInventory();
        }
    }

    void DebugInventory()
    {
        Debug.Log("Player Inventory : " + GetInventoryAsString());
    }

    private string GetInventoryAsString()
    {
        string result = "";
        for (int i = 0; i < inventory.ItemCount; i++)
        {
            if (inventory[i] != null)
            {
                result += inventory[i].Name + ",";
            }
        }
        return result.TrimEnd(',');
    }
}

