using System;

class Employee
{
    // Sınıf Nitelikleri
    public string Name; // Çalışanın adı ve soyadı
    public double Salary; // Çalışanın maaşı
    public int WorkHours; // Haftalık çalışma saati
    public int HireYear; // İşe başlangıç yılı

    // Kurucu Metot
    public Employee(string name, double salary, int workHours, int hireYear)
    {
        Name = name;
        Salary = salary;
        WorkHours = workHours;
        HireYear = hireYear;
    }

    // Vergi Hesaplama Metodu
    public double Tax()
    {
        if (Salary > 1000)
        {
            return Salary * 0.03; // Maaşın %3'ü kadar vergi
        }
        return 0; // 1000 TL'den az maaş için vergi yok
    }

    // Bonus Hesaplama Metodu
    public double Bonus()
    {
        if (WorkHours > 40)
        {
            return (WorkHours - 40) * 30; // Fazla her saat için 30 TL
        }
        return 0; // 40 saatten az çalışmada bonus yok
    }

    // Maaş Artışı Hesaplama Metodu
    public double RaiseSalary()
    {
        int yearsWorked = 2021 - HireYear; // Çalışma yılı
        if (yearsWorked < 10)
        {
            return Salary * 0.05; // %5 zam
        }
        else if (yearsWorked >= 10 && yearsWorked < 20)
        {
            return Salary * 0.10; // %10 zam
        }
        else
        {
            return Salary * 0.15; // %15 zam
        }
    }

    // Çalışan Bilgilerini Yazdıran Metot
    public override string ToString()
    {
        double tax = Tax();
        double bonus = Bonus();
        double raise = RaiseSalary();
        double totalSalary = Salary - tax + bonus + raise;

        return $"Çalışanın Adı: {Name}\n" +
               $"Maaşı: {Salary} TL\n" +
               $"Haftalık Çalışma Saati: {WorkHours}\n" +
               $"İşe Başlangıç Yılı: {HireYear}\n" +
               $"Vergi: {tax} TL\n" +
               $"Bonus: {bonus} TL\n" +
               $"Maaş Zammı: {raise} TL\n" +
               $"Vergi ve Bonuslar Dahil Maaş: {totalSalary} TL";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Bir çalışan nesnesi oluştur
        Employee emp = new Employee("Cenk Çetin", 1200, 45, 2010);

        // Çalışan bilgilerini ekrana yazdır
        Console.WriteLine(emp.ToString());
    }
}