Console.WriteLine("****************************************************");
Console.WriteLine(" ");

int[] arr = {5, 6, 9};
int[] negArr = {-9, -6, -5};
int[] shiftArr = {1, 3, 7, 5, 9};
int[] num2strArr = {-7, 20, 65};

Console.WriteLine("1.");
Console.WriteLine(" ");
static void PrintNumbers(){
    // Print all of the integers from 1 to 255.
    for(int i = 1; i < 256; i++){
        Console.WriteLine(i);
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

PrintNumbers();

Console.WriteLine("2.");
Console.WriteLine(" ");
static void PrintOdds(){
    // Print all of the odd integers from 1 to 255.
    for(int i = 1; i < 256; i++){
        if(i % 2 == 1){
            Console.WriteLine(i);
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

PrintOdds();

Console.WriteLine("3.");
Console.WriteLine(" ");
static void PrintSum(){
    // Print all of the numbers from 0 to 255, 
    // but this time, also print the sum as you go. 
    // For example, your output should be something like this:
    // New number: 0 Sum: 0
    // New number: 1 Sum: 1
    // New number: 2 Sum: 3
    int sum = 0;
    for(int i = 1; i < 256; i++){
        Console.WriteLine($"Number: {i}");
        sum += i;
        Console.WriteLine($"Sum: {sum}");
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");

}

PrintSum();

Console.WriteLine("4.");
Console.WriteLine(" ");
static void LoopArray(int[] numbers){
    // Write a function that would iterate through each item of the given integer array and 
    // print each value to the console. 
    for(int i = 0; i < numbers.Length; i++){
        Console.WriteLine(numbers[i]);
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

LoopArray(arr);

Console.WriteLine("5.");
Console.WriteLine(" ");
static void FindMax(int[] numbers){
    // Write a function that takes an integer array and prints and returns the maximum value in the array. 
    // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
    // or even a mix of positive numbers, negative numbers and zero.
    int max = 0;
    for(int i = 0; i < numbers.Length; i++){
        max = numbers[0];
        if(max < numbers[i]){
            max = numbers[i];
        }
    }
    Console.WriteLine(max);
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

FindMax(negArr);

Console.WriteLine("6.");
Console.WriteLine(" ");
static void GetAverage(int[] numbers){
    // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
    // For example, with an array [2, 10, 3], your program should write 5 to the console.
    int sum = 0, avg = 0;
    for(int i = 0; i < numbers.Length; i++){
        sum += numbers[i];
    }
    avg = sum / numbers.Length;
    Console.WriteLine(avg);
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

GetAverage(arr);

Console.WriteLine("7.");
Console.WriteLine(" ");
static void OddList(){
    // Write a function that creates, and then returns, a List that contains all the odd numbers between 1 to 255. 
    // When the program is done, the List should have the values of [1, 3, 5, 7, ... 255].
    int[] odd = new int[256/2];
    for(int i = 1; i < 256; i++){
        if(i % 2 == 1){
            odd[i / 2] = i;
            Console.WriteLine(odd[i / 2]);
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

OddList();

Console.WriteLine("8.");
Console.WriteLine(" ");
static void GreaterThanY(int[] numbers, int y){
    // Write a function that takes an integer List, and an integer "y" and returns the number of values 
    // That are greater than the "y" value. 
    // For example, if our List contains 1, 3, 5, 7 and y is 3. Your function should return 2 
    // (since there are two values in the List that are greater than 3).
    for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] > y){
            Console.WriteLine(numbers[i]);
        }
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

Random rand = new Random();
int num8 = rand.Next(1, 9);
GreaterThanY(arr, num8);

Console.WriteLine("9.");
Console.WriteLine(" ");
static void SquareArrayValues(int[] numbers){
    // Write a function that takes a List of integers called "numbers", and then multiplies each value by itself.
    // For example, [1,5,10,-10] should become [1,25,100,100]
    for(int i = 0; i < numbers.Length; i ++){
        Console.WriteLine(numbers[i] * numbers[i]);
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

SquareArrayValues(arr);
SquareArrayValues(negArr);

Console.WriteLine("10.");
Console.WriteLine(" ");
static void EliminateNegatives(int[] numbers){
    // Given a List of integers called "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
    // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
    for(int i = 0; i < numbers.Length; i++){
        if(numbers[i] < 0){
            numbers[i] = 0;
        }
        Console.WriteLine(numbers[i]);
    }
    Console.WriteLine(" ");
    Console.WriteLine("****************************************************");
    Console.WriteLine(" ");
}

EliminateNegatives(arr);
EliminateNegatives(negArr);