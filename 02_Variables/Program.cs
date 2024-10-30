﻿using System;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler
            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.OutputEncoding = Encoding.UTF8;

            //Console.WriteLine("---- Elma Birim Fiyatı: " + applePrice + "₺");
            //Console.WriteLine("---- Portakal Birim Fiyatı: " + orangePrice + "₺");
            //Console.WriteLine("---- Çilek Birim Fiyatı: " + strawberryPrice + "₺");
            //Console.WriteLine("---- Patates Birim Fiyatı: " + potatoPrice + "₺");
            //Console.WriteLine("---- Domates Birim Fiyatı: " + tomatoPrice + "₺");

            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //Console.WriteLine($"Alınan Ürün: Elma - Birim Fiyat: {applePrice} - Gramaj: {appleGram} - Toplam Tutar: {applePrice * appleGram}₺");

            //Console.WriteLine($"Alınan Ürün: Portakal - Birim Fiyat: {orangePrice} - Gramaj: {orangeGram} - Toplam Tutar: {orangePrice * orangeGram}₺");

            //Console.WriteLine($"Alınan Ürün: Çilek - Birim Fiyat: {strawberryPrice} - Gramaj: {strawberryGram} - Toplam Tutar: {strawberryPrice * strawberryGram}₺");

            //Console.WriteLine($"Alınan Ürün: Patates - Birim Fiyat: {potatoPrice} - Gramaj: {potatoGram} - Toplam Tutar: {potatoPrice * potatoGram}₺");

            //Console.WriteLine($"Alınan Ürün: Domates - Birim Fiyat: {tomatoPrice} - Gramaj: {tomatoGram} - Toplam Tutar: {tomatoPrice * tomatoGram}₺");

            //double shoppingTotalPrice = (applePrice * appleGram) + (orangePrice * orangeGram) + (strawberryPrice * strawberryGram) + (potatoPrice * potatoGram) + (tomatoPrice * tomatoGram);

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine($"Alışveriş Toplam Tutar: {shoppingTotalPrice}₺");

            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi ****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaşı: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("TC No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("------------------");
            //Console.WriteLine($"Yolcu TC Kimlik No: {passengerIdentityNumber} - Ad Soyad: {passengerName} {passengerSurname} - {passengerDistrict} / {passengerCity} - {passengerAge}");

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümleri

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvPrice * tvCount;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav notunu giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav notunu giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav notunu giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            #endregion

            #region Klavyeden Karakter Girişleri

            char gender;
            Console.Write("Lütfen cinsiyet seçiniz: ");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            #endregion

            Console.Read();
        }
    }
}