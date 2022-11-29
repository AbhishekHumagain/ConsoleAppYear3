using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Year3ConsoleApp.Week5
{
    public class ListData
    {
        public static void Newlist()
        {
            List<SampleModel> list = new List<SampleModel>
            {
                new SampleModel{TaskName = "Workshop1",  DueDate = DateTime.Now.AddDays(1), IsDone = true},
                new SampleModel{TaskName = "Workshop2",  DueDate = DateTime.Now.AddDays(2), IsDone = false},
                new SampleModel{TaskName = "Workshop3",  DueDate = DateTime.Now.AddDays(3), IsDone = true},
                new SampleModel{TaskName = "Workshop4",  DueDate = DateTime.Now.AddDays(4), IsDone = true},
                new SampleModel{TaskName = "Workshop5",  DueDate = DateTime.Now.AddDays(5), IsDone = false},
                new SampleModel{TaskName = "Workshop6",  DueDate = DateTime.Now.AddDays(6), IsDone = true},
                new SampleModel{TaskName = "Workshop7",  DueDate = DateTime.Now.AddDays(7), IsDone = false},
                new SampleModel{TaskName = "Workshop8",  DueDate = DateTime.Now.AddDays(8), IsDone = true},
                new SampleModel{TaskName = "Workshop9",  DueDate = DateTime.Now.AddDays(9), IsDone = false},
                new SampleModel{TaskName = "Workshop10", DueDate = DateTime.Now.AddDays(10), IsDone = true},
               
            };

            //searching
            List<SampleModel> searchList = list.Where(x => x.IsDone == false).ToList();

            Console.WriteLine(searchList); //throws error
            Console.WriteLine(searchList.Select(x => x.TaskName).FirstOrDefault());

            foreach (var item in searchList)
            {
                Console.WriteLine(item.TaskName + "," + item.IsDone);
            }

            List<SampleModel> searchList1 = list.Where(x => x.TaskName.Contains("Workshop10")).ToList();

            //sorting
            Console.WriteLine("This is Sorting");
            List<SampleModel> sortList = list.OrderBy(x => x.CreatedAt).ToList();
            List<SampleModel> sortList1 = list.OrderByDescending(x => x.CreatedAt).ToList();

            //project
            List<Guid> selectList = list.Where(x => !x.IsDone).Select(x => x.Id).ToList();


        }
    }
}
