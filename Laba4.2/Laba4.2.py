import os


def run_file_processing():
    """
    Головна функція, що виконує всі кроки завдання:
    а) Створює файл TF_1.
    б) Обробляє TF_1 та створює TF_2.
    в) Виводить вміст TF_2.
    """

    # --- а) Створення текстового файлу TF_1 ---
    print("--- Крок а: Створення файлу TF_1 ---")
    file_tf1 = "TF_1.txt"

    # Довільні рядки, що містять літери, символи та цифри
    content_for_tf1 = [
        "Це перший рядок, що містить цифри 123.",
        "Короткий рядок 45.",
        "А це найдовший рядок з усіх, 67890, який ми тут маємо.",
        "Python is great! Ver. 3.12.",
        "Символи: !@#$%^&*()_+"
    ]

    try:
        with open(file_tf1, "w", encoding="utf-8") as f:
            for line in content_for_tf1:
                f.write(line + "\n")
        print(f"✅ Файл '{file_tf1}' успішно створено.")

    except IOError as e:
        print(f"❌ Помилка при створенні файлу '{file_tf1}': {e}")
        return  # Зупиняємо виконання, якщо файл не вдалося створити

    # --- б) Читання TF_1, обробка та запис у TF_2 ---
    print("\n--- Крок б: Обробка TF_1 та створення TF_2 ---")
    file_tf2 = "TF_2.txt"

    try:
        # Читаємо весь вміст файлу TF_1 в один рядок
        with open(file_tf1, "r", encoding="utf-8") as f:
            full_content = f.read()

        # 1. Прибираємо символи нового рядка, щоб отримати суцільний текст
        # 2. Фільтруємо, залишаючи тільки ті символи, що НЕ є цифрами
        chars_without_digits = "".join(char for char in full_content.replace('\n', '') if not char.isdigit())

        # Записуємо результат у файл TF_2
        with open(file_tf2, "w", encoding="utf-8") as f:
            line_number = 1
            # Розбиваємо суцільний текст на шматки по 10 символів
            for i in range(0, len(chars_without_digits), 10):
                chunk = chars_without_digits[i:i + 10]

                # Форматуємо номер рядка, щоб він займав 5 позицій (вирівнювання ліворуч)
                formatted_line_number = str(line_number).ljust(5)

                # Записуємо відформатований рядок у файл
                f.write(f"{formatted_line_number} {chunk}\n")
                line_number += 1

        print(f"✅ Файл '{file_tf2}' успішно створено та відформатовано.")

    except FileNotFoundError:
        print(f"❌ Помилка: вхідний файл '{file_tf1}' не знайдено.")
        return
    except IOError as e:
        print(f"❌ Помилка при роботі з файлами: {e}")
        return

    # --- в) Читання та виведення вмісту файлу TF_2 ---
    print(f"\n--- Крок в: Виведення вмісту файлу TF_2 ---")
    try:
        with open(file_tf2, "r", encoding="utf-8") as f:
            final_content = f.read()
            print(f"Вміст файлу '{file_tf2}':\n")
            # Виводимо вміст, який ми щойно прочитали
            print(final_content)

    except FileNotFoundError:
        print(f"❌ Помилка: файл '{file_tf2}' не знайдено.")


# Запуск головної функції
if __name__ == "__main__":
    run_file_processing()