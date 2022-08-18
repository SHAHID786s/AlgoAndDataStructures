
using AlgoAndDataStructures.ADT;
using AlgoAndDataStructures.ArrInsertion;
using AlgoAndDataStructures.Linked_lists;

//ADT
//Car car1 = new Car();              
//car1.Manufacturer = "nissan";   
//**********************************************************************************************

//0(1) 'CONSTANT' on the time complexity graph this is regarded as a excellent 
// var test =0;
//void insertColor (string c)
//{
//   string color1 = c;
//}
//7+8+6 or 7>8 
//calling a function insertColor("green")
//accessing an arr element employee[5]

// 0(n) 'LINEAR' on the time complexity graph and to find them look for loops this is regarded as 'FAIR'
//string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
//for (int i = 0; i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}

//0(n^2) 'QUADRATIC' usually regarded as an 'HORRIBLE' approach   usually a nested forloop
//string[] popularity = new string[] { "Awesome", "Cool", "OK", "Bad" };
//string[] cars = new string[] { "Volvo", "BMW", "Ford", "Mazda" };
//for (int i = 0; i < cars.Length; i++)
//{   
//    for (int j = 0; j < popularity.Length; j++)
//        Console.WriteLine(popularity[j] + cars[i]);
//}
//the not so common ones LOG N binary search and trees , N LOG (N) quicksort, mergesort, shellsort, cubesort,


//************************************Arrays insert end*********************************************************
//Employee.Insert();

//****************************************LINEAR SEARCH***********************************************************

/*int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

bool locate(int[]n,int search)
{
    for (int i = 0; i < nums.Length; i++)
    {
        if(nums[i] == search)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(locate(nums, 5));*/

//**********************LINKED LISTS ********************************

//note that at the end of the list we always have null

Node n1 = new Node(3); // think of these as boxes
Node n2 = new Node(10);
Node n3 = new Node(2);
Node n4 = new Node(26);

n1.Next = n2; // think of this as a link between the boxes
n2.Next = n3;
n3.Next = n4;

int countNodes(Node head)
{
    int count = 1; // as we already start with a node we increment

    Node current = head; // head now becomes the current node / object

    //as long aas list contains objects until we reach the end of list
    while(current.Next!=null)
    {
        current = current.Next; //traverse through the list next node / object now stored in current varaible
        // increment the counter
        count += 1;        
    }
    return count;
}

Console.WriteLine("The amount of nodes: "+ countNodes(n1)); // prints 4 nodes

InsertFirstNode(786, n1);

void InsertFirstNode (int data,Node head)
{
    Console.WriteLine("The head was :" + head.Data);
    Node newNode = new Node(data);
    newNode.Next = head; //so newNode becomes first
    Console.WriteLine("The head is now :" + newNode.Data  );
}


