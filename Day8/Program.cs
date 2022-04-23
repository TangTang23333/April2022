using Day8;

//Practice working with Generics
//1. Create a custom Stack class MyStack<T> that can be used with any data type which
//has following methods
//1. int Count()
//2.T Pop()
//3.Void Push()
MyStack<int> s = new MyStack<int>();
s.Push(4);
s.Push(5);
s.Push(6);
s.Push(7);
s.Push(8);
Console.WriteLine($"Stack length is {s.Count()}");
Console.WriteLine($"pop {s.Pop()} from stack");
Console.WriteLine($"pop {s.Pop()} from stack");
Console.WriteLine($"Stack length is {s.Count()}");


//2.Create a Generic List data structure MyList<T> that can store any data type.
//Implement the following methods.
//1. void Add (T element)
//2.T Remove(int index)
//3. bool Contains(T element)
//4. void Clear()
//5. void InsertAt(T element, int index)
//6. void DeleteAt(int index)
//7.T Find(int index
//
MyList<int> l = new MyList<int>();
l.Add(1);
l.Add(2);
l.Add(3);
l.Add(4);
l.Add(5);
foreach (int i in l.list)
{
    Console.WriteLine(i);
}
Console.WriteLine($"we remove index at 3 -----> {l.Remove(3)}");
foreach (int i in l.list)
{
    Console.WriteLine(i);
}
Console.WriteLine($"if 6 is contained ----> {l.Contains(6)}");
l.InsertAt(0, 0);
foreach (int i in l.list)
{
    Console.WriteLine(i);
}
l.DeleteAt(1);
foreach (int i in l.list)
{
    Console.WriteLine(i);
}
Console.WriteLine($"index of 3 is {l.Find(3)}");




//3.Implement a GenericRepository<T> class that implements IRepository<T> interface
//that will have common /CRUD/ operations so that it can work with any data source
//such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
//on T were it should be of reference type and can be of type Entity which has one
//property called Id. IRepository<T> should have following methods
//1. void Add(T item)
//2. void Remove(T item)
//3.Void Save()
//4.IEnumerable < T > GetAll()
////5.T GetById(int id)
