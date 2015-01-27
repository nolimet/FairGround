using UnityEngine;
using System.Collections;

public class FlickerLight : MonoBehaviour
{

    [SerializeField]
    float min = 0, max = 0;

    [SerializeField]
    Light[] Lights;
    [SerializeField]
    string LightTag = "FlickeringLight";

    void Start()
    {
        AutoMapLights();
        StartCoroutine(flickering());
    }

    IEnumerator flickering()
    {
        float a, b, c,d = max;
        int length;
        bool add = false;
        while (true)
        {
            length = (int)Random.Range(20, 120);
            a = Random.Range(min, max * 0.3f);
            b = Random.Range(max * 0.5f, max);
            c = b - a;
            for (int i = 0; i < length; i++)
            {
                if (d >= b)
                    add = false;
                if (d <= a)
                    add = true;

                if (add)
                    d += c * Time.deltaTime;
                else
                    d -= c * Time.deltaTime;
                foreach(Light l in Lights)
                light.intensity=d;

                yield return new WaitForEndOfFrame();

            }
        }
    }

    void AutoMapLights()
    {
        System.Collections.Generic.List<Light> l = new System.Collections.Generic.List<Light>();

        GameObject[] games = GameObject.FindGameObjectsWithTag(LightTag);

        foreach (GameObject g in games)
        {
            l.Add(g.GetComponent<Light>());
        }

        Lights = l.ToArray();
    }
}
