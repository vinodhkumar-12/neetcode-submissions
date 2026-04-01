public class MyHashSet {

    private int size = 1000;
    private List<int>[] buckets;

    private int Hash(int key)
    {
        return key % size;
    }

    public MyHashSet() {
        buckets = new List<int>[size];
    }
    
    public void Add(int key) {
        int index = Hash(key);

        if(buckets[index] == null)
        {
            buckets[index] = new List<int>();
        }

        if(!buckets[index].Contains(key))
        {
            buckets[index].Add(key);
        }
    }
    
    public void Remove(int key) {
          int index = Hash(key);

          if(buckets[index]!= null)
          {
            buckets[index].Remove(key);
          }
    }
    
    public bool Contains(int key) {

        int index = Hash(key);
        
        return buckets[index] != null && buckets[index].Contains(key);
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */