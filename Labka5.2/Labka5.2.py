import datetime


# --- Ієрархія класів ---
#
#       Товар (базовий клас)
#         /       \
#   Продукт     Іграшка (похідні класи)
#      |
# Молочний продукт (похідний клас)
#

# 1. Базовий клас
class Good:
    """Базовий клас, що описує загальний товар."""

    def __init__(self, name="Невідомо", price=0.0, barcode="N/A"):
        """Конструктор для ініціалізації об'єкта."""
        print(f"Конструктор Good для '{name}'")
        self.name = name
        self.price = price
        self.barcode = barcode

    def __del__(self):
        """Деструктор, який викликається при видаленні об'єкта."""
        # Замініть "ПІБ Студента" на ваше власне прізвище, ім'я та по-батькові
        print(f"\nДеструктор для {self.name}:")
        print("Лабораторна робота виконана студентом 2 курсу <ПІБ Студента>.")

    # В Python немає прямого перевантаження конструкторів, як у C#.
    # Тому ми імітуємо "конструктор перезавантаження" (копіювання) за допомогою методу класу.
    @classmethod
    def from_instance(cls, instance):
        """Конструктор копіювання (перезавантаження)."""
        return cls(instance.name, instance.price, instance.barcode)

    def get_info(self):
        """Загальний метод, який буде перевизначено в нащадках."""
        return "Це загальний товар."

    def show(self):
        """Метод для виведення інформації про об'єкт."""
        print("--- Інформація про товар ---")
        print(f"Назва: {self.name}")
        print(f"Ціна: {self.price} грн")
        print(f"Штрих-код: {self.barcode}")

# 2. Похідний клас від Good
class Product(Good):
    """Описує харчовий продукт."""

    def __init__(self, name="Продукт", price=0.0, barcode="N/A", expiration_days=0):
        """Конструктор для ініціалізації об'єкта."""
        super().__init__(name, price, barcode)  # Виклик конструктора базового класу
        print(f"Конструктор Product для '{name}'")
        self.expiration_date = datetime.date.today() + datetime.timedelta(days=expiration_days)
        self.calories = 0
        self.weight_grams = 0

    @classmethod
    def from_instance(cls, instance):
        """Конструктор копіювання (перезавантаження)."""
        new_instance = cls(instance.name, instance.price, instance.barcode)
        new_instance.expiration_date = instance.expiration_date
        new_instance.calories = instance.calories
        new_instance.weight_grams = instance.weight_grams
        return new_instance

    def get_info(self):
        """Перевизначення методу базового класу."""
        return "Це харчовий продукт."

    def show(self):
        """Розширення методу Show() базового класу."""
        super().show()
        print(f"Термін придатності: {self.expiration_date.strftime('%d.%m.%Y')}")
        print(f"Калорійність: {self.calories} ккал")
        print(f"Вага: {self.weight_grams} г")


# 3. Похідний клас від Product
class DairyProduct(Product):
    """Описує молочний продукт."""

    def __init__(self, name="Молочний продукт", price=0.0, barcode="N/A", expiration_days=7, fat_content=3.2):
        """Конструктор для ініціалізації об'єкта."""
        super().__init__(name, price, barcode, expiration_days)
        print(f"Конструктор DairyProduct для '{name}'")
        self.fat_content_percentage = fat_content
        self.is_lactose_free = False
        self.storage_temperature = "+4°C"

    @classmethod
    def from_instance(cls, instance):
        """Конструктор копіювання (перезавантаження)."""
        new_instance = super().from_instance(instance)  # Використовуємо копіювання з батьківського класу
        new_instance.fat_content_percentage = instance.fat_content_percentage
        new_instance.is_lactose_free = instance.is_lactose_free
        new_instance.storage_temperature = instance.storage_temperature
        return new_instance

    def get_info(self):
        """Перевизначення методу."""
        return "Це молочний продукт."

    def show(self):
        """Розширення методу Show()."""
        super().show()
        print(f"Жирність: {self.fat_content_percentage}%")
        print(f"Безлактозний: {'Так' if self.is_lactose_free else 'Ні'}")
        print(f"Температура зберігання: {self.storage_temperature}")


# 4. Ще один похідний клас від Good
class Toy(Good):
    """Описує іграшку."""

    def __init__(self, name="Іграшка", price=0.0, barcode="N/A", age_limit=3):
        """Конструктор для ініціалізації об'єкта."""
        super().__init__(name, price, barcode)
        print(f"Конструктор Toy для '{name}'")
        self.age_limit = age_limit
        self.material = "Пластик"
        self.manufacturer = "Невідомий"

    @classmethod
    def from_instance(cls, instance):
        """Конструктор копіювання (перезавантаження)."""
        new_instance = cls(instance.name, instance.price, instance.barcode, instance.age_limit)
        new_instance.material = instance.material
        new_instance.manufacturer = instance.manufacturer
        return new_instance

    def get_info(self):
        """Перевизначення методу."""
        return "Це іграшка для дітей."

    def show(self):
        """Розширення методу Show()."""
        super().show()
        print(f"Вікове обмеження: {self.age_limit}+")
        print(f"Матеріал: {self.material}")
        print(f"Виробник: {self.manufacturer}")


# --- Демонстрація роботи класів ---
if __name__ == "__main__":
    print("===== Демонстрація створення об'єктів =====")

    # 1. Створення об'єкта "Молоко" за допомогою конструктора ініціалізації
    milk = DairyProduct(name="Молоко 'Ферма'", price=45.50, barcode="4820012345678", expiration_days=10,
                        fat_content=2.5)
    milk.is_lactose_free = False
    milk.storage_temperature = "+2°C - +6°C"

    # 2. Створення об'єкта "Машинка"
    car = Toy(name="Спортивна машинка", price=250.0, barcode="5901234567890", age_limit=5)
    car.manufacturer = "Hot Wheels"

    print("\n\n===== Демонстрація методу Show() =====")
    milk.show()
    print("-" * 25)
    car.show()

    print("\n\n===== Демонстрація перевизначеного методу get_info() =====")
    print(f"Інформація про молоко: {milk.get_info()}")
    print(f"Інформація про машинку: {car.get_info()}")

    print("\n\n===== Демонстрація конструктора копіювання =====")
    # Створюємо копію об'єкта 'milk'
    kefir = DairyProduct.from_instance(milk)
    kefir.name = "Кефір 'Добриня'"  # Змінюємо деякі поля
    kefir.price = 42.0
    kefir.fat_content_percentage = 1.0

    print("Інформація про новий об'єкт (копію):")
    kefir.show()

    print("\n\n===== Завершення програми та виклик деструкторів =====")
    # Деструктори будуть викликані автоматично при завершенні роботи програми