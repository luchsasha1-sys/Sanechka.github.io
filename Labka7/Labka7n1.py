import tkinter as tk
from tkinter import ttk, messagebox
from datetime import datetime, timedelta


class ElectionApp(tk.Tk):
    """
    Головний клас GUI-додатку для контролю передвиборчої кампанії.
    """

    def __init__(self):
        super().__init__()

        # --- Налаштування вікна ---
        self.title("Контроль передвиборчої кампанії")
        self.geometry("500x300")
        self.resizable(False, False)

        # Використовуємо сучасні стилі ttk
        self.style = ttk.Style(self)
        self.style.configure("TLabel", font=("Arial", 11))
        self.style.configure("TButton", font=("Arial", 11, "bold"))
        self.style.configure("TEntry", font=("Arial", 11))
        self.style.configure("TLabelframe.Label", font=("Arial", 12, "bold"))

        # --- Головна рамка ---
        main_frame = ttk.Frame(self, padding="15")
        main_frame.pack(fill="both", expand=True)

        # --- Секція вводу ---
        input_frame = ttk.Frame(main_frame)
        input_frame.pack(fill="x", pady=10)

        ttk.Label(input_frame, text="Дата голосування (ДДММРРРР):").pack(side="left", padx=5)
        self.entry_date = ttk.Entry(input_frame)
        self.entry_date.pack(side="left", fill="x", expand=True)

        # --- Кнопка розрахунку ---
        self.btn_calculate = ttk.Button(main_frame, text="Розрахувати", command=self.calculate_campaign)
        self.btn_calculate.pack(fill="x", pady=10, ipady=8)  # ipady робить кнопку вищою

        # --- Секція виводу результатів ---
        output_frame = ttk.LabelFrame(main_frame, text="Результати")
        output_frame.pack(fill="both", expand=True, pady=10)

        # Використовуємо .grid() всередині для гарного вирівнювання
        output_frame.columnconfigure(1, weight=1)

        # 1. Результат: Дні, що залишилися
        ttk.Label(output_frame, text="Днів до голосування:", font=("Arial", 11, "bold")).grid(row=0, column=0,
                                                                                              sticky="w", padx=10,
                                                                                              pady=10)

        self.days_var = tk.StringVar(value="---")  # Змінна для динамічного оновлення
        ttk.Label(output_frame, textvariable=self.days_var, font=("Arial", 14, "bold"), foreground="#007ACC").grid(
            row=0, column=1, sticky="w", padx=10)

        # 2. Результат: Дата закінчення агітації
        ttk.Label(output_frame, text="Агітація припиняється:", font=("Arial", 11, "bold")).grid(row=1, column=0,
                                                                                                sticky="w", padx=10,
                                                                                                pady=10)

        self.end_date_var = tk.StringVar(value="---")  # Змінна для динамічного оновлення
        ttk.Label(output_frame, textvariable=self.end_date_var, font=("Arial", 14, "bold"), foreground="#CC0000").grid(
            row=1, column=1, sticky="w", padx=10)

    def calculate_campaign(self):
        """
        Головний метод, який виконує всі розрахунки при натисканні кнопки.
        """
        # 1. Отримуємо рядок з датою з поля вводу
        date_str = self.entry_date.get()

        # 2. Намагаємося перетворити рядок на об'єкт datetime
        try:
            # Використовуємо strptime для парсингу дати з формату ДДММРРРР
            election_date = datetime.strptime(date_str, "%d%m%Y")
        except ValueError:
            # Якщо формат невірний, показуємо помилку
            messagebox.showerror("Помилка формату",
                                 "Невірний формат дати!\n\n"
                                 "Будь ласка, введіть дату у форматі ДДММРРРР\n"
                                 "(наприклад, 25102025)")
            return

        # 3. Отримуємо поточну дату (без часу)
        today = datetime.now().date()

        # --- Розрахунок 1: Кількість днів, що залишилися ---

        # .date() - беремо тільки дату з об'єкта election_date
        remaining_delta = election_date.date() - today
        remaining_days = remaining_delta.days

        # 4. Перевіряємо, чи дата не в минулому
        if remaining_days < 0:
            messagebox.showwarning("Минула дата", f"Ця дата вже пройшла ({remaining_days} дн. тому).")
            self.days_var.set(f"{remaining_days} (в минулому)")
        else:
            self.days_var.set(str(remaining_days))

        # --- Розрахунок 2: Дата закінчення агітації ---

        # "За законом передвиборча агітація припиняється у нуль годин...
        # ...за добу до дня голосування."
        # Це означає: (Дата Голосування) - (1 доба)

        campaign_end_datetime = election_date - timedelta(days=1)

        # 5. Форматуємо дату для гарного виводу
        end_date_formatted = campaign_end_datetime.strftime("%d.%m.%Y")

        # Оновлюємо текстові змінні у GUI
        self.end_date_var.set(f"{end_date_formatted}, 00:00:00")


# --- Запуск програми ---
if __name__ == "__main__":
    app = ElectionApp()
    app.mainloop()