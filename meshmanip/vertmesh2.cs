using UnityEngine;
using System.Collections;

public class vertmesh2 : MonoBehaviour
{
    public Vector3[] newVertices;
    public Vector2[] newUV;
    public int[] newTriangles;

    public int zigs = 100;
    float oneOverZigs;
    private Particle[] particles;

    // Use this for initialization
    void Start()
    {
        //part about particles
        GetComponent<ParticleEmitter>().emit = false;

        GetComponent<ParticleEmitter>().Emit(zigs);
        particles = GetComponent<ParticleEmitter>().particles;

        //part about mesh
        Mesh mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
        mesh.vertices = newVertices;
        mesh.uv = newUV;
        mesh.triangles = newTriangles;

        //put particle on mesh (or die trying)
        particles[0].position = newVertices[0];
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("particles.Length " + particles.Length);
        Debug.Log("particle 0 " + particles[0].position);
        Debug.Log("particle 10 " + particles[10].position);
        Debug.Log("vertice 0 " + newVertices[0]);
    }
}
