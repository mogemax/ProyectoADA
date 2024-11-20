using System;
using System.Collections;
using System.ComponentModel;
using System.Xml;
namespace ConsoleApp1;

public class Class1
{
    public static void Main(string[] arg){
        //Structure validation
        int n=0;
        do{
            Console.Write("Enter the number of classes: ");
            n = int.Parse(Console.ReadLine());
            // Validate that the number of classes is greater than 5
            if(n<5){
                Console.WriteLine("Invalid number of classes. (Greater than 5)");
            }
        }while(n<5);
        Console.WriteLine("");
        //Structure declaration
        Class[] arr = new Class[n];
        // Call the menu function with the class array
        Menu(arr);
    }
    // Structure to hold class information
    struct Class
    {
        public string id; // Subject ID
        public string subject_name; // Subject
        public string teacher_name; // Teacher’s name
        public double[] hours; // How much time it takes
        public double total_hours; // Total hours of class in the week
        public double absences; // Allowed absences
    }
    // Method to display menu and handle user selection
    static void Menu(Class[] arr1){
        //flag declaration
        int band=0, opc=0;
        do{
        Console.WriteLine("     MENU    ");
        Console.WriteLine("1. Data capture.");
        Console.WriteLine("2. Results.");
        Console.WriteLine("3. End of program.");
        do{
            Console.Write("Choose an option: ");
            opc = int.Parse(Console.ReadLine());
            // Validate that the option is between 1 and 3
            if(opc<1||opc>3){
                Console.WriteLine("Invalid option. (Between 1 and 3).");
            }
        }while(opc<1||opc>3);
        Console.WriteLine("");
        switch(opc){
            case 1:
                Data(arr1); // Capture data
                band=1;
            break;
            case 2:
                if(band==1){
                    Results(arr1); // Show results
                }
                else{
                    Console.WriteLine("Enter data first.");
                }
            break;
            case 3:
            Console.WriteLine("End."); // End program
            break;
            }

        }while(opc<3);
    }

    // Method to capture data for each class
    static void Data(Class[] arr2){
        int n1 = arr2.Length;
        //Cycle to fill in class data
        for(int i=0;i<n1;i++){
            Console.Write("Enter the subject ID: ");
            arr2[i].id=Console.ReadLine();
            Console.Write("Enter the subject name: ");
            arr2[i].subject_name=Console.ReadLine();
            Console.Write("Enter the teacher name: ");
            arr2[i].teacher_name=Console.ReadLine();
            Console.WriteLine("");
            arr2[i].hours = new double[n1];
            do{
            //cycle to fill the hours array
            for(int j=0;j<5;j++){
                switch(j){
                    case 0:
                        do{
                            Console.Write("Enter the subject hours on Monday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            // Validate that the hours are between 0 and 3
                            if(arr2[i].hours[j]<0||arr2[i].hours[j]>3){
                                Console.WriteLine("Invalid number of hours (Between 1 and 3).");
                            }
                        }while(arr2[i].hours[j]<0||arr2[i].hours[j]>3);
                    break;
                    case 1:
                        do{
                            Console.Write("Enter the subject hours on Tuesday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            // Validate that the hours are between 0 and 3
                            if(arr2[i].hours[j]<0||arr2[i].hours[j]>3){
                                Console.WriteLine("Invalid number of hours (Between 1 and 3).");
                            }
                        }while(arr2[i].hours[j]<0||arr2[i].hours[j]>3);
                    break;
                    case 2:
                        do{
                            Console.Write("Enter the subject hours on Wednesday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            // Validate that the hours are between 0 and 3
                            if(arr2[i].hours[j]<0||arr2[i].hours[j]>3){
                                Console.WriteLine("Invalid number of hours (Between 1 and 3).");
                            }
                        }while(arr2[i].hours[j]<0||arr2[i].hours[j]>3);
                    break;
                    case 3:
                        do{
                            Console.Write("Enter the subject hours on Thursday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            // Validate that the hours are between 0 and 3
                            if(arr2[i].hours[j]<0||arr2[i].hours[j]>3){
                                Console.WriteLine("Invalid number of hours (Between 1 and 3).");
                            }
                        }while(arr2[i].hours[j]<0||arr2[i].hours[j]>3);
                    break;
                    case 4:
                        do{
                            Console.Write("Enter the subject hours on Friday: ");
                            arr2[i].hours[j]=double.Parse(Console.ReadLine());
                            // Validate that the hours are between 0 and 3
                            if(arr2[i].hours[j]<0||arr2[i].hours[j]>3){
                                Console.WriteLine("Invalid number of hours (Between 1 and 3).");
                            }
                        }while(arr2[i].hours[j]<0||arr2[i].hours[j]>3);
                    break;
                }
                //operation to calculate the total hours of the class in the week
                arr2[i].total_hours += arr2[i].hours[j];
            }
            // Validate that the total hours are at least 1
            if(arr2[i].total_hours<1){
                Console.WriteLine("You need a minimum of 1 hour of class");
            }
            }while(arr2[i].total_hours<1);
            Console.WriteLine("");
            arr2[i].absences = (arr2[i].total_hours*1.5); // Calculate absences based on total hours

        }
        

    }
    // Method to show results based on user selection
    static void Results(Class[] arr3){
        int op=0;
        do{
        Console.WriteLine("     SUBMENU     ");
        Console.WriteLine("1. Show full schedule.");
        Console.WriteLine("2. Search by id");
        Console.WriteLine("3. Names of the 5 teachers with the most class hours");
        Console.WriteLine("4. Return to menu.");
        do{
            Console.Write("Choose an option: ");
            op = int.Parse(Console.ReadLine());
            // Validate that the option is between 1 and 4
            if(op<1||op>4){
                Console.WriteLine("Invalid option. (Between 1 and 4).");
            }
        }while(op<1||op>4);
        switch(op){
            case 1:
                Schedule(arr3); // Show full schedule
            break;
            case 2:
                Search(arr3); // Search by ID
            break;
            case 3:
                Biggest(arr3); // Show top 5 teachers
            break;
            case 4:
                Console.WriteLine("Returning."); // Return to menu
            break;
        }
        }while(op<4);
    }
    // Method to display full schedule
    static void Schedule(Class[] arr4){
        int n = arr4.Length;
        //cycle to print matter data
        for(int i=0;i<n;i++){
            Console.WriteLine("\n\tClass "+(i+1)+": "+arr4[i].subject_name);
            Console.WriteLine("\tID: {0}\tTeacher: {1}",arr4[i].id,arr4[i].teacher_name);
            Console.WriteLine("\tTotal Hours: {0}\tAbsences: {1}\n",arr4[i].total_hours,arr4[i].absences);
            //Cycle to print only the days in which you have class
            for(int m=0;m<5;m++){
                switch(m){
                case 0:
                    if(arr4[i].hours[m]!=0){
                        Console.WriteLine("\t\tOn Monday you have "+arr4[i].hours[m]+" hours of "+arr4[i].subject_name);
                    }
                break;
                case 1:
                    if(arr4[i].hours[m]!=0){
                        Console.WriteLine("\t\tOn Tuesday you have "+arr4[i].hours[m]+" hours of "+arr4[i].subject_name);
                    }
                break;
                case 2:
                    if(arr4[i].hours[m]!=0){
                        Console.WriteLine("\t\tOn Wednesday you have "+arr4[i].hours[m]+" hours of "+arr4[i].subject_name);
                    }
                break;
                case 3:
                    if(arr4[i].hours[m]!=0){
                        Console.WriteLine("\t\tOn Thursday you have "+arr4[i].hours[m]+" hours of "+arr4[i].subject_name);
                    }
                break;
                case 4:
                    if(arr4[i].hours[m]!=0){
                        Console.WriteLine("\t\tOn Friday you have "+arr4[i].hours[m]+" hours of "+arr4[i].subject_name);
                    }
                break;
            }
            }
            Console.WriteLine("");
        }
    }
    // Method to search class by ID
    static void Search(Class[] arr5){
        int n1 = arr5.Length;
        int indice = -1;
        Console.Write("\nEnter the id of the class to search: ");
        string id = Console.ReadLine();
        //cycle to search the structure
        for(int m = 0;m<n1;m++){
            if(arr5[m].id==id){
                indice = m;
                Console.WriteLine("\tClass: "+arr5[m].subject_name);
                Console.WriteLine("\tID: {0}\tTeacher: {1}",arr5[m].id,arr5[m].teacher_name);
                Console.WriteLine("\tTotal Hours: {0}\tTotal Absences: {1}",arr5[m].total_hours,arr5[m].absences);
            }
        }
        // If the class is not found, show a message
        if(indice == -1){
                Console.WriteLine("Class not found.");
            }
    }
    // Method to find the top 5 teachers with the most class hours
    static void Biggest(Class[] arr6){
        int n2 = arr6.Length;
        Class aux;
        // Bubble sort to find the top 5 teachers with the most class hours
        for(int p=0;p<n2-1;p++){
            for(int q=0;q<n2-(p+1);q++){
                if(arr6[q].total_hours<arr6[q+1].total_hours){
                    aux = arr6[q+1];
                    arr6[q+1] = arr6[q];
                    arr6[q] = aux;
                }
            }
        }
        Console.Write("");
        // Display the top 5 teachers
        for(int r=0;r<5;r++){
            Console.WriteLine("Profesor: {0} \t Total Hours: {1}",arr6[r].teacher_name,arr6[r].total_hours);
        }
    }
}

