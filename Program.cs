using System;
using System.Collections;
using System.IO;

namespace levent
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string under50string = " säljare har nått nivå 1. 0-50 artiklar" + "\n" ;
            string from50to99string = " säljare har nått nivå 2. 50-99 artiklar" + "\n" ;
            string from99to199string = " säljare har nått nivå 3. 99-199 artiklar" + "\n" ;
            string over199string = " säljare har nått nivå 4. 199 eller fler artiklar" + "\n" ;
            
            string name = "";
            decimal personalNumber = 0;
            decimal district = 0;
            int quantity = 0;
            
            string mall = "Namn " + "Personnr " + "Distrikt " + "Antal"; 
            string summary = "";

            string allInfo = "";
                        
            // The different lists aka categories
            var under50list = new ArrayList(); 
            var from50to99list = new ArrayList();
            var from99to199list = new ArrayList();  
            var over199list = new ArrayList();
            
            for(;;){

                // Name
                Console.WriteLine("Enter a person's name:");
                name = Console.ReadLine();
                
                // Person number
                Console.WriteLine("Please enter the person number:");
                personalNumber = Convert.ToDecimal(Console.ReadLine());

                // District
                Console.WriteLine("Please enter the district code:");
                district = Convert.ToDecimal(Console.ReadLine());

                // Quantity
                Console.WriteLine("Please enter the quantity:");
                quantity = Convert.ToInt32(Console.ReadLine());

                summary = name + " " + personalNumber + " " + district + " " + quantity;
                
                // Checks how many sellers in right categories
                if(quantity < 50){
                    under50list.Add(summary);
                }else if(quantity > 50 && quantity < 99){
                    from50to99list.Add(summary);
                }else if(quantity > 99 && quantity < 200){
                    from99to199list.Add(summary);
                }else if(quantity > 199){
                    over199list.Add(summary);
                    Console.WriteLine(over199list.Count);
                }
                
                Console.WriteLine("You want to add another person? yes/no");
                string answer = Console.ReadLine();
            
                if (answer == "no"){
                    allInfo += mall + "\n";
                    
                    if(under50list.Count > 0){
                        allInfo += String.Join("\n", under50list.ToArray());
                        allInfo += "\n" + under50list.Count + under50string + "\n";
                    } 

                    if(from50to99list.Count > 0){
                        allInfo += String.Join("\n", from50to99list.ToArray());
                        allInfo += "\n" + from50to99list.Count + from50to99string + "\n";
                    } 

                    if(from99to199list.Count > 0){
                        allInfo += String.Join("\n", from99to199list.ToArray());
                        allInfo += "\n" + from99to199list.Count + from99to199string + "\n";
                    }

                    if(over199list.Count > 0){
                        allInfo += String.Join("\n", over199list.ToArray());
                        allInfo += "\n" + over199list.Count + over199string + "\n";
                    }
                    
                Console.WriteLine(allInfo);
                WriteToFile(allInfo); 
                break;               
                }
            }
        }

        // Method that creates and writes the information to a text file
        private static void WriteToFile( string test )  {
            StreamWriter File = new StreamWriter("Information.txt");
            File.WriteLine(test);
            File.Close();
        }
    }
}
