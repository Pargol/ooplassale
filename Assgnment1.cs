using System;

class Computer{

    private string brand;
    private string model;
    private int price;
    private long SN;

    private static int count = 0;

    public Computer(string brand, string model, int price, long SN){
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

    public int getPrice(){
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

    public void setPrice(int price){
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

}



class ComputerStore{

    const string password = "PASSWORD";

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
                    continue;
                }

            } while(choice != 5);


        }
    
}