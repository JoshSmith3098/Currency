using UnityEngine;
using System.Collections;

public class Currency : MonoBehaviour {
        private static Currency instance = new Currency();

        public static Currency Instance
        {
            get
            {
                return instance;
            }
        }

        public string[] GlobalArray { get; set; }
    }

    // to call this code ue the following piece of code
    //var myGlobalArray = Currency.Instance.GlobalArray;
