using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletSpeed = 10;
    public float fireRate = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //shoot using fireRate
        if (Input.GetButtonDown("Fire1"))
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            //only shoot if mouse is still held
            if (!Input.GetButton("Fire1"))
            {
                yield break;
            }

            //create a bullet
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            //get the rigidbody of the bullet
            Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            //add force to the bullet
            rb.AddForce(transform.right * bulletSpeed, ForceMode2D.Impulse);

            //wait for fireRate
            yield return new WaitForSeconds(fireRate);
        }
    }
}
