/*
 * Создано в SharpDevelop.
 * Пользователь: егор
 * Дата: 25.02.2017
 * Время: 18:01
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
namespace HomeWork
{
	class Program
	{
		public static void zad1(){
			string a = "Ответ: ";
			int b = 5;
			int c = 2;
			Console.WriteLine(a + float.Parse(b.ToString())/float.Parse(c.ToString()));
		}
		public static void zad2(){
			int a = 61;
			int b = 61;
			int c = 61;
			int d = 213;
			if(((a > b) && (c == d)) || ((d == a) && (d != c)))
			{
				Console.WriteLine("Ок");
			}
			else if((a != b) && (a != c))
			{
				Console.WriteLine("Второй вариант");
			}
			else
			{
				Console.WriteLine("Беда беда");
			}
		}
		public static void zad3(){
			for (int i = 0; i < 10; i++) {
				if(i == 5)
				{
					Console.WriteLine("5 итераций");
					break;
				}
			}
		}
		public static void zad4(){
			Random r = new Random();
			List<int> mas = new List<int>();
			int[] mas1 = new int[10];
			int[] mas2 = new int[11];
			for (int i = 0; i < 10; i++) {
				mas1[i] = r.Next(1,100);
				Console.WriteLine(mas1[i]);
			}
			izi:
				for (int i = 0; i < 10; i++) {
					for (int j = 0; j < 10; j++) {
						if ((mas1[i] == mas1[j]) && (i != j)) {
							mas1[i] = r.Next(1,100);
							goto izi;
						}
					}
				}
			Console.WriteLine("         [s");
			for (int i = 0; i < 10; i++) {
				mas.Add(mas1[i]);
			}
			mas.Add(101);
			for (int i = 0; i < 11; i++) {
				mas2[i] = mas[i];
			}
			Array.Sort(mas2);
			foreach(int d in mas2){
				Console.WriteLine(d + " ");
			}
		}
		public static void zad5(){
			string a;
			zad5:
				for (int i = 0; i < 2; i++) {
					a = Console.ReadLine();
					goto zad5;
				}
		}
		public static void zad6(){
			string a = "qwertypasdfgpzxcvb";
			string b = "йцуфывячс";
			string c = a+b;
		}
		public static void zad7(){
			Directory.CreateDirectory("C://vs/");
			Directory.CreateDirectory("C://vs/folder/");
			File.WriteAllText("C://vs/folder/Hello.txt", "O_o");
			FileStream fs = new FileStream("C://vs/folder/Hello.txt", FileMode.Open);
			StreamReader sr = new StreamReader(fs);
			Console.WriteLine(sr.ReadToEnd());
			sr.Close();
		}
		public static void Main(string[] args)
		{
			zad1();
			Console.ReadKey(true);
		}
	}
}