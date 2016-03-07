using UnityEngine;
using System.Collections;

public class vertmesh_backup : MonoBehaviour
{
    private Particle[] particles;
    private Vector3[] vertList = new Vector3[5];
    void Start()
    {
        //part on mesh

        gameObject.AddComponent<MeshFilter>();
        gameObject.AddComponent<MeshRenderer>();
        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();



        vertList[0] = new Vector3(0, 0, 0);
        vertList[1] = new Vector3(0, 1, 0);
        vertList[2] = new Vector3(1, 1, 0);

        mesh.vertices = vertList;

        mesh.triangles = new int[] { 0, 1, 2 };

        //part on particules

        GetComponent<ParticleEmitter>().emit = false;

        GetComponent<ParticleEmitter>().Emit(3);
        particles = GetComponent<ParticleEmitter>().particles;

        // generic

        /* //simple exemple that work
        mesh.vertices = new Vector3[] { new Vector3(0, 0, 0), new Vector3(0, 1, 0), new Vector3(1, 1, 0) };
        mesh.uv = new Vector2[] { new Vector2(0, 0), new Vector2(0, 1), new Vector2(1, 1) };
        mesh.triangles = new int[] { 0, 1, 2 };
        */

        Debug.Log(vertList[0]);
    }

    void Update()
    {
        particles[0].position = vertList[0];
        particles[1].position = vertList[1];
        particles[2].position = vertList[2];

        GetComponent<ParticleEmitter>().particles = particles;

        Debug.Log(GetComponent<ParticleEmitter>().particleCount);
    }
}