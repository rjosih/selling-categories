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
                    Console.WriteLine(mall + "\n");
                    
                    if(under50list.Count > 0){
                        PrintValues( under50list );
                        Console.WriteLine(under50list.Count + under50string);
                    } 

                    if(from50to99list.Count > 0){
                        PrintValues(from50to99list);
                        Console.WriteLine(from50to99list.Count + from50to99string);
                    } 

                    if(from99to199list.Count > 0){
                        PrintValues(from99to199list);
                        Console.WriteLine(from99to199list.Count + from99to199string);
                    }

                    if(over199list.Count > 0){
                        PrintValues(over199list);
                        Console.WriteLine(over199list.Count + over199string);
                    }

                    string test = "Test";
                    WriteToFile(test); 
                break;               
                }
            }
        }
        
        // Method that prints all objects in the given ArrayList
        public static void PrintValues( IEnumerable arrayList )  {
        foreach ( Object obj in arrayList )
            Console.WriteLine("   {0}", obj);
        }

        // Method that creates and writes the information to a text file
        private static void WriteToFile( string test )  {
            StreamWriter File = new StreamWriter("Information.txt");
            File.WriteLine(test);
            File.Close();
        }
    }
}
