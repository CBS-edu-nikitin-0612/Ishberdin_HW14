using System;
/// <summary>
/// Используя Visual Studio, создайте проект по шаблону Console Application.
///Требуется:
///Создайте класс DocumentWorker.
///В теле класса создайте три метода OpenDocument(), EditDocument(), SaveDocument().
///В тело каждого из методов добавьте вывод на экран соответствующих строк:
///"Документ открыт", "Редактирование документа доступно в версии Про", "Сохранение документа доступно в версии Про".
///Создайте производный класс ProDocumentWorker.
///Переопределите соответствующие методы, при переопределении методов выводите следующие строки:
///"Документ отредактирован", "Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт".
///Создайте производный класс ExpertDocumentWorker от базового класса ProDocumentWorker.
///Переопределите соответствующий метод. При вызове данного метода необходимо выводить на экран "Документ сохранен в новом формате".
///В теле метода Main() реализуйте возможность приема от пользователя номера ключа доступа pro и exp.
///Если пользователь не вводит ключ, он может пользоваться только бесплатной версией (создается экземпляр базового класса),
///если пользователь ввел номера ключа доступа pro и exp, то должен создаться экземпляр соответствующей версии класса, приведенный к базовому – DocumentWorker.
/// </summary>
namespace Task4
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                string inPut;
                DocumentWorker documentWorker;
                Console.WriteLine("Введите ключ: ");
                inPut = Console.ReadLine();
                switch (inPut)
                {
                    case "pro":
                        documentWorker = new ProDocumentWorker();
                        break;
                    case "exp":
                        documentWorker = new ExpertDocumentWorker();
                        break;
                    default:
                        documentWorker = new DocumentWorker();
                        break;
                }
                if (inPut == "exit")
                {
                    break;
                }
                documentWorker.OpenDocument();
                documentWorker.EditDocument();
                documentWorker.SaveDocument();
            }
        }
    }
    class DocumentWorker
    {
        public virtual void OpenDocument()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void EditDocument()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void SaveDocument()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument()
        {
            Console.WriteLine("Документ отредактирован");
        }
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт");
        }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public override void SaveDocument()
        {
            Console.WriteLine("Документ сохранен в новом формате");
        }
    }
}
