using UnityEngine;

public class InstantiationManager : MonoBehaviour
{
    public static InstantiationManager getInstance;
    void Awake() { getInstance = this; }

    public void Instantiate(GameObject obj, Vector3 pos, Quaternion rot, Transform parent, float destroyDelay)
    {
        GameObject go = Instantiate(obj, pos, rot);
        if (parent != null) 
            go.transform.parent = parent;
        if (destroyDelay > 0)
            Destroy(go, destroyDelay);
    }
}