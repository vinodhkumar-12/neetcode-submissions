public class MyHashMap {

    private int size = 1000;
    private LinkedList<(int key, int value)>[] buckets;

    private int Index(int key)
    {
        return key%size;
    }

    public MyHashMap() {
        buckets = new LinkedList<(int, int)>[size];
    }
    
    public void Put(int key, int value) {

       var index  = Index(key);

        if(buckets[index] == null)
        {
            buckets[index] = new LinkedList<(int,int)>();
        }

       if(buckets[index] != null)
       {
            foreach(var pair in buckets[index])
            {
                if(pair.key == key)
                {
                    var node  = buckets[index].Find(pair);
                    
                    buckets[index].Remove(node);

                    buckets[index].AddLast((key, value));

                    return;
                }
            }
       }

       buckets[index].AddLast((key, value));
    }
    
    public int Get(int key) {

        var index = Index(key);

        if(buckets[index] == null)
            return -1;

        foreach(var pair in buckets[index])
        {
            if(pair.key == key)
            {
                return pair.value;
            }
        }
        
        return -1;
    }
    
    public void Remove(int key) {

        var index = Index(key);

        if(buckets[index] == null)
            return;

        foreach(var pair in buckets[index])
        {
            if(pair.key == key){
                buckets[index].Remove(pair);
                return;
            }
        }
        
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */