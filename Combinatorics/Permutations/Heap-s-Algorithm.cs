// Heap's Algorithm
// Generates all possible permutations of n objects.

// https://en.wikipedia.org/wiki/Heap%27s_algorithm

// In this file, we will implement this algorithm to find permutations of integers from 1 to n.

// Output the k! permutations of A in which the first k elements are permuted in all ways.
// To get all permutations of A, use k := length of A.
//
// If k > length of A, will try to access A out of bounds.
// If k <= 0 there will be no output (empty array has no permutations)
void Permutations(int k, int[] array)
{
    if (k == 1)
    {
        foreach (int i in array)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    else
    {
        // Permutations with last element fixed.
        Permutations(k - 1, array);

        for (int i = 0; i < k - 1; i++)
        {
            if (k % 2 == 0)
            {
                // Swap array[i] and array[k-1]
                array[i] += array[k - 1];
                array[k - 1] = array[i] - array[k - 1];
                array[i] -= array[k - 1];
            }
            else
            {
                // Swap array[0] and array[k-1]
                array[0] += array[k - 1];
                array[k - 1] = array[0] - array[k - 1];
                array[0] -= array[k - 1];
            }
            
            Permutations(k - 1, array);
        }
    }
}

int[] array = new int[] {1, 2, 3, 4};

Permutations(4, array);

// Output:
/* 1 2 3 4 
 * 2 1 3 4 
 * 3 1 2 4 
 * 1 3 2 4 
 * 2 3 1 4 
 * 3 2 1 4 
 * 4 2 1 3 
 * 2 4 1 3 
 * 1 4 2 3 
 * 4 1 2 3 
 * 2 1 4 3 
 * 1 2 4 3 
 * 1 3 4 2 
 * 3 1 4 2 
 * 4 1 3 2 
 * 1 4 3 2 
 * 3 4 1 2 
 * 4 3 1 2 
 * 4 3 2 1 
 * 3 4 2 1 
 * 2 4 3 1 
 * 4 2 3 1 
 * 3 2 4 1 
 * 2 3 4 1
 */
