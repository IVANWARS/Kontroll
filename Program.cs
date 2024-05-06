string [] array = new string [] {};
String fromUser = ReadImput ();
switch (fromUser)
{
    case "1":
    array = new string[] {};
    break;

    case "2":
    array = new string [] {};
    break;

    case "3":
    array = new string [] {};
    break;


default:
Console.WriteLine ( $ { fromUser } );
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
 PrintArray(newarray);

 

