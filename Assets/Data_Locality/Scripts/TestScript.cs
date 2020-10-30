using System;
using UnityEngine;

class TestScript : MonoBehaviour {

    public bool bUseStructData = false;

    const int count = 1000000;
    ProjectileStruct[] projectileStructs = new ProjectileStruct[count];
    ProjectileClass[] projectileClasses = new ProjectileClass[count];

    struct ProjectileStruct {
        public Vector3 Position;
        public Vector3 Velocity;
    }

    class ProjectileClass {
        public Vector3 Position;
        public Vector3 Velocity;
    }

    private void Awake () {
        for (int i = 0; i < count; ++i) {
            projectileStructs[i] = new ProjectileStruct ();
        }
        Shuffle (projectileStructs);

        for (int i = 0; i < count; ++i) {
            projectileClasses[i] = new ProjectileClass ();
        }
        Shuffle (projectileClasses);
    }

    void Update () {

        if (bUseStructData) {
            for (int i = 0; i < count; ++i) {
                UpdateProjectile (ref projectileStructs[i], 0.5f);
            }
        } else {
            for (int i = 0; i < count; ++i) {
                UpdateProjectile (ref projectileClasses[i], 0.5f);
            }
        }

    }

    void UpdateProjectile (ref ProjectileStruct projectile, float time) {
        projectile.Position += projectile.Velocity * time;
    }
    void UpdateProjectile (ref ProjectileClass projectile, float time) {
        projectile.Position += projectile.Velocity * time;
    }

    void UpdateProjectile (ProjectileClass projectile, float time) {
        projectile.Position += projectile.Velocity * time;
    }

    public static void Shuffle<T> (T[] list) {
        System.Random random = new System.Random ();
        for (int n = list.Length; n > 1;) {
            n--;
            int k = random.Next (n + 1);
            T value = list[k];
            list[k] = list[n];
            list[n] = value;
        }
    }
}