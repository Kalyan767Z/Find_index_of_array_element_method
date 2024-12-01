# Program: Methods for String Display and Finding Index of Array Element

## Task

1. Write a method that displays a string where the characters and their frequency are input by the user.
2. Write a method to find the index of an element in an integer array. The method should return the index of the first found element (if it exists).

---

## Program Description

### 1. **Method for Displaying a String with User-Input Characters:**

   - The user is prompted to input characters along with the number of times each character should appear.
   - Based on the user input, the program constructs a string composed of those characters repeated according to the specified frequency.

### 2. **Method for Finding the Index of an Array Element:**

   - This method accepts an array of integers and a target element.
   - It iterates through the array to locate the first occurrence of the target element and returns its index.
   - If the element is not found, it returns `-1` to indicate the absence of the element.

---

## Program Structure

1. **Findndex Method:**
   - This method takes an array of integers and a target element as input.
   - It searches for the target element in the array and returns the index of its first occurrence.
   - If the element is not found, the method returns `-1`.

2. **Main Method:**
   - First, the program prompts the user to input the size of the array.
   - Then, the program asks the user to input the values for each element of the array.
   - The user is then asked to input an element whose index is to be found.
   - The program calls the `Findndex` method to find and display the index of the specified element.

---

## Summary:

This program demonstrates two core functions: one for displaying a string generated from user-defined characters and frequencies, and another for searching an array to find the index of a specific element. The first method allows users to dynamically create a string, while the second method provides a way to locate the first occurrence of an element in an array.

The program validates user input to ensure that the array elements are integers and that the target element exists within the array, offering a clear and efficient approach to both tasks.
