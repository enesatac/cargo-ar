using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Barcode : MonoBehaviour
{
    [SerializeField]
    Text awbNumber;

    [SerializeField]
    Text uldNumber;

    [SerializeField]
    Text gateInfo;

    public string[] awb = { "235-11111111", "235-22222222", "235-33333333" };
    public string[] uld = { "PMC12345", "PAG99999", "AKE55555" };
    public string[] gate = { "Zone A", "Zone B", "Zone C" };


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnButtonClick() {
        awbNumber.text = "Awb Number : " + awb[Random.Range(0, 3)];
        uldNumber.text = "Uld Number : " + uld[Random.Range(0, 3)];
        gateInfo.text = "Gate Info : " + gate[Random.Range(0, 3)];
    }

}
