using Immersal.Samples.Navigation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public List<GameObject> pathlist = new List<GameObject>();
    public GameObject m_navigationPathPrefab; 
    private NavigationPath m_navigationPath = null;

    // Start is called before the first frame update
    void Start()
    {
        GameObject m_navigationPathObject = Instantiate(m_navigationPathPrefab);
        m_navigationPath = m_navigationPathObject.GetComponent<NavigationPath>();
        m_navigationPath.pathWidth = 1;
        
    }

    // Update is called once per frame
    void Update()
    {
        List<Vector3> pathpos = new List<Vector3>();
        foreach (var item in pathlist)
        {
            pathpos.Add(new Vector3(item.transform.position.x, item.transform.position.y, item.transform.position.z));
        }
        m_navigationPath.GeneratePath(pathpos, transform.right);
    }
}
