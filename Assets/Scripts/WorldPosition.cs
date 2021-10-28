using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WorldPosition : MonoBehaviour
{

    string _Text;
    Vector3 _pos;

    // Start is called before the first frame update
    void Start()
    {

       //convert to string _Text 
       _pos = this.transform.position;
       _Text = _pos.ToString();
       this.transform.GetComponent<TextMeshPro>().text = _Text;

    }


}
