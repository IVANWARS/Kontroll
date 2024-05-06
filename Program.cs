


Commands ();


string [] array = new string [] {};
  string fromUser = ReadImput ("");
switch (fromUser)
{
    case "1":
    array = new string[] {"Hello", "2", "world", ":-)" };
    break;

    case "2":
    array = new string [] {"1234", "1567", "-2", "computer science"};
    break;

    case "3":
    array = new string [] {"Russia", "Denmark", "Kazan" };
    break;

 
}

int lennewarray = 0 ;
for (int i = 0; i <= array.Length -1; i++)
{
    if (array.Length <= 3) lennewarray++;

}
 
 string[] newarray = new string [lennewarray];
 int idx = 0;

 for (int i = 0; i <= array.Length -1; i++)
 {
    if (array.Length <= 3)
    {
        newarray[idx] = array[i];
        idx++;
    }
 }
     
 PintArray( array);
 Console.Write("");
 

 
  void Commands()
{
    
    Console.WriteLine("1 “Hello”, “2”, “world”, “:-)” ");
    Console.WriteLine("2 [“1234”, “1567”, “-2”, “computer science”]");
    Console.WriteLine("3 [“Russia”, “Denmark”, “Kazan”]");
    
}


   string ReadImput (string msg) 
{
    Console.WriteLine(msg); 
    return Console.ReadLine();

}

void PintArray(string[] array)
{
    Console.Write("[]");
    for ( int i = 0; i < array.Length; i++)

    {
        Console.WriteLine($"/{array[i]}/,");
        
    }
       Console.Write("[]");
}