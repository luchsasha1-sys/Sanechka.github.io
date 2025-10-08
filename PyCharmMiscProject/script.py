import tkinter as tk
from tkinter import messagebox
import re

def extract_ip_addresses(text):
    pattern = r'\b([01]{4})\.([01]{4})\.([01]{4})\.([01]{4})\b'
    return re.findall(pattern, text)

def replace_ip_address(text, old_ip, new_ip):
    return text.replace(old_ip, new_ip)

def process_ips():
    text = txt_input.get("1.0", tk.END)
    ip_addresses = extract_ip_addresses(text)

    lbl_count.config(text=f"Кількість знайдених IP-адрес: {len(ip_addresses)}")

    listbox_ips.delete(0, tk.END)
    for ip in ip_addresses:
        listbox_ips.insert(tk.END, f"{ip[0]}.{ip[1]}.{ip[2]}.{ip[3]}")

def remove_ip():
    selected_ip = listbox_ips.get(tk.ACTIVE)
    if selected_ip:
        text = txt_input.get("1.0", tk.END)
        txt_input.delete("1.0", tk.END)
        txt_input.insert(tk.END, text.replace(selected_ip, ""))
        messagebox.showinfo("Видалено", f"IP-адреса {selected_ip} вилучена з тексту.")
    else:
        messagebox.showwarning("Помилка", "Будь ласка, виберіть IP-адресу для вилучення.")

def replace_ip():
    old_ip = listbox_ips.get(tk.ACTIVE)
    new_ip = entry_replace_ip.get()
    if old_ip and new_ip:
        text = txt_input.get("1.0", tk.END)
        new_text = replace_ip_address(text, old_ip, new_ip)
        txt_input.delete("1.0", tk.END)
        txt_input.insert(tk.END, new_text)
        messagebox.showinfo("Заміна", f"IP-адресу {old_ip} замінено на {new_ip}.")
    else:
        messagebox.showwarning("Помилка", "Будь ласка, виберіть IP-адресу та введіть нову.")

window = tk.Tk()
window.title("Пошук та заміна IP-адрес")
window.geometry("500x400")

txt_input = tk.Text(window, height=6, width=50)
txt_input.pack(pady=10)

btn_process = tk.Button(window, text="Знайти IP-адреси", command=process_ips)
btn_process.pack(pady=5)

lbl_count = tk.Label(window, text="Кількість знайдених IP-адрес: 0")
lbl_count.pack(pady=5)

listbox_ips = tk.Listbox(window, height=6, width=50)
listbox_ips.pack(pady=5)

btn_remove = tk.Button(window, text="Вилучити IP-адресу", command=remove_ip)
btn_remove.pack(pady=5)

entry_replace_ip = tk.Entry(window, width=30)
entry_replace_ip.pack(pady=5)

btn_replace = tk.Button(window, text="Замінити IP-адресу", command=replace_ip)
btn_replace.pack(pady=5)

window.mainloop()