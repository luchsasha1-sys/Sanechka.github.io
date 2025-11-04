namespace Labka5n3
{
    public class Truck : Transport
    {
        // Додаткове поле
        protected int weight;

        // Конструктор спадкоємця
        public Truck(string marka, int cylinders, int power, int maxSpeed, int weight)
            : base(marka, cylinders, power, maxSpeed) // Передаємо 4 параметри "батьку"
        {
            this.weight = weight; // 1 залишаємо собі
        }

        // МЕТОД 1 (ПЕРЕВИЗНАЧЕНИЙ)
        public override int GetPayload()
        {
            // (потужність * число циліндрів) + 100
            // Ми можемо викликати базовий метод і додати 100
            return base.GetPayload() + 100;
        }

        // МЕТОД 2 (ПЕРЕВИЗНАЧЕНИЙ)
        public override void UpdateModel()
        {
            // Спочатку викликаємо базовий метод (щоб збільшити швидкість)
            base.UpdateModel();
            // Потім додаємо свою логіку
            marka += " Вантажний автомобіль";
        }
    }
}