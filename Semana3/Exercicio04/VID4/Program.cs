// Arrays Deletions

int[] intArray = new int[9];

int length = 0;

for(int i = 0; i < 9; i++)
{
    intArray[length] = i;
    length++;
}

for(int i = 2; i < length; i++)
{
    intArray[i - 1] = intArray[i];
}

length--;

for(int i = 0; i < length; i++)
{
    Console.WriteLine(intArray[i]);
}