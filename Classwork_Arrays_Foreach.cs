using UnityEngine;

// L9 - Arrays & foreach (In-Class Classwork)
// Work through the TODOs in order. Attach this to an empty GameObject and press Play to test.
// Directions:
//   Section A - read the code and write your predicted answer, then test it.
//   Section B - write the code for each task.
//   Section C - solve each mini-interview problem (the approach is up to you).
public class Classwork_Arrays_Foreach : MonoBehaviour
{
    void Start()
    {
        // For Section A, use this array:
        int[] loot = { 5, 10, 15, 20 };

        // ============================================================
        // SECTION A: Trace & Predict (predict, then test)
        // ============================================================
        // A1. loot[0]
        // Answer: <5>
        //
        // A2. loot[3]
        // Answer: <20>
        //
        // A3. loot.Length
        // Answer: <4>
        //
        // A4. loot[loot.Length - 1]
        // Answer: <{3}>
        //
        // A5. loot[4]        (valid, or ERROR?)
        // Answer: <Error>
        //
        // A6. loot[-1]       (valid, or ERROR?)
        // Answer: <ERROR>
        //
        // A7. What does this print?
        //     foreach (int g in loot)
        //     {
        //         Debug.Log(g);
        //     }
        // Answer: <5, 10, 15, 20>
        //
        // A8. What does this print?
        //     for (int i = 0; i < 2; i++)
        //     {
        //         Debug.Log(loot[i]);
        //     }
        // Answer: <5, 10>

        // ============================================================
        // SECTION B: Application (write the code)
        // ============================================================
        // B1. Declare three arrays (write the full lines):
        //     a) three room names as strings: "Hall", "Vault", "Cell"
        string[] roomName =
        {
            "Hall",
            "Vault",
            "Cell"
        };
        //     b) four potion counts as ints: 2, 4, 6, 8
        int[] pointCount = { 2, 4, 6, 8};
        //     c) an empty array that holds 5 ints (all start at 0)
        int[] array = new int[5];
        //
        // B2. TOTAL LOOT: add up every value in the loot array above and print
        //     the total.
        int[] loot = { 5, 10, 15, 20 };
        int totalLoot = 0;
        foreach (int loot in totalLoot)
        {
            totalLoot += loot;
        }
        //
        // B3. INVENTORY LIST: given a string[] of items, print each item together
        //     with its index, like "0: torch".
        string[] items =
        {
            "torch",
            "sword",
            "boots"
        };
        for (int i = 0; i <items.Length; i++)
        {
            Debug.Log(i + ": " + items[i]);
        }
        //
        // B4. UPGRADE A SLOT: change the third item of an int[] to a new value,
        //     then print the whole array.
        int[] item = { 1, 2, 3};
        item[2] = 4;
        for (int i = 0; i < item.Length; i++)
        {
            Debug.Log(item[i]);
        }

        // ============================================================
        // SECTION C: Mini-Interview (write the code)
        // ============================================================
        // C1. STRONGEST ENEMY: given int[] enemyHealth, find and print the
        //     largest value (don't use a built-in Max).
        int[] enemyHealth = [ 35, 90, 45, 100, 40];
        int largest = enemyHealth[0];

        for (int i =1; i < enemyHealth.Length; i++)
        {
            if (enemyHealth[i] > largest)
                {
    
                    largest = enemnyHealth[i];
                
                }
        }
            Debug.Log("Strongest enemy: " + largest);
        //
        // C2. COUNT THE POTIONS: given a string[] of items and a target word
        //     (say "potion"), print how many times the target appears.
        string[] items= {"sword", "dagger", "sheild", "potion", "potion"};
        int count = 0;
        foreach (string item in items)
            {
                if (item == "potion")
                {
                    count++;
                }
            }
            Debug.Log("Potions found: " + count);
        
        //
        // C3. REVERSE ROLL CALL: given a string[] of party members, print the
        //     names from last to first.
        string[] party = {"Kila", "Gorg", "Phil", "Jet"};
        for (int i = party.Length -1; i>+ 0; i--)
        {
            debug.Log(party[i]);
        }
        //
        // C4. SURVIVORS: given int[] enemyHealth, print how many enemies are
        //     still alive (health above 0).
        int alive = 0;

        foreach (int hp in enemyHealth)
        {
            if(hp > 0)
            {
                alive++;
            }
        }
        Debug.Log("Surviviors: " + alive);
        //
        // C5. SORT THE LOOT: given an int[] of values in any order, rearrange
        //     them so they run from smallest to largest, then print them in order.
        int[] loot = { 9, 3, 7, 1, 5};
        for (int i= 0; i < loot.Length - 1; i++)
        {
            for (int j = 0; j < loot.Length - 1 - i; j++)
            {
                if (loot[j] > loot[j +1])
                {
                    int temp = loot[j];
                    loot[j] = loot[j + 1];
                    loot[j + 1] = temp;
                }
            }
        }

        foreach (int value in loot)
        {
            Debug.Log(value);
        }
        //
        // C6. FIND IN THE SORTED LOOT: using the now-sorted values from C5, look
        //     for a particular value and print whether it is in the list and, if
        //     so, at what index.
        int[] loot = { 1, 3, 5, 7, 9};
        int target = 7;
        int foundIndex = -1;
        //
        // C7. PALINDROME WORD: given a word (say "level"), print whether it reads
        //     the same forwards and backwards.
    }
}
