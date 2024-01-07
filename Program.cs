//Initialisiert das erste Array
int[] array1 = new int[5];

//fragt nach 5 Nummern
Console.WriteLine("Enter 5 numbers");

//fügt die nummern in das Array ein
for (int i = 0; i < 5; i++)
    array1[i] = Convert.ToInt32(Console.ReadLine());

//Initialisiert das zweite Array
int[] array2 = new int[5];

//kopiert die Values von erstem zum zweiten Array
for (int i = 0; i < 5; i++)
    array2[i] = array1[i];

//Zeigt die Values der beiden Arrays Seite bei Seite
for (int i = 0; i < 5; i++)
    Console.WriteLine($"{ array1[i]} and {array2[i]}");
