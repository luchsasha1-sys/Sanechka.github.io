namespace Labka5n3
{
    public class Tractor : Transport
    {
        // Додаткове поле
        protected int wheels;

        // Конструктор спадкоємця
        public Tractor(string marka, int cylinders, int power, int maxSpeed, int wheels)
            : base(marka, cylinders, power, maxSpeed) // Передаємо 4 параметри "батьку"
        {
            this.wheels = wheels; // 1 залишаємо собі
        }

        // МЕТОД 1 (ПЕРЕВИЗНАЧЕНИЙ)
        public override int GetPayload()
        {
            // (потужність * число циліндрів) + 50
            return base.GetPayload() + 50;
        }

        // МЕТОД 2 (ПЕРЕВИЗНАЧЕНИЙ)
        public override void UpdateModel()
        {
            // Спочатку викликаємо базовий метод
            base.UpdateModel();
            // Потім додаємо свою логіку
            marka += " Сільськогосподарський транспорт";
        }
    }
}