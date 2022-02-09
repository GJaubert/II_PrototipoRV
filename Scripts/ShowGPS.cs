using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class ShowGPS : MonoBehaviour {
    public Vector3 gps;
    public TextMeshProUGUI questionScreen;

    IEnumerator Start() {
        // Check if the user has location service enabled.
        if (!Input.location.isEnabledByUser) {
            questionScreen.text = "Habilita los permisos de ubicación";
            yield break;
        }
        // Starts the location service.
        Input.location.Start();

        // Waits until the location service initializes
        int maxWait = 10;
        while (Input.location.status == LocationServiceStatus.Initializing && maxWait > 0) {
            yield return new WaitForSeconds(1);
            maxWait--;
        }
        // If the service didn't initialize in 10 seconds this cancels location service use.
        if (maxWait < 1) {
            questionScreen.text = "Tiempo fuera amigo";
            print("Timed out");
            yield break;
        }
        // If the connection failed this cancels location service use.
        if (Input.location.status == LocationServiceStatus.Failed) {
            questionScreen.text = "No se ha podido descubrir la ubicacion";
            print("Unable to determine device location");
            yield break;
        } else {
            LocationService location = Input.location;
            // If the connection succeeded, this retrieves the device's current location and displays it in the Console window.
            LocationInfo locationData = location.lastData;
            Input.compass.enabled = true;
            gps = new Vector3(locationData.latitude,
                            locationData.longitude, locationData.altitude);
            questionScreen.text = gps.ToString();
        }

        // Stops the location service if there is no need to query location updates continuously.
        Input.location.Stop();
    }
}