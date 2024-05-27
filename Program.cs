SortedSet<int> a = [0, 2, 4, 5, 10, 8];
SortedSet<int> b = [5, 6, 7, 8, 9, 10];

// union
SortedSet<int> c = new(a);
c.UnionWith(b);

// PrintCollection(c);

// intersection
SortedSet<int> d = new(a);
d.IntersectWith(b);

// PrintCollection(d);

// difference
SortedSet<int> e = new(a);
e.ExceptWith(b);

PrintCollection(e);

void PrintCollection<T>(IEnumerable<T> collections)
{
    foreach (T collection in collections)
    {
        Console.Write(collection + " ");
    }
    Console.WriteLine("");
}
