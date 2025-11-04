namespace Labka5n3
{
    public class Transport
    {
        // Protected, щоб спадкоємці мали доступ
        protected string marka;
        protected int cylinders;
        protected int power;
        protected int maxSpeed;

        // Конструктор, який вимагає завдання
        public Transport(string marka, int cylinders, int power, int maxSpeed)
        {
            this.marka = marka;
            this.cylinders = cylinders;
            this.power = power;
            this.maxSpeed = maxSpeed;
        }

        // МЕТОД 1: Вантажопідйомність (робимо його VIRTUAL)
        public virtual int GetPayload()
        {
            return power * cylinders;
        }

        // МЕТОД 2: Оновлення моделі (робимо його VIRTUAL)
        public virtual void UpdateModel()
        {
            maxSpeed += 50;
        }

        // МЕТОД 3: Інформація
        // Цей метод НЕ віртуальний, але він буде поліморфним,
        // тому що він викликає GetPayload(), який є віртуальним.
        public string GetInfo()
        {
            // Викликаємо GetPayload() - C# сам визначить, яку версію
            // (базову, від Вантажівки чи від Трактора) викликати.
            return $"Марка: {marka}, " +
                   $"Макс. швидкість: {maxSpeed} км/год, " +
                   $"Вантажопідйомність: {GetPayload()}";
        }
    }
}