using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application. Требуется: 
/// Создать класс, представляющий учебный класс ClassRoom. 
/// Создайте класс ученик Pupil. 
/// В теле класса создайте методы void Study(), void Read(), void Write(), void Relax(). 
/// Создайте 3 производных класса ExcelentPupil, GoodPupil, BadPupil от класса базового класса Pupil и переопределите каждый из методов, в зависимости от успеваемости ученика. 
/// Конструктор класса ClassRoom принимает аргументы типа Pupil, класс должен состоять из 4 учеников. 
/// Предусмотрите возможность того, что пользователь может передать 2 или 3 аргумента. 
/// Выведите информацию о том, как все ученики экземпляра класса ClassRoom умеют учиться, читать, писать, отдыхать. 
/// </summary>
namespace Task2
{
    class Program
    {
        static void Main()
        {
        }
    }
    class ClassRoom
    {
        public Pupil[] pupils = new Pupil[4];
        ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3, Pupil pupil4)
        {
            pupils[0] = pupil1;
            pupils[1] = pupil2;
            pupils[2] = pupil3;
            pupils[3] = pupil4;
        }
        ClassRoom(Pupil pupil1, Pupil pupil2, Pupil pupil3)
        {
            new ClassRoom(pupil1, pupil2, pupil3, new Pupil());
        }
        ClassRoom(Pupil pupil1, Pupil pupil2)
        {
            new ClassRoom(pupil1, pupil2, new Pupil(), new Pupil());
        }
        public void Study()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Study();
            }
        }
        public void Read()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Read();
            }
        }
        public void Write()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Write();
            }
        }
        public void Relax()
        {
            foreach (Pupil pupil in pupils)
            {
                pupil.Relax();
            }
        }

    }
    class Pupil
    {
        public void Study()
        => Console.WriteLine("Normal study");
        public void Read()
        => Console.WriteLine("Normal read");
        public void Write()
        => Console.WriteLine("Normal write");
        public void Relax()
        => Console.WriteLine("Normal relax");
    }
    class ExcelentPupil : Pupil
    {
        public new void Study() => Console.WriteLine("Excelent study");
        public new void Read() => Console.WriteLine("Excelent read");
        public new void Write() => Console.WriteLine("Excelent write");
        public new void Relax()
        => Console.WriteLine("Excelent relax");
    }
    class GoodPupil : Pupil
    {
        public new void Study() => Console.WriteLine("Good study");
        public new void Read() => Console.WriteLine("Good read");
        public new void Write() => Console.WriteLine("Good write");
        public new void Relax() => Console.WriteLine("Good relax");
    }
    class BadPupil : Pupil
    {
        public new void Study() => Console.WriteLine("Bad study");
        public new void Read() => Console.WriteLine("Bad read");
        public new void Write() => Console.WriteLine("Bad write");
        public new void Relax() => Console.WriteLine("Bad relax");
    }
}
