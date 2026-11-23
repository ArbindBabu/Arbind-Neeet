public class TrieNode()
{
    public TrieNode[] child = new TrieNode[26];
    public bool endofword = false;
}

public class PrefixTree {

    private TrieNode root;

    public PrefixTree() {
         root = new TrieNode();
    }
    
    public void Insert(string word) {
        
        TrieNode cur = root;
        foreach(char w in word)
        {
            int i = w - 'a';
            if(cur.child[i] == null)
            {
              cur.child[i] = new TrieNode();
            }
            cur = cur.child[i];
        }
        cur.endofword = true;
    }
    
    public bool Search(string word) {
        
        TrieNode cur = root;
        foreach(char w in word)
        {
            int i = w - 'a';
            if(cur.child[i] == null)
            {
                return false;
            }
            cur = cur.child[i];
        }
        return cur.endofword;
    }
    
    public bool StartsWith(string prefix) {
        
        TrieNode  cur = root;
        foreach(char w in prefix)
        {
            int i = w - 'a';
            if(cur.child[i] == null)
            {
                return false;
            }
            cur = cur.child[i];
        }
        return true;
    }
}
