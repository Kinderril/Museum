using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PictureObject : MonoBehaviour
{

    public Texture Texture;
//    public Shader Shader;

    public string Info = "Desc";
    private const float coef = 0.5f;


    void Awake()
    {
        Info = Info.Replace("\\n", "\n");
        float maxWidth = 1024;
        var render = GetComponent<MeshRenderer>();
        Texture = render.material.mainTexture;
        var ls = transform.localScale;
        var p = (float)Texture.height / (float)Texture.width;

//        Debug.Log($"{txt.width}   {txt.height}");
//        if (txt.width > txt.height)
//        {
//
//        }

        transform.localScale = new Vector3(ls.x,1, ls.x * p);


        //        if (Texture.width < Texture.height)
        //        {
        //            if ()
        //        }
        //        else
        //        {
        //
        //        }

        //        var ww = Texture.width * coef;
        //        var hh = Texture.height * coef;
        //        CreateMesh(ww, hh);
    }

//    private Mesh CreateMesh(float width, float height)
//    {
//        var curMesh = GetComponent<MeshFilter>();
//        var render = GetComponent<MeshRenderer>();
//
//        Mesh m = new Mesh();
//        curMesh.mesh = m;
//        m.name = "ScriptedMesh";
//        m.vertices = new Vector3[] {
//            new Vector3(-width, -height, 0.01f),
//            new Vector3(width, -height, 0.01f),
//            new Vector3(width, height, 0.01f),
//            new Vector3(-width, height, 0.01f)
//        };
//        m.uv = new Vector2[] {
//            new Vector2 (0, 0),
//            new Vector2 (0, 1),
//            new Vector2(1, 1),
//            new Vector2 (1, 0)
//        };
//        m.triangles = new int[] { 0, 1, 2, 0, 2, 3 };
//        m.RecalculateNormals();
//        var mat = new Material(Shader);
//        mat.mainTexture = Texture;
//        render.material = mat;
//        return m;
//    }

}
