namespace SearchLibrary
{
    public class LinearSearch
    {
        public int Search(int key, int[] elemArray)
        {
            for (int i = 0; i < elemArray.Length; i++)
            {
                if (elemArray[i] == key)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}