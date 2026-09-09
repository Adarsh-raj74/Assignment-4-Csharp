using System;
class Program
{
    delegate void notificationDelegate(string massage);
    static void SendEmail(string massage)
    {
        Console.WriteLine("Email: " + massage);
    }
    static void SendSMS(string massage)
    {
        Console.WriteLine("SMS: " + massage);
    }
    static void SendWhatsApp(string massage)
    {
        Console.WriteLine("WhatsApp: " + massage);
    }
    static void Main()
    {
        notificationDelegate notify = SendEmail;
        notify += SendSMS;
        notify += SendWhatsApp;
        notify("Your order has been confirmed!");
        Console.ReadLine();
    }    
}