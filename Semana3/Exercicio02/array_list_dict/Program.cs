//ARRAY
string[] myArray = new string[7];
myArray [0] = "Monday";
myArray [1] = "Tuesday";
myArray [2] = "Wednesday";
myArray [3] = "Thursday";
myArray [4] = "Friday";
myArray [5] = "Saturday";
myArray [6] = "Sunday";

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}


//LIST
List<string> myList = new List<string> ();
myList.Add("Monday");
myList.Add("Tuesday");
myList.Add("Wednesday");
myList.Add("Thursday");
myList.Add("Friday");
myList.Add("Saturday");
myList.Add("Sunday");

for (int i = 0; i < myList.Count; i++)
{
    myList[i] = myList[i].Substring(0, 3);
    Console.WriteLine(myList[i]);
}


//DICTONAIRY
Dictionary<int, string> myDictionary = new Dictionary<int, string> ();

myDictionary[0] = "Monday";
myDictionary[1] = "Tuesday";
myDictionary[2] = "Wednesday";
myDictionary[3] = "Thursday";
myDictionary[4] = "Friday";
myDictionary[5] = "Saturday";
//myDictionary[6] = "Sunday";
myDictionary.Add(6, "Sunday");

for (int i = 0; i < myDictionary.Count; i++)
{
    myDictionary[i] = myDictionary[i].Substring(0, 3);
    Console.WriteLine(myDictionary[i]);
}
