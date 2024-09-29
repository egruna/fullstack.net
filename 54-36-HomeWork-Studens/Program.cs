/*---
 * تعداد کل دانش اموزان سوال شود و بعد به تعدار از کاربر اسم بگسرد
نگهداری کل دانش آموزان کلاس
نام دانش اموز بتواند در لیست وارد کند   
مشاهده کل لیست دانش آموزان
امکان ورود معدل برای هر دانش آموز
امکان مشاده معدل کل کلاس
بعد از انتخاب هر دانش آموز معذل آن قابل نمایش باشد
---*/
Console.WriteLine("Welcome To Student App:");
Console.WriteLine("Enter the Number Of students:");
//int studentNumber = 1;
int studentNumber=int.Parse(Console.ReadLine());
List<(string Name, double Grade)> students = new List<(string, double)>();
string studentName = "student1";
double gradeOfStudent = 12.2;
double allsum = 0;
for (int i = 0; i < studentNumber; i++)
{
    Console.Write($"Enter Student name:{i+1} =");
     studentName=Console.ReadLine();
    Console.Write($"Enter Student Grade:{i+1} =");
    gradeOfStudent =double.Parse(Console.ReadLine());
    

    students.Add((studentName, gradeOfStudent));
    allsum += gradeOfStudent;
}
 for (int i = 0;i < studentNumber; i++)
{
    Console.WriteLine(students[i]);
}

Console.WriteLine($"average of class is:{classAverage(studentNumber, allsum)}");
//double classAverage = 0;
static double classAverage(int allNumber, double allSum)
{
    return (allSum/allNumber);
}
Console.ReadLine();
