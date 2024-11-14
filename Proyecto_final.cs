namespace ConsoleApp1;

public class Class1
{
    public static void main(string arg[]){
        //Structure validation
        int n=0;
        do{
            Console.Write("Enter the number of classes: ");
            n = int.Parse(Console.ReadLine());
            if(n<5){
                Console.WriteLine("Invalid number of classes. (Greater than 5)");
            }
        }while(n<5);

        Class[] arr = new Class[n];

        Menu(arr);
    }
    struct Class
    {
        public string id;
        public string subject_name;
        public string teacher_name;
        public double[] hours;
        public double total_hours;
        public double absences;
    }
    static void Menu(Class[] arr1){
        int band=0, opc=0;
        do{
        Console.WriteLine("     MENU    ");
        Console.WriteLine("1. Data capture.");
        Console.WriteLine("2. Results.");
        Console.WriteLine("3. End of program.");
        do{
            Console.Write("Choose an option: ");
            opc = int.Parse(Console.ReadLine()):
            if(opc<1||opc>3){
                Console.WriteLine("Invalid option. (Between 1 and 3).");
            }
        }while(opc<1||opc>3);
        
        switch(opc){
            case 1:
                Data(arr1);
            break;
            case 2:
                if(band==1){
                    Results(arr1);
                }
                else{
                    Console.WriteLine("Enter data first.");
                }
            break;
            case 3:
            Console.WriteLine("End.");
            break;
            }

        }while(opc<3);
    }

    static void Data(Class[] arr2){
        int n1 = arr2.Lenght;
        for(int i=0;i<n1;i++){
            Console.Write("Enter the subject ID: ");
            arr2[i].id=Console.ReadLine();
            Console.Write("Enter the subject name: ");
            arr2[i].subject_name=Console.ReadLine();\
            Console.Write("Enter the teacher name: ");
            arr2[i].teacher_name=Console.ReadLine();

            arr2[i].hours = new int[n1];

            for(int j=0;j<5;j++){
                switch(){
                    case 1:
                        do{
                            Console.Write("Enter the subject hours on Monday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            if(arr2[i].hours[j]<1||arr2[i].hours[j]>3){
                                Console.Write("Invalid number of hours.");
                            }
                        }while(arr2[i].hours[j]<1||arr2[i].hours[j]>3);
                    break;
                    case 2:
                        do{
                            Console.Write("Enter the subject hours on Tuesday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            if(arr2[i].hours[j]<1||arr2[i].hours[j]>3){
                                Console.Write("Invalid number of hours.");
                            }
                        }while(arr2[i].hours[j]<1||arr2[i].hours[j]>3);
                    break;
                    case 3:
                        do{
                            Console.Write("Enter the subject hours on Wednesday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            if(arr2[i].hours[j]<1||arr2[i].hours[j]>3){
                                Console.Write("Invalid number of hours.");
                            }
                        }while(arr2[i].hours[j]<1||arr2[i].hours[j]>3);
                    break;
                    case 4:
                        do{
                            Console.Write("Enter the subject hours on Thursday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            if(arr2[i].hours[j]<1||arr2[i].hours[j]>3){
                                Console.Write("Invalid number of hours.");
                            }
                        }while(arr2[i].hours[j]<1||arr2[i].hours[j]>3);
                    break;
                    case 5:
                        do{
                            Console.Write("Enter the subject hours on Friday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            if(arr2[i].hours[j]<1||arr2[i].hours[j]>3){
                                Console.Write("Invalid number of hours.");
                            }
                        }while(arr2[i].hours[j]<1||arr2[i].hours[j]>3);
                    break;
                }
                arr2[i].total_hours += arr2[i].hours[j];
            }

            arr2[i].absences = (arr2[i].total_hours*1.5);

        }
        

    }
    static void Results(Class[] arr3){
        int op=0;
        do{
        Console.WriteLine("     SUBMENU     ");
        Console.WriteLine("1. Show full schedule.");
        Console.WriteLine("2. Search by id");
        Console.WriteLine("3. Names of the 5 teachers with the most class hours");
        Console.WriteLine("4. Return to menu.")
        do{
            Console.Write("Choose an option: ");
            op = int.Parse(Console.ReadLine()):
            if(op<1||op>4){
                Console.WriteLine("Invalid option. (Between 1 and 4).");
            }
        }while(op<1||op>4);
        switch(op){
            case 1:
                Schedule(arr3);
            break;
            case 2:
                Search(arr3);
            break;
            case 3:
                Biggest(arr3);
            break;
            case 4:
                Console.WriteLine("Returning.");
            break;
        }
        }while(op<4);
    }
    static void Schedule(Class[] arr4){
        
    }
    static void Search(Class[] arr5){

    }
    static void Biggest(Class[] arr6){

    }
}

