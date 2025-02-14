using UnityEngine;

[System.Serializable]
public class Stat {
    public float CurHP, MaxHP, Attack, AttackSpeed, MoveSpeed;

}

public class Mobs : MonoBehaviour
{
    public Stat stat;
    public float direction, speed;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate()
    }
}
