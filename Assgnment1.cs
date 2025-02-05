using System;

class Computer{

    private string brand;
    private string model;
    private double price;
    private long SN;

    private static int count = 0;

    public Computer(string brand, string model, double price, long SN){
        this.brand = brand;
        this.model = model;
        this.price = price;
        this.SN = SN;
        count++;
    }

    public int getBrand(){
        return count;
    }

    public string getModel(){
        return model;
    }

    public double getPrice(){
        return price;
    }

    public long getSN(){
        return SN;
    }

    public void setBrand(string brand){
        this.brand = brand;
    }

    public void setModel(string model){
        this.model = model;
    }

    public void setPrice(double price){
        this.price = price;
    }

    public void setSN(long SN){
        this.SN = SN;
    }

    public override string ToString(){
        return $"Brand: {brand}\nModel: {model}\nPrice: {price:C}\nSerial Number: {SN}";
    }
    //findNumberOfCreatedComputers()

    public static int findNumberOfCreatedComputers(){
        return count;
    }
    //jsdhf

}



class ComputerStore{

    const string PASSWORD = "PASSWORD";

    static Computer[] inventory;

    static void Main(){
            
            Console.WriteLine("Welcome to the computer store!");
            Console.WriteLine("Enter the maximum number of computers:");
            int maxOfComputers = Convert.ToInt32(Console.ReadLine());

            inventory = new Computer[maxOfComputers];

            int choice;

            do{
                Console.WriteLine("\nMain Menu");
                Console.WriteLine("1. Add New computer");
                Console.WriteLine("2. Update Computer");
                Console.WriteLine("3. Search by Brand");
                Console.WriteLine("4.  Search by Price");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice:");
                
                while(!int.TryParse(Console.ReadLine(),out choice) || choice<1 || choice > 5){
                    Console.WriteLine("Invalid Input Try again");

                     switch (choice)
                         {
                            case 1: AddComputers(); break;
                           // case 2: UpdateComputer(); break;
                           // case 3: SearchByBrand(); break;
                           // case 4: SearchByPrice(); break;
                            case 5: Console.WriteLine("Exiting program. Goodbye!"); break;
                        }
                }

            } while(choice != 5);


        }
        static bool Authenticate()
    {
        int attempts = 3;
        while (attempts > 0)
        {
            Console.Write("Enter password: ");
            string input = Console.ReadLine();
            if (input == PASSWORD) return true;
            attempts--;
            Console.WriteLine($"Incorrect password. {attempts} attempts remaining.");
        }
        return false;
    }

    static void AddComputers()
    {
        if (!Authenticate()) return;

        Console.Write("How many computers do you want to add? ");
        int count = int.Parse(Console.ReadLine());

        int availableSpace = 0;
        foreach (var comp in inventory) if (comp == null) availableSpace++;
        
        if (count > availableSpace)
        {
            Console.WriteLine($"Not enough space! You can only add {availableSpace} more computers.");
            return;
        }

        for (int i = 0; i < inventory.Length; i++)
        {
            if (inventory[i] == null && count > 0)
            {
                Console.Write("Enter brand: ");
                string brand = Console.ReadLine();
                Console.Write("Enter model: ");
                string model = Console.ReadLine();
                Console.Write("Enter serial number: ");
                long SN = long.Parse(Console.ReadLine());
                Console.Write("Enter price: ");
                double price = double.Parse(Console.ReadLine());

                inventory[i] = new Computer(brand, model, price, SN);
                count--;
                Console.WriteLine("Computer added successfully!");
            }
        }
    }
    
}