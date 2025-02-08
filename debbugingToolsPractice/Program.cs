/*  
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
int x = 5;

int y = ChangeValue(x);

Console.WriteLine(y);

int ChangeValue(int value) 
{
    value = 10;
    return value;
}