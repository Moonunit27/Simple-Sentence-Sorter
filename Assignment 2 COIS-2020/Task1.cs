///////////////////////////////////////////////////////////////////////////////
//Program Name: The Letter Frequency Program                                 //
//Programmer: Sarah Rayfuse                                                  //                                                    //
//Program Description: This program asks the users to enter letters, it then //
//puts them in an array and counts the frequency of that letter's appearance //
//Data Dictionary:                                                           //
//Lettersarray: An array without a set number of shelves                     //
//Enteredletters: The letters in the array                                   //
//counter: keeps track of shelf number in Lettersarray                       //
//Frequencyarray: an array that keeps track of frequencies                   //
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//Lettersarray: name of array
// Enteredletters: letters in array

public class Assignment2
{
    public void GetFrequencies() //GetFrequencies method
    {
        int counter = 0;// initialize counter at 0
     
        Console.WriteLine("Please enter some text");// prompts user to enter some letters
        string Enteredletters = Console.ReadLine();// gets the Letters from the user

        string[] Lettersarray = new string[Enteredletters.Length];// unlimited array for characters
        for (int i = 0; i < Enteredletters.Length; i++)// loop that is the size of Enteredletters
        {
            Lettersarray[i] = Enteredletters[i].ToString();// puts letters in an array 
        }

        Array.Sort(Lettersarray);// sorts the array
        foreach (string letter in Lettersarray) Console.Write(letter + " "); // prints sorted array

        String previousletter = Lettersarray[0];// previous is the first shelf of array

        int[] Frequencyarray = new int[Lettersarray.Length];// new array with unlimited shelves this holds frequencies
        Frequencyarray[0] = 1; // initialize first shelf of Frequencyarray to 1
        for (int j = 1; j < Lettersarray.Length; j++)// loop through whole Letters array
        {
            if (previousletter == Lettersarray[j])// if previousletter is equal to the next letter enter the following 
            {
                Frequencyarray[counter]++;// add one to frequency
            }
            else
            {
                counter++;// add one to counter
                previousletter = Lettersarray[j];// 
                Frequencyarray[counter] = 1;// frequency stays at one
            }

        }

        foreach (int number in Frequencyarray)
            try
            {
                Console.Write(number + " "); // prints frequencies
            }
             catch {
                counter = 0;
            }
        Console.ReadLine();
    }
}
