import tkinter as tk
from tkinter import messagebox, ttk


# --- 1. ІЄРАРХІЯ КЛАСІВ ---
# (Ця частина НЕ змінилася, вона така ж, як була)

class Tovar:
    """ Базовий клас: Товар """

    def __init__(self, name="Товар", price=0.0, barcode="000000"):
        self.name = name
        self.price = price
        self.barcode = barcode

    def __del__(self):
        """
        Деструктор.
        !! НЕ ЗАБУДЬ ВПИСАТИ СВОЄ ПІБ !!
        """
        print("Лабораторна робота виконанна студентом 2 курсу [Твоє ПІБ]")

    def show(self):
        """ Метод Show() для виведення даних """
        return f"--- Товар ---\n" \
               f"Назва: {self.name}\n" \
               f"Ціна: {self.price}\n" \
               f"Штрих-код: {self.barcode}"

    def get_info(self):
        """ Поліморфний метод """
        return "Загальний товар"


class Igrashka(Tovar):
    """ Похідний клас: Іграшка (наслідує Товар) """

    def __init__(self, name="Іграшка", price=0.0, barcode="111111",
                 age_rating="3+", material="Пластик", manufacturer="N/A"):
        super().__init__(name, price, barcode)
        self.age_rating = age_rating
        self.material = material
        self.manufacturer = manufacturer

    def show(self):
        """ Перевизначений метод Show() """
        base_info = super().show()
        return f"{base_info}\n" \
               f"--- Іграшка ---\n" \
               f"Вік: {self.age_rating}\n" \
               f"Матеріал: {self.material}\n" \
               f"Виробник: {self.manufacturer}"

    def get_info(self):
        return "Іграшка для дітей"


class Product(Tovar):
    """ Похідний клас: Продукт (наслідує Товар) """

    def __init__(self, name="Продукт", price=0.0, barcode="222222",
                 expiry_date="01.01.2025", calories=0, weight=0.0):
        super().__init__(name, price, barcode)
        self.expiry_date = expiry_date
        self.calories = calories
        self.weight = weight

    def show(self):
        """ Перевизначений метод Show() """
        base_info = super().show()
        return f"{base_info}\n" \
               f"--- Продукт ---\n" \
               f"Термін придат.: {self.expiry_date}\n" \
               f"Калорії: {self.calories}\n" \
               f"Вага: {self.weight} кг"

    def get_info(self):
        return "Харчовий продукт"


class MolochniyProduct(Product):
    """ Похідний клас: Молочний продукт (наслідує Продукт) """

    def __init__(self, name="Молоко", price=0.0, barcode="333333",
                 expiry_date="01.01.2025", calories=50, weight=1.0,
                 fat_percent=3.2, storage_temp=4):
        super().__init__(name, price, barcode, expiry_date, calories, weight)
        self.fat_percent = fat_percent
        self.storage_temp = storage_temp

    def show(self):
        """ Перевизначений метод Show() """
        base_info = super().show()
        return f"{base_info}\n" \
               f"--- Молочний продукт ---\n" \
               f"Жирність: {self.fat_percent}%\n" \
               f"Темп. зберігання: {self.storage_temp}°C"

    def get_info(self):
        return "Молочний харчовий продукт"


# --- 2. ГРАФІЧНИЙ ІНТЕРФЕЙС (GUI) ---
# (ОСЬ ТУТ ВСІ ЗМІНИ)

class ItemApp(tk.Tk):
    def __init__(self):
        super().__init__()
        # 1. Базові налаштування вікна
        self.title("Облік товарів (v2.0)")  # Змінили назву
        self.geometry("500x520")  # Трохи інший розмір

        # Головна рамка з відступами
        main_frame = ttk.Frame(self, padding="10 10 10 10")
        main_frame.pack(fill=tk.BOTH, expand=True)

        # 2. Рамка для вибору типу
        type_frame = ttk.LabelFrame(main_frame, text="1. Виберіть тип")
        type_frame.pack(fill=tk.X, padx=5, pady=5)

        self.item_type = ttk.Combobox(type_frame,
                                      values=["Іграшка", "Продукт", "Молочний продукт"],
                                      state="readonly")  # state="readonly" - не можна вписати своє
        self.item_type.current(0)
        self.item_type.pack(fill=tk.X, padx=10, pady=10)  # Відступи всередині рамки

        # 3. Рамка для полів вводу (використовуємо .grid)
        data_frame = ttk.LabelFrame(main_frame, text="2. Введіть дані")
        data_frame.pack(fill=tk.X, padx=5, pady=5)

        # Налаштовуємо колонки .grid: 0-ва (мітки) і 1-ша (поля вводу)
        data_frame.columnconfigure(1, weight=1)  # Дозволяємо 1-й колонці розтягуватись

        self.entries = {}
        labels = ["Назва", "Ціна", "Штрих-код", "Поле 1", "Поле 2"]

        # Створюємо мітки (Label) і поля (Entry) у сітці
        for i, label_text in enumerate(labels):
            label = ttk.Label(data_frame, text=label_text + ":")
            # sticky='w' (west) - притиснути до лівого краю
            label.grid(row=i, column=0, padx=10, pady=5, sticky="w")

            entry = ttk.Entry(data_frame)
            # sticky='ew' (east-west) - розтягнути по горизонталі
            entry.grid(row=i, column=1, padx=10, pady=5, sticky="ew")

            self.entries[label_text] = entry

        # 4. Рамка для кнопок (горизонтально)
        button_frame = ttk.Frame(main_frame)
        button_frame.pack(fill=tk.X, padx=5, pady=10)

        # Робимо 2 колонки однакової ширини
        button_frame.columnconfigure(0, weight=1)
        button_frame.columnconfigure(1, weight=1)

        btn_create = ttk.Button(button_frame, text="Створити / Оновити", command=self.create_item)
        btn_create.grid(row=0, column=0, padx=5, sticky="ew")  # sticky='ew' - розтягнути

        btn_show = ttk.Button(button_frame, text="Показати інформацію", command=self.show_item)
        btn_show.grid(row=0, column=1, padx=5, sticky="ew")

        # 5. Рамка для виводу результату
        output_frame = ttk.LabelFrame(main_frame, text="3. Результат")
        output_frame.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)  # expand=True - займає все місце, що лишилось

        self.output = tk.Text(output_frame, height=10, width=60)
        self.output.pack(fill=tk.BOTH, expand=True, padx=5, pady=5)

        self.current_item = None  # Змінна для зберігання об'єкта

    def create_item(self):
        """
        Створює об'єкт на основі даних з GUI
        (ЛОГІКА ТУТ НЕ ЗМІНИЛАСЬ)
        """
        dtype = self.item_type.get()
        name = self.entries["Назва"].get() or "N/A"
        price = self.entries["Ціна"].get() or "0"
        barcode = self.entries["Штрих-код"].get() or "000"
        pole1 = self.entries["Поле 1"].get()
        pole2 = self.entries["Поле 2"].get()

        try:
            if dtype == "Іграшка":
                self.current_item = Igrashka(
                    name=name, price=float(price), barcode=barcode,
                    age_rating=pole1 or "3+",
                    material=pole2 or "Пластик"
                )

            elif dtype == "Продукт":
                self.current_item = Product(
                    name=name, price=float(price), barcode=barcode,
                    expiry_date=pole1 or "01.01.2025",
                    calories=int(pole2 or "0")
                )

            elif dtype == "Молочний продукт":
                self.current_item = MolochniyProduct(
                    name=name, price=float(price), barcode=barcode,
                    expiry_date=pole1 or "01.01.2025",
                    calories=int(pole2 or "0")
                )

            messagebox.showinfo("Створено", f"Об'єкт '{dtype}' успішно створено!")

        except ValueError:
            messagebox.showerror("Помилка", "Поля 'Ціна' та 'Поле 2 (калорії)' мають бути числами!")
        except Exception as e:
            messagebox.showerror("Помилка", f"Сталася помилка: {e}")

    def show_item(self):
        """
        Викликає методи show() та get_info()
        (ЛОГІКА ТУТ ТЕЖ НЕ ЗМІНИЛАСЬ)
        """
        if self.current_item:
            info_show = self.current_item.show()
            info_type = self.current_item.get_info()
            text = f"{info_show}\n\n--- Тип (метод get_info) ---\n{info_type}"
            self.output.delete(1.0, tk.END)
            self.output.insert(tk.END, text)
        else:
            messagebox.showwarning("Помилка", "Спочатку створіть об'єкт кнопкою 'Створити / Оновити'!")


# --- 3. ЗАПУСК ПРОГРАМИ ---
if __name__ == "__main__":
    app = ItemApp()
    app.mainloop()