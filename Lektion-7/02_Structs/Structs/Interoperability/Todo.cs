using System.Runtime.InteropServices;

namespace _02_Structs.Structs.Interoperability;


[StructLayout(LayoutKind.Sequential)]
public struct Todo
{
	public int userId;
	public int id;
	public string title;
	public bool completed;
}



/* 
 

{
  "userId": 1,
  "id": 1,
  "title": "delectus aut autem",
  "completed": false
} 


https://jsonplaceholder.typicode.com/todos/1

*/