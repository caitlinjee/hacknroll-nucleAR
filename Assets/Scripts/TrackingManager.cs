using System;
using Mapbox.Unity.Map;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Com.NucleAr.MapAr
{
    public class TrackingManager : MonoBehaviour
    {
        public Button control;
        public GameObject planeFinder;
        private void Start()
        {
            control.onClick.AddListener(delegate { StopTracking(); });
        }

        public void StartTracking()
        {
            planeFinder.SetActive(true); 
            control.GetComponentInChildren<Text>().text = "Stop Plane Detection";
            control.onClick.AddListener(delegate { StopTracking(); });
        }

        public void StopTracking()
        {
            planeFinder.SetActive(false);
            control.GetComponentInChildren<Text>().text = "Start Plane Detection";
            control.onClick.AddListener(delegate { StartTracking(); });
        }

        public void ClearMaps()
        {
            AbstractMap[] abstractMaps = FindObjectsOfType<AbstractMap>();
            foreach (AbstractMap abstractMap in abstractMaps)
            {
                abstractMap.Destroy();
            }
        }
    }
}