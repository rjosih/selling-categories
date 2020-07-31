# selling-categories
Helping two friends understand programming. Program that sort the sellers into four categories based on how many things they've sold. 

## Get started
`npm run dev`

### How it works
Manually type in 
* Name 
* Person number
* District area 
* How many articles the person has sold

After this comes "you want to add another person? yes / no " 

The program will only respond if you type `no` otherwise it takes the answer as a yes. 

If the answer is yes the loop goes on until you respond no. 

When you respond no, the person(s) are categorized into four different levels based on how many articles they've sold (Line 73 - 91).

The program controls which category the person belongs to and adds it to the list.

This is the four different categories: 

* Under 50 articles
* From 50 to 99 articles
* From 99 to 199 articles
* Over 200 articles

This will be formatted into a pleasant string that you can see in the terminal right after the program exit. 
Also a new .txt-file named `Information.txt` will be visable with the same content.

If you decide to run the program again the text file will be overwritten. 

The terminal will look like this: 

![PictureOfTerminal](https://i.imgur.com/LbwRPd6.png)


The .txt-file will look like this: 

![PictureOfTxtFile](https://i.imgur.com/ygn6fjN.png)


### Some small explanations for Nico and Levent
* `ReadLine` makes the program read what you has written in the terminal
* `Convert.ToDecimal` and `Convert.ToInt32` is to convert the string from the terminal into a number
* Why decimal is used on district and personal number is that the "numbers" given is sometimes too large for the Int-limit. Decimal can handle more characters.
* The symbol `"\n"` stands for new line and simply jumps to a new line. Just for formatting. 
* On line 74 `String.Join("\n", under50list.ToArray());` converts the array list to a string so it can be added to the string that gonna be written to the file. ArrayLists can't be written "raw" in this situation.
* The symbol `allInfo +=` stands for adding information to an existing object so it doesn't get overwritten.

Hejdå Levent och Nico hoppas ni gillade min presentation xoxo 






