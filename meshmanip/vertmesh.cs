using UnityEngine;
using System.Collections;

public class vertmesh : MonoBehaviour
{
    ///private Particle[] particles;
    //private Vector3[] vertList = new Vector3[5];
    void Start()
    {
        //part on mesh
        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<SkinnedMeshRenderer>();
    }


    void Update()
    {
        float dt = Time.time;

        SkinnedMeshRenderer[] skin = GetComponentsInChildren<SkinnedMeshRenderer>();

        Debug.Log(skin[1]);

        Mesh baked = new Mesh();
        skin[1].BakeMesh(baked);

        Vector3 lScale = skin[1].GetComponentInParent<Animator>().transform.localScale;
        skin[1].GetComponentInParent<Animator>().transform.localScale = lScale;

        Vector3[] verts = baked.vertices;

        //        Debug.Log(baked.vertexCount);

        //Debug.Log(skin.GetLowerBound);

        /*
        Debug.Log(baked.vertexCount + "\t" + "toto 0" +"\t"+ verts[0][0] + "\t" + verts[0][1] + "\t" + verts[0][2] + "\t" + dt);
        Debug.Log(baked.vertexCount + "\t" + "toto-1" +"\t"+ verts[verts.Length - 1][0] + "\t" + verts[verts.Length - 1][1] + "\t" + verts[verts.Length - 1][2] + "\t" + dt);
        */

        
        for (int i=0; i<=2; i++)//verts.Length-1; i++)
        {
            //Debug.Log(i);
            //Debug.Log(verts[i]);
            Debug.Log(baked.vertexCount + "\t" + "toto"+" " + i + "\t" + verts[i][0] + "\t" + verts[i][1] + "\t" + verts[i][2] + "\t" + dt);
        }
        
        
        /*
        Vector3 baseposition = skin.transform.position;

        float vertnum = verts.GetLength;

        

        Debug.Log("toto " + verts[0][0] +"\t"+ verts[0][1] + "\t" +verts[0][2] + "\t" + dt);
        //Debug.Log(Time.time);
*/
    }
}