﻿using System;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else

            //Console.WriteLine("Lütfen şifreyi giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi giriniz: ");
            //country = Console.ReadLine();

            //if (capital == "ankara" & country == "türkiye")
            //{
            //    Console.Write("veriler doğrulandı");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı giriş");
            //}

            //int number;
            //Console.Write("Sayıyı Giriniz");
            //number = int.Parse(Console.ReadLine());
            //if (number == 5)
            //{
            //    Console.WriteLine("Sayı doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result = "";

            //Console.Write("Sınav1: ");
            //exam1 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların Ortalaması: " + average);

            //if (average > 0 & average <= 50)
            //{
            //    result = "Sonuc vasat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result = "Sonuc orta";
            //}
            //if (average > 70 & average <= 84)
            //{
            //    result = "Sonuc iyi";
            //}
            //if (average > 84)
            //{
            //    result = "Sonuc çok iyi";                
            //}
            //Console.WriteLine(result);

            //string city;
            //Console.Write("Lütfen şehir girişi yapınız: ");
            //city = Console.ReadLine();

            //if(city == "adana" | city == "ankara" | city == "bursa" | city == "trabzon")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir mevcut değil");
            //}


            //Console.Write("Lütfen kullanıcı adını giriniz: ");
            //string userName = Console.ReadLine();
            //if (userName != "admin")
            //{
            //    Console.WriteLine("Bu kullanıcı adı kabul edilemez");
            //}
            //else
            //{
            //    Console.WriteLine("Welcome");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1.sayıyı giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Lütfen 2.sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan: " + result);

            //Console.Write("Lütfen sayıyı giriniz: ");
            //int number = int.Parse(Console.ReadLine());

            //if (number % 2 == 0)
            //{
            //    Console.WriteLine("Sayı çifttir");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı tektir");
            //}

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen takım sembolünü giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if (team == 'g' | team == 'G')
            //{
            //    Console.WriteLine("Galatasaray");
            //}
            //if (team == 'f' | team == 'F')
            //{
            //    Console.WriteLine("Fenerbahçe");
            //}
            //if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("****** C# Eğitim Kampı Restoran **********");
            //Console.WriteLine();
            //Console.WriteLine("------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizaalar");
            //Console.WriteLine("4- İçecekelr");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("------------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını görmek istediğiniz menüyü seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasulye Pilavı");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlican Musakka");
            //    Console.WriteLine("----------Ana Yemekler-------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Çorbalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezogelin Çorbası");
            //    Console.WriteLine("---------Çorbalar-------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Pizzalar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Akdeniz Pizza");
            //    Console.WriteLine("2-Margarita Pizza");
            //    Console.WriteLine("---------Pizzalar-------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------İçecekler-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Ayran");
            //    Console.WriteLine("2-Su");
            //    Console.WriteLine("3-Portakal Suyu");
            //    Console.WriteLine("---------İçecekler-------------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("---------Tatlılar-------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Trileçe");
            //    Console.WriteLine("2-Kazandibi");
            //    Console.WriteLine("2-Sütlaç");
            //    Console.WriteLine("---------Tatlılar-------------");
            //    Console.WriteLine();
            //}


            #endregion


            #region Switch Case

            //Console.Write("Lütfen ay girişi yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Ocak");
            //        break;
            //    case 2:
            //        Console.WriteLine("Şubat");
            //        break;
            //    case 3:
            //        Console.WriteLine("Mart");
            //        break;
            //    case 4:
            //        Console.WriteLine("Nisan");
            //        break;
            //    case 5:
            //        Console.WriteLine("Mayıs");
            //        break;
            //    case 6:
            //        Console.WriteLine("Haziran");
            //        break;
            //    case 7:
            //        Console.WriteLine("Temmuz");
            //        break;
            //    case 8:
            //        Console.WriteLine("Ağustos");
            //        break;
            //    case 9:
            //        Console.WriteLine("Eylül");
            //        break;
            //    case 10:
            //        Console.WriteLine("Ekim");
            //        break;
            //    case 11:
            //        Console.WriteLine("Kasım");
            //        break;
            //    case 12:
            //        Console.WriteLine("aralık");
            //        break;
            //    default:
            //        Console.WriteLine("Hatalı giriş");
            //        break;
            //}

            #endregion

            #region Switch Case Hesap Makinesi

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1.Sayıyı giriniz: ");
            //number1 = int.Parse(Console.ReadLine());
            //Console.Write("2.Sayıyı giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Yapmak istediğinişz işlemi giriniz: ");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+':
            //        result = number1 + number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Sonuc: " + result);
            //        break;
            //    default:
            //        Console.WriteLine("");
            //        break;
            //}


            #endregion


            Console.Read();
        }
    }
}
