// See https://aka.ms/new-console-template for more information
using System.Linq;
using ClassDemo;






List<Student> GetALLStudent()
{
    List<Student> students = new List<Student>();

    students.Add(new Student { RollNo = 101, Name = "Demo", Age = 20, Branch = "CSE", Cpi = 10, Sem = 3 });

    students.Add(new Student { RollNo = 102, Name = "jay", Age = 21, Branch = "CE", Cpi = 6.5, Sem = 2 });

    students.Add(new Student { RollNo = 103, Name = "asdE", Age = 20, Branch = "ME", Cpi = 5.5, Sem = 3 });

    students.Add(new Student { RollNo = 104, Name = "Raj", Age = 22, Branch = "CSE", Cpi = 2.5, Sem = 5 });

    students.Add(new Student { RollNo = 105, Name = "viru", Age = 20, Branch = "ME", Cpi = 7.5, Sem = 6 });

    return students;

}
static List<Course> GetCourses()
{
    return new List<Course>
            {
                new Course { Rno=101, CourseName="Data Structures", Credits=4 },
                new Course { Rno=101, CourseName="Algorithms", Credits=3 },
                new Course { Rno=102, CourseName="Circuit Design", Credits=4 },
                new Course { Rno=103, CourseName="Mechanics", Credits=3 },
                new Course { Rno=104, CourseName="Electronics", Credits=4 },
                new Course { Rno=105, CourseName="Database Systems", Credits=3 },
                new Course { Rno=106, CourseName="Thermodynamics", Credits=3 },
                new Course { Rno=107, CourseName="Power Systems", Credits=4 },
                new Course { Rno=108, CourseName="Operating Systems", Credits=4 },
                new Course { Rno=109, CourseName="Software Engineering", Credits=3 },
                new Course { Rno=110, CourseName="AI", Credits=4 },
                new Course { Rno=111, CourseName="Networking", Credits=3 },
                new Course { Rno=112, CourseName="Fluid Mechanics", Credits=3 },
                new Course { Rno=113, CourseName="Machine Learning", Credits=4 },
                new Course { Rno=114, CourseName="Robotics", Credits=3 }
            };
}

var students = GetALLStudent();
var courses = GetCourses();
//Console.WriteLine("=======================================");
//foreach (Student student in students)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch}, CPI: {student.Cpi} , sem : {student.Sem}");
//}


//Console.WriteLine("=======================================");
//// get all student gt 8
//var greatherthan = students.Where(s => s.Cpi > 8.0f).ToList();
//foreach (Student student in greatherthan)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch}, CPI: {student.Cpi}");
//}


//Console.WriteLine("=======================================");
//// get all student lt 8
//var leasthan = students.Where(s => s.Cpi < 8.0f).ToList();
//foreach (Student student in leasthan)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch}, CPI: {student.Cpi}");
//}



//Console.WriteLine("=======================================");
//// get all student between 7 & 8
//var between = students.Where(s => s.Cpi > 7.0f &&  s.Cpi < 8.0f ).ToList();
//foreach (Student student in between)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch}, CPI: {student.Cpi}");
//}

//Console.WriteLine("==============sem 3  & cpi > 8=================");
//// get all student between 7 & 8
//var demo = students.Where(s => s.Sem == 3 || s.Cpi <= 8.0f).ToList();
//foreach (Student student in demo)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}

//Console.WriteLine("==============name start with R================");
//// get all student between 7 & 8
//var namer = students.Where(s => s.Name.StartsWith("R")).ToList();
//foreach (Student student in namer)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}

//Console.WriteLine("==============name contain E with sem 3 ================");
//// get all student between 7 & 8
//var namee = students.Where(s => s.Name.Contains("E") && s.Sem==3).ToList();
//foreach (Student student in namee)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}
//Console.WriteLine("==============name contain E with sem 3 ====== roll no name branch sem ==========");
//// get all student between 7 & 8
//var nameselect = students.Where(s => s.Name.Contains("E") && s.Sem == 3).ToList();
//foreach (Student student in namee)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name} , Branch: {student.Branch},sem : {student.Sem}");
//}



//Console.WriteLine("==============name end H with sem 3 ================");
//// get all student between 7 & 8
//var endwithh = students.Where(s => s.Name.EndsWith("H") && s.Sem == 3).ToList();
//foreach (Student student in endwithh)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}

//Console.WriteLine("==============MAx cpi  ================");
//// get all student between 7 & 8
//var Maxcpi = students.Max(s => s.Cpi);
//Console.WriteLine(Maxcpi.ToString());


//Console.WriteLine("==============Min cpi  ================");
//// get all student between 7 & 8
//var Mincpi = students.Min(s => s.Cpi);
//Console.WriteLine(Mincpi.ToString());


//Console.WriteLine("==============Avg cpi  ================");
//// get all student between 7 & 8
//var avg = students.Average(s => s.Cpi);
//Console.WriteLine(avg.ToString());

////Console.WriteLine("==============sum cpi  ================");
////// get all student between 7 & 8
////var sumcpi = students.(s => s.Cpi);
////Console.WriteLine(sumcpi.ToString());.


//Console.WriteLine("==============gt > 8 and sem = 3 orderby bus  cpi  ================");

//var oredrby = students.Where(s => s.Cpi > 8 && s.Sem == 3).OrderByDescending(s => s.RollNo).ToList();
//foreach (Student student in oredrby)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}

//Console.WriteLine("==============gt > 8 andthenby pi  ================");

//var thenBy = students.Where(s => s.Cpi > 3 ).OrderByDescending(s => s.RollNo).ThenBy(s => s.Branch).ToList();
//foreach (Student student in thenBy)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}

//Console.WriteLine("==============skip 3 and take 3 ================");

//var skip = students.Skip(3).Take(3);
//foreach (Student student in skip)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}



//Console.WriteLine("==============take  3  ================");

//var take = students.Take(3);
//foreach (Student student in take)
//{
//    Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, Branch: {student.Branch},sem : {student.Sem}, CPI: {student.Cpi}");
//}



//Console.WriteLine("============== Group by Branch and Sem ===============");

//var groupBy = students.GroupBy(s => new { s.Branch, s.Sem });

//foreach (var group in groupBy)
//{
//    Console.WriteLine($"Branch: {group.Key.Branch}, Sem: {group.Key.Sem} ");

//    foreach (var student in group)
//    {
//        Console.WriteLine($"Rno: {student.RollNo}, Name: {student.Name}, Age: {student.Age}, CPI: {student.Cpi}");
//    }
//}


//Console.WriteLine("-------------------------- Group by Branch,sem and count of that ------------------------");
//var stu3 = students.GroupBy(s => new { s.Branch, s.Sem })
//    .Select(g => new { g.Key.Branch, g.Key.Sem, Count = g.Count() }).ToList();
//foreach (var group in stu3)
//{
//    Console.WriteLine($"Branch: {group.Branch}, Sem: {group.Sem}, Count: {group.Count}");
//}

//// 15. Students Ordered by CPI Descending 
//Console.WriteLine("15. Students Ordered by CPI Descending:");
//var orderedByCpiDescending = students.OrderByDescending(s => s.Cpi);
//Console.WriteLine(string.Join(Environment.NewLine,
//    orderedByCpiDescending.Select(s => $"Rno: {s.RollNo}, Name: {s.Name}, Branch: {s.Branch}, Sem: {s.Sem}, CPI: {s.Cpi}, Age: {s.Age} ")));


// 99. Group Students by Branch and Sem with Total Course Credits 
Console.WriteLine("99. Group Students by Branch and Sem with Total Course Credits:");
var totalCreditsByBranchSem = students.Join(courses, s => s.RollNo, c => c.Rno, (s, c) => (Student: s, Course: c))
    .GroupBy(sc => (sc.Student.Branch, sc.Student.Sem))
    .Select(g => (g.Key.Branch, g.Key.Sem, TotalCredits: g.Sum(sc => sc.Course.Credits)));
Console.WriteLine(string.Join(Environment.NewLine, totalCreditsByBranchSem
    .Select(g => $"Branch: {g.Branch}, Sem: {g.Sem}, Total Credits: {g.TotalCredits}")));


// 100. Join Students with Courses, Select Students with Multiple Courses 
Console.WriteLine("100. Join Students with Courses, Select Students with Multiple Courses:");
var studentsWithMultipleCourses = students.GroupJoin(courses, s => s.RollNo, c => c.Rno,
    (s, cs) => (Student: s, CourseCount: cs.Count()));
Console.WriteLine(string.Join(Environment.NewLine, studentsWithMultipleCourses
    .Select(sc => $"Rno: {sc.Student.RollNo}, Name: {sc.Student.Name}, Course Count: {sc.CourseCount}")));