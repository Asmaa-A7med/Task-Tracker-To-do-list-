namespace TaskTrackerProj
{
    internal class Program
    {
        //create array of tasks
        static string[] tasks = new string[100];
        static int TaskInx = 0;

        //methode for Adding a task
        private static void AddTask()
        {
            Console.WriteLine(" Enter task title : ");
            string taskTitle=Console.ReadLine();

            tasks[TaskInx] = taskTitle;
            Console.WriteLine("your task added");
            TaskInx++;
        }

        //Methode for view tasks
        private static void ViewTasks()
        {
            Console.WriteLine(" Tasks List : ");
            for(int i=0;i<TaskInx;i++)
            {
                Console.WriteLine($"Task title {i+1} :{tasks[i]}");
            }
        }

        //methode fir Mark Task
        private static void MarkCompleted()
        {
            Console.WriteLine(" Enter task number ");
            string taskNumber=Console.ReadLine();
            int taskId=Convert.ToInt32(taskNumber);

            tasks[taskId] = tasks[taskId] + " completed !";
        }

        //remove task 
        private static void DeleteTask()
        {
            Console.WriteLine(" Enter task number ");
            string taskNumber = Console.ReadLine();
            int taskId = Convert.ToInt32(taskNumber);

            tasks[taskId] = string.Empty;
        }

        static void Main(string[] args)
        {
            //welcom user
            Console.WriteLine("Welcome to task tracker ");


            while(true)
            {
                Console.WriteLine("Enter your choise from 1 to 5 ");
                Console.WriteLine("1: Add ask \n2: view tasks\n3: task mark\n4: remove task\n5: Exit");

                string UserChoise = Console.ReadLine();
                //use switch to handel task
                switch (UserChoise)
                {
                    //Add task
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        ViewTasks();
                        break;

                    case "3":
                        MarkCompleted();
                        break;

                    case "4":
                        DeleteTask();
                        break;

                    case "5":
                        //exit
                        //use the environment with exit method to exit the loop
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("please enter number from 1 to 5");
                        break;
                }
            }
           


        }
    }
}

















/// task tracker || to do list 
/// welcom user 
/// handel tasks (add new |view tasks | delete | mark task | exit )