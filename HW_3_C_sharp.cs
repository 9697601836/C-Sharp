using System;
// Создается событие UserEvent, являющееся членом делегата UI.
// Обработчик данного события определяется в классе UserInfo, и добавляется с помощью синтаксиса +=
namespace MyThirdSharpProgram
{
    delegate void UI ();

    class MyEvent
    {
        // Объявляем событие
        public event UI UserEvent;

        // Используем метод для запуска события
        public void OnUserEvent()
        {
            UserEvent();
        }
    }

    class UserInfo
    {
        string uiName, uiFamily;
        int uiAge;

        public UserInfo(string Name, string Family, int Age)
        {
            this.Name = Name;
            this.Family = Family;
            this.Age = Age;
        }

        public string Name { set { uiName = value; } get { return uiName; } }
        public string Family { set { uiFamily = value; } get { return uiFamily; } }
        public int Age { set { uiAge = value; } get { return uiAge; } }

        // Обработчик события
        public void UserInfoHandler()
        {
            Console.WriteLine("Событие вызвано!\n");
            Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}",Name,Family,Age);
        }
    }

    class Program
    {
        static void Main()
        {
            MyEvent evt = new MyEvent();
            UserInfo user1 = new UserInfo(Name: "Иван", Family: "Быков", Age: 26);

            // Добавляем обработчик события
            evt.UserEvent += user1.UserInfoHandler;
           
            // Запустим событие
            evt.OnUserEvent();

            Console.ReadLine();
        }
    }
}