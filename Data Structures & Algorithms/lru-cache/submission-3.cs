public class LRUCache {
    private Dictionary<int, LinkedListNode<(int Key, int Value)>> _cacheMap;
    private int _capacity;
    private LinkedList<(int Key, int Value)> _cache;
    public LRUCache(int capacity) {
        _capacity = capacity;
        _cacheMap = new ();
        _cache = new ();
    }
    
    public int Get(int key) {
        if(_cacheMap.TryGetValue(key, out var node)){
            _cache.Remove(node);
            _cache.AddLast(node);
            return node.Value.Value;
        }
        return -1;
    }
    
    public void Put(int key, int value) {
        bool isUpdate = _cacheMap.ContainsKey(key);
        if (_cacheMap.Count == _capacity && !isUpdate){
            var lruNode = _cache.First;
            _cacheMap.Remove(lruNode.Value.Key);
            _cache.RemoveFirst();
        } else if (isUpdate) {
            var nodeToUpdate = _cacheMap[key];
            _cache.Remove(nodeToUpdate);
        }
        var node = _cache.AddLast((key, value));
        _cacheMap[key] = node;
    }
}