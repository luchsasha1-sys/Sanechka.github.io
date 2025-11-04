import tkinter as tk
from tkinter import ttk, messagebox
from abc import ABC, abstractmethod


# --- 1. ІЄРАРХІЯ КЛАСІВ (з ABC) ---

class Transport(ABC):
    """
    Абстрактний базовий клас: Транспорт.
    Містить 4 методи: 2 абстрактних, 2 звичайних.
    """

    def __init__(self, name, max_speed, payload):
        self.name = name  # Назва/Марка
        self.max_speed = max_speed  # Макс. швидкість
        self.payload = payload  # Вантажопідйомність (ключове поле для пошуку)
        super().__init__()

    # --- Абстрактні методи (2) ---

    @abstractmethod
    def get_full_info(self):
        """
        Повинен бути реалізований нащадками.
        Повертає повну інформацію про об'єкт.
        """
        pass

    @abstractmethod
    def start_engine(self):
        """
        Повинен бути реалізований нащадками.
        Повертає рядок, що імітує звук запуску.
        """
        pass

    # --- Звичайні (конкретні) методи (2) ---

    def get_base_info(self):
        """
        Загальний метод, однаковий для всіх нащадків.
        Повертає базову інформацію.
        """
        return f"Назва: {self.name}, Макс. швидкість: {self.max_speed} км/год"

    def get_payload(self):
        """
        Загальний метод для доступу до поля вантажопідйомності.
        Потрібен для функції пошуку.
        """
        return self.payload


class Car(Transport):
    """
    Похідний клас: Автомобіль.
    """

    def __init__(self, name, max_speed, payload, color, doors):
        super().__init__(name, max_speed, payload)
        self.color = color  # Власне поле 1
        self.doors = doors  # Власне поле 2

    # --- Реалізація абстрактних методів ---

    def get_full_info(self):
        """
        Реалізація методу 'get_full_info'.
        """
        base_info = self.get_base_info()  # Використовуємо метод батька
        return (f"[АВТОМОБІЛЬ]\n"
                f"{base_info}\n"
                f"Вантажопідйомність: {self.get_payload()} кг\n"
                f"Колір: {self.color}, Кількість дверей: {self.doors}")

    def start_engine(self):
        """
        Реалізація методу 'start_engine'.
        """
        return f"{self.name} заводиться: Врум-врум!"

    # --- Власний метод (вимагався 1) ---

    def honk(self):
        """
        Власний унікальний метод класу Car.
        """
        return f"{self.name} сигналить: Бі-біп!"


class Train(Transport):
    """
    Похідний клас: Потяг.
    """

    def __init__(self, name, max_speed, payload, wagon_count, train_type):
        super().__init__(name, max_speed, payload)
        self.wagon_count = wagon_count  # Власне поле 1
        self.train_type = train_type  # Власне поле 2

    # --- Реалізація абстрактних методів ---

    def get_full_info(self):
        """
        Реалізація методу 'get_full_info'.
        """
        base_info = self.get_base_info()
        return (f"[ПОТЯГ]\n"
                f"{base_info}\n"
                f"Вантажопідйомність: {self.get_payload()} тонн\n"
                f"Тип: {self.train_type}, Кількість вагонів: {self.wagon_count}")

    def start_engine(self):
        """
        Реалізація методу 'start_engine'.
        """
        return f"{self.name} рушає: Чух-чух-чух!"

    # --- Власний метод (вимагався 1) ---

    def announce_stop(self, station_name):
        """
        Власний унікальний метод класу Train.
        """
        return f"Увага! Потяг '{self.name}' прибуває на станцію {station_name}."


# --- 2. ГРАФІЧНИЙ ІНТЕРФЕЙС (GUI) ---

class App(tk.Tk):
    def __init__(self):
        super().__init__()
        self.title("Лабораторна робота №6 (Абстрактні класи)")
        self.geometry("600x650")

        # Наша "база (масив) з n машин"
        self.vehicle_database = []

        # --- Створення вкладок ---
        self.notebook = ttk.Notebook(self)

        self.tab_create = ttk.Frame(self.notebook)
        self.tab_database = ttk.Frame(self.notebook)

        self.notebook.add(self.tab_create, text="Створення об'єктів")
        self.notebook.add(self.tab_database, text="База даних та Пошук")

        self.notebook.pack(expand=True, fill="both")

        # --- Заповнення вкладки "Створення" ---
        self.create_tab_widgets()

        # --- Заповнення вкладки "База даних" ---
        self.create_database_tab_widgets()

    def create_tab_widgets(self):
        """Створює віджети для першої вкладки (Створення). (ОНОВЛЕНА ВЕРСІЯ)"""
        frame = ttk.Frame(self.tab_create, padding="10")
        frame.pack(expand=True, fill="both")

        ttk.Label(frame, text="Тип транспорту:").pack(pady=5)
        self.transport_type = ttk.Combobox(frame, values=["Автомобіль", "Потяг"], state="readonly")
        self.transport_type.pack(fill="x", padx=10)
        self.transport_type.current(0)
        self.transport_type.bind("<<ComboboxSelected>>", self.toggle_fields)

        # --- Рамка для спільних полів (використовуємо .grid) ---
        common_frame = ttk.LabelFrame(frame, text="Загальні параметри")
        common_frame.pack(fill="x", padx=10, pady=10)
        common_frame.columnconfigure(1, weight=1)  # Дозволяємо 2-й колонці (полям вводу) розтягуватись

        self.entries = {}
        common_fields = ["Назва", "Макс. швидкість (км/год)"]

        for i, field in enumerate(common_fields):
            ttk.Label(common_frame, text=field).grid(row=i, column=0, padx=10, pady=5, sticky="w")
            entry = ttk.Entry(common_frame)
            entry.grid(row=i, column=1, padx=10, pady=5, sticky="ew")
            self.entries[field] = entry

        # --- Динамічні рамки (для Авто та Потяга) (використовуємо .grid) ---

        # Рамка для Авто
        self.car_frame = ttk.LabelFrame(frame, text="Параметри Автомобіля")
        self.car_frame.columnconfigure(1, weight=1)  # Дозволяємо 2-й колонці розтягуватись

        car_fields = ["Вантажопідйомність (кг)", "Колір", "Кількість дверей"]
        for i, field in enumerate(car_fields):
            ttk.Label(self.car_frame, text=field).grid(row=i, column=0, padx=10, pady=5, sticky="w")
            entry = ttk.Entry(self.car_frame)
            entry.grid(row=i, column=1, padx=10, pady=5, sticky="ew")
            self.entries[field] = entry

        # Рамка для Потяга
        self.train_frame = ttk.LabelFrame(frame, text="Параметри Потяга")
        self.train_frame.columnconfigure(1, weight=1)  # Дозволяємо 2-й колонці розтягуватись

        train_fields = ["Вантажопідйомність (тонн)", "Кількість вагонів", "Тип (напр. Пасажирський)"]
        for i, field in enumerate(train_fields):
            ttk.Label(self.train_frame, text=field).grid(row=i, column=0, padx=10, pady=5, sticky="w")
            entry = ttk.Entry(self.train_frame)
            entry.grid(row=i, column=1, padx=10, pady=5, sticky="ew")
            self.entries[field] = entry

        # Кнопка Створення
        ttk.Button(frame, text="Додати до бази", command=self.create_vehicle).pack(pady=20, fill="x", padx=10)

        # Початкове налаштування видимості
        self.toggle_fields(None)

    def toggle_fields(self, event):
        """Ховає або показує рамки з полями вводу."""
        if self.transport_type.get() == "Автомобіль":
            self.car_frame.pack(fill="x", padx=10, pady=10)
            self.train_frame.pack_forget()
        else:  # Потяг
            self.train_frame.pack(fill="x", padx=10, pady=10)
            self.car_frame.pack_forget()

    def create_vehicle(self):
        """Зчитує дані з полів та створює об'єкт."""
        try:
            # Зчитуємо спільні поля
            name = self.entries["Назва"].get()
            if not name:
                messagebox.showerror("Помилка", "Назва не може бути порожньою.")
                return
            max_speed = int(self.entries["Макс. швидкість (км/год)"].get())

            if self.transport_type.get() == "Автомобіль":
                payload = int(self.entries["Вантажопідйомність (кг)"].get())
                color = self.entries["Колір"].get()
                doors = int(self.entries["Кількість дверей"].get())

                new_vehicle = Car(name, max_speed, payload, color, doors)

            else:  # Потяг
                payload = int(self.entries["Вантажопідйомність (тонн)"].get())
                wagons = int(self.entries["Кількість вагонів"].get())
                train_type = self.entries["Тип (напр. Пасажирський)"].get()

                new_vehicle = Train(name, max_speed, payload, wagons, train_type)

            # Додаємо об'єкт до нашої "бази"
            self.vehicle_database.append(new_vehicle)
            messagebox.showinfo("Успіх", f"Об'єкт '{new_vehicle.name}' успішно додано до бази!")

            # Очищуємо поля
            for entry in self.entries.values():
                entry.delete(0, "end")

        except ValueError:
            messagebox.showerror("Помилка вводу",
                                 "Перевірте, чи всі числові поля заповнені коректно (швидкість, вантажопідйомність і т.д.).")
        except Exception as e:
            messagebox.showerror("Невідома помилка", str(e))

    def create_database_tab_widgets(self):
        """Створює віджети для другої вкладки (База та Пошук)."""
        frame = ttk.Frame(self.tab_database, padding="10")
        frame.pack(expand=True, fill="both")

        # --- Рамка пошуку ---
        search_frame = ttk.LabelFrame(frame, text="Пошук за вантажопідйомністю")
        search_frame.pack(fill="x", padx=5, pady=5)

        ttk.Label(search_frame, text="Показати транспорт з вантажопідйомністю БІЛЬШЕ ніж:").pack(side="left", padx=5)
        self.search_entry = ttk.Entry(search_frame, width=10)
        self.search_entry.pack(side="left", padx=5)
        ttk.Button(search_frame, text="Знайти", command=self.search_database).pack(side="left", padx=5)

        # --- Кнопка "Показати всіх" ---
        ttk.Button(frame, text="Вивести повну інформацію з бази", command=self.show_all_database).pack(pady=10,
                                                                                                       fill="x", padx=5)

        # --- Поле виводу ---
        output_frame = ttk.LabelFrame(frame, text="Результат")
        output_frame.pack(fill="both", expand=True, padx=5, pady=5)

        self.output_text = tk.Text(output_frame, wrap="word", state="disabled")
        scrollbar = ttk.Scrollbar(output_frame, orient="vertical", command=self.output_text.yview)
        self.output_text.configure(yscrollcommand=scrollbar.set)

        scrollbar.pack(side="right", fill="y")
        self.output_text.pack(fill="both", expand=True, padx=5, pady=5)

    def _display_results(self, text_to_show):
        """Допоміжна функція для виведення тексту у поле."""
        self.output_text.config(state="normal")
        self.output_text.delete("1.0", "end")
        self.output_text.insert("1.0", text_to_show)
        self.output_text.config(state="disabled")

    def show_all_database(self):
        """Виводить повну інформацію з бази на екран."""
        if not self.vehicle_database:
            self._display_results("База даних порожня. Створіть об'єкти на першій вкладці.")
            return

        full_info = ""
        for vehicle in self.vehicle_database:
            full_info += vehicle.get_full_info() + "\n"
            full_info += vehicle.start_engine() + "\n"
            # Демонструємо власний метод
            if isinstance(vehicle, Car):
                full_info += vehicle.honk() + "\n"
            elif isinstance(vehicle, Train):
                full_info += vehicle.announce_stop("Центральна") + "\n"
            full_info += "-" * 30 + "\n"

        self._display_results(full_info)

    def search_database(self):
        """Організовує пошук машин, що задовольняють вимогам."""
        try:
            min_payload = int(self.search_entry.get())
        except ValueError:
            messagebox.showerror("Помилка пошуку", "Будь ласка, введіть числове значення для пошуку.")
            return

        results = []
        for vehicle in self.vehicle_database:
            # Використовуємо загальний метод get_payload()
            if vehicle.get_payload() > min_payload:
                results.append(vehicle)

        if not results:
            self._display_results(f"Не знайдено транспорту з вантажопідйомністю більше {min_payload}.")
            return

        result_info = f"--- Знайдено {len(results)} об'єкт(ів) з вантажопідйомністю > {min_payload} ---\n\n"
        for vehicle in results:
            result_info += vehicle.get_full_info() + "\n"
            result_info += "-" * 30 + "\n"

        self._display_results(result_info)


# --- 3. ЗАПУСК ПРОГРАМИ ---
if __name__ == "__main__":
    app = App()
    app.mainloop()