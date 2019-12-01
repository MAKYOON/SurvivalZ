using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float rateOfFire = 1.5f;
    private float nextFire = 0.0f;

    /*J'ai suivi l'exemple sur la documentation Unity concernant l'utilisation du Time.time pour éviter le spamming.
     * Pour l'explication : Time.time renvoie le temps écoulé depuis le début du programme. Au début on initialise la variable
     * nextFire à 0. Du coup si le joueur appuie sur Espace, et que Time.time > nextFire (ce qui est toujours le cas la première fois)
     * alors on envoie le chien. A ce moment là, la variable nextFire prend la valeur Time.time (donc le temps écoulé jusque-là) + une valeur
     * représentant le délai entre deux input. 
     * Ex : On lance le programme. Au bout de 2s (donc Time.time = 2) > nextFire (=0) donc on envoie le chien.
     * nextFire = Time.time (=2) + rateOfFire (=1.5) = 3.5
     * Donc tant que Time.time != 3.5, donc 1.5 secondes après, on ne peut pas ré-effectuer l'action !
     */

    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && (Time.time > nextFire))
        {
            nextFire = Time.time + rateOfFire;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
